using System.ComponentModel;

namespace ManagerDAS;

partial class CautareDAS
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CautareDAS));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.criteriuCB1 = new System.Windows.Forms.ComboBox();
            this.opțiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criteriu1L = new System.Windows.Forms.Label();
            this.criteriu2L = new System.Windows.Forms.Label();
            this.criteriuCB2 = new System.Windows.Forms.ComboBox();
            this.rezultateBtn = new System.Windows.Forms.Button();
            this.limtaL = new System.Windows.Forms.Label();
            this.CautareDASDgv = new System.Windows.Forms.DataGridView();
            this.eDASAbdBtn = new System.Windows.Forms.Button();
            this.eDASEditBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eDASStgBtn = new System.Windows.Forms.Button();
            this.modulLabel1 = new System.Windows.Forms.Label();
            this.modulLabel2 = new System.Windows.Forms.Label();
            this.dataInceputLabel1 = new System.Windows.Forms.Label();
            this.dataInceputLabel2 = new System.Windows.Forms.Label();
            this.dataSfarsitLabel1 = new System.Windows.Forms.Label();
            this.dataSfarsitLabel2 = new System.Windows.Forms.Label();
            this.modulComboBox1 = new System.Windows.Forms.ComboBox();
            this.modulComboBox2 = new System.Windows.Forms.ComboBox();
            this.dataInceputDP1 = new System.Windows.Forms.DateTimePicker();
            this.dataInceputDP2 = new System.Windows.Forms.DateTimePicker();
            this.dataSfarsitDP1 = new System.Windows.Forms.DateTimePicker();
            this.Trainer1Cb1 = new System.Windows.Forms.ComboBox();
            this.Trainer2Cb2 = new System.Windows.Forms.ComboBox();
            this.Trainer1L1 = new System.Windows.Forms.Label();
            this.Trainer1L2 = new System.Windows.Forms.Label();
            this.Trainer2L1 = new System.Windows.Forms.Label();
            this.Trainer2L2 = new System.Windows.Forms.Label();
            this.Trainer1Cb2 = new System.Windows.Forms.ComboBox();
            this.Trainer2Cb1 = new System.Windows.Forms.ComboBox();
            this.dataSfarsitDP2 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CautareDASDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem1,
            this.ștergereToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // editareToolStripMenuItem1
            // 
            this.editareToolStripMenuItem1.Name = "editareToolStripMenuItem1";
            this.editareToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editareToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.editareToolStripMenuItem1.Text = "Editare";
            this.editareToolStripMenuItem1.Click += new System.EventHandler(this.eDASEditBt_Click);
            // 
            // ștergereToolStripMenuItem1
            // 
            this.ștergereToolStripMenuItem1.Name = "ștergereToolStripMenuItem1";
            this.ștergereToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ștergereToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.ștergereToolStripMenuItem1.Text = "Ștergere";
            this.ștergereToolStripMenuItem1.Click += new System.EventHandler(this.eDASStgBtn_Click);
            // 
            // criteriuCB1
            // 
            this.criteriuCB1.FormattingEnabled = true;
            this.criteriuCB1.Items.AddRange(new object[] {
            "Modul",
            "DataInceput",
            "DataSfarsit",
            "Trainer 1",
            "Trainer 2"});
            this.criteriuCB1.Location = new System.Drawing.Point(93, 94);
            this.criteriuCB1.Name = "criteriuCB1";
            this.criteriuCB1.Size = new System.Drawing.Size(201, 28);
            this.criteriuCB1.TabIndex = 43;
            this.criteriuCB1.SelectedIndexChanged += new System.EventHandler(this.criteriuCB1_SelectedIndexChanged);
            // 
            // opțiuniToolStripMenuItem
            // 
            this.opțiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem,
            this.ștergereToolStripMenuItem,
            this.printareToolStripMenuItem});
            this.opțiuniToolStripMenuItem.Name = "opțiuniToolStripMenuItem";
            this.opțiuniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.opțiuniToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opțiuniToolStripMenuItem.Text = "Opțiuni";
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.eDASEditBt_Click);
            // 
            // ștergereToolStripMenuItem
            // 
            this.ștergereToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ștergereToolStripMenuItem.Name = "ștergereToolStripMenuItem";
            this.ștergereToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ștergereToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ștergereToolStripMenuItem.Text = "Ștergere";
            this.ștergereToolStripMenuItem.Click += new System.EventHandler(this.eDASStgBtn_Click);
            // 
            // printareToolStripMenuItem
            // 
            this.printareToolStripMenuItem.Name = "printareToolStripMenuItem";
            this.printareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printareToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.printareToolStripMenuItem.Text = "Printare";
            this.printareToolStripMenuItem.Click += new System.EventHandler(this.printareToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opțiuniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criteriu1L
            // 
            this.criteriu1L.Location = new System.Drawing.Point(6, 94);
            this.criteriu1L.Name = "criteriu1L";
            this.criteriu1L.Size = new System.Drawing.Size(84, 31);
            this.criteriu1L.TabIndex = 40;
            this.criteriu1L.Text = "Criteriu 1: ";
            // 
            // criteriu2L
            // 
            this.criteriu2L.Location = new System.Drawing.Point(6, 143);
            this.criteriu2L.Name = "criteriu2L";
            this.criteriu2L.Size = new System.Drawing.Size(84, 31);
            this.criteriu2L.TabIndex = 41;
            this.criteriu2L.Text = "Criteriu 2: ";
            // 
            // criteriuCB2
            // 
            this.criteriuCB2.FormattingEnabled = true;
            this.criteriuCB2.Items.AddRange(new object[] {
            "Modul",
            "DataInceput",
            "DataSfarsit",
            "Trainer 1",
            "Trainer 2"});
            this.criteriuCB2.Location = new System.Drawing.Point(93, 140);
            this.criteriuCB2.Name = "criteriuCB2";
            this.criteriuCB2.Size = new System.Drawing.Size(201, 28);
            this.criteriuCB2.TabIndex = 44;
            this.criteriuCB2.SelectedIndexChanged += new System.EventHandler(this.criteriuCB2_SelectedIndexChanged);
            // 
            // rezultateBtn
            // 
            this.rezultateBtn.Location = new System.Drawing.Point(515, 192);
            this.rezultateBtn.Name = "rezultateBtn";
            this.rezultateBtn.Size = new System.Drawing.Size(132, 32);
            this.rezultateBtn.TabIndex = 49;
            this.rezultateBtn.Text = "Rezultate";
            this.rezultateBtn.UseVisualStyleBackColor = true;
            this.rezultateBtn.Click += new System.EventHandler(this.rezultateBtn_Click);
            // 
            // limtaL
            // 
            this.limtaL.Location = new System.Drawing.Point(16, 227);
            this.limtaL.Name = "limtaL";
            this.limtaL.Size = new System.Drawing.Size(728, 23);
            this.limtaL.TabIndex = 50;
            this.limtaL.Text = "S-au afișat doar primele 6 rezultate! Introduceți fie un al doilea criteriu de se" +
    "lecție, fie alte criterii.";
            this.limtaL.Visible = false;
            // 
            // CautareDASDgv
            // 
            this.CautareDASDgv.AllowUserToAddRows = false;
            this.CautareDASDgv.AllowUserToDeleteRows = false;
            this.CautareDASDgv.AllowUserToOrderColumns = true;
            this.CautareDASDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CautareDASDgv.ContextMenuStrip = this.contextMenuStrip1;
            this.CautareDASDgv.Location = new System.Drawing.Point(12, 253);
            this.CautareDASDgv.Name = "CautareDASDgv";
            this.CautareDASDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CautareDASDgv.Size = new System.Drawing.Size(821, 171);
            this.CautareDASDgv.TabIndex = 51;
            // 
            // eDASAbdBtn
            // 
            this.eDASAbdBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.eDASAbdBtn.Location = new System.Drawing.Point(16, 443);
            this.eDASAbdBtn.Name = "eDASAbdBtn";
            this.eDASAbdBtn.Size = new System.Drawing.Size(106, 34);
            this.eDASAbdBtn.TabIndex = 52;
            this.eDASAbdBtn.Text = "Abandonare";
            this.eDASAbdBtn.UseVisualStyleBackColor = true;
            // 
            // eDASEditBt
            // 
            this.eDASEditBt.Location = new System.Drawing.Point(317, 444);
            this.eDASEditBt.Name = "eDASEditBt";
            this.eDASEditBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eDASEditBt.Size = new System.Drawing.Size(175, 33);
            this.eDASEditBt.TabIndex = 53;
            this.eDASEditBt.Text = "Editare date Program";
            this.eDASEditBt.UseVisualStyleBackColor = true;
            this.eDASEditBt.Click += new System.EventHandler(this.eDASEditBt_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Pentru a șterge criteriile selectate apasati Ctrl + C";
            // 
            // eDASStgBtn
            // 
            this.eDASStgBtn.Location = new System.Drawing.Point(631, 444);
            this.eDASStgBtn.Name = "eDASStgBtn";
            this.eDASStgBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eDASStgBtn.Size = new System.Drawing.Size(187, 33);
            this.eDASStgBtn.TabIndex = 55;
            this.eDASStgBtn.Text = "Ștergere date Program";
            this.eDASStgBtn.UseVisualStyleBackColor = true;
            this.eDASStgBtn.Click += new System.EventHandler(this.eDASStgBtn_Click);
            // 
            // modulLabel1
            // 
            this.modulLabel1.Location = new System.Drawing.Point(333, 94);
            this.modulLabel1.Name = "modulLabel1";
            this.modulLabel1.Size = new System.Drawing.Size(56, 27);
            this.modulLabel1.TabIndex = 56;
            this.modulLabel1.Text = "Modul:";
            this.modulLabel1.Visible = false;
            // 
            // modulLabel2
            // 
            this.modulLabel2.Location = new System.Drawing.Point(333, 143);
            this.modulLabel2.Name = "modulLabel2";
            this.modulLabel2.Size = new System.Drawing.Size(56, 27);
            this.modulLabel2.TabIndex = 57;
            this.modulLabel2.Text = "Modul:";
            this.modulLabel2.Visible = false;
            // 
            // dataInceputLabel1
            // 
            this.dataInceputLabel1.Location = new System.Drawing.Point(333, 94);
            this.dataInceputLabel1.Name = "dataInceputLabel1";
            this.dataInceputLabel1.Size = new System.Drawing.Size(102, 27);
            this.dataInceputLabel1.TabIndex = 58;
            this.dataInceputLabel1.Text = "Data Început:";
            this.dataInceputLabel1.Visible = false;
            // 
            // dataInceputLabel2
            // 
            this.dataInceputLabel2.Location = new System.Drawing.Point(333, 143);
            this.dataInceputLabel2.Name = "dataInceputLabel2";
            this.dataInceputLabel2.Size = new System.Drawing.Size(102, 27);
            this.dataInceputLabel2.TabIndex = 59;
            this.dataInceputLabel2.Text = "Data Început:";
            this.dataInceputLabel2.Visible = false;
            // 
            // dataSfarsitLabel1
            // 
            this.dataSfarsitLabel1.Location = new System.Drawing.Point(333, 91);
            this.dataSfarsitLabel1.Name = "dataSfarsitLabel1";
            this.dataSfarsitLabel1.Size = new System.Drawing.Size(102, 27);
            this.dataSfarsitLabel1.TabIndex = 60;
            this.dataSfarsitLabel1.Text = "Data Sfârșit:";
            this.dataSfarsitLabel1.Visible = false;
            // 
            // dataSfarsitLabel2
            // 
            this.dataSfarsitLabel2.Location = new System.Drawing.Point(333, 141);
            this.dataSfarsitLabel2.Name = "dataSfarsitLabel2";
            this.dataSfarsitLabel2.Size = new System.Drawing.Size(102, 27);
            this.dataSfarsitLabel2.TabIndex = 61;
            this.dataSfarsitLabel2.Text = "Data Sfârșit:";
            this.dataSfarsitLabel2.Visible = false;
            // 
            // modulComboBox1
            // 
            this.modulComboBox1.FormattingEnabled = true;
            this.modulComboBox1.Items.AddRange(new object[] {
            "A face o critică constructivă",
            "Comunicare",
            "Cum te prezinți în fața unui angajator",
            "Managementul conflictelor"});
            this.modulComboBox1.SelectedIndex = 0;
            this.modulComboBox1.Location = new System.Drawing.Point(454, 91);
            this.modulComboBox1.Name = "modulComboBox1";
            this.modulComboBox1.Size = new System.Drawing.Size(225, 28);
            this.modulComboBox1.TabIndex = 64;
            this.modulComboBox1.Visible = false;
            // 
            // modulComboBox2
            // 
            this.modulComboBox2.FormattingEnabled = true;
            this.modulComboBox2.Items.AddRange(new object[] {
            "A face o critică constructivă",
            "Comunicare",
            "Cum te prezinți în fața unui angajator",
            "Managementul conflictelor"});
            this.modulComboBox2.SelectedIndex = 0;
            this.modulComboBox2.Location = new System.Drawing.Point(454, 140);
            this.modulComboBox2.Name = "modulComboBox2";
            this.modulComboBox2.Size = new System.Drawing.Size(225, 28);
            this.modulComboBox2.TabIndex = 65;
            this.modulComboBox2.Visible = false;
            // 
            // dataInceputDP1
            // 
            this.dataInceputDP1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInceputDP1.Location = new System.Drawing.Point(685, 38);
            this.dataInceputDP1.Name = "dataInceputDP1";
            this.dataInceputDP1.Size = new System.Drawing.Size(115, 25);
            this.dataInceputDP1.TabIndex = 66;
            this.dataInceputDP1.Visible = false;
            // 
            // dataInceputDP2
            // 
            this.dataInceputDP2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInceputDP2.Location = new System.Drawing.Point(454, 139);
            this.dataInceputDP2.Name = "dataInceputDP2";
            this.dataInceputDP2.Size = new System.Drawing.Size(115, 25);
            this.dataInceputDP2.TabIndex = 67;
            this.dataInceputDP2.Visible = false;
            // 
            // dataSfarsitDP1
            // 
            this.dataSfarsitDP1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataSfarsitDP1.Location = new System.Drawing.Point(564, 38);
            this.dataSfarsitDP1.Name = "dataSfarsitDP1";
            this.dataSfarsitDP1.Size = new System.Drawing.Size(115, 25);
            this.dataSfarsitDP1.TabIndex = 68;
            this.dataSfarsitDP1.Visible = false;
            // 
            // Trainer1Cb1
            // 
            this.Trainer1Cb1.FormattingEnabled = true;
            this.Trainer1Cb1.Location = new System.Drawing.Point(324, 39);
            this.Trainer1Cb1.Name = "Trainer1Cb1";
            this.Trainer1Cb1.Size = new System.Drawing.Size(225, 28);
            this.Trainer1Cb1.TabIndex = 70;
            this.Trainer1Cb1.Visible = false;
            // 
            // Trainer2Cb2
            // 
            this.Trainer2Cb2.FormattingEnabled = true;
            this.Trainer2Cb2.Location = new System.Drawing.Point(454, 140);
            this.Trainer2Cb2.Name = "Trainer2Cb2";
            this.Trainer2Cb2.Size = new System.Drawing.Size(225, 28);
            this.Trainer2Cb2.TabIndex = 71;
            this.Trainer2Cb2.Visible = false;
            // 
            // Trainer1L1
            // 
            this.Trainer1L1.Location = new System.Drawing.Point(333, 91);
            this.Trainer1L1.Name = "Trainer1L1";
            this.Trainer1L1.Size = new System.Drawing.Size(77, 21);
            this.Trainer1L1.TabIndex = 72;
            this.Trainer1L1.Text = "Trainer 1: ";
            this.Trainer1L1.Visible = false;
            // 
            // Trainer1L2
            // 
            this.Trainer1L2.Location = new System.Drawing.Point(333, 138);
            this.Trainer1L2.Name = "Trainer1L2";
            this.Trainer1L2.Size = new System.Drawing.Size(77, 21);
            this.Trainer1L2.TabIndex = 73;
            this.Trainer1L2.Text = "Trainer 1: ";
            this.Trainer1L2.Visible = false;
            // 
            // Trainer2L1
            // 
            this.Trainer2L1.Location = new System.Drawing.Point(333, 94);
            this.Trainer2L1.Name = "Trainer2L1";
            this.Trainer2L1.Size = new System.Drawing.Size(77, 21);
            this.Trainer2L1.TabIndex = 74;
            this.Trainer2L1.Text = "Trainer 2:";
            this.Trainer2L1.Visible = false;
            // 
            // Trainer2L2
            // 
            this.Trainer2L2.Location = new System.Drawing.Point(333, 143);
            this.Trainer2L2.Name = "Trainer2L2";
            this.Trainer2L2.Size = new System.Drawing.Size(77, 21);
            this.Trainer2L2.TabIndex = 75;
            this.Trainer2L2.Text = "Trainer 2:";
            this.Trainer2L2.Visible = false;
            // 
            // Trainer1Cb2
            // 
            this.Trainer1Cb2.FormattingEnabled = true;
            this.Trainer1Cb2.Location = new System.Drawing.Point(454, 140);
            this.Trainer1Cb2.Name = "Trainer1Cb2";
            this.Trainer1Cb2.Size = new System.Drawing.Size(225, 28);
            this.Trainer1Cb2.TabIndex = 76;
            this.Trainer1Cb2.Visible = false;
            // 
            // Trainer2Cb1
            // 
            this.Trainer2Cb1.FormattingEnabled = true;
            this.Trainer2Cb1.Location = new System.Drawing.Point(93, 39);
            this.Trainer2Cb1.Name = "Trainer2Cb1";
            this.Trainer2Cb1.Size = new System.Drawing.Size(225, 28);
            this.Trainer2Cb1.TabIndex = 77;
            this.Trainer2Cb1.Visible = false;
            // 
            // dataSfarsitDP2
            // 
            this.dataSfarsitDP2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataSfarsitDP2.Location = new System.Drawing.Point(454, 140);
            this.dataSfarsitDP2.Name = "dataSfarsitDP2";
            this.dataSfarsitDP2.Size = new System.Drawing.Size(115, 25);
            this.dataSfarsitDP2.TabIndex = 69;
            this.dataSfarsitDP2.Visible = false;
            // 
            // CautareDAS
            // 
            this.AcceptButton = this.eDASEditBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.eDASAbdBtn;
            this.ClientSize = new System.Drawing.Size(839, 543);
            this.Controls.Add(this.Trainer2Cb1);
            this.Controls.Add(this.Trainer1Cb2);
            this.Controls.Add(this.Trainer2L2);
            this.Controls.Add(this.Trainer2L1);
            this.Controls.Add(this.Trainer1L2);
            this.Controls.Add(this.Trainer1L1);
            this.Controls.Add(this.Trainer2Cb2);
            this.Controls.Add(this.Trainer1Cb1);
            this.Controls.Add(this.dataSfarsitDP2);
            this.Controls.Add(this.dataSfarsitDP1);
            this.Controls.Add(this.dataInceputDP2);
            this.Controls.Add(this.dataInceputDP1);
            this.Controls.Add(this.modulComboBox2);
            this.Controls.Add(this.modulComboBox1);
            this.Controls.Add(this.dataSfarsitLabel2);
            this.Controls.Add(this.dataSfarsitLabel1);
            this.Controls.Add(this.dataInceputLabel2);
            this.Controls.Add(this.dataInceputLabel1);
            this.Controls.Add(this.modulLabel2);
            this.Controls.Add(this.modulLabel1);
            this.Controls.Add(this.eDASStgBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eDASEditBt);
            this.Controls.Add(this.eDASAbdBtn);
            this.Controls.Add(this.CautareDASDgv);
            this.Controls.Add(this.limtaL);
            this.Controls.Add(this.rezultateBtn);
            this.Controls.Add(this.criteriuCB2);
            this.Controls.Add(this.criteriu2L);
            this.Controls.Add(this.criteriu1L);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.criteriuCB1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CautareDAS";
            this.Text = "Căutare Program DAS";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CautareDAS_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CautareDASDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.ToolStripMenuItem printareToolStripMenuItem;

    private System.Windows.Forms.ComboBox Trainer1Cb2;
    private System.Windows.Forms.ComboBox Trainer2Cb1;

    private System.Windows.Forms.Label Trainer2L1;

    private System.Windows.Forms.Label Trainer2L2;

    private System.Windows.Forms.Label Trainer1L1;
    private System.Windows.Forms.Label Trainer1L2;

    private System.Windows.Forms.ComboBox Trainer2Cb2;

    private System.Windows.Forms.ComboBox Trainer1Cb1;

    private System.Windows.Forms.DateTimePicker dataInceputDP2;
    private System.Windows.Forms.DateTimePicker dataSfarsitDP1;
    private System.Windows.Forms.DateTimePicker dataSfarsitDP2;

    private System.Windows.Forms.DateTimePicker dataInceputDP1;

    private System.Windows.Forms.ComboBox modulComboBox2;

    private System.Windows.Forms.ComboBox modulComboBox1;

    private System.Windows.Forms.Label dataSfarsitLabel1;
    private System.Windows.Forms.Label dataSfarsitLabel2;
    private System.Windows.Forms.Label trainerLabel1;
    private System.Windows.Forms.Label trainerLabel2;

    private System.Windows.Forms.Label modulLabel2;
    private System.Windows.Forms.Label dataInceputLabel1;
    private System.Windows.Forms.Label dataInceputLabel2;

    private System.Windows.Forms.Label modulLabel1;

    private System.Windows.Forms.Button eDASStgBtn;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button eDASEditBt;
    private System.Windows.Forms.Button eDASAbdBtn;
    private System.Windows.Forms.DataGridView CautareDASDgv;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem ștergereToolStripMenuItem1;
    private System.Windows.Forms.Label limtaL;
    private System.Windows.Forms.Button rezultateBtn;
    private System.Windows.Forms.ComboBox criteriuCB2;
    private System.Windows.Forms.Label criteriu2L;
    private System.Windows.Forms.Label criteriu1L;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem opțiuniToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ștergereToolStripMenuItem;
    private System.Windows.Forms.ComboBox criteriuCB1;

    #endregion
}