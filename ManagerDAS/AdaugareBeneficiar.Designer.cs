using System.ComponentModel;

namespace ManagerDAS;

partial class AdaugareBeneficiar
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareBeneficiar));
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.numeBenTb = new System.Windows.Forms.TextBox();
        this.MgrCazCb = new System.Windows.Forms.ComboBox();
        this.modulLabel = new System.Windows.Forms.Label();
        this.ModulCb = new System.Windows.Forms.ComboBox();
        this.DASCb = new System.Windows.Forms.CheckBox();
        this.AdaugareBenAbd = new System.Windows.Forms.Button();
        this.AdBenbtn = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.label1.Location = new System.Drawing.Point(14, 18);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(55, 37);
        this.label1.TabIndex = 0;
        this.label1.Text = "Nume";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.label2.Location = new System.Drawing.Point(14, 61);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(97, 37);
        this.label2.TabIndex = 1;
        this.label2.Text = "Manager Caz";
        // 
        // numeBenTb
        // 
        this.numeBenTb.AcceptsReturn = true;
        this.numeBenTb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.numeBenTb.Location = new System.Drawing.Point(127, 21);
        this.numeBenTb.Name = "numeBenTb";
        this.numeBenTb.Size = new System.Drawing.Size(290, 25);
        this.numeBenTb.TabIndex = 3;
        // 
        // MgrCazCb
        // 
        this.MgrCazCb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.MgrCazCb.FormattingEnabled = true;
        this.MgrCazCb.Location = new System.Drawing.Point(127, 58);
        this.MgrCazCb.Name = "MgrCazCb";
        this.MgrCazCb.Size = new System.Drawing.Size(153, 28);
        this.MgrCazCb.TabIndex = 4;
        // 
        // modulLabel
        // 
        this.modulLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.modulLabel.Location = new System.Drawing.Point(14, 138);
        this.modulLabel.Name = "modulLabel";
        this.modulLabel.Size = new System.Drawing.Size(64, 37);
        this.modulLabel.TabIndex = 6;
        this.modulLabel.Text = "Modul";
        this.modulLabel.Visible = false;
        // 
        // ModulCb
        // 
        this.ModulCb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.ModulCb.FormattingEnabled = true;
        this.ModulCb.Items.AddRange(new object[] { "A Face O Critica Constructivă", "Comunicare", "Cum Te Prezinti In Fata Unui Angajator", "Managementul Conflictelor" });
        this.ModulCb.SelectedIndex = 0;
        this.ModulCb.Location = new System.Drawing.Point(127, 138);
        this.ModulCb.Name = "ModulCb";
        this.ModulCb.Size = new System.Drawing.Size(290, 28);
        this.ModulCb.TabIndex = 7;
        this.ModulCb.Visible = false;
        // 
        // DASCb
        // 
        this.DASCb.Appearance = System.Windows.Forms.Appearance.Button;
        this.DASCb.Location = new System.Drawing.Point(127, 105);
        this.DASCb.Name = "DASCb";
        this.DASCb.Size = new System.Drawing.Size(158, 27);
        this.DASCb.TabIndex = 8;
        this.DASCb.Text = "Este înscris în DAS?";
        this.DASCb.UseVisualStyleBackColor = true;
        this.DASCb.CheckedChanged += new System.EventHandler(this.DASCb_CheckedChanged);
        // 
        // AdaugareBenAbd
        // 
        this.AdaugareBenAbd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.AdaugareBenAbd.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.AdaugareBenAbd.Location = new System.Drawing.Point(24, 196);
        this.AdaugareBenAbd.Name = "AdaugareBenAbd";
        this.AdaugareBenAbd.Size = new System.Drawing.Size(103, 32);
        this.AdaugareBenAbd.TabIndex = 9;
        this.AdaugareBenAbd.Text = "Abandonare";
        this.AdaugareBenAbd.UseMnemonic = false;
        this.AdaugareBenAbd.UseVisualStyleBackColor = true;
        // 
        // AdBenbtn
        // 
        this.AdBenbtn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.AdBenbtn.Location = new System.Drawing.Point(230, 196);
        this.AdBenbtn.Name = "AdBenbtn";
        this.AdBenbtn.Size = new System.Drawing.Size(187, 32);
        this.AdBenbtn.TabIndex = 10;
        this.AdBenbtn.Text = "Adăugare Beneficiar";
        this.AdBenbtn.UseMnemonic = false;
        this.AdBenbtn.UseVisualStyleBackColor = true;
        this.AdBenbtn.Click += new System.EventHandler(this.AdBenbtn_Click);
        // 
        // AdaugareBeneficiar
        // 
        this.AcceptButton = this.AdBenbtn;
        this.AllowDrop = true;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.AdaugareBenAbd;
        this.ClientSize = new System.Drawing.Size(429, 240);
        this.Controls.Add(this.AdBenbtn);
        this.Controls.Add(this.AdaugareBenAbd);
        this.Controls.Add(this.DASCb);
        this.Controls.Add(this.ModulCb);
        this.Controls.Add(this.modulLabel);
        this.Controls.Add(this.MgrCazCb);
        this.Controls.Add(this.numeBenTb);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "AdaugareBeneficiar";
        this.Text = "Adăugare Beneficiar";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button AdBenbtn;

    //private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Button AdaugareBenAbd;

    private System.Windows.Forms.CheckBox DASCb;

    private System.Windows.Forms.ComboBox ModulCb;

    private System.Windows.Forms.Label modulLabel;

    private System.Windows.Forms.ComboBox MgrCazCb;

    private System.Windows.Forms.TextBox numeBenTb;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}