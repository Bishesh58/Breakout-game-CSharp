using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    class Bricks
    {
        /// <summary>
        /// Your Brick class must have following attributes 
        /// Add more attributes if required 
        /// </summary>
        private PictureBox[,] bricks;
        public int rows;
        public int cols;

        public Bricks(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.bricks = new PictureBox[rows, cols];
        }
        //Add methods 
        public void showBricks(Form windowsScreen)
        {
            int bricksHeight = 25;
            int bricksWidth = 50;
             Random rnd = new Random();

            for(int x= 0; x < rows; x++)
            {
                for(int y = 0; y < cols; y++)
                {
                    bricks[x, y] = new PictureBox();
                    bricks[x, y].Width = bricksWidth;
                    bricks[x, y].Height = bricksHeight;
                    bricks[x, y].Top = bricksHeight * x;
                    bricks[x, y].Left = bricksWidth * y;

                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                    bricks[x, y].BackColor = randomColor;
                    bricks[x, y].Tag = "bricks";
                    bricks[x, y].BorderStyle = BorderStyle.Fixed3D;
                    bricks[x, y].BringToFront();
                    windowsScreen.Controls.Add(bricks[x, y]);
                }
            }
        }
        
    }
}
