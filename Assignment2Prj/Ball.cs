using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Assignment2Prj
{
    class Ball
    {
        /// <summary>
        /// Your Ball class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private PictureBox picBall;
        private int verticalSpeed, horizontalSpeed;
        private Form gameWindow;
        private Bricks bricks;
        public int score;


        public Ball(PictureBox picBall, int verticalSpeed, int horizontalSpeed)
        {
            this.picBall = picBall;
            this.verticalSpeed = verticalSpeed;
            this.horizontalSpeed = horizontalSpeed;
        }
        //Add methods
        public void moveBall(Form gamewindow, PictureBox paddle)
        {
            picBall.Top += verticalSpeed;
            picBall.Left += horizontalSpeed;

            if (picBall.Bottom > gamewindow.ClientSize.Height || picBall.Top < 0)
            {
                verticalSpeed = -verticalSpeed;
            }
            if (picBall.Right > gamewindow.ClientSize.Width || picBall.Left < 0)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            if (picBall.Bounds.IntersectsWith(paddle.Bounds))
            {
                verticalSpeed = -verticalSpeed;
            }

            foreach(Control x in gamewindow.Controls)
            {
                if(x is PictureBox &&(string)x.Tag == "bricks")
                {
                    if (picBall.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        score += 1;
                        gamewindow.Controls.Remove(x);
                        // x.Visible = false;
                        verticalSpeed = -verticalSpeed;
                    } 
                }
            }
        }
    }
}
