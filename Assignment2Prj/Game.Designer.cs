namespace Assignment2Prj
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblScore = new System.Windows.Forms.Label();
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.picBg = new System.Windows.Forms.PictureBox();
            this.lbHighScore = new System.Windows.Forms.Label();
            this.grpBoxWinner = new System.Windows.Forms.GroupBox();
            this.lblWinner2 = new System.Windows.Forms.Label();
            this.lblWinner1 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picLife2 = new System.Windows.Forms.PictureBox();
            this.picLife1 = new System.Windows.Forms.PictureBox();
            this.picLife3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).BeginInit();
            this.grpBoxWinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLife3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblScore.Location = new System.Drawing.Point(13, 728);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(95, 27);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.Transparent;
            this.picPaddle.Image = global::Assignment2Prj.Properties.Resources.paddle;
            this.picPaddle.Location = new System.Drawing.Point(587, 728);
            this.picPaddle.Margin = new System.Windows.Forms.Padding(4);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(139, 37);
            this.picPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPaddle.TabIndex = 2;
            this.picPaddle.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(635, 635);
            this.picBall.Margin = new System.Windows.Forms.Padding(4);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(24, 24);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // picBg
            // 
            this.picBg.Enabled = false;
            this.picBg.Image = ((System.Drawing.Image)(resources.GetObject("picBg.Image")));
            this.picBg.Location = new System.Drawing.Point(0, 0);
            this.picBg.Name = "picBg";
            this.picBg.Size = new System.Drawing.Size(1302, 765);
            this.picBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBg.TabIndex = 4;
            this.picBg.TabStop = false;
            // 
            // lbHighScore
            // 
            this.lbHighScore.AutoSize = true;
            this.lbHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lbHighScore.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighScore.ForeColor = System.Drawing.Color.Yellow;
            this.lbHighScore.Location = new System.Drawing.Point(1046, 697);
            this.lbHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(0, 27);
            this.lbHighScore.TabIndex = 5;
            // 
            // grpBoxWinner
            // 
            this.grpBoxWinner.Controls.Add(this.lblWinner2);
            this.grpBoxWinner.Controls.Add(this.lblWinner1);
            this.grpBoxWinner.Controls.Add(this.btnRestart);
            this.grpBoxWinner.Controls.Add(this.btnQuit);
            this.grpBoxWinner.Controls.Add(this.pictureBox1);
            this.grpBoxWinner.Enabled = false;
            this.grpBoxWinner.Location = new System.Drawing.Point(481, 168);
            this.grpBoxWinner.Name = "grpBoxWinner";
            this.grpBoxWinner.Size = new System.Drawing.Size(351, 291);
            this.grpBoxWinner.TabIndex = 6;
            this.grpBoxWinner.TabStop = false;
            this.grpBoxWinner.Visible = false;
            // 
            // lblWinner2
            // 
            this.lblWinner2.AutoSize = true;
            this.lblWinner2.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblWinner2.Location = new System.Drawing.Point(61, 108);
            this.lblWinner2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinner2.Name = "lblWinner2";
            this.lblWinner2.Size = new System.Drawing.Size(223, 27);
            this.lblWinner2.TabIndex = 13;
            this.lblWinner2.Text = "Chicken Dinner!!";
            // 
            // lblWinner1
            // 
            this.lblWinner1.AutoSize = true;
            this.lblWinner1.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblWinner1.Location = new System.Drawing.Point(61, 79);
            this.lblWinner1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinner1.Name = "lblWinner1";
            this.lblWinner1.Size = new System.Drawing.Size(218, 27);
            this.lblWinner1.TabIndex = 12;
            this.lblWinner1.Text = "Winner Winner ";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.BackgroundImage")));
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Ravie", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(55, 188);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(105, 46);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Ravie", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(192, 188);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(105, 46);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // picLife2
            // 
            this.picLife2.BackColor = System.Drawing.Color.Transparent;
            this.picLife2.Image = ((System.Drawing.Image)(resources.GetObject("picLife2.Image")));
            this.picLife2.Location = new System.Drawing.Point(1241, 697);
            this.picLife2.Name = "picLife2";
            this.picLife2.Size = new System.Drawing.Size(23, 28);
            this.picLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLife2.TabIndex = 9;
            this.picLife2.TabStop = false;
            // 
            // picLife1
            // 
            this.picLife1.BackColor = System.Drawing.Color.Transparent;
            this.picLife1.Image = ((System.Drawing.Image)(resources.GetObject("picLife1.Image")));
            this.picLife1.Location = new System.Drawing.Point(1212, 697);
            this.picLife1.Name = "picLife1";
            this.picLife1.Size = new System.Drawing.Size(23, 28);
            this.picLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLife1.TabIndex = 10;
            this.picLife1.TabStop = false;
            // 
            // picLife3
            // 
            this.picLife3.BackColor = System.Drawing.Color.Transparent;
            this.picLife3.Image = ((System.Drawing.Image)(resources.GetObject("picLife3.Image")));
            this.picLife3.Location = new System.Drawing.Point(1270, 697);
            this.picLife3.Name = "picLife3";
            this.picLife3.Size = new System.Drawing.Size(23, 28);
            this.picLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLife3.TabIndex = 11;
            this.picLife3.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1301, 766);
            this.Controls.Add(this.picLife3);
            this.Controls.Add(this.picLife1);
            this.Controls.Add(this.picLife2);
            this.Controls.Add(this.grpBoxWinner);
            this.Controls.Add(this.lbHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picPaddle);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
            this.Text = "Breakout";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).EndInit();
            this.grpBoxWinner.ResumeLayout(false);
            this.grpBoxWinner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLife3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox picBg;
        private System.Windows.Forms.Label lbHighScore;
        private System.Windows.Forms.GroupBox grpBoxWinner;
        private System.Windows.Forms.Label lblWinner2;
        private System.Windows.Forms.Label lblWinner1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picLife2;
        private System.Windows.Forms.PictureBox picLife1;
        private System.Windows.Forms.PictureBox picLife3;
    }
}

