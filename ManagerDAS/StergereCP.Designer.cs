using System.ComponentModel;

namespace ManagerDAS;

partial class StergereCP
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
        this.comboBox1 = new System.Windows.Forms.ComboBox();
        this.label1 = new System.Windows.Forms.Label();
        this.listView1 = new System.Windows.Forms.ListView();
        this.SuspendLayout();
        // 
        // comboBox1
        // 
        this.comboBox1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Location = new System.Drawing.Point(234, 23);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(271, 28);
        this.comboBox1.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.label1.Location = new System.Drawing.Point(42, 26);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(186, 23);
        this.label1.TabIndex = 1;
        this.label1.Text = "Nume consilier de căutat";
        // 
        // listView1
        // 
        this.listView1.Location = new System.Drawing.Point(42, 111);
        this.listView1.Name = "listView1";
        this.listView1.Size = new System.Drawing.Size(716, 226);
        this.listView1.TabIndex = 2;
        this.listView1.UseCompatibleStateImageBehavior = false;
        // 
        // StergereCP
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.listView1);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.comboBox1);
        this.Name = "StergereCP";
        this.Text = "StergereCP";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.ListView listView1;

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label1;

    #endregion
}