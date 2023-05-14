using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using ManagerDAS.bin.Debug.Media;


namespace ManagerDAS;

public partial class Form1 : Form
{
    private readonly string connString = "Data Source = ManagerDAS.db";
    private ToolStripItem _beneficiarItem;


    private Button _btnApasat;
    private ToolStripItem _consilierItem;
    private ToolStripItem _dasItem;
    private ToolStripItem _Lista;


    public Form1()
    {
        InitializeComponent();
    }

    private void llAjutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start("Media\\Stimate_domnule_profesor.pdf");
    }


    private void MenuBtn(Button buton)
    {
        _btnApasat = buton;

        var menu = new ContextMenuStrip();
        //Consilier
        _consilierItem = menu.Items.Add("Consilier de Probațiune");
        _consilierItem.Name = "ConsilieriDeProbatiune";
        _consilierItem.Click += consilierItem_Click;

        //Program DAS
        _dasItem = menu.Items.Add("Program DAS");
        _dasItem.Name = "ProgramDAS";
        _dasItem.Click += dasItem_Click;

        //Beneficiar
        _beneficiarItem = menu.Items.Add("Beneficiar");
        _beneficiarItem.Name = "Beneficiar";
        _beneficiarItem.Click += _beneficiarItem_Click;

        menu.Show(buton, new Point(0, buton.Height));
    }


    private void BtnPrincipale(Button btnApasat, ToolStripItem toolStripItem)
    {
        switch ((btnApasat.Name, toolStripItem.Name))
        {
            case ("btAdaugare", "ConsilieriDeProbatiune"):
                var adaugareConsilierProbatiune = new AdaugareConsilierProbatiune();
                adaugareConsilierProbatiune.ShowDialog();
                break;
            case ("btAdaugare", "ProgramDAS"):
                var ad = new AdaugareDAS();
                ad.ShowDialog();
                break;
            case ("btAdaugare", "Beneficiar"):
                var ab = new AdaugareBeneficiar();
                ab.ShowDialog();
                break;
            case ("btEditare", "ConsilieriDeProbatiune"):
                var ccp = new CautareCP();
                ccp.ShowDialog();
                break;
            case ("btEditare", "Beneficiar"):
                var cb = new CautareBeneficiar();
                cb.ShowDialog();
                break;
            case ("btEditare", "ProgramDAS"):
                var cdas = new CautareDAS();
                cdas.ShowDialog();
                break;
            case ("btAfisare", "Diagramă"):
                GenerareDiagramaDAS();
                break;
            default:
                MessageBox.Show("Trist!!!");
                break;
        }
    }

    //Se creeaza meniurile
    private void btAdaugare_Click(object sender, EventArgs e)
    {
        MenuBtn(btAdaugare);
    }

    private void btEditare_Click(object sender, EventArgs e)
    {
        MenuBtn(btEditare);
    }


    private void btAfișare_Click(object sender, EventArgs e)
    {
        var listaMenu = new ContextMenuStrip();

        var menuItem1 = new ToolStripMenuItem("Lista");
        listaMenu.Items.Add(menuItem1);
        var listaSubMenuCP = new ToolStripMenuItem("Consilieri de probațiune");
        menuItem1.DropDownItems.Add(listaSubMenuCP);
        listaSubMenuCP.Click += ListaSubMenuTCP_Click;

        var listaSubMenuProgram = new ToolStripMenuItem("Program DAS");
        menuItem1.DropDownItems.Add(listaSubMenuProgram);
        listaSubMenuProgram.Click += ListaSubMenuProgram_Click;

        var listaSubMenuB = new ToolStripMenuItem("Beneficiar");
        menuItem1.DropDownItems.Add(listaSubMenuB);
        listaSubMenuB.Click += ListaSubMenuB_Click;

        var listaSubMenuCPProgram = new ToolStripMenuItem("Consilieri de probațiune abilitați");
        menuItem1.DropDownItems.Add(listaSubMenuCPProgram);
        listaSubMenuCPProgram.Click += ListaSubMenuCPProgram_Click;


        var listaSubMenuBProgram = new ToolStripMenuItem("Beneficiari înscriși într-un program");
        menuItem1.DropDownItems.Add(listaSubMenuBProgram);
        listaSubMenuBProgram.Click += ListaSubMenuBProgram_Click;

        //listaMenu.Items.Add("Diagramă");

        var menuItem2 = new ToolStripMenuItem("Diagramă");
        listaMenu.Items.Add(menuItem2);
        menuItem2.Click += menuItem2_Click;

        listaMenu.Show(btAfisare, new Point(0, btAfisare.Height));
    }

    private void ListaSubMenuProgram_Click(object sender, EventArgs e)
    {
        GenerareListaDAS();
    }

    private void menuItem2_Click(object sender, EventArgs e)
    {
        GenerareDiagramaDAS();
    }

    private void ListaSubMenuCPProgram_Click(object sender, EventArgs e)
    {
        GenerareListaConsilieriAbilitati();
    }

    private void ListaSubMenuTCP_Click(object sender, EventArgs e)
    {
        GenerareListaTotiConsilieri();
    }

    private void ListaSubMenuBProgram_Click(object sender, EventArgs e)
    {
        GenerareListaBeneficiariDAS();
    }

    private void ListaSubMenuB_Click(object sender, EventArgs e)
    {
        GenerareListaTotiBeneficiari();
    }

    private void consilierItem_Click(object sender, EventArgs e)
    {
        BtnPrincipale(_btnApasat, _consilierItem);
    }

    private void dasItem_Click(object sender, EventArgs e)
    {
        BtnPrincipale(_btnApasat, _dasItem);
    }

    private void _beneficiarItem_Click(object sender, EventArgs e)
    {
        BtnPrincipale(_btnApasat, _beneficiarItem);
    }


    private void GenerareListaDAS()
    {
        try
        {
            using (var conexiune = new SQLiteConnection(connString))
            {
                var q =
                    @"SELECT ProgramDAS.ProgramDASId, ProgramDAS.Modul, ProgramDAS.DataInceput, ProgramDAS.DataSfarsit, CP1.Nume AS Trainer1Nume, CP2.Nume AS Trainer2Nume 
                          FROM ProgramDAS 
                          LEFT JOIN ConsilieriDeProbatiune CP1 ON ProgramDAS.Trainer1= CP1.ConsilierDeProbatiuneId
                          LEFT JOIN ConsilieriDeProbatiune CP2 ON ProgramDAS.Trainer2= CP2.ConsilierDeProbatiuneId";


                var comanda = new SQLiteCommand(q, conexiune);
                conexiune.Open();
                var reader = comanda.ExecuteReader();


                using (var wdp = WordprocessingDocument.Create("Programe_DAS.docx",
                           WordprocessingDocumentType.Document))
                {
                    var mainPart = wdp.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    var body = mainPart.Document.AppendChild(new Body());

                    // Creare tabel
                    var table = new Table();
                    var tableProperties = new TableProperties();

                    var tableBorders = new TableBorders();
                    tableBorders.TopBorder = new TopBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.BottomBorder = new BottomBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.LeftBorder = new LeftBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.RightBorder = new RightBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.InsideHorizontalBorder = new InsideHorizontalBorder()
                        { Val = BorderValues.Single, Size = 2 };
                    tableBorders.InsideVerticalBorder = new InsideVerticalBorder()
                        { Val = BorderValues.Single, Size = 2 };

                    table.AppendChild(tableProperties);

                    // Adăugare antet tabel
                    var headerRow = new TableRow();
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Modul")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Data Început")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Data Sfârșit")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Consilier de probațiune 1")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Consilier de probațiune 2")))));

                    table.AppendChild(headerRow);
                    while (reader.Read())
                    {
                        var Modul = reader["Modul"].ToString();
                        var DataInceput = reader["DataInceput"].ToString();
                        var DataSfarsit = reader["DataSfarsit"].ToString();
                        var Trainer1Nume = reader["Trainer1Nume"].ToString();
                        var Trainer2Nume = reader["Trainer2Nume"].ToString();


                        var row = new TableRow();
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(Modul)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(DataInceput)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(DataSfarsit)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(Trainer1Nume)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(Trainer2Nume)))));


                        table.AppendChild(row);
                    }

                    body.AppendChild(table);
                    wdp.Save();
                }

                Process.Start("WINWORD.EXE", "Programe_DAS.docx");
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F1) Process.Start("Media\\Stimate_domnule_profesor.pdf");

        if (e.KeyCode == Keys.C && e.Alt)
        {
            // BtnPrincipale(btAdaugare, _consilierItem);

            /*Mesaj către domnul profesor:
             
             Nu înțeleg de ce dacă adaug funcția de mai sus  îmi dă eroare de obiect neinstanțiat,
             Însă dacă pun codul de mai jos funcționează.
             Mulțumesc mult pentru ajutor! 
            
             */
            var adaugareConsilierProbatiune = new AdaugareConsilierProbatiune();
            adaugareConsilierProbatiune.ShowDialog();
        }

        if (e.KeyCode == Keys.B && e.Alt)
        {
            var ab = new AdaugareBeneficiar();
            ab.ShowDialog();
        }

        if (e.KeyCode == Keys.D && e.Alt)
        {
            var ad = new AdaugareDAS();
            ad.ShowDialog();
        }

        if (e.KeyCode == Keys.C && e.Control)
        {
            var ccp = new CautareCP();
            ccp.ShowDialog();
        }

        if (e.KeyCode == Keys.B && e.Control)
        {
            var cb = new CautareBeneficiar();
            cb.ShowDialog();
        }

        if (e.KeyCode == Keys.D && e.Control)
        {
            var cdas = new CautareDAS();
            cdas.ShowDialog();
        }

        if (e.KeyCode == Keys.F2) GenerareListaTotiConsilieri();

        if (e.KeyCode == Keys.F3) GenerareListaConsilieriAbilitati();

        if (e.KeyCode == Keys.F4) GenerareListaTotiBeneficiari();

        if (e.KeyCode == Keys.F5) GenerareListaBeneficiariDAS();

        if (e.KeyCode == Keys.F6) GenerareDiagramaDAS();
    }

    private void GenerareListaBeneficiariDAS()
    {
        try
        {
            using (var conexiune = new SQLiteConnection(connString))
            {
                var q =
                    $@"SELECT Beneficiar.BeneficiarId ,Beneficiar.NumeBeneficiar, CP1.Nume AS NumeCP, ProgramDAS.Modul AS ModulDAS FROM Beneficiar
                                                       LEFT JOIN ConsilieriDeProbatiune CP1 ON Beneficiar.ManagerCaz = CP1.ConsilierDeProbatiuneId
                                                       LEFT JOIN ConsilieriDeProbatiune CP2 ON Beneficiar.ManagerCaz = CP2.ConsilierDeProbatiuneId
                                                       LEFT JOIN ProgramDAS ON Beneficiar.ProgramDAS = ProgramDAS.ProgramDASId
                                                       WHERE ModulDAS != null";


                var comanda = new SQLiteCommand(q, conexiune);
                conexiune.Open();
                var reader = comanda.ExecuteReader();

                using (var wdp = WordprocessingDocument.Create("ListăBeneficiariDAS.docx",
                           WordprocessingDocumentType.Document))
                {
                    var mainPart = wdp.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    var body = mainPart.Document.AppendChild(new Body());

                    // Creare tabel
                    var table = new Table();
                    var tableProperties = new TableProperties();

                    var tableBorders = new TableBorders();
                    tableBorders.TopBorder = new TopBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.BottomBorder = new BottomBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.LeftBorder = new LeftBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.RightBorder = new RightBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.InsideHorizontalBorder = new InsideHorizontalBorder()
                        { Val = BorderValues.Single, Size = 2 };
                    tableBorders.InsideVerticalBorder = new InsideVerticalBorder()
                        { Val = BorderValues.Single, Size = 2 };

                    table.AppendChild(tableProperties);

                    // Adăugare antet tabel
                    var headerRow = new TableRow();
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Nume Beneficiar")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Manager Caz")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Program DAS")))));

                    table.AppendChild(headerRow);
                    while (reader.Read())
                    {
                        var Nume = reader["NumeBeneficiar"].ToString();
                        var mgrCaz = reader["NumeCP"].ToString();
                        var das = reader["ModulDAS"].ToString();

                        var row = new TableRow();
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(Nume)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(mgrCaz)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(das)))));


                        table.AppendChild(row);
                    }


                    body.AppendChild(table);
                    wdp.Save();
                }

                Process.Start("WINWORD.EXE", "ListăBeneficiariDAS.docx");
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }

    private void GenerareListaTotiBeneficiari()
    {
        try
        {
            using (var conexiune = new SQLiteConnection(connString))
            {
                var q =
                    $@"SELECT Beneficiar.BeneficiarId ,Beneficiar.NumeBeneficiar, CP1.Nume AS NumeCP, ProgramDAS.Modul AS ModulDAS FROM Beneficiar
                                                       LEFT JOIN ConsilieriDeProbatiune CP1 ON Beneficiar.ManagerCaz = CP1.ConsilierDeProbatiuneId
                                                       LEFT JOIN ConsilieriDeProbatiune CP2 ON Beneficiar.ManagerCaz = CP2.ConsilierDeProbatiuneId
                                                       LEFT JOIN ProgramDAS ON Beneficiar.ProgramDAS = ProgramDAS.ProgramDASId";


                var comanda = new SQLiteCommand(q, conexiune);
                conexiune.Open();
                var reader = comanda.ExecuteReader();

                using (var wdp = WordprocessingDocument.Create("ListăToțiBeneficiari.docx",
                           WordprocessingDocumentType.Document))
                {
                    var mainPart = wdp.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    var body = mainPart.Document.AppendChild(new Body());

                    // Creare tabel
                    var table = new Table();
                    var tableProperties = new TableProperties();

                    var tableBorders = new TableBorders();
                    tableBorders.TopBorder = new TopBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.BottomBorder = new BottomBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.LeftBorder = new LeftBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.RightBorder = new RightBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.InsideHorizontalBorder = new InsideHorizontalBorder()
                        { Val = BorderValues.Single, Size = 2 };
                    tableBorders.InsideVerticalBorder = new InsideVerticalBorder()
                        { Val = BorderValues.Single, Size = 2 };

                    table.AppendChild(tableProperties);

                    // Adăugare antet tabel
                    var headerRow = new TableRow();
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Nume Beneficiar")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Manager Caz")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Program DAS")))));

                    table.AppendChild(headerRow);
                    while (reader.Read())
                    {
                        var Nume = reader["NumeBeneficiar"].ToString();
                        var mgrCaz = reader["NumeCP"].ToString();
                        var das = reader["ModulDAS"].ToString();

                        var row = new TableRow();
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(Nume)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(mgrCaz)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(das)))));


                        table.AppendChild(row);
                    }


                    body.AppendChild(table);
                    wdp.Save();
                }

                Process.Start("WINWORD.EXE", "ListăToțiBeneficiari.docx");
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }

    private void GenerareListaTotiConsilieri()
    {
        try
        {
            using (var conexiune = new SQLiteConnection(connString))
            {
                var q = "SELECT * FROM ConsilieriDeProbatiune";
                var comanda = new SQLiteCommand(q, conexiune);
                conexiune.Open();
                var reader = comanda.ExecuteReader();

                using (var wdp = WordprocessingDocument.Create("Listă_toți_consilierii_SP_București.docx",
                           WordprocessingDocumentType.Document))
                {
                    string tableTitle = "Listă Consilieri de Probațiune";
                    
                    
                    var mainPart = wdp.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    var body = mainPart.Document.AppendChild(new Body());

                    // Creare tabel
                    var table = new Table();
                    var tableProperties = new TableProperties();
                    
                    var titleRow = new TableRow();
                    var titleCell = new TableCell(new Paragraph(new Run(new Text(tableTitle))));
                    titleCell.AppendChild(new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "5000" }));
                    titleCell.AppendChild(new VerticalMerge { Val = MergedCellValues.Restart });
                    titleRow.AppendChild(titleCell);
                    table.AppendChild(titleRow);

                    var tableBorders = new TableBorders();
                    tableBorders.TopBorder = new TopBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.BottomBorder = new BottomBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.LeftBorder = new LeftBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.RightBorder = new RightBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.InsideHorizontalBorder = new InsideHorizontalBorder()
                        { Val = BorderValues.Single, Size = 2 };
                    tableBorders.InsideVerticalBorder = new InsideVerticalBorder()
                        { Val = BorderValues.Single, Size = 2 };

                    table.AppendChild(tableProperties);

                    // Adăugare antet tabel
                    var headerRow = new TableRow();
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Nume")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("DataIntrariiInSistem")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Studii")))));

                    table.AppendChild(headerRow);
                    while (reader.Read())
                    {
                        var Nume = reader["Nume"].ToString();
                        var DataIntrariiInSistem = reader["DataIntrariiInSistem"].ToString();
                        var Studii = reader["Studii"].ToString();

                        var row = new TableRow();
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(Nume)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(DataIntrariiInSistem)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(Studii)))));


                        table.AppendChild(row);
                    }

                    body.AppendChild(table);
                    wdp.Save();
                }

                Process.Start("WINWORD.EXE", "Listă_toți_consilierii_SP_București.docx");
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }

    private void GenerareListaConsilieriAbilitati()
    {
        try
        {
            using (var conexiune = new SQLiteConnection(connString))
            {
                var q = "SELECT * FROM ConsilieriDeProbatiune WHERE Abilitat = 'Da'";
                var comanda = new SQLiteCommand(q, conexiune);
                conexiune.Open();
                var reader = comanda.ExecuteReader();
                //String path ="Test.docx";

                using (var wdp = WordprocessingDocument.Create("Consilier_abilitați_DAS.docx",
                           WordprocessingDocumentType.Document))
                {
                    string titlu = "Listă Conilieri de Probațiune cu abilități DAS";
                    var mainPart = wdp.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    var body = mainPart.Document.AppendChild(new Body());

                    // Creare tabel
                    var table = new Table();
                    var tableProperties = new TableProperties();
                    var titleRow = new TableRow();
                    var titleCell = new TableCell(new Paragraph(new Run(new Text(titlu))));
                    titleCell.AppendChild(new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = "5000" }));
                    titleCell.AppendChild(new VerticalMerge { Val = MergedCellValues.Restart });
                    titleRow.AppendChild(titleCell);
                    table.AppendChild(titleRow);
                    

                    var tableBorders = new TableBorders();
                    tableBorders.TopBorder = new TopBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.BottomBorder = new BottomBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.LeftBorder = new LeftBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.RightBorder = new RightBorder() { Val = BorderValues.Single, Size = 2 };
                    tableBorders.InsideHorizontalBorder = new InsideHorizontalBorder()
                        { Val = BorderValues.Single, Size = 2 };
                    tableBorders.InsideVerticalBorder = new InsideVerticalBorder()
                        { Val = BorderValues.Single, Size = 2 };

                    table.AppendChild(tableProperties);

                    // Adăugare antet tabel
                    var headerRow = new TableRow();
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Nume")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("DataIntrariiInSistem")))));
                    headerRow.AppendChild(new TableCell(new Paragraph(new Run(new Text("Studii")))));

                    table.AppendChild(headerRow);
                    while (reader.Read())
                    {
                        var Nume = reader["Nume"].ToString();
                        var DataIntrariiInSistem = reader["DataIntrariiInSistem"].ToString();
                        var Studii = reader["Studii"].ToString();

                        var row = new TableRow();
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(Nume)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(DataIntrariiInSistem)))));
                        row.AppendChild(new TableCell(new Paragraph(new Run(new Text(Studii)))));


                        table.AppendChild(row);
                    }

                    body.AppendChild(table);
                    wdp.Save();
                }

                Process.Start("WINWORD.EXE", "Consilier_abilitați_DAS.docx");
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
    }

    private void GenerareDiagramaDAS()
    {
        var d = new Diagrama();
        d.Show();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}