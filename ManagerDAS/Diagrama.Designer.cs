using System.ComponentModel;

namespace ManagerDAS;

partial class Diagrama
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagrama));
        this.desenator_Diagrama1 = new ManagerDAS.Desenator_Diagrama();
        this.comboBox1 = new System.Windows.Forms.ComboBox();
        this.SuspendLayout();
        // 
        // desenator_Diagrama1
        // 
        this.desenator_Diagrama1.Location = new System.Drawing.Point(19, 14);
        this.desenator_Diagrama1.Name = "desenator_Diagrama1";
        this.desenator_Diagrama1.Size = new System.Drawing.Size(949, 112);
        this.desenator_Diagrama1.TabIndex = 0;
        // 
        // comboBox1
        // 
        this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Location = new System.Drawing.Point(317, 132);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(198, 21);
        this.comboBox1.TabIndex = 1;
        this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
        // 
        // Diagrama
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 800);
        this.Controls.Add(this.comboBox1);
        this.Controls.Add(this.desenator_Diagrama1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "Diagrama";
        this.Text = "Diagramă Programe DAS";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox comboBox1;

    private ManagerDAS.Desenator_Diagrama desenator_Diagrama1;

    #endregion
}