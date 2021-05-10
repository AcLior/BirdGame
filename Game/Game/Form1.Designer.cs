
namespace Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrMove1 = new System.Windows.Forms.Timer(this.components);
            this.rock1 = new System.Windows.Forms.PictureBox();
            this.rock2 = new System.Windows.Forms.PictureBox();
            this.rock3 = new System.Windows.Forms.PictureBox();
            this.tmrMove2 = new System.Windows.Forms.Timer(this.components);
            this.tmrMove3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birdPlayer = new System.Windows.Forms.PictureBox();
            this.tmrMoveBird = new System.Windows.Forms.Timer(this.components);
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.picTree1 = new System.Windows.Forms.PictureBox();
            this.picTree2 = new System.Windows.Forms.PictureBox();
            this.picShrub1 = new System.Windows.Forms.PictureBox();
            this.picTree3 = new System.Windows.Forms.PictureBox();
            this.picShrub2 = new System.Windows.Forms.PictureBox();
            this.picShrub3 = new System.Windows.Forms.PictureBox();
            this.tmrPlant = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.BunnyPlayer = new System.Windows.Forms.PictureBox();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.txtFinalScore = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblScoreBoard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birdPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShrub1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShrub2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShrub3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunnyPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMove1
            // 
            this.tmrMove1.Tick += new System.EventHandler(this.tmrMove1_Tick);
            // 
            // rock1
            // 
            this.rock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rock1.Image = ((System.Drawing.Image)(resources.GetObject("rock1.Image")));
            this.rock1.Location = new System.Drawing.Point(742, 411);
            this.rock1.Name = "rock1";
            this.rock1.Size = new System.Drawing.Size(58, 40);
            this.rock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock1.TabIndex = 0;
            this.rock1.TabStop = false;
            this.rock1.Visible = false;
            // 
            // rock2
            // 
            this.rock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rock2.Image = ((System.Drawing.Image)(resources.GetObject("rock2.Image")));
            this.rock2.Location = new System.Drawing.Point(760, 422);
            this.rock2.Name = "rock2";
            this.rock2.Size = new System.Drawing.Size(40, 29);
            this.rock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock2.TabIndex = 1;
            this.rock2.TabStop = false;
            this.rock2.Visible = false;
            // 
            // rock3
            // 
            this.rock3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rock3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rock3.Image = ((System.Drawing.Image)(resources.GetObject("rock3.Image")));
            this.rock3.Location = new System.Drawing.Point(760, 422);
            this.rock3.Name = "rock3";
            this.rock3.Size = new System.Drawing.Size(40, 29);
            this.rock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock3.TabIndex = 2;
            this.rock3.TabStop = false;
            this.rock3.Visible = false;
            // 
            // tmrMove2
            // 
            this.tmrMove2.Tick += new System.EventHandler(this.tmrMove2_Tick_1);
            // 
            // tmrMove3
            // 
            this.tmrMove3.Tick += new System.EventHandler(this.tmrMove3_Tick_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.endGameToolStripMenuItem.Text = "End Game";
            this.endGameToolStripMenuItem.Click += new System.EventHandler(this.endGameToolStripMenuItem_Click);
            // 
            // birdPlayer
            // 
            this.birdPlayer.Image = ((System.Drawing.Image)(resources.GetObject("birdPlayer.Image")));
            this.birdPlayer.Location = new System.Drawing.Point(0, 399);
            this.birdPlayer.Name = "birdPlayer";
            this.birdPlayer.Size = new System.Drawing.Size(62, 52);
            this.birdPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.birdPlayer.TabIndex = 7;
            this.birdPlayer.TabStop = false;
            this.birdPlayer.Visible = false;
            this.birdPlayer.Click += new System.EventHandler(this.birdPlayer_Click);
            this.birdPlayer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.birdPlayer_MouseDoubleClick);
            // 
            // tmrMoveBird
            // 
            this.tmrMoveBird.Enabled = true;
            this.tmrMoveBird.Tick += new System.EventHandler(this.tmrMoveBird_Tick);
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(12, 345);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(0, 13);
            this.lblLimit.TabIndex = 9;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblGameOver.Location = new System.Drawing.Point(200, 116);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(387, 76);
            this.lblGameOver.TabIndex = 10;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScore.Location = new System.Drawing.Point(251, 220);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(129, 25);
            this.lblYourScore.TabIndex = 11;
            this.lblYourScore.Text = "Your score: ";
            this.lblYourScore.Visible = false;
            // 
            // picTree1
            // 
            this.picTree1.Image = ((System.Drawing.Image)(resources.GetObject("picTree1.Image")));
            this.picTree1.Location = new System.Drawing.Point(0, 328);
            this.picTree1.Name = "picTree1";
            this.picTree1.Size = new System.Drawing.Size(112, 107);
            this.picTree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTree1.TabIndex = 12;
            this.picTree1.TabStop = false;
            this.picTree1.Visible = false;
            // 
            // picTree2
            // 
            this.picTree2.Image = ((System.Drawing.Image)(resources.GetObject("picTree2.Image")));
            this.picTree2.Location = new System.Drawing.Point(387, 353);
            this.picTree2.Name = "picTree2";
            this.picTree2.Size = new System.Drawing.Size(93, 93);
            this.picTree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTree2.TabIndex = 13;
            this.picTree2.TabStop = false;
            this.picTree2.Visible = false;
            // 
            // picShrub1
            // 
            this.picShrub1.Image = ((System.Drawing.Image)(resources.GetObject("picShrub1.Image")));
            this.picShrub1.Location = new System.Drawing.Point(148, 422);
            this.picShrub1.Name = "picShrub1";
            this.picShrub1.Size = new System.Drawing.Size(92, 24);
            this.picShrub1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShrub1.TabIndex = 14;
            this.picShrub1.TabStop = false;
            this.picShrub1.Visible = false;
            // 
            // picTree3
            // 
            this.picTree3.Image = ((System.Drawing.Image)(resources.GetObject("picTree3.Image")));
            this.picTree3.Location = new System.Drawing.Point(692, 345);
            this.picTree3.Name = "picTree3";
            this.picTree3.Size = new System.Drawing.Size(96, 93);
            this.picTree3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTree3.TabIndex = 15;
            this.picTree3.TabStop = false;
            this.picTree3.Visible = false;
            // 
            // picShrub2
            // 
            this.picShrub2.Image = ((System.Drawing.Image)(resources.GetObject("picShrub2.Image")));
            this.picShrub2.Location = new System.Drawing.Point(273, 411);
            this.picShrub2.Name = "picShrub2";
            this.picShrub2.Size = new System.Drawing.Size(92, 24);
            this.picShrub2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShrub2.TabIndex = 16;
            this.picShrub2.TabStop = false;
            this.picShrub2.Visible = false;
            // 
            // picShrub3
            // 
            this.picShrub3.Image = ((System.Drawing.Image)(resources.GetObject("picShrub3.Image")));
            this.picShrub3.Location = new System.Drawing.Point(506, 422);
            this.picShrub3.Name = "picShrub3";
            this.picShrub3.Size = new System.Drawing.Size(92, 24);
            this.picShrub3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShrub3.TabIndex = 17;
            this.picShrub3.TabStop = false;
            this.picShrub3.Visible = false;
            // 
            // tmrPlant
            // 
            this.tmrPlant.Interval = 200;
            this.tmrPlant.Tick += new System.EventHandler(this.tmrPlant_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(711, 59);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 25);
            this.lblScore.TabIndex = 18;
            // 
            // BunnyPlayer
            // 
            this.BunnyPlayer.Image = ((System.Drawing.Image)(resources.GetObject("BunnyPlayer.Image")));
            this.BunnyPlayer.Location = new System.Drawing.Point(0, 399);
            this.BunnyPlayer.Name = "BunnyPlayer";
            this.BunnyPlayer.Size = new System.Drawing.Size(62, 52);
            this.BunnyPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BunnyPlayer.TabIndex = 20;
            this.BunnyPlayer.TabStop = false;
            this.BunnyPlayer.Visible = false;
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.Location = new System.Drawing.Point(85, 6);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(80, 17);
            this.lblStartGame.TabIndex = 22;
            this.lblStartGame.Text = "Start Game";
            this.lblStartGame.Click += new System.EventHandler(this.lblStartGame_Click);
            this.lblStartGame.MouseLeave += new System.EventHandler(this.lblStartGame_MouseLeave);
            this.lblStartGame.MouseHover += new System.EventHandler(this.lblStartGame_MouseHover);
            // 
            // txtFinalScore
            // 
            this.txtFinalScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtFinalScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalScore.Location = new System.Drawing.Point(387, 220);
            this.txtFinalScore.Name = "txtFinalScore";
            this.txtFinalScore.Size = new System.Drawing.Size(100, 23);
            this.txtFinalScore.TabIndex = 24;
            this.txtFinalScore.Visible = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(61, 77);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblScoreBoard
            // 
            this.lblScoreBoard.AutoSize = true;
            this.lblScoreBoard.Location = new System.Drawing.Point(12, 40);
            this.lblScoreBoard.Name = "lblScoreBoard";
            this.lblScoreBoard.Size = new System.Drawing.Size(65, 13);
            this.lblScoreBoard.TabIndex = 26;
            this.lblScoreBoard.Text = "Scoreboard:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScoreBoard);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtFinalScore);
            this.Controls.Add(this.lblStartGame);
            this.Controls.Add(this.BunnyPlayer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.birdPlayer);
            this.Controls.Add(this.rock3);
            this.Controls.Add(this.rock2);
            this.Controls.Add(this.rock1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picTree1);
            this.Controls.Add(this.picShrub1);
            this.Controls.Add(this.picShrub2);
            this.Controls.Add(this.picTree2);
            this.Controls.Add(this.picShrub3);
            this.Controls.Add(this.picTree3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birdPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShrub1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTree3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShrub2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShrub3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BunnyPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMove1;
        private System.Windows.Forms.PictureBox rock1;
        private System.Windows.Forms.PictureBox rock2;
        private System.Windows.Forms.PictureBox rock3;
        private System.Windows.Forms.Timer tmrMove2;
        private System.Windows.Forms.Timer tmrMove3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox birdPlayer;
        private System.Windows.Forms.Timer tmrMoveBird;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.PictureBox picTree1;
        private System.Windows.Forms.PictureBox picTree2;
        private System.Windows.Forms.PictureBox picShrub1;
        private System.Windows.Forms.PictureBox picTree3;
        private System.Windows.Forms.PictureBox picShrub2;
        private System.Windows.Forms.PictureBox picShrub3;
        private System.Windows.Forms.Timer tmrPlant;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox BunnyPlayer;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.TextBox txtFinalScore;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblScoreBoard;
    }
}

