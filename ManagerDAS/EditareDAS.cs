using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ManagerDAS;

public partial class EditareDAS : Form
{
    private readonly string connString = "Data Source = ManagerDAS.db";
    private readonly DataRow DASSelectat;

    public EditareDAS(DataRow DASSelectat)
    {
        InitializeComponent();
        this.DASSelectat = DASSelectat;

        var selectareTrainer = "SELECT Nume FROM ConsilieriDeProbatiune ORDER BY Nume";


        using (var da = new SQLiteDataAdapter(selectareTrainer, connString))
        {
            var dt = new DataTable();
            da.Fill(dt);
            Trainer1CB.DataSource = dt;
            Trainer1CB.DisplayMember = "Nume";
        }

        using (var da = new SQLiteDataAdapter(selectareTrainer, connString))
        {
            var dt = new DataTable();
            da.Fill(dt);
            Trainer2CB.DataSource = dt;
            Trainer2CB.DisplayMember = "Nume";
        }
    }

    private void EditareDAS_Load(object sender, EventArgs e)
    {
        try
        {
            ModulCB.Text = DASSelectat["Modul"].ToString();
            dataInceputDP.Value = Convert.ToDateTime(DASSelectat["DataInceput"]);
            dataSfarsitDP.Value = Convert.ToDateTime(DASSelectat["DataSfarsit"]);
            Trainer1CB.Text = DASSelectat["Trainer1Nume"].ToString();
            Trainer2CB.Text = DASSelectat["Trainer2Nume"].ToString();
        }
        catch (Exception exception)
        {
            MessageBox.Show($@"Editare DAS Load: {exception.Message}");
        }
    }

    private object GetTrainerId(string numeTrainer)
    {
        var selectareTrainerId =
            $@"SELECT ConsilierDeProbatiuneId FROM ConsilieriDeProbatiune WHERE Nume = @numeTrainer";
        try
        {
            using (var conn = new SQLiteConnection(connString))
            {
                var cmd = new SQLiteCommand(selectareTrainerId, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@numeTrainer", numeTrainer);
                var trainerId = cmd.ExecuteScalar();
                return trainerId;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("◄ GetTrainerID ► " + e.Message);
        }

        return -1;
    }


    private void UpdateDAS()
    {
        const string query =
            $@"UPDATE ProgramDAS SET Modul = @modul, DataInceput = @dataInceput, DataSfarsit = @dataSfarsit, Trainer1 = @trainer1, Trainer2 = @trainer2 WHERE ProgramDASId = @programDASId";
        try
        {
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@modul", ModulCB.Text);
                    cmd.Parameters.AddWithValue("@dataInceput", dataInceputDP.Value);
                    cmd.Parameters.AddWithValue("@dataSfarsit", dataSfarsitDP.Value);
                    cmd.Parameters.AddWithValue("@trainer1", GetTrainerId(Trainer1CB.Text));
                    cmd.Parameters.AddWithValue("@trainer2", GetTrainerId(Trainer2CB.Text));
                    cmd.Parameters.AddWithValue("@programDASId", DASSelectat["ProgramDASId"]);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show(@"DAS editat cu succes!");

            Close();
        }
        catch (Exception exception)
        {
            MessageBox.Show($@"Editare DAS: {exception.Message}");
        }
    }

    private void EditareDASBt_Click(object sender, EventArgs e)
    {
        UpdateDAS();
    }
}