using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ManagerDAS;

public partial class EditareBeneficiar : Form
{
    private readonly string connString = "Data Source = ManagerDAS.db";
    private readonly DataRow BeneficiarSelectat;


    public EditareBeneficiar(DataRow beneficiarSelectat)
    {
        BeneficiarSelectat = beneficiarSelectat;
        InitializeComponent();

        var selectareMgrCaz = "SELECT Nume FROM ConsilieriDeProbatiune ORDER BY Nume";
        var selectareModul = "SELECT Modul, DataInceput FROM ProgramDAS ORDER BY Modul";

        using (var da = new SQLiteDataAdapter(selectareMgrCaz, connString))
        {
            var dt = new DataTable();
            da.Fill(dt);
            MgrCazEbCb.DataSource = dt;
            MgrCazEbCb.DisplayMember = "Nume";
        }

        using (var da = new SQLiteDataAdapter(selectareModul, connString))
        {
            var dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("Modul/DataInceput", typeof(string), "Modul + ' (' + DataInceput+ ')'");
            ModulEbCb.DataSource = dt;
            ModulEbCb.DisplayMember = "Modul/DataInceput";
            // ModulEbCb.DisplayMember = "Modul";  
            // ModulEbCb.DisplayMember = "DataInceput";
        }
    }

    private void EditareBeneficiar_Load(object sender, EventArgs e)
    {
        try
        {
            numeEditBenTb.Text = BeneficiarSelectat["NumeBeneficiar"].ToString();
            MgrCazEbCb.Text = BeneficiarSelectat["NumeCP"].ToString();
            ModulEbCb.Text = BeneficiarSelectat["ModulDAS"].ToString();
        }
        catch (Exception exception)
        {
            MessageBox.Show($@"Load: {exception.Message}");
        }
    }

    private object GetMgrCazId(string nume)
    {
        var query = $@"SELECT ConsilierDeProbatiuneId FROM ConsilieriDeProbatiune WHERE Nume = @n";
        try
        {
            using (var connection = new SQLiteConnection(connString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@n", nume);
                connection.Open();
                var mgrId = command.ExecuteScalar();
                return mgrId;
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show($@"GetMgrCazId: {exception.Message}");
        }

        return -1;
    }

    private object GetDASId(string modul, string dataInceput)
    {
        var query = $@"SELECT ProgramDASId FROM ProgramDAS WHERE Modul = @m and DataInceput = @di";
        try
        {
            using (var connection = new SQLiteConnection(connString))
            {
                var command = new SQLiteCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@m", modul);
                command.Parameters.AddWithValue("@di", dataInceput);
                var dasId = command.ExecuteScalar();
                return dasId;
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            using (var sw = new StreamWriter("eroare.txt"))
            {
                sw.WriteLine(exception.InnerException + "\n" + exception.Message + "\n" + exception.StackTrace);
                MessageBox.Show($@"GetDASId: {exception.Message}");
            }
        }

        return -1;
    }

    private void UpdateBenDb()
    {
        const string query =
            "UPDATE Beneficiar SET NumeBeneficiar = @n, ManagerCaz = @mc, ProgramDAS = @pd WHERE BeneficiarId = @i";
        try
        {
            using (var connection = new SQLiteConnection(connString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@n", numeEditBenTb.Text);
                command.Parameters.AddWithValue("@mc", GetMgrCazId(MgrCazEbCb.Text));
                var index = ModulEbCb.Text.IndexOf("(", StringComparison.Ordinal);
                var modul = "";
                var dataInceput = "";


                if (ModulEbCb.Text != "" && index != -1)
                {
                    modul = ModulEbCb.Text.Substring(0, index - 1);
                    dataInceput = ModulEbCb.Text.Substring(index + 1, ModulEbCb.Text.Length - index - 2);
                    command.Parameters.AddWithValue("@pd", GetDASId(modul, dataInceput));
                    MessageBox.Show($@"modul: {modul} dataInceput: {dataInceput}  ID= {GetDASId(modul, dataInceput)}");
                }
                else
                {
                    command.Parameters.AddWithValue("@pd", 100);
                }

                command.Parameters.AddWithValue("@i", BeneficiarSelectat["BeneficiarId"]);
                connection.Open();
                command.ExecuteNonQuery();

                //MessageBox.Show(GetDASId(modul, dataInceput).ToString());
            }

            MessageBox.Show(@"Datele au fost actualizate cu succes!", "Succes", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Dispose();
        }
        catch (Exception exception)
        {
            MessageBox.Show($@"update BenDb: {exception.Message}");
        }
    }

    private void EditBenbtn_Click(object sender, EventArgs e)
    {
        UpdateBenDb();
    }
}