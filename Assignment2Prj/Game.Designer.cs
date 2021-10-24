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
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).BeginInit();
            this.grpBoxWinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(13, 728);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(70, 25);
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
            this.picBall.Location = new System.Drawing.Point(641, 594);
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
            this.lbHighScore.Location = new System.Drawing.Point(1144, 728);
            this.lbHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(0, 27);
            this.lbHighScore.TabIndex = 5;
            // 
            // grpBoxWinner
            // 
            this.grpBoxWinner.Controls.Add(this.lblWinner2);
            this.grpBoxWinner.Controls.Add(this.lblWinner1);
            this.grpBoxWinner.Controls.Add(this.btnStart);
            this.grpBoxWinner.Controls.Add(this.button1);
            this.grpBoxWinner.Controls.Add(this.pictureBox1);
            this.grpBoxWinner.Enabled = false;
            this.grpBoxWinner.Location = new System.Drawing.Point(542, 168);
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
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Ravie", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(55, 188);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 46);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "restart";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ravie", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(192, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = false;
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
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1301, 766);
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
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

