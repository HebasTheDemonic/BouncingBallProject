using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    class BouncingBall
    {
        int x;
        int y;
        int dx;
        int dy;

        public BouncingBall(int width, int height)
        {
            x = new Random().Next(width-25);
            y = new Random().Next(30,height-25);
            dx = 2;
            dy = 3;
        }

        public void PaintBall(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Red);
            graphics.FillEllipse(brush, x, y, 20, 20);
        }

        public Region MoveBall(int width, int height)
        {
            Rectangle rect = new Rectangle(x-2, y-3, 24, 26);
            Region region = new Region(rect);

            if (x + dx < -1 || x + dx > width - 20)
            {
                dx = -dx;
            }

            if (y + dy < 30 || y + dy > height - 20)
            {
                dy = -dy;
            }

            x += dx;
            y += dy;
            return region;
        }

    }
}
