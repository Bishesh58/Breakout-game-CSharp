using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Prj
{
    public partial class Game : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// 

        private Bricks bricks;
        private Ball ball;
        private Paddle paddle;
        private Manager manager;

        private int verticalSpeed;
        private int horizontalSpeed;
        private int bricksRows;
        private int bricksCols;
        private int paddleSpeed;


    

        public Game()
        {
            InitializeComponent();
            //Adjust these numbers 
            this.verticalSpeed = 5;
            this.horizontalSpeed = 5;
            this.bricksRows = 5;
            this.bricksCols = 20;
            this.paddleSpeed = 11;

            //Create objects 
            this.ball = new Ball(picBall, verticalSpeed, horizontalSpeed);
            this.paddle = new Paddle(picPaddle, paddleSpeed);
            this.bricks = new Bricks(bricksRows, bricksCols);

            this.manager = new Manager(bricks, ball, paddle);

        }

        private void Game_Load(object sender, EventArgs e)
        {
            bricks.showBricks(this);
            picBg.Enabled = true;
            picBg.SendToBack();
            
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            ball.moveBall(this, paddle.picPaddle, picLife1, picLife2, 
                picLife3, grpBoxWinner, timer, lblWinner1, lblWinner2);
            paddle.movePaddle();
            lblScore.Text = "Score: " + ball.score.ToString();
            manager.showHighScore(lbHighScore, ball.score);
            manager.gameOver(ball.score, timer, grpBoxWinner);
           
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle.moveLeft();
            }
            if (e.KeyCode == Keys.Right)
            {
                paddle.moveRight(this);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Game f1 = new Game();
            f1.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
