using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ManagerDAS;

public partial class CautareCP : Form
{
    private DataTable _dataTable;

    private readonly string connectionString = "Data Source = ManagerDAS.db";

    public CautareCP()
    {
        InitializeComponent();
    }

    private void SwitchVizualiareCrietrii()
    {
        switch (criteriuCb.SelectedItem)
        {
            case "Nume":
                numeL.Show();
                numeTb1.Show();
                disL.Hide();
                disDP.Hide();
                studiiL.Hide();
                csCb.Hide();
                break;
            case "Data Intrării în Sistem":
                disL.Show();
                disDP.Show();
                numeL.Hide();
                numeTb1.Hide();
                studiiL.Hide();
                csCb.Hide();
                break;
            case "Studii":
                studiiL.Show();
                csCb.Show();
                numeL.Hide();
                numeTb1.Hide();
                disL.Hide();
                disDP.Hide();
                break;
        }

        switch (criteriuCb2.SelectedItem)
        {
            case "Nume":
                nume2L.Show();
                numeTb2.Show();
                dis3L.Hide();
                disDP2.Hide();
                studiiL2.Hide();
                csCb2.Hide();
                break;
            case "Data Intrării în Sistem":
                dis3L.Show();
                disDP2.Show();
                nume2L.Hide();
                numeTb2.Hide();
                studiiL2.Hide();
                csCb2.Hide();
                break;
            case "Studii":
                studiiL2.Show();
                csCb2.Show();
                nume2L.Hide();
                numeTb2.Hide();
                dis3L.Hide();
                disDP2.Hide();
                break;
        }
    }

    private void criteriuCb_SelectedIndexChanged(object sender, EventArgs e)
    {
        SwitchVizualiareCrietrii();
    }

    private void criteriuCb2_SelectedIndexChanged(object sender, EventArgs e)
    {
        SwitchVizualiareCrietrii();
    }

    private void StergereCriterii()
    {
        numeL.Hide();
        numeTb1.Hide();
        nume2L.Hide();
        numeTb2.Hide();
        disL.Hide();
        disDP.Hide();
        dis3L.Hide();
        disDP2.Hide();
        studiiL.Hide();
        csCb.Hide();
        studiiL2.Hide();
        csCb2.Hide();
        criteriuCb.Text = "";
        criteriuCb2.Text = "";
    }

    private void CautareCP_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.C) StergereCriterii();
        if (e.Control && e.KeyCode == Keys.S) SteregereCP();
        if (e.Control && e.KeyCode == Keys.E) EditareConsilier();
    }

    private void AfisareRezulateCriteriu1()
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            var criteriu = "";
            var valoare = "";
            switch (criteriuCb.SelectedItem)
            {
                case "Nume":
                    criteriu = "Nume";
                    valoare = $@"%{numeTb1.Text}%";
                    break;
                case "Studii":
                    criteriu = "Studii";
                    valoare = csCb.Text;
                    break;
                case "Data Intrării în Sistem":
                    criteriu = "DataIntrariiInSistem";
                    valoare = disDP.Text;
                    break;
                default:
                    MessageBox.Show("Eroare Criteriu", "Pe bune?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            var query =
                $"SELECT * FROM ConsilieriDeProbatiune WHERE {criteriu} like '{valoare}' LIMIT 6";
            try
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        _dataTable = new DataTable();

                        adapter.Fill(_dataTable);

                        CautareCPDgv.DataSource = _dataTable;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Selecție invalidă.Aceasta a generat următoarea eroare:{exception}", @"Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            query = $@"SELECT COUNT(*) FROM ConsilieriDeProbatiune WHERE {criteriu} like '{valoare}'";
            var cmd = new SQLiteCommand(query, connection);
            var limita = Convert.ToInt32(cmd.ExecuteScalar());

            if (limita > 6) limtaL.Visible = true;

            if (limita <= 6) limtaL.Visible = false;
        }
    }

    private void AfisareRezulateCriteriu2()
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            var criteriu = "";
            var valoare = "";
            switch (criteriuCb2.SelectedItem)
            {
                case "Nume":
                    criteriu = "Nume";
                    valoare = $@"%{numeTb2.Text}%";
                    break;
                case "Studii":
                    criteriu = "Studii";
                    valoare = csCb2.Text;
                    break;
                case "Data Intrării în Sistem":
                    criteriu = "DataIntrariiInSistem";
                    valoare = disDP2.Text;
                    break;
                default:
                    MessageBox.Show(@"Eroare Criteriu", @"Pe bune?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            var query = $"SELECT * FROM ConsilieriDeProbatiune WHERE {criteriu} like '{valoare}'LIMIT 6";

            try
            {
                //MessageBox.Show(query);

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        _dataTable = new DataTable();
                        adapter.Fill(_dataTable);
                        CautareCPDgv.DataSource = _dataTable;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Selecție invalidă.Aceasta a generat următoarea eroare:{exception}", @"Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            query = $@"SELECT COUNT(*) FROM ConsilieriDeProbatiune WHERE {criteriu} like '{valoare}'";
            var cmd = new SQLiteCommand(query, connection);
            var limita = Convert.ToInt32(cmd.ExecuteScalar());

            if (limita > 6) limtaL.Visible = true;

            if (limita <= 6) limtaL.Visible = false;
        }
    }

    private void AfisareRezultate2Criterii()
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            var criteriu1 = "";
            var criteriu2 = "";
            var valoare1 = "";
            var valoare2 = "";

            switch (criteriuCb.SelectedItem, criteriuCb2.SelectedItem)
            {
                case (("Nume", "Data Intrării în Sistem")):
                    criteriu1 = "Nume";
                    valoare1 = $@"%{numeTb1.Text}%";
                    criteriu2 = "DataIntrariiInSistem";
                    valoare2 = disDP2.Text;
                    break;
                case (("Nume", "Studii")):
                    criteriu1 = "Nume";
                    valoare1 = $@"%{numeTb1.Text}%";
                    criteriu2 = "Studii";
                    valoare2 = csCb2.Text;
                    break;
                case (("Data Intrării în Sistem", "Studii")):
                    criteriu1 = "DataIntrariiInSistem";
                    valoare1 = disDP.Text;
                    criteriu2 = "Studii";
                    valoare2 = csCb2.Text;
                    break;
                case (("Data Intrării în Sistem", "Nume")):
                    criteriu1 = "DataIntrariiInSistem";
                    valoare1 = disDP.Text;
                    criteriu2 = "Nume";
                    valoare2 = numeTb2.Text;
                    break;
                case (("Studii", "Nume")):
                    criteriu1 = "Studii";
                    valoare1 = csCb2.Text;
                    criteriu2 = "Nume";
                    valoare2 = numeTb2.Text;
                    break;
                case (("Studii", "Data Intrării în Sistem")):
                    criteriu1 = "Studii";
                    valoare1 = csCb2.Text;
                    criteriu2 = "DataIntrariiInSistem";
                    valoare2 = disDP2.Text;
                    break;
                case (("Nume", "Nume")):
                    criteriu1 = "Nume";
                    valoare1 = $@"%{numeTb1.Text}%";
                    criteriu2 = "Nume";
                    valoare2 = $@"%{numeTb2.Text}%";
                    break;
                case (("Data Intrării în Sistem", "Data Intrării în Sistem")):
                    criteriu1 = "DataIntrariiInSistem";
                    valoare1 = disDP.Text;
                    criteriu2 = "DataIntrariiInSistem";
                    valoare2 = disDP2.Text;
                    break;
                case (("Studii", "Studii")):
                    criteriu1 = "Studii";
                    valoare1 = csCb.Text;
                    criteriu2 = "Studii";
                    valoare2 = csCb2.Text;
                    break;
                default:
                    MessageBox.Show($@"{criteriuCb.SelectedItem} ///// {criteriuCb2.SelectedItem}");
                    break;
            }

            var query = "";
            if (criteriu1 == criteriu2)
                query =
                    $"SELECT * FROM ConsilieriDeProbatiune WHERE {criteriu1} like '{valoare1}' or {criteriu2} like '{valoare2}' LIMIT 6";
            else
                query =
                    $"SELECT * FROM ConsilieriDeProbatiune WHERE {criteriu1} like '{valoare1}' and {criteriu2} like '{valoare2}' LIMIT 6";

            try
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                         _dataTable = new DataTable();

                        adapter.Fill(_dataTable);

                        CautareCPDgv.DataSource = _dataTable;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $@"Combinație de criterii selecție invalidă.Această Combinație a generat următoarea eroare:\n\n{exception}",
                    @"Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (criteriu1 == criteriu2)
                query =
                    $@"SELECT COUNT(*) FROM ConsilieriDeProbatiune WHERE {criteriu1} like '{valoare1}' or {criteriu2} like '{valoare2}'";

            else
                query =
                    $@"SELECT COUNT(*) FROM ConsilieriDeProbatiune WHERE {criteriu1} like '{valoare1}' and {criteriu2} like '{valoare2}'";

            var cmd = new SQLiteCommand(query, connection);
            var limita = Convert.ToInt32(cmd.ExecuteScalar());

            if (limita > 6) limtaL.Visible = true;

            if (limita <= 6) limtaL.Visible = false;
        }
    }

    private void SteregereCP()
    {
        try
        {
            var id = CautareCPDgv.SelectedRows[0].Cells[0].Value;
            var nume = CautareCPDgv.SelectedRows[0].Cells[1].Value;
            var result = MessageBox.Show($@"Sunteți sigur că doriți să ștergeți Consilierul de probațiune {nume}?", @"Ștergere",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var query = $@"DELETE FROM ConsilieriDeProbatiune WHERE ConsilierDeProbatiuneId = {id}";

                using (var conn = new SQLiteConnection(connectionString))
                {
                    var command = new SQLiteCommand(query, conn);
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show($@"Consilierul de probațiune {nume} a fost șters cu succes!", @"Ștergere", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    CautareCPDgv.Rows.Remove(CautareCPDgv.SelectedRows[0]);
                }
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show(@"Nu ați selectat niciun consilier de probațiune!", "Eroare", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        catch (Exception e)
        {
            MessageBox.Show($@"Eroare la ștergere:\n\n{e}", @"Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void rezultateBtn_Click(object sender, EventArgs e)
    {
        if (criteriuCb.Text != "" && criteriuCb2.Text != "")
            AfisareRezultate2Criterii();
        else if (criteriuCb.Text != "" && criteriuCb2.Text == "")
            AfisareRezulateCriteriu1();
        else if (criteriuCb.Text == "" && criteriuCb2.Text != "")
            AfisareRezulateCriteriu2();
        else
            MessageBox.Show(@"Vă rugăm selectați un criteriu!", @"Cel puțin un criteriu", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
    }

    private void EditareConsilier()
    {
        try
        {
            var consilierSelectat = (CautareCPDgv.SelectedRows[0].DataBoundItem as DataRowView).Row;

            var editareCp = new EditareCP(consilierSelectat);
            editareCp.ShowDialog();
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show(@"Nu ați selectat niciun consilier de probațiune!", "Eroare", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void ecpEditBt_Click(object sender, EventArgs e)
    {
        EditareConsilier();
    }


    private void ecpStgBtn_Click(object sender, EventArgs e)
    {
        SteregereCP();
    }
    
    
    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
       
        Graphics graphics = e.Graphics;
        Font font = new Font("Arial", 12);
        Brush brush = Brushes.Black;
        float lineHeight = font.GetHeight(graphics);
        float x = e.MarginBounds.Left;
        float y = e.MarginBounds.Top;
        
        
            foreach (DataRow row in _dataTable.Rows)
            {
                string rowText = "";
            
                foreach (var item in row.ItemArray)
                {
                    rowText += item + "\t"; 
                }
            
                graphics.DrawString(rowText, font, brush, x, y);
                y += lineHeight;
            }
        
        
        e.HasMorePages = !(y < e.MarginBounds.Bottom);
    }

    private void printareToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        PrintDocument printare = new PrintDocument();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        if (_dataTable != null)
        {
            printare.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog.Document = printare;
            printPreviewDialog.ShowDialog();
        }

        else
        {
            MessageBox.Show("Vă rugăm să căutați un consilier de probațiune înainte de a imprima!", "Eroare",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }

   
}