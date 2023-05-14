using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ManagerDAS;

public partial class CautareDAS : Form
{
    private readonly string connString = "Data Source = ManagerDAS.db";
    private DataTable dt;

    public CautareDAS()
    {
        InitializeComponent();

        var selTrainer = "SELECT * FROM ConsilieriDeProbatiune ORDER BY Nume";

        using (var da = new SQLiteDataAdapter(selTrainer, connString))
        {
            var dt = new DataTable();
            da.Fill(dt);

            Trainer1Cb1.DataSource = dt;
            Trainer1Cb1.DisplayMember = "Nume";
            Trainer2Cb1.DataSource = dt;
            Trainer2Cb1.DisplayMember = "Nume";
        }

        using (var da = new SQLiteDataAdapter(selTrainer, connString))
        {
            var dt = new DataTable();
            da.Fill(dt);
            Trainer1Cb2.DataSource = dt;
            Trainer1Cb2.DisplayMember = "Nume";
            Trainer2Cb2.DataSource = dt;
            Trainer2Cb2.DisplayMember = "Nume";
        }
    }

    private void SwitchVizualiareCrietrii()
    {
        switch (criteriuCB1.SelectedItem)
        {
            case "Modul":
                modulLabel1.Show();
                modulComboBox1.Show();
                dataInceputLabel1.Visible = false;
                dataInceputDP1.Visible = false;
                dataSfarsitLabel1.Visible = false;
                dataSfarsitDP1.Visible = false;
                Trainer1L1.Visible = false;
                Trainer1Cb1.Visible = false;
                Trainer2L1.Visible = false;
                Trainer2Cb1.Visible = false;
                break;
            case "DataInceput":
                dataInceputLabel1.Visible = true;
                dataInceputDP1.Visible = true;
                dataSfarsitLabel1.Visible = false;
                dataSfarsitDP1.Visible = false;
                Trainer1L1.Visible = false;
                Trainer1Cb1.Visible = false;
                Trainer2L1.Visible = false;
                Trainer2Cb1.Visible = false;
                modulLabel1.Visible = false;
                modulComboBox1.Visible = false;
                break;
            case "DataSfarsit":
                dataInceputLabel1.Visible = false;
                dataInceputDP1.Visible = false;
                dataSfarsitLabel1.Visible = true;
                dataSfarsitDP1.Visible = true;
                Trainer1L1.Visible = false;
                Trainer1Cb1.Visible = false;
                Trainer2L1.Visible = false;
                Trainer2Cb1.Visible = false;
                modulLabel1.Visible = false;
                modulComboBox1.Visible = false;
                break;
            case "Trainer 1":
                dataInceputLabel1.Visible = false;
                dataInceputDP1.Visible = false;
                dataSfarsitLabel1.Visible = false;
                dataSfarsitDP1.Visible = false;
                Trainer1L1.Visible = true;
                Trainer1Cb1.Visible = true;
                Trainer2L1.Visible = true;
                Trainer2Cb1.Visible = true;
                modulLabel1.Visible = false;
                modulComboBox1.Visible = false;
                break;
            case "Trainer 2":
                dataInceputLabel1.Visible = false;
                dataInceputDP1.Visible = false;
                dataSfarsitLabel1.Visible = false;
                dataSfarsitDP1.Visible = false;
                Trainer1L1.Visible = false;
                Trainer1Cb1.Visible = false;
                Trainer2L1.Visible = true;
                Trainer2Cb1.Visible = true;
                modulLabel1.Visible = false;
                modulComboBox1.Visible = false;
                break;
        }

        switch (criteriuCB2.SelectedItem)
        {
            case "Modul":
                modulLabel2.Visible = true;
                modulComboBox2.Visible = true;
                dataInceputLabel2.Visible = false;
                dataInceputDP2.Visible = false;
                dataSfarsitLabel2.Visible = false;
                dataSfarsitDP2.Visible = false;
                Trainer2L2.Visible = false;
                Trainer1Cb2.Visible = false;
                Trainer2L2.Visible = false;
                Trainer2Cb2.Visible = false;
                break;
            case "DataInceput":
                dataInceputLabel2.Visible = true;
                dataInceputDP2.Visible = true;
                dataSfarsitLabel2.Visible = false;
                dataSfarsitDP2.Visible = false;
                Trainer2L2.Visible = false;
                Trainer1Cb2.Visible = false;
                Trainer2L2.Visible = false;
                Trainer2Cb2.Visible = false;
                modulLabel2.Visible = false;
                modulComboBox2.Visible = false;
                break;
            case "DataSfarsit":
                dataInceputLabel2.Visible = false;
                dataInceputDP2.Visible = false;
                dataSfarsitLabel2.Visible = true;
                dataSfarsitDP2.Visible = true;
                Trainer2L2.Visible = false;
                Trainer1Cb2.Visible = false;
                Trainer2L2.Visible = false;
                Trainer2Cb2.Visible = false;
                modulLabel2.Visible = false;
                modulComboBox2.Visible = false;
                break;
            case "Trainer 1":
                dataInceputLabel2.Visible = false;
                dataInceputDP2.Visible = false;
                dataSfarsitLabel2.Visible = false;
                dataSfarsitDP2.Visible = false;
                Trainer1L2.Visible = true;
                Trainer1Cb2.Visible = true;
                Trainer2L2.Visible = false;
                Trainer2Cb2.Visible = false;
                modulLabel2.Visible = false;
                modulComboBox2.Visible = false;
                break;
            case "Trainer 2":
                dataInceputLabel2.Visible = false;
                dataInceputDP2.Visible = false;
                dataSfarsitLabel2.Visible = false;
                dataSfarsitDP2.Visible = false;
                Trainer1L2.Visible = false;
                Trainer1Cb2.Visible = false;
                Trainer2L2.Visible = true;
                Trainer2Cb2.Visible = true;
                modulLabel2.Visible = false;
                modulComboBox2.Visible = false;
                break;
        }
    }

    private void criteriuCB1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            SwitchVizualiareCrietrii();
        }
        catch (Exception exception)
        {
            MessageBox.Show($@"Switch Crit 1: {exception.Message}");
        }
    }

    private void criteriuCB2_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            SwitchVizualiareCrietrii();
        }
        catch (Exception exception)
        {
            MessageBox.Show($@"Switch Crit 1: {exception.Message}");
        }
    }

    private void StergereCriterii()
    {
        modulLabel1.Visible = false;
        modulComboBox1.Text = "";
        modulComboBox1.Visible = false;
        dataInceputLabel1.Visible = false;
        dataInceputDP1.Text = "";
        dataInceputDP1.Visible = false;
        dataSfarsitLabel1.Visible = false;
        dataSfarsitDP1.Text = "";
        dataSfarsitDP1.Visible = false;
        Trainer1L1.Visible = false;
        Trainer1Cb1.Text = "";
        Trainer1Cb1.Visible = false;
        Trainer2L1.Visible = false;
        Trainer2Cb1.Text = "";
        Trainer2Cb1.Visible = false;
        modulLabel2.Visible = false;
        modulComboBox2.Text = "";
        modulComboBox2.Visible = false;
        dataInceputLabel2.Visible = false;
        dataInceputDP2.Text = "";
        dataInceputDP2.Visible = false;
        dataSfarsitLabel2.Visible = false;
        dataSfarsitDP2.Text = "";
        dataSfarsitDP2.Visible = false;
        Trainer1L2.Visible = false;
        Trainer1Cb2.Text = "";
        Trainer1Cb2.Visible = false;
        Trainer2L2.Visible = false;
        Trainer2Cb2.Text = "";
        Trainer2Cb2.Visible = false;
    }

    private void CautareDAS_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.C) StergereCriterii();
        if (e.Control && e.KeyCode == Keys.E) EditDAS();
        if (e.Control && e.KeyCode == Keys.S) StergereDAS();
    }

    private object GetTrainerID(string nume)
    {
        var getAllTrainers = $@"SELECT ConsilierDeProbatiuneId FROM ConsilieriDeProbatiune WHERE Nume = @n";

        try
        {
            using (var conexiune = new SQLiteConnection(connString))
            {
                conexiune.Open();
                var comanda = new SQLiteCommand(getAllTrainers, conexiune);
                comanda.Parameters.AddWithValue("@n", nume);
                var tid = comanda.ExecuteScalar();
                return tid;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($@"Get Trainer ID: {e.Message}");
            return null;
        }
    }

    private void AfisareRezultateCriteriu1()
    {
        using (var conexiune = new SQLiteConnection(connString))
        {
            conexiune.Open();
            var criteriu = "";
            var valoare = "";

            switch (criteriuCB1.SelectedItem)
            {
                case "Modul":
                    criteriu = "Modul";
                    valoare = modulComboBox1.SelectedItem.ToString();
                    break;
                case "DataInceput":
                    criteriu = "DataInceput";
                    valoare = dataInceputDP1.Value.ToString("dd-MM-yyyy");
                    break;
                case "DataSfarsit":
                    criteriu = "DataSfarsit";
                    valoare = dataSfarsitDP1.Value.ToString("dd-MM-yyyy");
                    break;
                case "Trainer 1":
                    criteriu = "Trainer1";
                    valoare = $@"{GetTrainerID(Trainer1Cb1.Text)}";
                    break;
                case "Trainer 2":
                    criteriu = "Trainer2";
                    valoare = $@"{GetTrainerID(Trainer2Cb1.Text)}";
                    break;
            }

            var rezCrit1 =
                $@"SELECT ProgramDAS.ProgramDASId, ProgramDAS.Modul, ProgramDAS.DataInceput, ProgramDAS.DataSfarsit, CP1.Nume AS Trainer1Nume, CP2.Nume AS Trainer2Nume 
                              FROM ProgramDAS 
                              LEFT JOIN ConsilieriDeProbatiune CP1 ON ProgramDAS.Trainer1= CP1.ConsilierDeProbatiuneId
                              LEFT JOIN ConsilieriDeProbatiune CP2 ON ProgramDAS.Trainer2= CP2.ConsilierDeProbatiuneId                                                                                              
                              WHERE ProgramDAS.{@criteriu} like '{@valoare}'
                              LIMIT 6";

            try
            {
                using (var comanda = new SQLiteCommand(rezCrit1, conexiune))
                {
                    using (var da = new SQLiteDataAdapter(comanda))
                    {
                        dt = new DataTable();
                        comanda.Parameters.AddWithValue("@criteriu", criteriu);
                        comanda.Parameters.AddWithValue("@valoare", valoare);
                        da.Fill(dt);

                        CautareDASDgv.DataSource = dt;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Afisare Rezultate Criteriu 1: {e.Message}", @"Eroare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            var lQuery = $@"SELECT COUNT(*) FROM ProgramDAS WHERE {criteriu} like '%{valoare}%'";
            var lComanda = new SQLiteCommand(lQuery, conexiune);
            var limita = Convert.ToInt32(lComanda.ExecuteScalar());

            if (limita > 6) limtaL.Visible = true;

            if (limita <= 6) limtaL.Visible = false;
        }
    }

    private void AfisareRezultateCriteriu2()
    {
        using (var conexiune = new SQLiteConnection(connString))
        {
            conexiune.Open();
            var criteriu = "";
            var valoare = "";

            switch (criteriuCB2.SelectedItem)
            {
                case "Modul":
                    criteriu = "Modul";
                    valoare = modulComboBox2.SelectedItem.ToString();
                    break;
                case "DataInceput":
                    criteriu = "DataInceput";
                    valoare = dataInceputDP2.Value.ToString("dd-MM-yyyy");
                    break;
                case "DataSfarsit":
                    criteriu = "DataSfarsit";
                    valoare = dataSfarsitDP2.Value.ToString("dd-MM-yyyy");
                    break;
                case "Trainer 1":
                    criteriu = "Trainer1";
                    valoare = $@"{GetTrainerID(Trainer1Cb2.Text)}";
                    break;
                case "Trainer 2":
                    criteriu = "Trainer2";
                    valoare = $@"{GetTrainerID(Trainer2Cb2.Text)}";
                    break;
            }

            var rezCrit2 =
                $@"SELECT ProgramDAS.ProgramDASId, ProgramDAS.Modul, ProgramDAS.DataInceput, ProgramDAS.DataSfarsit, CP1.Nume AS Trainer1Nume, CP2.Nume AS Trainer2Nume 
                              FROM ProgramDAS 
                              LEFT JOIN ConsilieriDeProbatiune CP1 ON ProgramDAS.Trainer1= CP1.ConsilierDeProbatiuneId
                              LEFT JOIN ConsilieriDeProbatiune CP2 ON ProgramDAS.Trainer2= CP2.ConsilierDeProbatiuneId                                                                                             
                              WHERE ProgramDAS.{@criteriu} like '%{@valoare}%'
                              LIMIT 6";

            try
            {
                using (var comanda = new SQLiteCommand(rezCrit2, conexiune))
                {
                    using (var da = new SQLiteDataAdapter(comanda))
                    {
                        dt = new DataTable();
                        comanda.Parameters.AddWithValue("@criteriu", criteriu);
                        comanda.Parameters.AddWithValue("@valoare", valoare);
                        da.Fill(dt);

                        CautareDASDgv.DataSource = dt;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Afisare Rezultate Criteriu 2: {e.Message}", @"Eroare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

    private void AfisareRezultate2Criterii()
    {
        using (var conexiune = new SQLiteConnection(connString))
        {
            conexiune.Open();
            var criteriu1 = "";
            var valoare1 = "";
            var criteriu2 = "";
            var valoare2 = "";

            switch (criteriuCB1.Text, criteriuCB2.Text)
            {
                case ("Modul", "DataInceput"):
                    criteriu1 = "Modul";
                    modulComboBox1.SelectedItem = "A face o critică constructivă";
                    modulComboBox1.Text = "A face o critică constructivă";
                    criteriu1 = "Modul";
                    valoare1 = $@"'%{modulComboBox1.SelectedItem.ToString()}%'";
                    criteriu2 = "DataInceput";
                    valoare2 = $@"'%{dataInceputDP2.Value.ToString("dd-MM-yyyy")}%'";
                    break;
                case ("Modul", "DataSfarsit"):
                    criteriu1 = "Modul";
                    valoare1 = $@"'%{modulComboBox1.SelectedItem.ToString()}%'";
                    criteriu2 = "DataSfarsit";
                    valoare2 = $@"'%{dataSfarsitDP2.Value.ToString("dd-MM-yyyy")}%'";
                    break;
                case ("Modul", "Trainer 1"):
                    criteriu1 = "Modul";
                    valoare1 = $@"'{modulComboBox1.SelectedItem.ToString()}'";
                    criteriu2 = "Trainer1";
                    valoare2 = $@"{GetTrainerID(Trainer1Cb2.Text)}";
                    break;
                case ("Modul", "Trainer 2"):
                    criteriu1 = "Modul";
                    valoare1 = $@"'{modulComboBox1.SelectedItem.ToString()}'";
                    criteriu2 = "Trainer2";
                    valoare2 = $@"{GetTrainerID(Trainer2Cb2.Text)}";
                    break;
                case ("DataInceput", "Modul"):
                    criteriu1 = "DataInceput";
                    valoare1 = dataInceputDP1.Value.ToString("dd-MM-yyyy");
                    criteriu2 = "Modul";
                    valoare2 = $@"'{modulComboBox2.SelectedItem.ToString()}'";
                    break;
                case ("DataInceput", "DataSfarsit"):
                    criteriu1 = "DataInceput";
                    valoare1 = dataInceputDP1.Value.ToString("dd-MM-yyyy");
                    criteriu2 = "DataSfarsit";
                    valoare2 = dataSfarsitDP2.Value.ToString("dd-MM-yyyy");
                    break;
                case ("DataInceput", "Trainer 1"):
                    criteriu1 = "DataInceput";
                    valoare1 = dataInceputDP1.Value.ToString("dd-MM-yyyy");
                    criteriu2 = "Trainer1";
                    valoare2 = $@"{GetTrainerID(Trainer1Cb2.Text)}";
                    break;
                case ("DataInceput", "Trainer 2"):
                    criteriu1 = "DataInceput";
                    valoare1 = dataInceputDP1.Value.ToString("dd-MM-yyyy");
                    criteriu2 = "Trainer2";
                    valoare2 = $@"{GetTrainerID(Trainer2Cb2.Text)}";
                    break;
                case ("DataSfarsit", "Modul"):
                    criteriu1 = "DataSfarsit";
                    valoare1 = dataSfarsitDP1.Value.ToString("dd-MM-yyyy");
                    criteriu2 = "Modul";
                    valoare2 = $@"'{modulComboBox2.SelectedItem.ToString()}'";
                    break;
                case ("DataSfarsit", "DataInceput"):
                    criteriu1 = "DataSfarsit";
                    valoare1 = dataSfarsitDP1.Value.ToString("dd-MM-yyyy");
                    criteriu2 = "DataInceput";
                    valoare2 = dataInceputDP2.Value.ToString("dd-MM-yyyy");
                    break;
                case ("DataSfarsit", "Trainer 1"):
                    criteriu1 = "DataSfarsit";
                    valoare1 = dataSfarsitDP1.Value.ToString("dd-MM-yyyy");
                    criteriu2 = "Trainer1";
                    valoare2 = $@"{GetTrainerID(Trainer1Cb2.Text)}";
                    break;
                case ("DataSfarsit", "Trainer 2"):
                    criteriu1 = "DataSfarsit";
                    valoare1 = dataSfarsitDP1.Value.ToString("dd-MM-yyyy");
                    criteriu2 = "Trainer2";
                    valoare2 = $@"{GetTrainerID(Trainer2Cb2.Text)}";
                    break;
                case ("Trainer 1", "Modul"):
                    criteriu1 = "Trainer1";
                    valoare1 = $@"{GetTrainerID(Trainer1Cb1.Text)}";
                    criteriu2 = "Modul";
                    valoare2 = $@"'{modulComboBox2.SelectedItem.ToString()}'";
                    break;
                case ("Trainer 1", "DataInceput"):
                    criteriu1 = "Trainer1";
                    valoare1 = $@"{GetTrainerID(Trainer1Cb1.Text)}";
                    criteriu2 = "DataInceput";
                    valoare2 = dataInceputDP2.Value.ToString("dd-MM-yyyy");
                    break;
                case ("Trainer 1", "DataSfarsit"):
                    criteriu1 = "Trainer1";
                    valoare1 = $@"{GetTrainerID(Trainer1Cb1.Text)}";
                    criteriu2 = "DataSfarsit";
                    valoare2 = dataSfarsitDP2.Value.ToString("dd-MM-yyyy");
                    break;
                case ("Trainer 1", "Trainer 2"):
                    criteriu1 = "Trainer1";
                    valoare1 = $@"{GetTrainerID(Trainer1Cb1.Text)}";
                    criteriu2 = "Trainer2";
                    valoare2 = $@"{GetTrainerID(Trainer2Cb2.Text)}";
                    break;
                case ("Trainer 2", "Modul"):
                    criteriu1 = "Trainer2";
                    valoare1 = $@"{GetTrainerID(Trainer2Cb1.Text)}";
                    criteriu2 = "Modul";
                    valoare2 = $@"'{modulComboBox2.SelectedItem.ToString()}'";
                    break;
                case ("Trainer 2", "DataInceput"):
                    criteriu1 = "Trainer2";
                    valoare1 = $@"{GetTrainerID(Trainer2Cb1.Text)}";
                    criteriu2 = "DataInceput";
                    valoare2 = dataInceputDP2.Value.ToString("dd-MM-yyyy");
                    break;
                case ("Trainer 2", "DataSfarsit"):
                    criteriu1 = "Trainer2";
                    valoare1 = $@"{GetTrainerID(Trainer2Cb1.Text)}";
                    criteriu2 = "DataSfarsit";
                    valoare2 = dataSfarsitDP2.Value.ToString("dd-MM-yyyy");
                    break;
                case ("Modul", "Modul"):
                    criteriu1 = "Modul";
                    valoare1 = modulComboBox1.SelectedItem.ToString();
                    criteriu2 = "Modul";
                    valoare2 = modulComboBox2.SelectedItem.ToString();
                    break;
                case ("DataInceput", "DataInceput"):
                    criteriu1 = "DataInceput";
                    valoare1 = dataInceputDP1.Value.ToString("dd-MM-yyyy");
                    criteriu2 = "DataInceput";
                    valoare2 = dataInceputDP2.Value.ToString("dd-MM-yyyy");
                    break;
                case ("DataSfarsit", "DataSfarsit"):
                    criteriu1 = "DataSfarsit";
                    valoare1 = dataSfarsitDP1.Value.ToString("dd-MM-yyyy");
                    criteriu2 = "DataSfarsit";
                    valoare2 = dataSfarsitDP2.Value.ToString("dd-MM-yyyy");
                    break;
                case ("Trainer 2", "Trainer 1"):
                    criteriu1 = "Trainer1";
                    valoare1 = $@"{GetTrainerID(Trainer2Cb1.Text)}";
                    criteriu2 = "Trainer1";
                    valoare2 = $@"{GetTrainerID(Trainer1Cb2.Text)}";
                    break;
                case ("Trainer 2", "Trainer 2"):
                    criteriu1 = "Trainer2";
                    valoare1 = $@"{GetTrainerID(Trainer2Cb1.Text)}";
                    criteriu2 = "Trainer2";
                    valoare2 = $@"{GetTrainerID(Trainer2Cb2.Text)}";
                    break;
                case ("Trainer 1", "Trainer 1"):
                    criteriu1 = "Trainer1";
                    valoare1 = $@"{GetTrainerID(Trainer1Cb1.Text)}";
                    criteriu2 = "Trainer1";
                    valoare2 = $@"{GetTrainerID(Trainer1Cb2.Text)}";
                    break;
            }

            try
            {
                var rez2Crit = "";
                if (criteriu1 == criteriu2)
                    rez2Crit =
                        $@"SELECT ProgramDAS.ProgramDASId, ProgramDAS.Modul, ProgramDAS.DataInceput, ProgramDAS.DataSfarsit, CP1.Nume AS Trainer1Nume, CP2.Nume AS Trainer2Nume 
                              FROM ProgramDAS 
                              LEFT JOIN ConsilieriDeProbatiune CP1 ON ProgramDAS.Trainer1= CP1.ConsilierDeProbatiuneId
                              LEFT JOIN ConsilieriDeProbatiune CP2 ON ProgramDAS.Trainer2= CP2.ConsilierDeProbatiuneId                                                                                             
                              WHERE ProgramDAS.{@criteriu1} like {@valoare1} or ProgramDAS.{@criteriu2} like {@valoare2}
                              LIMIT 6";

                if (criteriu1 != criteriu2)
                    rez2Crit =
                        $@"SELECT ProgramDAS.ProgramDASId, ProgramDAS.Modul, ProgramDAS.DataInceput, ProgramDAS.DataSfarsit, CP1.Nume AS Trainer1Nume, CP2.Nume AS Trainer2Nume 
                              FROM ProgramDAS 
                              LEFT JOIN ConsilieriDeProbatiune CP1 ON ProgramDAS.Trainer1= CP1.ConsilierDeProbatiuneId
                              LEFT JOIN ConsilieriDeProbatiune CP2 ON ProgramDAS.Trainer2= CP2.ConsilierDeProbatiuneId                                                                                             
                              WHERE ProgramDAS.{@criteriu1} like {@valoare1} and ProgramDAS.{@criteriu2} like {@valoare2}
                              LIMIT 6";

                using (var comanda = new SQLiteCommand(rez2Crit, conexiune))
                {
                    comanda.Parameters.AddWithValue("@criteriu1", criteriu1);
                    comanda.Parameters.AddWithValue("@valoare1", valoare1);
                    comanda.Parameters.AddWithValue("@criteriu2", criteriu2);
                    comanda.Parameters.AddWithValue("@valoare2", valoare2);
                    using (var da = new SQLiteDataAdapter(comanda))
                    {
                         dt = new DataTable();
                        da.Fill(dt);
                        CautareDASDgv.DataSource = dt;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($@"Afisare Rezultate 2 Criterii : {e.Message}", @"Eroare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

    private void EditDAS()
    {
        try
        {
            var DASSel = (CautareDASDgv.SelectedRows[0].DataBoundItem as DataRowView).Row;
            var eDAS = new EditareDAS(DASSel);
            eDAS.Show();
        }
        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show(@"Selectați cel puțin un program din tabel!", @"Eroare", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void StergereDAS()
    {
        try
        {
            var DASSel = (CautareDASDgv.SelectedRows[0].DataBoundItem as DataRowView)?.Row;
            if (DASSel == null) return;
            var DASId = DASSel["ProgramDASId"].ToString();
            var DASModul = DASSel["Modul"].ToString();
            var DASDataInceput = DASSel["DataInceput"].ToString();
            var DASDataSfarsit = DASSel["DataSfarsit"].ToString();
            var DASTrainer1 = DASSel["Trainer1Nume"].ToString();
            var DASTrainer2 = DASSel["Trainer2Nume"].ToString();
            var DAS = $@"Modul: {DASModul} 
                         Data Inceput: {DASDataInceput} 
                         DataSfarsit:  {DASDataSfarsit} 
                         Formator 1:{DASTrainer1} 
                         Formator 2: {DASTrainer2}";
            var confirmare = MessageBox.Show($@"Sunteți sigur că doriți să ștergeți acest program DAS -  {DAS}?",
                @"Confirmare",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmare == DialogResult.Yes)
            {
                var stergereDAS = $@"DELETE FROM ProgramDAS WHERE ProgramDASId = {DASId}";

                using (var conexiune = new SQLiteConnection(connString))
                {
                    var comanda = new SQLiteCommand(stergereDAS, conexiune);
                    conexiune.Open();
                    comanda.ExecuteNonQuery();
                }

                MessageBox.Show($@"DAS-ul {DAS} a fost șters cu succes!", @"Succes", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        catch (ArgumentOutOfRangeException)
        {
            MessageBox.Show(@"Nu ați selectat niciun Program DAS!", "Eroare", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        catch (Exception e)
        {
            MessageBox.Show($@"Stergere DAS : {e.Message}", @"Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        if (criteriuCB1.SelectedItem != null && criteriuCB2.SelectedItem == null) AfisareRezultateCriteriu1();

        if (criteriuCB1.SelectedItem == null && criteriuCB2.SelectedItem != null) AfisareRezultateCriteriu2();

        if (criteriuCB1.SelectedItem != null && criteriuCB2.SelectedItem != null) AfisareRezultate2Criterii();
    }


    private void eDASEditBt_Click(object sender, EventArgs e)
    {
        EditDAS();
    }

    private void eDASStgBtn_Click(object sender, EventArgs e)
    {
        StergereDAS();
    }

    private void printareToolStripMenuItem_Click(object sender, EventArgs e)
    {
       PrintDocument printare = new PrintDocument();
       PrintPreviewDialog previzualizare = new PrintPreviewDialog();

       if (dt == null)
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

        foreach (DataRow dr in dt.Rows)
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