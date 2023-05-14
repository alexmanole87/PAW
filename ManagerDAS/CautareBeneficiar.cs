using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ManagerDAS;

public partial class CautareBeneficiar : Form
{
    private readonly string _connString = "Data Source = ManagerDAS.db";
    private DataTable _dt;

    public CautareBeneficiar()
    {
        InitializeComponent();

        var selMgrCaz = "SELECT * FROM ConsilieriDeProbatiune ORDER BY Nume";
        using (var da = new SQLiteDataAdapter(selMgrCaz, _connString))
        {
            var dt = new DataTable();
            da.Fill(dt);
            MgrCazEbCb1.DataSource = dt;
            MgrCazEbCb1.DisplayMember = "Nume";
            MgrCazEbCb2.DataSource = dt;
            MgrCazEbCb2.DisplayMember = "Nume";
        }
    }

    private void SwitchVizualiareCrietrii()
    {
        switch (criteriuCB1.SelectedItem)
        {
            case "Nume":
                numeL.Show();
                numeTb1.Show();
                programDASL2.Hide();
                MgrCazEbCb1.Hide();
                mgrL1.Hide();
                dasEbCb1.Hide();
                break;
            case "Manager Caz":
                mgrL1.Show();
                MgrCazEbCb1.Show();
                numeL.Hide();
                numeTb1.Hide();
                mgrL1.Hide();
                dasEbCb1.Hide();
                break;
            case "Program DAS":
                programDASL1.Show();
                dasEbCb1.Show();
                numeL.Hide();
                numeTb1.Hide();
                mgrL1.Hide();
                MgrCazEbCb1.Hide();
                break;
        }

        switch (criteriuCB2.SelectedItem)
        {
            case "Nume":
                numeL2.Show();
                numeTb2.Show();
                managerCazL2.Hide();
                MgrCazEbCb2.Hide();
                programDASL2.Hide();
                dasEbCb2.Hide();
                break;
            case "Manager Caz":
                managerCazL2.Show();
                MgrCazEbCb2.Show();
                numeL2.Hide();
                numeTb2.Hide();
                programDASL2.Hide();
                dasEbCb2.Hide();
                break;
            case "Program DAS":
                programDASL2.Show();
                dasEbCb2.Show();
                numeL2.Hide();
                numeTb2.Hide();
                managerCazL2.Hide();
                MgrCazEbCb2.Hide();
                break;
        }
    }


    private void criteriuCB1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SwitchVizualiareCrietrii();
    }

    private void criteriuCB2_SelectedIndexChanged(object sender, EventArgs e)
    {
        SwitchVizualiareCrietrii();
    }

    private void StergereCriterii()
    {
        numeTb1.Text = "";
        numeTb1.Hide();
        MgrCazEbCb1.SelectedItem = null;
        MgrCazEbCb1.Hide();
        numeTb2.Text = "";
        numeTb2.Hide();
        MgrCazEbCb2.SelectedItem = null;
        MgrCazEbCb2.Hide();
        dasEbCb1.SelectedItem = null;
        dasEbCb1.Hide();
        dasEbCb2.SelectedItem = null;
        dasEbCb2.Hide();
        criteriuCB1.SelectedItem = null;
        criteriuCB2.SelectedItem = null;
    }


    private void CautareBeneficiar_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.C) StergereCriterii();
        if (e.Control && e.KeyCode == Keys.S) StergereBeneficiar();
        if (e.Control && e.KeyCode == Keys.E) EditareBen();
    }

    private object GetMgrCazId(string nume)
    {
        var q = $@"SELECT ConsilierDeProbatiuneId FROM ConsilieriDeProbatiune WHERE Nume = @nume";
        try
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                var command = new SQLiteCommand(q, connection);
                connection.Open();
                command.Parameters.AddWithValue("@nume", nume);
                var tid = command.ExecuteScalar();
                return tid;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($@"ManagerCazID: {e.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    private object GetDasId(string modul)
    {
        var q = $@"SELECT ProgramDASId FROM ProgramDAS WHERE Modul = @modul";

        try
        {
            using (var connection = new SQLiteConnection(_connString))
            {
                var command = new SQLiteCommand(q, connection);
                connection.Open();
                command.Parameters.AddWithValue("@modul", modul);
                var tid = command.ExecuteScalar();
                return tid;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($@"ProgramDASID: {e.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    private void AfisareRezulateCriteriu1()
    {
        using (var connection = new SQLiteConnection(_connString))
        {
            connection.Open();
            var criteriu = "";
            var valoare = "";
            switch (criteriuCB1.SelectedItem)
            {
                case "Nume":
                    criteriu = "NumeBeneficiar";
                    valoare = $@"%{numeTb1.Text}%";
                    break;
                case "Manager Caz":
                    criteriu = "ManagerCaz";
                    valoare = $@"{GetMgrCazId(MgrCazEbCb1.Text)}";
                    break;
                case "Program DAS":
                    criteriu = "ProgramDAS";
                    valoare = $@"{GetDasId(dasEbCb1.Text)}";
                    break;
                default:
                    MessageBox.Show("Eroare Criteriu", "Pe bune?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            var query =
                $@"SELECT Beneficiar.BeneficiarId, Beneficiar.NumeBeneficiar, CP1.Nume AS NumeCP, ProgramDAS.Modul AS ModulDAS, ProgramDAS.DataInceput, ProgramDAS.DataSfarsit FROM Beneficiar
                            LEFT JOIN ConsilieriDeProbatiune CP1 ON Beneficiar.ManagerCaz = CP1.ConsilierDeProbatiuneId
                            LEFT JOIN ConsilieriDeProbatiune CP2 ON Beneficiar.ManagerCaz = CP2.ConsilierDeProbatiuneId
                            LEFT JOIN ProgramDAS ON Beneficiar.ProgramDAS = ProgramDAS.ProgramDASId
                            WHERE Beneficiar.{@criteriu} like '%{@valoare}%'
                            LIMIT 6";


            try
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        _dt = new DataTable();
                        command.Parameters.AddWithValue("@criteriu", criteriu);
                        command.Parameters.AddWithValue("@valoare", valoare);
                        adapter.Fill(_dt);

                        CautareBenDgv.DataSource = _dt;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $@"Selecție PRIMUL CRITERIUL: Selecție invalidă.Aceasta a generat următoarea eroare:{exception}",
                    @"Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            query = $@"SELECT COUNT(*) FROM Beneficiar WHERE {criteriu} like '{valoare}'";
            var cmd = new SQLiteCommand(query, connection);
            var limita = Convert.ToInt32(cmd.ExecuteScalar());

            if (limita > 6) limtaL.Visible = true;

            if (limita <= 6) limtaL.Visible = false;
        }
    }

    private void AfisareRezulateCriteriu2()
    {
        using (var connection = new SQLiteConnection(_connString))
        {
            connection.Open();
            var criteriu = "";
            var valoare = "";
            switch (criteriuCB2.SelectedItem)
            {
                case "Nume":
                    criteriu = "NumeBeneficiar";
                    valoare = $@"%{numeTb2.Text}%";
                    break;
                case "Manager Caz":
                    criteriu = "ManagerCaz";
                    valoare = $@"{GetMgrCazId(MgrCazEbCb2.Text)}";
                    break;
                case "Program DAS":
                    criteriu = "ProgramDAS";
                    valoare = $@"{GetDasId(dasEbCb2.Text)}";
                    break;
                default:
                    MessageBox.Show(@"Selecție AL DOILEA CRITERIU: Eroare Criteriu", @"Pe bune?!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
            }

            var query =
                $@"SELECT Beneficiar.BeneficiarId,Beneficiar.NumeBeneficiar, CP1.Nume AS NumeCP, ProgramDAS.Modul AS ModulDAS, ProgramDAS.DataInceput, ProgramDAS.DataSfarsit FROM Beneficiar
                            LEFT JOIN ConsilieriDeProbatiune CP1 ON Beneficiar.ManagerCaz = CP1.ConsilierDeProbatiuneId
                            LEFT JOIN ConsilieriDeProbatiune CP2 ON Beneficiar.ManagerCaz = CP2.ConsilierDeProbatiuneId
                            LEFT JOIN ProgramDAS ON Beneficiar.ProgramDAS = ProgramDAS.ProgramDASId
                            WHERE Beneficiar.{@criteriu} like '%{@valoare}%'
                            LIMIT 6";

            try
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        _dt = new DataTable();

                        command.Parameters.AddWithValue("@criteriu", criteriu);
                        command.Parameters.AddWithValue("@valoare", valoare);
                        adapter.Fill(_dt);

                        CautareBenDgv.DataSource = _dt;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Selecție invalidă.Aceasta a generat următoarea eroare:{exception}", @"Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            query = $@"SELECT COUNT(*) FROM Beneficiar WHERE {criteriu} like '{valoare}'";
            var cmd = new SQLiteCommand(query, connection);
            var limita = Convert.ToInt32(cmd.ExecuteScalar());

            if (limita > 6) limtaL.Visible = true;

            if (limita <= 6) limtaL.Visible = false;
        }
    }

    private void AfisareRezultate2Criterii()
    {
        using (var connection = new SQLiteConnection(_connString))
        {
            connection.Open();
            var criteriu1 = "";
            var criteriu2 = "";
            var valoare1 = "";
            var valoare2 = "";

            switch (criteriuCB1.SelectedItem, criteriuCB2.SelectedItem)
            {
                case (("Nume", "Manager Caz")):
                    criteriu1 = "NumeBeneficiar";
                    valoare1 = $@"%{numeTb1.Text}%";
                    criteriu2 = "ManagerCaz";
                    valoare2 = $@"{GetMgrCazId(MgrCazEbCb2.Text)}";
                    break;
                case (("Nume", "Program DAS")):
                    criteriu1 = "NumeBeneficiar";
                    valoare1 = $@"%{numeTb1.Text}%";
                    criteriu2 = "ProgramDAS";
                    valoare2 = $@"{GetDasId(dasEbCb2.Text)}";
                    break;
                case (("Manager Caz", "Program DAS")):
                    criteriu1 = "ManagerCaz";
                    valoare1 = $@"{GetMgrCazId(MgrCazEbCb1.Text)}";
                    criteriu2 = "ProgramDAS";
                    valoare2 = $@"{GetDasId(dasEbCb2.Text)}";
                    break;
                case (("Manager Caz", "Nume")):
                    criteriu1 = "ManagerCaz";
                    valoare1 = $@"{GetMgrCazId(MgrCazEbCb1.Text)}";
                    criteriu2 = "NumeBeneficiar";
                    valoare2 = $@"{numeTb2.Text}";
                    break;
                case (("Program DAS", "Nume")):
                    criteriu1 = "ProgramDAS";
                    valoare1 = $@"{GetDasId(dasEbCb1.Text)}";
                    criteriu2 = "NumeBeneficiar";
                    valoare2 = numeTb2.Text;
                    break;
                case (("Program DAS", "Manager Caz")):
                    criteriu1 = "ProgramDAS";
                    valoare1 = $@"{GetDasId(dasEbCb1.Text)}";
                    criteriu2 = "ManagerCaz";
                    valoare2 = $@"{GetMgrCazId(MgrCazEbCb2.Text)}";
                    break;
                case (("Nume", "Nume")):
                    criteriu1 = "NumeBeneficiar";
                    valoare1 = $@"%{numeTb1.Text}%";
                    criteriu2 = "NumeBeneficiar";
                    valoare2 = $@"%{numeTb2.Text}%";
                    break;
                case (("Manager Caz", "Manager Caz")):
                    criteriu1 = "ManagerCaz";
                    valoare1 = (string)GetMgrCazId(MgrCazEbCb1.Text);
                    criteriu2 = "ManagerCaz";
                    valoare2 = (string)GetMgrCazId(MgrCazEbCb2.Text);
                    break;
                case (("Program DAS", "Program DAS")):
                    criteriu1 = "ProgramDAS";
                    valoare1 = $@"{GetDasId(dasEbCb1.Text)}";
                    criteriu2 = "ProgramDAS";
                    valoare2 = $@"{GetDasId(dasEbCb2.Text)}";
                    break;
                default:
                    MessageBox.Show($@"{criteriuCB1.SelectedItem} ///// {criteriuCB2.SelectedItem}");
                    break;
            }

            var query = "";
            if (criteriu1 == criteriu2)
                query =
                    $@"SELECT Beneficiar.BeneficiarId ,Beneficiar.NumeBeneficiar, CP1.Nume AS NumeCP, ProgramDAS.Modul AS ModulDAS, ProgramDAS.DataInceput, ProgramDAS.DataSfarsit FROM Beneficiar
                            LEFT JOIN ConsilieriDeProbatiune CP1 ON Beneficiar.ManagerCaz = CP1.ConsilierDeProbatiuneId
                            LEFT JOIN ConsilieriDeProbatiune CP2 ON Beneficiar.ManagerCaz = CP2.ConsilierDeProbatiuneId
                            LEFT JOIN ProgramDAS ON Beneficiar.ProgramDAS = ProgramDAS.ProgramDASId
                            WHERE Beneficiar.{@criteriu1} like '%{@valoare1}%' or Beneficiar.{@criteriu2} like '%{@valoare2}%'
                            LIMIT 6";
            else
                query =
                    $@"SELECT Beneficiar.BeneficiarId, Beneficiar.NumeBeneficiar, CP1.Nume AS NumeCP, ProgramDAS.Modul AS ModulDAS, ProgramDAS.DataInceput, ProgramDAS.DataSfarsit FROM Beneficiar
                            LEFT JOIN ConsilieriDeProbatiune CP1 ON Beneficiar.ManagerCaz = CP1.ConsilierDeProbatiuneId
                            LEFT JOIN ConsilieriDeProbatiune CP2 ON Beneficiar.ManagerCaz = CP2.ConsilierDeProbatiuneId
                            LEFT JOIN ProgramDAS ON Beneficiar.ProgramDAS = ProgramDAS.ProgramDASId
                            WHERE Beneficiar.{@criteriu1} like '%{@valoare1}%' and Beneficiar.{@criteriu2} like '%{@valoare2}%'
                            LIMIT 6";

            try
            {
                // MessageBox.Show(query);
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        _dt = new DataTable();
                        command.Parameters.AddWithValue("@criteriu1", criteriu1);
                        command.Parameters.AddWithValue("@valoare1", valoare1);
                        command.Parameters.AddWithValue("@criteriu2", criteriu2);
                        command.Parameters.AddWithValue("@valoare2", valoare2);

                        adapter.Fill(_dt);

                        CautareBenDgv.DataSource = _dt;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $@"Selecție AMBELE CRITERII: Combinație de criterii selecție invalidă.Această Combinație a generat următoarea eroare:\n\n{exception}",
                    @"Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (criteriu1 == criteriu2)
                query =
                    $@"SELECT COUNT(*) FROM Beneficiar WHERE {criteriu1} like '{valoare1}' or {criteriu2} like '{valoare2}'";

            else
                query =
                    $@"SELECT COUNT(*) FROM Beneficiar WHERE {criteriu1} like '{valoare1}' and {criteriu2} like '{valoare2}'";

            var cmd = new SQLiteCommand(query, connection);
            var limita = Convert.ToInt32(cmd.ExecuteScalar());

            if (limita > 6) limtaL.Visible = true;

            if (limita <= 6) limtaL.Visible = false;
        }
    }

    private void StergereBeneficiar()
    {
        try
        {
            var id = CautareBenDgv.SelectedRows[0].Cells[0].Value;
            var nume = CautareBenDgv.SelectedRows[0].Cells[1].Value;
            var result = MessageBox.Show($@"Sunteți sigur că doriți să ștergeți beneficiarul {nume}?", @"Ștergere",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var query = $@"DELETE FROM Beneficiar WHERE BeneficiarId = {id}";

                using (var conn = new SQLiteConnection(_connString))
                {
                    var command = new SQLiteCommand(query, conn);
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show($@"Beneficiarul {nume} a fost șters cu succes!", @"Ștergere", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    CautareBenDgv.Rows.Remove(CautareBenDgv.SelectedRows[0]);
                }
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show(@"Nu ați selectat niciun beneficiar!", "Eroare", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        catch (Exception e)
        {
            MessageBox.Show($@"Eroare la ștergere:\n\n{e}", @"Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void rezultateBtn_Click(object sender, EventArgs e)
    {
        if (criteriuCB1.SelectedItem == null && criteriuCB2.SelectedItem == null)
        {
            MessageBox.Show(@"Selectați cel puțin un criteriu de căutare!", @"Eroare", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        if (criteriuCB1.SelectedItem != null && criteriuCB2.SelectedItem == null) AfisareRezulateCriteriu1();

        if (criteriuCB1.SelectedItem == null && criteriuCB2.SelectedItem != null) AfisareRezulateCriteriu2();

        if (criteriuCB1.SelectedItem != null && criteriuCB2.SelectedItem != null) AfisareRezultate2Criterii();
    }


    private void EditareBen()
    {
        try
        {
            var benefSel = (CautareBenDgv.SelectedRows[0].DataBoundItem as DataRowView).Row;
            var eb = new EditareBeneficiar(benefSel);
            eb.Show();
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show(@"Selectați cel puțin un beneficiar din tabel!", @"Eroare", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void ebEditBt_Click(object sender, EventArgs e)
    {
        EditareBen();
    }

    private void ebStgBtn_Click(object sender, EventArgs e)
    {
        StergereBeneficiar();
    }
    
    private void printareToolStripMenuItem_Click(object sender, EventArgs e)
    {
        PrintDocument printare = new PrintDocument();
        PrintPreviewDialog previzualizare = new PrintPreviewDialog();

        if (_dt == null)
        {
            MessageBox.Show(@"Nu există date de printat!", @"Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            printare.PrintPage += Printare_PrintPage;
            previzualizare.Document = printare;
            previzualizare.ShowDialog();    
        }
       
    }

    private void Printare_PrintPage(Object sender, PrintPageEventArgs e)
    {
        Graphics grafica = e.Graphics;
      
        Font font = new Font("Arial", 12);
        Brush pensula = Brushes.Black;
        
        float linieHigh = font.GetHeight(grafica);
        float startX = e.MarginBounds.Left;
        float startY = e.MarginBounds.Top;

        foreach (DataRow dr in _dt.Rows)
        {
            string textRand = "";
            
            foreach (var item in dr.ItemArray)
            {
                textRand += item + "\t";
            }
            
            grafica.DrawString(textRand, font, pensula, startX, startY);
            startY += linieHigh;
        }
        
        e.HasMorePages = !(startY < e.MarginBounds.Bottom);
        
    }
}