using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ManagerDAS;

public partial class EditareCP : Form
{
    private readonly string conString = "Data Source = ManagerDAS.db";
    private readonly DataRow consilierSelectat;

    public EditareCP(DataRow consilierSelectat)
    {
        InitializeComponent();
        this.consilierSelectat = consilierSelectat;
    }

    private void EditareCP_Load(object sender, EventArgs e)
    {
        try
        {
            tbNume.Text = consilierSelectat["Nume"].ToString();
            dis.Value = DateTime.ParseExact(consilierSelectat["DataIntrariiInSistem"].ToString(), "dd/MM/yyyy", null);
            studii.Text = consilierSelectat["Studii"].ToString();
            abilitatCB.Checked = consilierSelectat["Abilitat"].ToString() == "Da";
        }
        catch (Exception exception)
        {
            using (var sw = new StreamWriter("eroare.txt"))
            {
                sw.WriteLine(exception.InnerException + "\n" + exception.Message + "\n" + exception.StackTrace);
            }
        }
    }

    private void updateDB()
    {
        var query =
            "UPDATE ConsilieriDeProbatiune SET Nume = @n, DataIntrariiInSistem = @dis, Studii = @s, Abilitat = @a WHERE ConsilierDeProbatiuneId = @i";
        try
        {
            using (var connection = new SQLiteConnection(conString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@n", tbNume.Text);
                command.Parameters.AddWithValue("@dis", dis.Text);
                command.Parameters.AddWithValue("@s", studii.Text);
                command.Parameters.AddWithValue("@a", abilitatCB.Checked ? "Da" : "Nu");
                command.Parameters.AddWithValue("@i", consilierSelectat["ConsilierDeProbatiuneId"]);
                connection.Open();
                command.ExecuteNonQuery();
            }

            MessageBox.Show(@"Consilierul a fost actualizat cu succes!", @"Succes", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Dispose();
        }
        catch (Exception exception)
        {
            MessageBox.Show($@"Cerere invalidă! Aceasta a generat următoarea eroare: {exception}", @"Eroare",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btOk_Click(object sender, EventArgs e)
    {
        updateDB();
    }
}