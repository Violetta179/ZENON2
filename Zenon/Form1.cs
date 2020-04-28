using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zenon
{
    public partial class Form1 : Form
    {
        int _Vel1 = 3;
        int _Vel2 = 15;
        int _dt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Int32.TryParse(textBox1.Text, out _Vel1);
            Int32.TryParse(textBox2.Text, out _Vel2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           _dt++;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen1 = new Pen(Color.Blue);
            Pen pen2 = new Pen(Color.Red);
            pictureBox1.Image = bmp;

            graph.DrawRectangle(pen1, 100 + _Vel1 * _dt, 10, 20, 50);
            graph.DrawRectangle(pen2, 0 + _Vel2 * _dt, 50, 20, 60);
            graph.DrawRectangle(pen1, 100 + _Vel1 * _dt, 210, 20, 50);

            if ((100 + _Vel1 * _dt) > (_Vel2 * _dt))
            {
                graph.DrawRectangle(pen2, 0 + _Vel2 * _dt, 250, 20, 60);
            }
            else
            {
                graph.DrawRectangle(pen2, (100 + _Vel1 * _dt) - 2, 250, 20, 60);
            }

            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

