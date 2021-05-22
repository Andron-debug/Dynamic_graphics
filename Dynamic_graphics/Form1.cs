using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_graphics
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(System.Drawing.Color.Black, 6);
        int l = 50; //длинна линии
        float angal = 0;//текущий угол
        float v = (float)0.01;// угловая скорость
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            g.Clear(System.Drawing.Color.White);
            g.DrawLine(p, pictureBox1.Width / 2, pictureBox1.Height / 2, l + pictureBox1.Width / 2, l + pictureBox1.Height / 2);
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            Step_timer.Interval = 1;
            Step_timer.Start();
        }

        private void Pause_button_Click(object sender, EventArgs e)
        {
            Step_timer.Stop();
        }

        private void Step_timer_Tick(object sender, EventArgs e)
        {
            g.Clear(System.Drawing.Color.White);
            angal -= v;
            if ((angal >= 6.28) || (angal <= -6.28)) angal = 0;
            g.DrawLine(p, pictureBox1.Width / 2, pictureBox1.Height / 2, l*MathF.Cos(angal)+ pictureBox1.Width / 2, l*MathF.Sin(angal)+ pictureBox1.Height / 2);
        }
    }
}
