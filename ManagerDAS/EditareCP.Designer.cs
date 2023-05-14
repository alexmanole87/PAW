using System.ComponentModel;

namespace ManagerDAS;

partial class EditareCP
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditareCP));
        this.btCancel = new System.Windows.Forms.Button();
        this.btOk = new System.Windows.Forms.Button();
        this.studii = new System.Windows.Forms.ComboBox();
        this.dis = new System.Windows.Forms.DateTimePicker();
        this.tbNume = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.Nume = new System.Windows.Forms.Label();
        this.abilitatCB = new System.Windows.Forms.CheckBox();
        this.SuspendLayout();
        // 
        // btCancel
        // 
        this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btCancel.Location = new System.Drawing.Point(39, 265);
        this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.btCancel.Name = "btCancel";
        this.btCancel.Size = new System.Drawing.Size(161, 32);
        this.btCancel.TabIndex = 29;
        this.btCancel.Text = "Abandonare";
        this.btCancel.UseVisualStyleBackColor = true;
        // 
        // btOk
        // 
        this.btOk.Location = new System.Drawing.Point(384, 265);
        this.btOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.btOk.Name = "btOk";
        this.btOk.Size = new System.Drawing.Size(161, 32);
        this.btOk.TabIndex = 28;
        this.btOk.Text = "Salvează Consilierul";
        this.btOk.UseVisualStyleBackColor = true;
        this.btOk.Click += new System.EventHandler(this.btOk_Click);
        // 
        // studii
        // 
        this.studii.AutoCompleteCustomSource.AddRange(new string[] { "Psihologie", "Asistență Socială", "Drept", "Sociologie" });
        this.studii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.studii.FormattingEnabled = true;
        this.studii.Items.AddRange(new object[] { "Psihologie", "Asistență Socială", "Drept", "Sociologie" });
        this.studii.Location = new System.Drawing.Point(297, 142);
        this.studii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.studii.Name = "studii";
        this.studii.Size = new System.Drawing.Size(248, 28);
        this.studii.TabIndex = 27;
        // 
        // dis
        // 
        this.dis.AllowDrop = true;
        this.dis.CalendarFont = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.dis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dis.Location = new System.Drawing.Point(295, 82);
        this.dis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.dis.Name = "dis";
        this.dis.Size = new System.Drawing.Size(251, 25);
        this.dis.TabIndex = 26;
        // 
        // tbNume
        // 
        this.tbNume.AllowDrop = true;
        this.tbNume.Cursor = System.Windows.Forms.Cursors.No;
        this.tbNume.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.tbNume.Location = new System.Drawing.Point(297, 22);
        this.tbNume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.tbNume.Name = "tbNume";
        this.tbNume.Size = new System.Drawing.Size(249, 23);
        this.tbNume.TabIndex = 25;
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.label2.Location = new System.Drawing.Point(16, 131);
        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(79, 40);
        this.label2.TabIndex = 23;
        this.label2.Text = "Studii";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.label1.Location = new System.Drawing.Point(16, 71);
        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(281, 40);
        this.label1.TabIndex = 22;
        this.label1.Text = "Data Intrării în Sistem\r\n";
        // 
        // Nume
        // 
        this.Nume.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.Nume.Location = new System.Drawing.Point(16, 14);
        this.Nume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.Nume.Name = "Nume";
        this.Nume.Size = new System.Drawing.Size(99, 40);
        this.Nume.TabIndex = 21;
        this.Nume.Text = "Nume";
        // 
        // abilitatCB
        // 
        this.abilitatCB.Location = new System.Drawing.Point(295, 197);
        this.abilitatCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.abilitatCB.Name = "abilitatCB";
        this.abilitatCB.Size = new System.Drawing.Size(254, 34);
        this.abilitatCB.TabIndex = 30;
        this.abilitatCB.Text = "Abilitat";
        this.abilitatCB.UseVisualStyleBackColor = true;
        // 
        // EditareCP
        // 
        this.AcceptButton = this.btOk;
        this.AllowDrop = true;
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.btCancel;
        this.ClientSize = new System.Drawing.Size(571, 324);
        this.Controls.Add(this.abilitatCB);
        this.Controls.Add(this.btCancel);
        this.Controls.Add(this.btOk);
        this.Controls.Add(this.studii);
        this.Controls.Add(this.dis);
        this.Controls.Add(this.tbNume);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.Nume);
        this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "EditareCP";
        this.Text = "EditareCP";
        this.Load += new System.EventHandler(this.EditareCP_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.CheckBox abilitatCB;
    private System.Windows.Forms.Button btCancel;
    private System.Windows.Forms.Button btOk;
    private System.Windows.Forms.ComboBox studii;
    private System.Windows.Forms.DateTimePicker dis;
    private System.Windows.Forms.TextBox tbNume;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label Nume;

    #endregion
}