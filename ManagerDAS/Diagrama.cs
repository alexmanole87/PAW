using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ManagerDAS;

public partial class Diagrama : Form
{
    private readonly string conexiune = "Data Source = ManagerDAS.db";
    public static int count = 0;
    public static event EventHandler CountUpdated;

    public Diagrama()
    {
        InitializeComponent();

        var selectare = "SELECT * FROM ProgramDAS ORDER BY Modul";

        using (var da = new SQLiteDataAdapter(selectare, conexiune))
        {
            var dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Modul";
        }
    }

    private object GetId(string modul)
    {
        var query = $@"SELECT ProgramDASId FROM ProgramDAS WHERE Modul = @m";
        try
        {
            using (var conn = new SQLiteConnection(conexiune))
            {
                var cmd = new SQLiteCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@m", modul);
                var id = cmd.ExecuteScalar();
                return id;
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show($@"GetId: {exception.Message}");
            return null;
        }
    }
    
    private object GetCount(object id)
    {
        var query = $@"SELECT COUNT(*) FROM Beneficiar WHERE ProgramDAS = @id";
        try
        {
            using (var conn = new SQLiteConnection(conexiune))
            {
                using ( var cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    var countObg = cmd.ExecuteScalar();
                    return countObg;
                }
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show($@"GetCount: {exception.Message}");
            return null;
        }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            
            //count = int.TryParse(GetCount(GetId(comboBox1.Text)));
            MessageBox.Show(GetCount(GetId(comboBox1.Text)).ToString());
            CountUpdated?.Invoke(this, EventArgs.Empty);
        }
        catch (Exception exception) 
        {
            MessageBox.Show(@"comboBox1_SelectedIndexChanged: " + exception.Message);
            count = -2;
            CountUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}