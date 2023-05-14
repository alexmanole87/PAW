using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ManagerDAS;

public partial class AdaugareConsilierProbatiune : Form
{
    private readonly string connectionString = "Data Source = ManagerDAS.db";

    public AdaugareConsilierProbatiune()
    {
        InitializeComponent();
    }

    private void AdaugareElement()
    {
        var q =
            "INSERT INTO ConsilieriDeProbatiune (Nume, DataIntrariiInSistem, Studii, Abilitat) VALUES (@n, @d, @s, @a)";
        try
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(q, connection);

                command.Parameters.AddWithValue("@n", tbNume.Text);
                command.Parameters.AddWithValue("@d", dis.Text);
                command.Parameters.AddWithValue("@s", studii.Text);
                command.Parameters.AddWithValue("@a", abilitatCB.Checked ? "Da" : "Nu");

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        catch (Exception ex) { MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error); }


    }

    private void btOk_Click(object sender, EventArgs e)
    {
        var res = MessageBox.Show(
            $"Sigur doriți să introduceți următorul consilier: nume: {tbNume.Text} și studii: {studii.Text}",
            "Adăugare Consilier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res != DialogResult.Yes) return;
        AdaugareElement();
        Dispose();
    }
}