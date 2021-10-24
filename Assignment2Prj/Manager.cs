using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    class Manager
    {
        /// <summary>
        /// Your Manager class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private Bricks bricks;
        private Ball ball;
        private Paddle paddle;

        public Manager(Bricks bricks, Ball ball, Paddle paddle)
        {
            this.bricks = bricks;
            this.ball = ball;
            this.paddle = paddle;


        }
        public void showHighScore(Label lb, int score)
        {
            if(score > 10)
            {
                lb.Text = "Nice!!";
            }
            if (score > 50)
            {
                lb.Text = "great!";
            }
            if (score > 70)
            {
                lb.Text = "amazing!!";
            }
            if (score > 90)
            {
                lb.Text = "Killing it!!";
            }
            if (score == 100)
            {
                lb.Text = "Winner!!";
            }
        }

        public void gameOver(int score, Timer timer, GroupBox gBox)
        {
            if(score == 100)
            {
                timer.Stop();
                gBox.Enabled = true;
                gBox.Visible = true;
            }
        }
    }
}
