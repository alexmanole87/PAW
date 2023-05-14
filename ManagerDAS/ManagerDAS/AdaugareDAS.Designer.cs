using System.ComponentModel;

namespace ManagerDAS.bin.Debug.Media;

partial class AdaugareDAS
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareDAS));
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.AbandonareBt = new System.Windows.Forms.Button();
        this.ModulCB = new System.Windows.Forms.ComboBox();
        this.dataInceputDP = new System.Windows.Forms.DateTimePicker();
        this.dataSfarsitDP = new System.Windows.Forms.DateTimePicker();
        this.Trainer1CB = new System.Windows.Forms.ComboBox();
        this.Trainer2CB = new System.Windows.Forms.ComboBox();
        this.AdaugareDASBt = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.label1.Location = new System.Drawing.Point(29, 21);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(53, 28);
        this.label1.TabIndex = 0;
        this.label1.Text = "Modul";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.label2.Location = new System.Drawing.Point(29, 64);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(111, 28);
        this.label2.TabIndex = 1;
        this.label2.Text = "Dată Început";
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.label3.Location = new System.Drawing.Point(29, 110);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(111, 28);
        this.label3.TabIndex = 2;
        this.label3.Text = "Dată Început";
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.label4.Location = new System.Drawing.Point(29, 148);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(111, 28);
        this.label4.TabIndex = 3;
        this.label4.Text = "Trainer 1";
        // 
        // label5
        // 
        this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.label5.Location = new System.Drawing.Point(29, 192);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(111, 28);
        this.label5.TabIndex = 4;
        this.label5.Text = "Trainer 2";
        // 
        // AbandonareBt
        // 
        this.AbandonareBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.AbandonareBt.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.AbandonareBt.Location = new System.Drawing.Point(29, 244);
        this.AbandonareBt.Name = "AbandonareBt";
        this.AbandonareBt.Size = new System.Drawing.Size(99, 36);
        this.AbandonareBt.TabIndex = 5;
        this.AbandonareBt.Text = "Abandonare";
        this.AbandonareBt.UseVisualStyleBackColor = true;
        // 
        // ModulCB
        // 
        this.ModulCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.ModulCB.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.ModulCB.FormattingEnabled = true;
        this.ModulCB.Items.AddRange(new object[] { "A face o critică constructivă", "Comunicare", "Cum te prezinți în fața unui angajator", "Managementul conflictelor" });
        this.ModulCB.SelectedIndex = 0;
        this.ModulCB.Location = new System.Drawing.Point(193, 16);
        this.ModulCB.Name = "ModulCB";
        this.ModulCB.Size = new System.Drawing.Size(309, 28);
        this.ModulCB.TabIndex = 7;
        // 
        // dataInceputDP
        // 
        this.dataInceputDP.CalendarFont = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.dataInceputDP.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.dataInceputDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dataInceputDP.Location = new System.Drawing.Point(193, 63);
        this.dataInceputDP.Name = "dataInceputDP";
        this.dataInceputDP.Size = new System.Drawing.Size(119, 25);
        this.dataInceputDP.TabIndex = 8;
        // 
        // dataSfarsitDP
        // 
        this.dataSfarsitDP.CalendarFont = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.dataSfarsitDP.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.dataSfarsitDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dataSfarsitDP.Location = new System.Drawing.Point(193, 106);
        this.dataSfarsitDP.Name = "dataSfarsitDP";
        this.dataSfarsitDP.Size = new System.Drawing.Size(119, 25);
        this.dataSfarsitDP.TabIndex = 9;
        // 
        // Trainer1CB
        // 
        this.Trainer1CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.Trainer1CB.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.Trainer1CB.FormattingEnabled = true;
        this.Trainer1CB.Location = new System.Drawing.Point(193, 148);
        this.Trainer1CB.Name = "Trainer1CB";
        this.Trainer1CB.Size = new System.Drawing.Size(220, 28);
        this.Trainer1CB.TabIndex = 10;
        // 
        // Trainer2CB
        // 
        this.Trainer2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.Trainer2CB.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.Trainer2CB.FormattingEnabled = true;
        this.Trainer2CB.Location = new System.Drawing.Point(193, 192);
        this.Trainer2CB.Name = "Trainer2CB";
        this.Trainer2CB.Size = new System.Drawing.Size(220, 28);
        this.Trainer2CB.TabIndex = 11;
        // 
        // AdaugareDASBt
        // 
        this.AdaugareDASBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.AdaugareDASBt.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.AdaugareDASBt.Location = new System.Drawing.Point(388, 244);
        this.AdaugareDASBt.Name = "AdaugareDASBt";
        this.AdaugareDASBt.Size = new System.Drawing.Size(114, 36);
        this.AdaugareDASBt.TabIndex = 12;
        this.AdaugareDASBt.Text = "Adăugare DAS";
        this.AdaugareDASBt.UseVisualStyleBackColor = true;
        this.AdaugareDASBt.Click += new System.EventHandler(this.AdaugareDASBt_Click);
        // 
        // AdaugareDAS
        // 
        this.AcceptButton = this.AdaugareDASBt;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
        this.CancelButton = this.AbandonareBt;
        this.ClientSize = new System.Drawing.Size(522, 301);
        this.Controls.Add(this.AdaugareDASBt);
        this.Controls.Add(this.Trainer2CB);
        this.Controls.Add(this.Trainer1CB);
        this.Controls.Add(this.dataSfarsitDP);
        this.Controls.Add(this.dataInceputDP);
        this.Controls.Add(this.ModulCB);
        this.Controls.Add(this.AbandonareBt);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "AdaugareDAS";
        this.Text = "Adăugare DAS";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button AdaugareDASBt;

    private System.Windows.Forms.ComboBox Trainer2CB;

    private System.Windows.Forms.DateTimePicker dataInceputDP;
    private System.Windows.Forms.ComboBox Trainer1CB;

    private System.Windows.Forms.DateTimePicker dataSfarsitDP;

    private System.Windows.Forms.ComboBox ModulCB;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button AbandonareBt;

    private System.Windows.Forms.Label label1;

    #endregion
}