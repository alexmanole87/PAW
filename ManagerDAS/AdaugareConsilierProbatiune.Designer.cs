using System.ComponentModel;

namespace ManagerDAS
{
    partial class AdaugareConsilierProbatiune
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareConsilierProbatiune));
            this.studii = new System.Windows.Forms.ComboBox();
            this.dis = new System.Windows.Forms.DateTimePicker();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.abilitatCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // studii
            // 
            this.studii.AutoCompleteCustomSource.AddRange(new string[] { "Psihologie", "Asistență Socială", "Drept", "Sociologie" });
            this.studii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studii.FormattingEnabled = true;
            this.studii.Items.AddRange(new object[] { "Psihologie", "Asistență Socială", "Drept", "Sociologie" });
            this.studii.SelectedIndex= 0;
            this.studii.Location = new System.Drawing.Point(223, 92);
            this.studii.Name = "studii";
            this.studii.Size = new System.Drawing.Size(187, 21);
            this.studii.TabIndex = 15;
            // 
            // dis
            // 
            this.dis.AllowDrop = true;
            this.dis.CalendarFont = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dis.Location = new System.Drawing.Point(221, 53);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(189, 20);
            this.dis.TabIndex = 14;
            // 
            // tbNume
            // 
            this.tbNume.AllowDrop = true;
            this.tbNume.Cursor = System.Windows.Forms.Cursors.No;
            this.tbNume.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNume.Location = new System.Drawing.Point(223, 14);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(188, 23);
            this.tbNume.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Abilitat";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Studii";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data Intrării în Sistem\r\n";
            // 
            // Nume
            // 
            this.Nume.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nume.Location = new System.Drawing.Point(12, 9);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(74, 26);
            this.Nume.TabIndex = 9;
            this.Nume.Text = "Nume";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(62, 178);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(121, 21);
            this.btOk.TabIndex = 18;
            this.btOk.Text = "Salvează Consilierul";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(289, 178);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 21);
            this.btCancel.TabIndex = 19;
            this.btCancel.Text = "Abandonare";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // abilitatCB
            // 
            this.abilitatCB.Location = new System.Drawing.Point(236, 130);
            this.abilitatCB.Name = "abilitatCB";
            this.abilitatCB.Size = new System.Drawing.Size(75, 22);
            this.abilitatCB.TabIndex = 20;
            this.abilitatCB.Text = "Abilitat";
            this.abilitatCB.UseVisualStyleBackColor = true;
            // 
            // AdaugareConsilierProbatiune
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(423, 210);
            this.Controls.Add(this.abilitatCB);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.studii);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdaugareConsilierProbatiune";
            this.Text = "Adăugare Consilier Probatiune";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox abilitatCB;

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;

        private System.Windows.Forms.ComboBox studii;
        private System.Windows.Forms.DateTimePicker dis;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nume;

        #endregion
    }
}