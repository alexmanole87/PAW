using System.ComponentModel;

namespace ManagerDAS;

partial class EditareBeneficiar
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditareBeneficiar));
        this.EditBenbtn = new System.Windows.Forms.Button();
        this.EditBenAbd = new System.Windows.Forms.Button();
        this.ModulEbCb = new System.Windows.Forms.ComboBox();
        this.modulEbLabel = new System.Windows.Forms.Label();
        this.MgrCazEbCb = new System.Windows.Forms.ComboBox();
        this.numeEditBenTb = new System.Windows.Forms.TextBox();
        this.MCEbL = new System.Windows.Forms.Label();
        this.numeEbL = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // EditBenbtn
        // 
        this.EditBenbtn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.EditBenbtn.Location = new System.Drawing.Point(240, 197);
        this.EditBenbtn.Name = "EditBenbtn";
        this.EditBenbtn.Size = new System.Drawing.Size(187, 32);
        this.EditBenbtn.TabIndex = 19;
        this.EditBenbtn.Text = "Editare Beneficiar";
        this.EditBenbtn.UseMnemonic = false;
        this.EditBenbtn.UseVisualStyleBackColor = true;
        this.EditBenbtn.Click += new System.EventHandler(this.EditBenbtn_Click);
        // 
        // EditBenAbd
        // 
        this.EditBenAbd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.EditBenAbd.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.EditBenAbd.Location = new System.Drawing.Point(34, 197);
        this.EditBenAbd.Name = "EditBenAbd";
        this.EditBenAbd.Size = new System.Drawing.Size(103, 32);
        this.EditBenAbd.TabIndex = 18;
        this.EditBenAbd.Text = "Abandonare";
        this.EditBenAbd.UseMnemonic = false;
        this.EditBenAbd.UseVisualStyleBackColor = true;
        // 
        // ModulEbCb
        // 
        this.ModulEbCb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.ModulEbCb.FormattingEnabled = true;
        this.ModulEbCb.Items.AddRange(new object[] { "A Face O Critica Constructivă", "Comunicare", "Cum Te Prezinti In Fata Unui Angajator", "Managementul Conflictelor" });
        this.ModulEbCb.Location = new System.Drawing.Point(137, 106);
        this.ModulEbCb.Name = "ModulEbCb";
        this.ModulEbCb.Size = new System.Drawing.Size(290, 28);
        this.ModulEbCb.TabIndex = 16;
        // 
        // modulEbLabel
        // 
        this.modulEbLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.modulEbLabel.Location = new System.Drawing.Point(24, 106);
        this.modulEbLabel.Name = "modulEbLabel";
        this.modulEbLabel.Size = new System.Drawing.Size(64, 37);
        this.modulEbLabel.TabIndex = 15;
        this.modulEbLabel.Text = "Modul";
        // 
        // MgrCazEbCb
        // 
        this.MgrCazEbCb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.MgrCazEbCb.FormattingEnabled = true;
        this.MgrCazEbCb.Location = new System.Drawing.Point(137, 59);
        this.MgrCazEbCb.Name = "MgrCazEbCb";
        this.MgrCazEbCb.Size = new System.Drawing.Size(153, 28);
        this.MgrCazEbCb.TabIndex = 14;
        // 
        // numeEditBenTb
        // 
        this.numeEditBenTb.AcceptsReturn = true;
        this.numeEditBenTb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.numeEditBenTb.Location = new System.Drawing.Point(137, 22);
        this.numeEditBenTb.Name = "numeEditBenTb";
        this.numeEditBenTb.Size = new System.Drawing.Size(290, 25);
        this.numeEditBenTb.TabIndex = 13;
        // 
        // MCEbL
        // 
        this.MCEbL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.MCEbL.Location = new System.Drawing.Point(24, 62);
        this.MCEbL.Name = "MCEbL";
        this.MCEbL.Size = new System.Drawing.Size(97, 37);
        this.MCEbL.TabIndex = 12;
        this.MCEbL.Text = "Manager Caz";
        // 
        // numeEbL
        // 
        this.numeEbL.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.numeEbL.Location = new System.Drawing.Point(24, 19);
        this.numeEbL.Name = "numeEbL";
        this.numeEbL.Size = new System.Drawing.Size(55, 37);
        this.numeEbL.TabIndex = 11;
        this.numeEbL.Text = "Nume";
        // 
        // EditareBeneficiar
        // 
        this.AcceptButton = this.EditBenbtn;
        this.AllowDrop = true;
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(446, 245);
        this.Controls.Add(this.EditBenbtn);
        this.Controls.Add(this.EditBenAbd);
        this.Controls.Add(this.ModulEbCb);
        this.Controls.Add(this.modulEbLabel);
        this.Controls.Add(this.MgrCazEbCb);
        this.Controls.Add(this.numeEditBenTb);
        this.Controls.Add(this.MCEbL);
        this.Controls.Add(this.numeEbL);
        this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "EditareBeneficiar";
        this.Text = "Editare Beneficiar";
        this.Load += new System.EventHandler(this.EditareBeneficiar_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button EditBenbtn;
    private System.Windows.Forms.Button EditBenAbd;
    private System.Windows.Forms.ComboBox ModulEbCb;
    private System.Windows.Forms.Label modulEbLabel;
    private System.Windows.Forms.ComboBox MgrCazEbCb;
    private System.Windows.Forms.TextBox numeEditBenTb;
    private System.Windows.Forms.Label MCEbL;
    private System.Windows.Forms.Label numeEbL;

    #endregion
}