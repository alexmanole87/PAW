using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ManagerDAS;

public partial class AdaugareBeneficiar : Form
{
    private readonly string connString = "Data Source = ManagerDAS.db";

    public AdaugareBeneficiar()
    {
        var selMgrCaz = "SELECT Nume FROM ConsilieriDeProbatiune ORDER BY Nume";
        InitializeComponent();
        using (var da = new SQLiteDataAdapter(selMgrCaz, connString))
        {
            var dt = new DataTable();
            da.Fill(dt);
            MgrCazCb.DisplayMember = "Nume";
            MgrCazCb.DataSource = dt;
        }
    }

    private void DASCb_CheckedChanged(object sender, EventArgs e)
    {
        DASCb.Text = DASCb.Checked ? "Beneficiar înscris în DAS" : "Beneficiar neînscris în DAS";
        if (DASCb.Checked)
        {
            ModulCb.Show();
            modulLabel.Show();
        }
        else
        {
            ModulCb.Hide();
            modulLabel.Hide();
        }
    }

    private object GetMgrCazId(string nume)
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

    private object GetMgrDASId(string nume)
    {
        var q = $"SELECT ProgramDASId FROM ProgramDAS WHERE Modul = '{nume}'";

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
        var qDAS = "INSERT INTO Beneficiar (NumeBeneficiar, ManagerCaz, ProgramDAS) VALUES (@n, @mc, @das)";
        var qFaraDAS = "INSERT INTO Beneficiar (NumeBeneficiar, ManagerCaz) VALUES (@n, @mc)";

        if (DASCb.Checked)
            using (var connection = new SQLiteConnection(connString))
            {
                var command = new SQLiteCommand(qDAS, connection);

                command.Parameters.AddWithValue("@n", numeBenTb.Text);
                command.Parameters.AddWithValue("@mc", GetMgrCazId($"{MgrCazCb.Text}"));
                command.Parameters.AddWithValue("@das", GetMgrDASId($"{ModulCb.Text}"));

                connection.Open();
                command.ExecuteNonQuery();
            }

        else
            using (var connection = new SQLiteConnection(connString))
            {
                var command = new SQLiteCommand(qFaraDAS, connection);

                command.Parameters.AddWithValue("@n", numeBenTb.Text);
                command.Parameters.AddWithValue("@mc", GetMgrCazId($"{MgrCazCb.Text}"));

                connection.Open();
                command.ExecuteNonQuery();
            }
    }

    private void AdBenbtn_Click(object sender, EventArgs e)
    {
        
        DialogResult dr = MessageBox.Show($@"Sigur adăugați următorul beneficiar: 
Nume: {numeBenTb.Text} 
Consilier Manager de caz: {MgrCazCb.Text}", @"Confirmare adăugare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
        
        if(dr == DialogResult.Yes)
        {
            AdaugareElement();
            Dispose();
        }
        else
        {
            Dispose();
        }
    }
}