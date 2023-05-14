namespace ManagerDAS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.llAjutor = new System.Windows.Forms.LinkLabel();
            this.btAdaugare = new System.Windows.Forms.Button();
            this.btEditare = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btAfisare = new System.Windows.Forms.Button();
            this.scurtaturiTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(89, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGER PROGRAM \"DEZVOLTAREA ABILITĂȚILOR SOCIALE\"";
            // 
            // llAjutor
            // 
            this.llAjutor.Location = new System.Drawing.Point(588, 9);
            this.llAjutor.Name = "llAjutor";
            this.llAjutor.Size = new System.Drawing.Size(200, 22);
            this.llAjutor.TabIndex = 1;
            this.llAjutor.TabStop = true;
            this.llAjutor.Text = "Stimate Domnule Profesor...";
            this.llAjutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAjutor_LinkClicked);
            // 
            // btAdaugare
            // 
            this.btAdaugare.Location = new System.Drawing.Point(24, 107);
            this.btAdaugare.Name = "btAdaugare";
            this.btAdaugare.Size = new System.Drawing.Size(136, 30);
            this.btAdaugare.TabIndex = 2;
            this.btAdaugare.Text = "Adăugare";
            this.btAdaugare.UseVisualStyleBackColor = true;
            this.btAdaugare.Click += new System.EventHandler(this.btAdaugare_Click);
            // 
            // btEditare
            // 
            this.btEditare.Location = new System.Drawing.Point(399, 107);
            this.btEditare.Name = "btEditare";
            this.btEditare.Size = new System.Drawing.Size(136, 30);
            this.btEditare.TabIndex = 3;
            this.btEditare.Text = "Editare/Ștergere";
            this.btEditare.UseVisualStyleBackColor = true;
            this.btEditare.Click += new System.EventHandler(this.btEditare_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // btAfisare
            // 
            this.btAfisare.Location = new System.Drawing.Point(744, 107);
            this.btAfisare.Name = "btAfisare";
            this.btAfisare.Size = new System.Drawing.Size(136, 30);
            this.btAfisare.TabIndex = 5;
            this.btAfisare.Text = "Afișare";
            this.btAfisare.UseVisualStyleBackColor = true;
            this.btAfisare.Click += new System.EventHandler(this.btAfișare_Click);
            // 
            // scurtaturiTB
            // 
            this.scurtaturiTB.Location = new System.Drawing.Point(24, 168);
            this.scurtaturiTB.Name = "scurtaturiTB";
            this.scurtaturiTB.ReadOnly = true;
            this.scurtaturiTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.scurtaturiTB.Size = new System.Drawing.Size(901, 141);
            this.scurtaturiTB.TabIndex = 7;
            this.scurtaturiTB.Text = resources.GetString("scurtaturiTB.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 320);
            this.Controls.Add(this.scurtaturiTB);
            this.Controls.Add(this.btAfisare);
            this.Controls.Add(this.btEditare);
            this.Controls.Add(this.btAdaugare);
            this.Controls.Add(this.llAjutor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Manager program DAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.RichTextBox scurtaturiTB;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.Button btAfisare;

        private System.Windows.Forms.Button btAdaugare;
        private System.Windows.Forms.Button btEditare;

        private System.Windows.Forms.LinkLabel llAjutor;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}