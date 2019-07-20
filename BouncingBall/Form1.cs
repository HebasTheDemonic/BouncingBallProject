using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Random rand = new Random();
        int x = 100;
        int y = 150;
        int dx = 2;
        int dy = 3;
        

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(PaintBall);
            this.DoubleBuffered = true;
        }

        private void PaintBall (object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Red);
            graphics.FillEllipse(brush, x, y, 20, 20);
        }

        private void MoveBall()
        {
            if (x + dx < -1 || x + dx > this.ClientSize.Width - 20) dx = -dx;
            if (y + dy < -2 || y + dy > this.ClientSize.Height - 20) dy = -dy;

            x += dx;
            y += dy;
            Invalidate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            MoveBall();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
