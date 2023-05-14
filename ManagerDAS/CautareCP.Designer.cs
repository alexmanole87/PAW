using System.ComponentModel;

namespace ManagerDAS;

partial class CautareCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CautareCP));
            this.label1 = new System.Windows.Forms.Label();
            this.criteriuCb = new System.Windows.Forms.ComboBox();
            this.numeL = new System.Windows.Forms.Label();
            this.disL = new System.Windows.Forms.Label();
            this.studiiL = new System.Windows.Forms.Label();
            this.csCb = new System.Windows.Forms.ComboBox();
            this.disDP = new System.Windows.Forms.DateTimePicker();
            this.numeTb1 = new System.Windows.Forms.TextBox();
            this.numeTb2 = new System.Windows.Forms.TextBox();
            this.disDP2 = new System.Windows.Forms.DateTimePicker();
            this.csCb2 = new System.Windows.Forms.ComboBox();
            this.studiiL2 = new System.Windows.Forms.Label();
            this.dis3L = new System.Windows.Forms.Label();
            this.nume2L = new System.Windows.Forms.Label();
            this.criteriuCb2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ecpAbdBtn = new System.Windows.Forms.Button();
            this.ecpEditBt = new System.Windows.Forms.Button();
            this.CautareCPDgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rezultateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.optiuniEdMS = new System.Windows.Forms.MenuStrip();
            this.opțiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ștergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limtaL = new System.Windows.Forms.Label();
            this.eCpStgBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CautareCPDgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.optiuniEdMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criteriu selecție 1: ";
            // 
            // criteriuCb
            // 
            this.criteriuCb.FormattingEnabled = true;
            this.criteriuCb.Items.AddRange(new object[] {
            "Nume",
            "Data Intrării în Sistem",
            "Studii"});
            this.criteriuCb.Location = new System.Drawing.Point(176, 38);
            this.criteriuCb.Name = "criteriuCb";
            this.criteriuCb.Size = new System.Drawing.Size(232, 28);
            this.criteriuCb.TabIndex = 1;
            this.criteriuCb.SelectedIndexChanged += new System.EventHandler(this.criteriuCb_SelectedIndexChanged);
            // 
            // numeL
            // 
            this.numeL.Location = new System.Drawing.Point(428, 37);
            this.numeL.Name = "numeL";
            this.numeL.Size = new System.Drawing.Size(165, 23);
            this.numeL.TabIndex = 2;
            this.numeL.Text = "Nume: ";
            this.numeL.Visible = false;
            // 
            // disL
            // 
            this.disL.Location = new System.Drawing.Point(428, 38);
            this.disL.Name = "disL";
            this.disL.Size = new System.Drawing.Size(210, 23);
            this.disL.TabIndex = 3;
            this.disL.Text = "Data intrării în sistem: ";
            this.disL.Visible = false;
            // 
            // studiiL
            // 
            this.studiiL.Location = new System.Drawing.Point(434, 38);
            this.studiiL.Name = "studiiL";
            this.studiiL.Size = new System.Drawing.Size(165, 23);
            this.studiiL.TabIndex = 4;
            this.studiiL.Text = "Studii: ";
            this.studiiL.Visible = false;
            // 
            // csCb
            // 
            this.csCb.FormattingEnabled = true;
            this.csCb.Items.AddRange(new object[] {
            "Psihologie",
            "Asistență Socială",
            "Drept",
            "Sociologie"});
            this.csCb.Location = new System.Drawing.Point(620, 31);
            this.csCb.Name = "csCb";
            this.csCb.Size = new System.Drawing.Size(223, 28);
            this.csCb.TabIndex = 6;
            this.csCb.Visible = false;
            // 
            // disDP
            // 
            this.disDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.disDP.Location = new System.Drawing.Point(613, 35);
            this.disDP.Name = "disDP";
            this.disDP.Size = new System.Drawing.Size(230, 25);
            this.disDP.TabIndex = 7;
            this.disDP.Visible = false;
            // 
            // numeTb1
            // 
            this.numeTb1.Location = new System.Drawing.Point(613, 31);
            this.numeTb1.Name = "numeTb1";
            this.numeTb1.Size = new System.Drawing.Size(232, 25);
            this.numeTb1.TabIndex = 8;
            this.numeTb1.Visible = false;
            // 
            // numeTb2
            // 
            this.numeTb2.Location = new System.Drawing.Point(611, 83);
            this.numeTb2.Name = "numeTb2";
            this.numeTb2.Size = new System.Drawing.Size(232, 25);
            this.numeTb2.TabIndex = 14;
            this.numeTb2.Visible = false;
            // 
            // disDP2
            // 
            this.disDP2.CustomFormat = "yyyy-MM-dd";
            this.disDP2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.disDP2.Location = new System.Drawing.Point(616, 86);
            this.disDP2.Name = "disDP2";
            this.disDP2.Size = new System.Drawing.Size(211, 25);
            this.disDP2.TabIndex = 13;
            this.disDP2.Visible = false;
            // 
            // csCb2
            // 
            this.csCb2.FormattingEnabled = true;
            this.csCb2.Items.AddRange(new object[] {
            "Psihologie",
            "Asistență Socială",
            "Drept",
            "Sociologie"});
            this.csCb2.Location = new System.Drawing.Point(614, 83);
            this.csCb2.Name = "csCb2";
            this.csCb2.Size = new System.Drawing.Size(213, 28);
            this.csCb2.TabIndex = 12;
            this.csCb2.Visible = false;
            // 
            // studiiL2
            // 
            this.studiiL2.Location = new System.Drawing.Point(434, 83);
            this.studiiL2.Name = "studiiL2";
            this.studiiL2.Size = new System.Drawing.Size(146, 23);
            this.studiiL2.TabIndex = 11;
            this.studiiL2.Text = "Studii: ";
            this.studiiL2.Visible = false;
            // 
            // dis3L
            // 
            this.dis3L.Location = new System.Drawing.Point(434, 81);
            this.dis3L.Name = "dis3L";
            this.dis3L.Size = new System.Drawing.Size(174, 23);
            this.dis3L.TabIndex = 10;
            this.dis3L.Text = "Data intrării în sistem: ";
            this.dis3L.Visible = false;
            // 
            // nume2L
            // 
            this.nume2L.Location = new System.Drawing.Point(434, 83);
            this.nume2L.Name = "nume2L";
            this.nume2L.Size = new System.Drawing.Size(146, 23);
            this.nume2L.TabIndex = 9;
            this.nume2L.Text = "Nume: ";
            this.nume2L.Visible = false;
            // 
            // criteriuCb2
            // 
            this.criteriuCb2.FormattingEnabled = true;
            this.criteriuCb2.Items.AddRange(new object[] {
            "Nume",
            "Data Intrării în Sistem",
            "Studii"});
            this.criteriuCb2.Location = new System.Drawing.Point(176, 78);
            this.criteriuCb2.Name = "criteriuCb2";
            this.criteriuCb2.Size = new System.Drawing.Size(232, 28);
            this.criteriuCb2.TabIndex = 16;
            this.criteriuCb2.SelectedIndexChanged += new System.EventHandler(this.criteriuCb2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(36, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Criteriu selecție 2:";
            // 
            // ecpAbdBtn
            // 
            this.ecpAbdBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ecpAbdBtn.Location = new System.Drawing.Point(43, 376);
            this.ecpAbdBtn.Name = "ecpAbdBtn";
            this.ecpAbdBtn.Size = new System.Drawing.Size(171, 34);
            this.ecpAbdBtn.TabIndex = 17;
            this.ecpAbdBtn.Text = "Abandonare";
            this.ecpAbdBtn.UseVisualStyleBackColor = true;
           
            // 
            // ecpEditBt
            // 
            this.ecpEditBt.Location = new System.Drawing.Point(238, 377);
            this.ecpEditBt.Name = "ecpEditBt";
            this.ecpEditBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ecpEditBt.Size = new System.Drawing.Size(289, 33);
            this.ecpEditBt.TabIndex = 18;
            this.ecpEditBt.Text = "Editare date consilier de probațiune";
            this.ecpEditBt.UseVisualStyleBackColor = true;
            this.ecpEditBt.Click += new System.EventHandler(this.ecpEditBt_Click);
            // 
            // CautareCPDgv
            // 
            this.CautareCPDgv.AllowUserToAddRows = false;
            this.CautareCPDgv.AllowUserToDeleteRows = false;
            this.CautareCPDgv.AllowUserToOrderColumns = true;
            this.CautareCPDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CautareCPDgv.ContextMenuStrip = this.contextMenuStrip1;
            this.CautareCPDgv.Location = new System.Drawing.Point(35, 200);
            this.CautareCPDgv.Name = "CautareCPDgv";
            this.CautareCPDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CautareCPDgv.Size = new System.Drawing.Size(808, 171);
            this.CautareCPDgv.TabIndex = 19;
            this.CautareCPDgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CautareCP_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem1,
            this.stergereToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 52);
            // 
            // editareToolStripMenuItem1
            // 
            this.editareToolStripMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editareToolStripMenuItem1.Name = "editareToolStripMenuItem1";
            this.editareToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editareToolStripMenuItem1.Size = new System.Drawing.Size(156, 24);
            this.editareToolStripMenuItem1.Text = "Editare";
            this.editareToolStripMenuItem1.Click += new System.EventHandler(this.ecpEditBt_Click);
            // 
            // stergereToolStripMenuItem1
            // 
            this.stergereToolStripMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stergereToolStripMenuItem1.Name = "stergereToolStripMenuItem1";
            this.stergereToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stergereToolStripMenuItem1.Size = new System.Drawing.Size(156, 24);
            this.stergereToolStripMenuItem1.Text = "Ștergere";
            this.stergereToolStripMenuItem1.Click += new System.EventHandler(this.ecpStgBtn_Click);
            // 
            // rezultateBtn
            // 
            this.rezultateBtn.Location = new System.Drawing.Point(662, 126);
            this.rezultateBtn.Name = "rezultateBtn";
            this.rezultateBtn.Size = new System.Drawing.Size(132, 32);
            this.rezultateBtn.TabIndex = 20;
            this.rezultateBtn.Text = "Rezultate";
            this.rezultateBtn.UseVisualStyleBackColor = true;
            this.rezultateBtn.Click += new System.EventHandler(this.rezultateBtn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pentru a șterge criteriile selectate apasati Ctrl + C";
            // 
            // optiuniEdMS
            // 
            this.optiuniEdMS.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.optiuniEdMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opțiuniToolStripMenuItem});
            this.optiuniEdMS.Location = new System.Drawing.Point(0, 0);
            this.optiuniEdMS.Name = "optiuniEdMS";
            this.optiuniEdMS.Size = new System.Drawing.Size(867, 26);
            this.optiuniEdMS.TabIndex = 22;
            this.optiuniEdMS.Text = "menuStrip1";
            this.optiuniEdMS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CautareCP_KeyDown);
            // 
            // opțiuniToolStripMenuItem
            // 
            this.opțiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem,
            this.ștergereToolStripMenuItem,
            this.printareToolStripMenuItem});
            this.opțiuniToolStripMenuItem.Name = "opțiuniToolStripMenuItem";
            this.opțiuniToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.opțiuniToolStripMenuItem.Text = "Opțiuni";
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.ecpEditBt_Click);
            // 
            // ștergereToolStripMenuItem
            // 
            this.ștergereToolStripMenuItem.Name = "ștergereToolStripMenuItem";
            this.ștergereToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ștergereToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ștergereToolStripMenuItem.Text = "Ștergere";
            this.ștergereToolStripMenuItem.Click += new System.EventHandler(this.ecpStgBtn_Click);
            // 
            // printareToolStripMenuItem
            // 
            this.printareToolStripMenuItem.Name = "printareToolStripMenuItem";
            this.printareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printareToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.printareToolStripMenuItem.Text = "Printare";
            this.printareToolStripMenuItem.Click += new System.EventHandler(this.printareToolStripMenuItem_Click_1);
            // 
            // limtaL
            // 
            this.limtaL.Location = new System.Drawing.Point(43, 173);
            this.limtaL.Name = "limtaL";
            this.limtaL.Size = new System.Drawing.Size(728, 23);
            this.limtaL.TabIndex = 23;
            this.limtaL.Text = "S-au afișat doar primele 6 rezultate! Introduceți fie un al doilea criteriu de se" +
    "lecție, fie alte criterii.";
            this.limtaL.Visible = false;
            // 
            // eCpStgBtn
            // 
            this.eCpStgBtn.Location = new System.Drawing.Point(537, 377);
            this.eCpStgBtn.Name = "eCpStgBtn";
            this.eCpStgBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eCpStgBtn.Size = new System.Drawing.Size(308, 33);
            this.eCpStgBtn.TabIndex = 24;
            this.eCpStgBtn.Text = "Ștergere date consilier de probațiune";
            this.eCpStgBtn.UseVisualStyleBackColor = true;
            this.eCpStgBtn.Click += new System.EventHandler(this.ecpStgBtn_Click);
            // 
            // CautareCP
            // 
            this.AcceptButton = this.ecpEditBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ecpAbdBtn;
            this.ClientSize = new System.Drawing.Size(867, 484);
            this.Controls.Add(this.eCpStgBtn);
            this.Controls.Add(this.limtaL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rezultateBtn);
            this.Controls.Add(this.CautareCPDgv);
            this.Controls.Add(this.ecpEditBt);
            this.Controls.Add(this.ecpAbdBtn);
            this.Controls.Add(this.criteriuCb2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numeTb2);
            this.Controls.Add(this.disDP2);
            this.Controls.Add(this.csCb2);
            this.Controls.Add(this.studiiL2);
            this.Controls.Add(this.dis3L);
            this.Controls.Add(this.nume2L);
            this.Controls.Add(this.numeTb1);
            this.Controls.Add(this.disDP);
            this.Controls.Add(this.csCb);
            this.Controls.Add(this.studiiL);
            this.Controls.Add(this.disL);
            this.Controls.Add(this.numeL);
            this.Controls.Add(this.criteriuCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optiuniEdMS);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.optiuniEdMS;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CautareCP";
            this.Text = "Căutare Consilier de Probațiune";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CautareCP_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CautareCPDgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.optiuniEdMS.ResumeLayout(false);
            this.optiuniEdMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.ToolStripMenuItem printareToolStripMenuItem;

    private System.Windows.Forms.Button eCpStgBtn;

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem1;

    private System.Windows.Forms.Label limtaL;

    private System.Windows.Forms.MenuStrip optiuniEdMS;
    private System.Windows.Forms.ToolStripMenuItem opțiuniToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ștergereToolStripMenuItem;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button rezultateBtn;

    private System.Windows.Forms.DataGridView CautareCPDgv;

    private System.Windows.Forms.Button ecpAbdBtn;
    private System.Windows.Forms.Button ecpEditBt;

    private System.Windows.Forms.ComboBox criteriuCb2;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.TextBox numeTb2;
    private System.Windows.Forms.DateTimePicker disDP2;
    private System.Windows.Forms.ComboBox csCb2;
    private System.Windows.Forms.Label studiiL2;
    private System.Windows.Forms.Label dis3L;
    private System.Windows.Forms.Label nume2L;

    private System.Windows.Forms.DateTimePicker disDP;
    private System.Windows.Forms.TextBox numeTb1;

    private System.Windows.Forms.ComboBox csCb;

    private System.Windows.Forms.Label numeL;
    private System.Windows.Forms.Label disL;
    private System.Windows.Forms.Label studiiL;

    private System.Windows.Forms.ComboBox criteriuCb;

    private System.Windows.Forms.Label label1;

    #endregion
}