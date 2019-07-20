using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        List<BouncingBall> bouncingBalls = new List<BouncingBall> { };

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            foreach (BouncingBall ball in bouncingBalls)
            {
                Invalidate(ball.MoveBall(this.ClientSize.Width, this.ClientSize.Height));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddBallBtn_Click(object sender, EventArgs e)
        {
            BouncingBall ball = new BouncingBall(this.ClientSize.Width, this.ClientSize.Height);
            bouncingBalls.Add(ball);
            this.Paint += new PaintEventHandler(ball.PaintBall);
        }
    }
}
