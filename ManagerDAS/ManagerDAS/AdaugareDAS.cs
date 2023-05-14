using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ManagerDAS.bin.Debug.Media;

public partial class AdaugareDAS : Form
{
    private readonly string connString = "Data Source = ManagerDAS.db";

    public AdaugareDAS()
    {
        var selTrainer = "SELECT Nume FROM ConsilieriDeProbatiune WHERE Abilitat = 'Da' ORDER BY Nume";
        InitializeComponent();
        using (var da = new SQLiteDataAdapter(selTrainer, connString))
        {
            var dt = new DataTable();
            da.Fill(dt);
            Trainer1CB.DisplayMember = "Nume";
            Trainer1CB.DataSource = dt;
            Trainer2CB.DisplayMember = "Nume";
            Trainer2CB.DataSource = dt;
        }

        using (var da = new SQLiteDataAdapter(selTrainer, connString))
        {
            var dt = new DataTable();
            da.Fill(dt);
            Trainer2CB.DisplayMember = "Nume";
            Trainer2CB.DataSource = dt;
        }
    }

    private object GetTrainerId(string nume)
    {
        var q = $"SELECT ConsilierDeProbatiuneId FROM ConsilieriDeProbatiune WHERE Nume = '{nume}'";

        using (var connection = new SQLiteConnection(connString))
        {
            var command = new SQLiteCommand(q, connection);
            connection.Open();
            var tid = command.ExecuteScalar();
            return tid;
        }
    }

    private void AdaugareElement()
    {
        var q =
            "INSERT INTO ProgramDAS (Modul, DataInceput, DataSfarsit, Trainer1, Trainer2) VALUES (@m, @di, @ds, @t1, @t2)";
        using (var connection = new SQLiteConnection(connString))
        {
            var command = new SQLiteCommand(q, connection);

            command.Parameters.AddWithValue("@m", ModulCB.Text);
            command.Parameters.AddWithValue("@di", dataInceputDP.Text);
            command.Parameters.AddWithValue("@ds", dataSfarsitDP.Text);
            command.Parameters.AddWithValue("@t1", GetTrainerId($"{Trainer1CB.Text}"));
            command.Parameters.AddWithValue("@t2", GetTrainerId($"{Trainer2CB.Text}"));
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    private void AdaugareDASBt_Click(object sender, EventArgs e)
    {
        AdaugareElement();
        //MessageBox.Show(ModulCB.Text);
    }
}