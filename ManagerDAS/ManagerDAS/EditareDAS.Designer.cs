using System.ComponentModel;

namespace ManagerDAS;

partial class EditareDAS
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditareDAS));
        this.EditareDASBt = new System.Windows.Forms.Button();
        this.Trainer2CB = new System.Windows.Forms.ComboBox();
        this.Trainer1CB = new System.Windows.Forms.ComboBox();
        this.dataSfarsitDP = new System.Windows.Forms.DateTimePicker();
        this.dataInceputDP = new System.Windows.Forms.DateTimePicker();
        this.ModulCB = new System.Windows.Forms.ComboBox();
        this.AbandonareBt = new System.Windows.Forms.Button();
        this.label5 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // EditareDASBt
        // 
        this.EditareDASBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.EditareDASBt.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.EditareDASBt.Location = new System.Drawing.Point(384, 251);
        this.EditareDASBt.Name = "EditareDASBt";
        this.EditareDASBt.Size = new System.Drawing.Size(114, 36);
        this.EditareDASBt.TabIndex = 24;
        this.EditareDASBt.Text = "Editare DAS";
        this.EditareDASBt.UseVisualStyleBackColor = true;
        this.EditareDASBt.Click += new System.EventHandler(this.EditareDASBt_Click);
        // 
        // Trainer2CB
        // 
        this.Trainer2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.Trainer2CB.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.Trainer2CB.FormattingEnabled = true;
        this.Trainer2CB.Location = new System.Drawing.Point(189, 199);
        this.Trainer2CB.Name = "Trainer2CB";
        this.Trainer2CB.Size = new System.Drawing.Size(220, 28);
        this.Trainer2CB.TabIndex = 23;
        // 
        // Trainer1CB
        // 
        this.Trainer1CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.Trainer1CB.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.Trainer1CB.FormattingEnabled = true;
        this.Trainer1CB.Location = new System.Drawing.Point(189, 155);
        this.Trainer1CB.Name = "Trainer1CB";
        this.Trainer1CB.Size = new System.Drawing.Size(220, 28);
        this.Trainer1CB.TabIndex = 22;
        // 
        // dataSfarsitDP
        // 
        this.dataSfarsitDP.CalendarFont = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.dataSfarsitDP.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.dataSfarsitDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dataSfarsitDP.Location = new System.Drawing.Point(189, 113);
        this.dataSfarsitDP.Name = "dataSfarsitDP";
        this.dataSfarsitDP.Size = new System.Drawing.Size(119, 25);
        this.dataSfarsitDP.TabIndex = 21;
        // 
        // dataInceputDP
        // 
        this.dataInceputDP.CalendarFont = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.dataInceputDP.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.dataInceputDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dataInceputDP.Location = new System.Drawing.Point(189, 70);
        this.dataInceputDP.Name = "dataInceputDP";
        this.dataInceputDP.Size = new System.Drawing.Size(119, 25);
        this.dataInceputDP.TabIndex = 20;
        // 
        // ModulCB
        // 
        this.ModulCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.ModulCB.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.ModulCB.FormattingEnabled = true;
        this.ModulCB.Items.AddRange(new object[] { "A face o critică constructivă", "Comunicare", "Cum te prezinți în fața unui angajator", "Managementul conflictelor" });
        this.ModulCB.Location = new System.Drawing.Point(189, 23);
        this.ModulCB.Name = "ModulCB";
        this.ModulCB.Size = new System.Drawing.Size(309, 28);
        this.ModulCB.TabIndex = 19;
        // 
        // AbandonareBt
        // 
        this.AbandonareBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.AbandonareBt.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.AbandonareBt.Location = new System.Drawing.Point(25, 251);
        this.AbandonareBt.Name = "AbandonareBt";
        this.AbandonareBt.Size = new System.Drawing.Size(99, 36);
        this.AbandonareBt.TabIndex = 18;
        this.AbandonareBt.Text = "Abandonare";
        this.AbandonareBt.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.label5.Location = new System.Drawing.Point(25, 199);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(111, 28);
        this.label5.TabIndex = 17;
        this.label5.Text = "Trainer 2";
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.label4.Location = new System.Drawing.Point(25, 155);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(111, 28);
        this.label4.TabIndex = 16;
        this.label4.Text = "Trainer 1";
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.label3.Location = new System.Drawing.Point(25, 117);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(111, 28);
        this.label3.TabIndex = 15;
        this.label3.Text = "Dată Început";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.label2.Location = new System.Drawing.Point(25, 71);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(111, 28);
        this.label2.TabIndex = 14;
        this.label2.Text = "Dată Început";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
        this.label1.Location = new System.Drawing.Point(25, 28);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(53, 28);
        this.label1.TabIndex = 13;
        this.label1.Text = "Modul";
        // 
        // EditareDAS
        // 
        this.AcceptButton = this.EditareDASBt;
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.AbandonareBt;
        this.ClientSize = new System.Drawing.Size(555, 308);
        this.Controls.Add(this.EditareDASBt);
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
        this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "EditareDAS";
        this.Text = "EditareDAS";
        this.Load += new System.EventHandler(this.EditareDAS_Load);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button EditareDASBt;
    private System.Windows.Forms.ComboBox Trainer2CB;
    private System.Windows.Forms.ComboBox Trainer1CB;
    private System.Windows.Forms.DateTimePicker dataSfarsitDP;
    private System.Windows.Forms.DateTimePicker dataInceputDP;
    private System.Windows.Forms.ComboBox ModulCB;
    private System.Windows.Forms.Button AbandonareBt;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;

    #endregion
}