using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
       int Vel1=0;
       int Vel2 =0;
       int dt = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt++;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen1 = new Pen(Color.Blue);
            Pen pen2 = new Pen(Color.Red);
            pictureBox1.Image = bmp;

            graph.DrawLine(pen1, 100 + Vel1 * dt, 10, 100 + Vel1 * dt, 50);
            graph.DrawLine(pen2, 0 + Vel2 * dt, 90, 0 + Vel2 * dt, 50);
            graph.DrawLine(pen1, 100 + Vel1 * dt, 210, 100 + Vel1 * dt, 250);

            if ((100 + Vel1 * dt) > (Vel2 * dt))
            {
                graph.DrawLine(pen2, 0 + Vel2 * dt, 290, 0 + Vel2 * dt, 250);
            }
            else
            {
                graph.DrawLine(pen2, (100 + Vel1 * dt) - 2, 290, (100 + Vel1 * dt) - 2, 250);
            }

            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
