using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    class Paddle
    {
        /// <summary>
        /// Your Paddle class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        public PictureBox picPaddle;
        public int paddleSpeed;
        private bool start;

        public Paddle(PictureBox picPaddle, int paddleSpeed)
        {
            this.picPaddle = picPaddle;
            this.paddleSpeed = paddleSpeed;
        }
        public void movePaddle()
        {
            start = true;
        }
        public void moveLeft()
        {  
            if(start)
            {
                if (picPaddle.Left > 0)
                {
                    picPaddle.Left -= paddleSpeed;
                }
            }
           
           
        }
        public void moveRight(Form gamewindow)
        {
            if (start)
            {
                if (picPaddle.Right < gamewindow.ClientSize.Width)
                    picPaddle.Left += paddleSpeed;
            }
        }
    }
}
