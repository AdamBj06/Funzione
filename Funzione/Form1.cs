using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funzione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenGraph_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            for (int y = 0; y <= 850; y++)
            {
                g.FillEllipse(Brushes.Black, 425, y, 2, 2);
            }
            for (int x = 0; x <= 850; x++)
            {
                g.FillEllipse(Brushes.Black, x, 425, 3, 3);
            }
        }

        private void GenFunc_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            for (int y = 425; y >= -425; y--)
            {
                for (int x = -425; x <= 425; x++)
                {
                    if (x != 0)
                    {
                        if (y == Convert.ToInt32(100 * Math.Sin(x/50))) //x^3/5000
                        {
                            g.FillEllipse(Brushes.Black, x + 425, -y + 425, 4, 4);
                        }
                    }
                }
            }
        }
        private void CleanGraph_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            for (int y = 0; y <= 850; y+=10)
            {
                for (int x = 0; x <= 850; x+=10)
                {
                    g.FillRectangle(Brushes.White, x, y, 10, 10);
                }
            }
        }
    }
}
/*
if (y == x) //retta
{
    g.FillEllipse(Brushes.Black, x+425, -y + 425, 4, 4);
}

if (y == int.Parse(Function.Text.Substring(0, 1)) * x + int.Parse(Function.Text.Substring(2, 1))) //retta genrlz
{
    g.FillEllipse(Brushes.Black, x+425, -y + 425, 4, 4);
}
*/