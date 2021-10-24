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
        public int lifeCount = 0;
       

        public Ball(PictureBox picBall, int verticalSpeed, int horizontalSpeed)
        {
            this.picBall = picBall;
            this.verticalSpeed = verticalSpeed;
            this.horizontalSpeed = horizontalSpeed;
            
        }
        //Add methods
        public void moveBall(Form gamewindow, PictureBox paddle, PictureBox life1, PictureBox life2, 
            PictureBox life3, GroupBox grpBox, Timer timer, Label lb1, Label lb2)
        {
            picBall.Top += verticalSpeed;
            picBall.Left += horizontalSpeed;

            if (picBall.Top < 0)
            {
                verticalSpeed = -verticalSpeed;
            }
            if (picBall.Right > gamewindow.ClientSize.Width || picBall.Left < 0)
            {
                horizontalSpeed = -horizontalSpeed;
            }
            if(picBall.Bottom > gamewindow.ClientSize.Height)
            {
                lifeCount += 1;
                picBall.Location = new Point(410, 550);
                paddle.Location = new Point(400, 593);
               
                if (lifeCount == 1)
                {
                    life1.Visible = false;
                }
                if (lifeCount == 2)
                {
                    life2.Visible = false;
                }
                if (lifeCount == 3)
                {
                    life3.Visible = false;
                    timer.Stop();
                    grpBox.Enabled = true;
                    grpBox.Visible = true;
                    lb1.Text = "Oops!!";
                    lb2.Text = "Try harder..!";
                    
                }

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
