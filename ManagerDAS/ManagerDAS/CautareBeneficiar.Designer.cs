using System.ComponentModel;

namespace ManagerDAS;

partial class CautareBeneficiar
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CautareBeneficiar));
        this.numeL = new System.Windows.Forms.Label();
        this.mgrL1 = new System.Windows.Forms.Label();
        this.numeL2 = new System.Windows.Forms.Label();
        this.managerCazL2 = new System.Windows.Forms.Label();
        this.criteriu1L = new System.Windows.Forms.Label();
        this.criteriu2L = new System.Windows.Forms.Label();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.opțiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ștergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.printareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.editareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.ștergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.criteriuCB1 = new System.Windows.Forms.ComboBox();
        this.criteriuCB2 = new System.Windows.Forms.ComboBox();
        this.programDASL2 = new System.Windows.Forms.Label();
        this.numeTb1 = new System.Windows.Forms.TextBox();
        this.numeTb2 = new System.Windows.Forms.TextBox();
        this.programDASL1 = new System.Windows.Forms.Label();
        this.rezultateBtn = new System.Windows.Forms.Button();
        this.limtaL = new System.Windows.Forms.Label();
        this.CautareBenDgv = new System.Windows.Forms.DataGridView();
        this.ebStgBtn = new System.Windows.Forms.Button();
        this.label2 = new System.Windows.Forms.Label();
        this.ebEditBt = new System.Windows.Forms.Button();
        this.ebAbdBtn = new System.Windows.Forms.Button();
        this.MgrCazEbCb1 = new System.Windows.Forms.ComboBox();
        this.MgrCazEbCb2 = new System.Windows.Forms.ComboBox();
        this.dasEbCb2 = new System.Windows.Forms.ComboBox();
        this.dasEbCb1 = new System.Windows.Forms.ComboBox();
        this.menuStrip1.SuspendLayout();
        this.contextMenuStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.CautareBenDgv)).BeginInit();
        this.SuspendLayout();
        // 
        // numeL
        // 
        this.numeL.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.numeL.Location = new System.Drawing.Point(370, 74);
        this.numeL.Name = "numeL";
        this.numeL.Size = new System.Drawing.Size(58, 30);
        this.numeL.TabIndex = 0;
        this.numeL.Text = "Nume:";
        this.numeL.Visible = false;
        // 
        // mgrL1
        // 
        this.mgrL1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.mgrL1.Location = new System.Drawing.Point(323, 77);
        this.mgrL1.Name = "mgrL1";
        this.mgrL1.Size = new System.Drawing.Size(119, 30);
        this.mgrL1.TabIndex = 1;
        this.mgrL1.Text = "Manager Caz:";
        this.mgrL1.Visible = false;
        // 
        // numeL2
        // 
        this.numeL2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.numeL2.Location = new System.Drawing.Point(370, 123);
        this.numeL2.Name = "numeL2";
        this.numeL2.Size = new System.Drawing.Size(58, 30);
        this.numeL2.TabIndex = 2;
        this.numeL2.Text = "Nume:";
        this.numeL2.Visible = false;
        // 
        // managerCazL2
        // 
        this.managerCazL2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.managerCazL2.Location = new System.Drawing.Point(323, 123);
        this.managerCazL2.Name = "managerCazL2";
        this.managerCazL2.Size = new System.Drawing.Size(119, 30);
        this.managerCazL2.TabIndex = 3;
        this.managerCazL2.Text = "Manager Caz:";
        this.managerCazL2.Visible = false;
        // 
        // criteriu1L
        // 
        this.criteriu1L.Location = new System.Drawing.Point(12, 74);
        this.criteriu1L.Name = "criteriu1L";
        this.criteriu1L.Size = new System.Drawing.Size(84, 31);
        this.criteriu1L.TabIndex = 4;
        this.criteriu1L.Text = "Criteriu 1: ";
        // 
        // criteriu2L
        // 
        this.criteriu2L.Location = new System.Drawing.Point(12, 123);
        this.criteriu2L.Name = "criteriu2L";
        this.criteriu2L.Size = new System.Drawing.Size(84, 31);
        this.criteriu2L.TabIndex = 5;
        this.criteriu2L.Text = "Criteriu 2: ";
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.opțiuniToolStripMenuItem });
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(849, 24);
        this.menuStrip1.TabIndex = 6;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // opțiuniToolStripMenuItem
        // 
        this.opțiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.editareToolStripMenuItem, this.ștergereToolStripMenuItem, this.printareToolStripMenuItem });
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
        this.editareToolStripMenuItem.Click += new System.EventHandler(this.ebEditBt_Click);
        // 
        // ștergereToolStripMenuItem
        // 
        this.ștergereToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.ștergereToolStripMenuItem.Name = "ștergereToolStripMenuItem";
        this.ștergereToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        this.ștergereToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
        this.ștergereToolStripMenuItem.Text = "Ștergere";
        this.ștergereToolStripMenuItem.Click += new System.EventHandler(this.ebStgBtn_Click);
        // 
        // printareToolStripMenuItem
        // 
        this.printareToolStripMenuItem.Name = "printareToolStripMenuItem";
        this.printareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
        this.printareToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
        this.printareToolStripMenuItem.Text = "Printare";
        this.printareToolStripMenuItem.Click += new System.EventHandler(this.printareToolStripMenuItem_Click);
        // 
        // contextMenuStrip1
        // 
        this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.editareToolStripMenuItem1, this.ștergereToolStripMenuItem1 });
        this.contextMenuStrip1.Name = "contextMenuStrip1";
        this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
        // 
        // editareToolStripMenuItem1
        // 
        this.editareToolStripMenuItem1.Name = "editareToolStripMenuItem1";
        this.editareToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
        this.editareToolStripMenuItem1.Text = "Editare";
        this.editareToolStripMenuItem1.Click += new System.EventHandler(this.ebEditBt_Click);
        // 
        // ștergereToolStripMenuItem1
        // 
        this.ștergereToolStripMenuItem1.Name = "ștergereToolStripMenuItem1";
        this.ștergereToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
        this.ștergereToolStripMenuItem1.Text = "Ștergere";
        this.ștergereToolStripMenuItem1.Click += new System.EventHandler(this.ebStgBtn_Click);
        // 
        // criteriuCB1
        // 
        this.criteriuCB1.FormattingEnabled = true;
        this.criteriuCB1.Items.AddRange(new object[] { "Nume", "Manager Caz", "Program DAS"});
        this.criteriuCB1.Location = new System.Drawing.Point(99, 74);
        this.criteriuCB1.Name = "criteriuCB1";
        this.criteriuCB1.Size = new System.Drawing.Size(201, 28);
        this.criteriuCB1.TabIndex = 8;
        this.criteriuCB1.SelectedIndexChanged += new System.EventHandler(this.criteriuCB1_SelectedIndexChanged);
        // 
        // criteriuCB2
        // 
        this.criteriuCB2.FormattingEnabled = true;
        this.criteriuCB2.Items.AddRange(new object[] { "Nume", "Manager Caz", "Program DAS"});
        this.criteriuCB2.Location = new System.Drawing.Point(99, 123);
        this.criteriuCB2.Name = "criteriuCB2";
        this.criteriuCB2.Size = new System.Drawing.Size(201, 28);
        this.criteriuCB2.TabIndex = 9;
        this.criteriuCB2.SelectedIndexChanged += new System.EventHandler(this.criteriuCB2_SelectedIndexChanged);
        // 
        // programDASL2
        // 
        this.programDASL2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.programDASL2.Location = new System.Drawing.Point(323, 123);
        this.programDASL2.Name = "programDASL2";
        this.programDASL2.Size = new System.Drawing.Size(119, 30);
        this.programDASL2.TabIndex = 10;
        this.programDASL2.Text = "Program DAS:";
        this.programDASL2.Visible = false;
        // 
        // numeTb1
        // 
        this.numeTb1.Location = new System.Drawing.Point(459, 74);
        this.numeTb1.Name = "numeTb1";
        this.numeTb1.Size = new System.Drawing.Size(194, 25);
        this.numeTb1.TabIndex = 11;
        this.numeTb1.Visible = false;
        // 
        // numeTb2
        // 
        this.numeTb2.Location = new System.Drawing.Point(459, 123);
        this.numeTb2.Name = "numeTb2";
        this.numeTb2.Size = new System.Drawing.Size(194, 25);
        this.numeTb2.TabIndex = 12;
        this.numeTb2.Visible = false;
        // 
        // programDASL1
        // 
        this.programDASL1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        this.programDASL1.Location = new System.Drawing.Point(323, 72);
        this.programDASL1.Name = "programDASL1";
        this.programDASL1.Size = new System.Drawing.Size(119, 30);
        this.programDASL1.TabIndex = 13;
        this.programDASL1.Text = "Program DAS:";
        this.programDASL1.Visible = false;
        // 
        // rezultateBtn
        // 
        this.rezultateBtn.Location = new System.Drawing.Point(521, 172);
        this.rezultateBtn.Name = "rezultateBtn";
        this.rezultateBtn.Size = new System.Drawing.Size(132, 32);
        this.rezultateBtn.TabIndex = 21;
        this.rezultateBtn.Text = "Rezultate";
        this.rezultateBtn.UseVisualStyleBackColor = true;
        this.rezultateBtn.Click += new System.EventHandler(this.rezultateBtn_Click);
        // 
        // limtaL
        // 
        this.limtaL.Location = new System.Drawing.Point(22, 207);
        this.limtaL.Name = "limtaL";
        this.limtaL.Size = new System.Drawing.Size(728, 23);
        this.limtaL.TabIndex = 24;
        this.limtaL.Text = "S-au afișat doar primele 6 rezultate! Introduceți fie un al doilea criteriu de se" + "lecție, fie alte criterii.";
        this.limtaL.Visible = false;
        // 
        // CautareBenDgv
        // 
        this.CautareBenDgv.AllowUserToAddRows = false;
        this.CautareBenDgv.AllowUserToDeleteRows = false;
        this.CautareBenDgv.AllowUserToOrderColumns = true;
        this.CautareBenDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.CautareBenDgv.ContextMenuStrip = this.contextMenuStrip1;
        this.CautareBenDgv.Location = new System.Drawing.Point(12, 233);
        this.CautareBenDgv.Name = "CautareBenDgv";
        this.CautareBenDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.CautareBenDgv.Size = new System.Drawing.Size(808, 171);
        this.CautareBenDgv.TabIndex = 25;
        // 
        // ebStgBtn
        // 
        this.ebStgBtn.Location = new System.Drawing.Point(637, 424);
        this.ebStgBtn.Name = "ebStgBtn";
        this.ebStgBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        this.ebStgBtn.Size = new System.Drawing.Size(187, 33);
        this.ebStgBtn.TabIndex = 29;
        this.ebStgBtn.Text = "Ștergere date Beneficiar";
        this.ebStgBtn.UseVisualStyleBackColor = true;
        this.ebStgBtn.Click += new System.EventHandler(this.ebStgBtn_Click);
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(22, 491);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(373, 23);
        this.label2.TabIndex = 28;
        this.label2.Text = "Pentru a șterge criteriile selectate apasati Ctrl + C";
        // 
        // ebEditBt
        // 
        this.ebEditBt.Location = new System.Drawing.Point(323, 424);
        this.ebEditBt.Name = "ebEditBt";
        this.ebEditBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        this.ebEditBt.Size = new System.Drawing.Size(175, 33);
        this.ebEditBt.TabIndex = 27;
        this.ebEditBt.Text = "Editare date Beneficiar";
        this.ebEditBt.UseVisualStyleBackColor = true;
        this.ebEditBt.Click += new System.EventHandler(this.ebEditBt_Click);
        // 
        // ebAbdBtn
        // 
        this.ebAbdBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.ebAbdBtn.Location = new System.Drawing.Point(22, 423);
        this.ebAbdBtn.Name = "ebAbdBtn";
        this.ebAbdBtn.Size = new System.Drawing.Size(106, 34);
        this.ebAbdBtn.TabIndex = 26;
        this.ebAbdBtn.Text = "Abandonare";
        this.ebAbdBtn.UseVisualStyleBackColor = true;
        // 
        // MgrCazEbCb1
        // 
        this.MgrCazEbCb1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.MgrCazEbCb1.FormattingEnabled = true;
        this.MgrCazEbCb1.Location = new System.Drawing.Point(459, 71);
        this.MgrCazEbCb1.Name = "MgrCazEbCb1";
        this.MgrCazEbCb1.Size = new System.Drawing.Size(153, 28);
        this.MgrCazEbCb1.TabIndex = 32;
        this.MgrCazEbCb1.Visible = false;
        // 
        // MgrCazEbCb2
        // 
        this.MgrCazEbCb2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.MgrCazEbCb2.FormattingEnabled = true;
        this.MgrCazEbCb2.Location = new System.Drawing.Point(459, 125);
        this.MgrCazEbCb2.Name = "MgrCazEbCb2";
        this.MgrCazEbCb2.Size = new System.Drawing.Size(153, 28);
        this.MgrCazEbCb2.TabIndex = 33;
        this.MgrCazEbCb2.Visible = false;
        // 
        // dasEbCb2
        // 
        this.dasEbCb2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.dasEbCb2.FormattingEnabled = true;
        this.dasEbCb2.Items.AddRange(new object[] { "A Face O Critica Constructivă", "Comunicare", "Cum Te Prezinti In Fata Unui Angajator", "Managementul Conflictelor" });
        this.dasEbCb2.SelectedIndex= 0;
        this.dasEbCb2.Location = new System.Drawing.Point(460, 126);
        this.dasEbCb2.Name = "dasEbCb2";
        this.dasEbCb2.Size = new System.Drawing.Size(290, 28);
        this.dasEbCb2.TabIndex = 34;
        this.dasEbCb2.Visible = false;
        // 
        // dasEbCb1
        // 
        this.dasEbCb1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.dasEbCb1.FormattingEnabled = true;
        this.dasEbCb1.Items.AddRange(new object[] { "A Face O Critica Constructivă", "Comunicare", "Cum Te Prezinti In Fata Unui Angajator", "Managementul Conflictelor" });
        this.dasEbCb1.SelectedIndex = 0;
        this.dasEbCb1.Location = new System.Drawing.Point(460, 71);
        this.dasEbCb1.Name = "dasEbCb1";
        this.dasEbCb1.Size = new System.Drawing.Size(290, 28);
        this.dasEbCb1.TabIndex = 35;
        this.dasEbCb1.Visible = false;
        // 
        // CautareBeneficiar
        // 
        this.AcceptButton = this.ebEditBt;
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.ebAbdBtn;
        this.ClientSize = new System.Drawing.Size(849, 612);
        this.Controls.Add(this.dasEbCb1);
        this.Controls.Add(this.dasEbCb2);
        this.Controls.Add(this.MgrCazEbCb2);
        this.Controls.Add(this.MgrCazEbCb1);
        this.Controls.Add(this.ebStgBtn);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.ebEditBt);
        this.Controls.Add(this.ebAbdBtn);
        this.Controls.Add(this.CautareBenDgv);
        this.Controls.Add(this.limtaL);
        this.Controls.Add(this.rezultateBtn);
        this.Controls.Add(this.programDASL1);
        this.Controls.Add(this.numeTb2);
        this.Controls.Add(this.numeTb1);
        this.Controls.Add(this.programDASL2);
        this.Controls.Add(this.criteriuCB2);
        this.Controls.Add(this.criteriuCB1);
        this.Controls.Add(this.criteriu2L);
        this.Controls.Add(this.criteriu1L);
        this.Controls.Add(this.managerCazL2);
        this.Controls.Add(this.numeL2);
        this.Controls.Add(this.mgrL1);
        this.Controls.Add(this.numeL);
        this.Controls.Add(this.menuStrip1);
        this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.MainMenuStrip = this.menuStrip1;
        this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "CautareBeneficiar";
        this.Text = "Căutare Beneficiar";
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CautareBeneficiar_KeyDown);
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.contextMenuStrip1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.CautareBenDgv)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem printareToolStripMenuItem;

    private System.Windows.Forms.ComboBox dasEbCb2;
    private System.Windows.Forms.ComboBox dasEbCb1;

    private System.Windows.Forms.ComboBox MgrCazEbCb2;

    private System.Windows.Forms.ComboBox MgrCazEbCb1;

    private System.Windows.Forms.Button ebStgBtn;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button ebEditBt;
    private System.Windows.Forms.Button ebAbdBtn;

    private System.Windows.Forms.DataGridView CautareBenDgv;

    private System.Windows.Forms.Label limtaL;

    private System.Windows.Forms.Button rezultateBtn;

    private System.Windows.Forms.TextBox numeTb2;
    private System.Windows.Forms.Label managerCazL2;

    private System.Windows.Forms.Label programDASL2;
    private System.Windows.Forms.TextBox numeTb1;

    private System.Windows.Forms.Label mgrL1;

    private System.Windows.Forms.ComboBox criteriuCB1;

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem ștergereToolStripMenuItem1;
    private System.Windows.Forms.ComboBox criteriuCB2;

    private System.Windows.Forms.ToolStripMenuItem ștergereToolStripMenuItem;

    private System.Windows.Forms.Label programDASL1;
    private System.Windows.Forms.Label criteriu1L;
    private System.Windows.Forms.Label criteriu2L;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem opțiuniToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;

    private System.Windows.Forms.Label numeL;
    private System.Windows.Forms.Label numeL2;

    #endregion
}