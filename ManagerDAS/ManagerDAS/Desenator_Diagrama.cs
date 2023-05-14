using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace ManagerDAS;

public partial class Desenator_Diagrama : UserControl
{
    private readonly string conexiune = "Data Source = ManagerDAS.db";
    private int _count = Diagrama.count;

    public Desenator_Diagrama()
    {
        InitializeComponent();
        Diagrama.CountUpdated += OnCountUpdated;
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        var squareSize = 50;
        var spacing = 10;
        var totalWidth = 12 * squareSize + 11 * spacing;

        MessageBox.Show($@"OnPaint: {_count}");

        for (var i = 0; i < 12; i++)
        {
            var rect = new Rectangle(i * (squareSize + spacing), 0, squareSize, squareSize);
            if (i >=  _count)
                pe.Graphics.FillRectangle(Brushes.Green, rect);
            else
                pe.Graphics.FillRectangle(Brushes.Red, rect);
        }
    }
    
    private void OnCountUpdated(object sender, EventArgs e)
    {
        try
        {
            _count = Diagrama.count;
            Invalidate();
        }
        catch (Exception exception)
        {
            MessageBox.Show("OnCountUpdated: " + exception.Message);
        }
       
    }
}
