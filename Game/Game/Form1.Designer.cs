
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
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birdPlayer = new System.Windows.Forms.PictureBox();
            this.tmrMoveBird = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
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
            this.rock1.Location = new System.Drawing.Point(744, 411);
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
            this.rock2.Location = new System.Drawing.Point(762, 422);
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
            this.rock3.Location = new System.Drawing.Point(762, 422);
            this.rock3.Name = "rock3";
            this.rock3.Size = new System.Drawing.Size(40, 29);
            this.rock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock3.TabIndex = 2;
            this.rock3.TabStop = false;
            this.rock3.Visible = false;
            // 
            // tmrMove2
            // 
            this.tmrMove2.Tick += new System.EventHandler(this.tmrMove2_Tick);
            // 
            // tmrMove3
            // 
            this.tmrMove3.Tick += new System.EventHandler(this.tmrMove3_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.endGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.startGameToolStripMenuItem.Text = "Start Game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // endGameToolStripMenuItem
            // 
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
            // 
            // tmrMoveBird
            // 
            this.tmrMoveBird.Enabled = true;
            this.tmrMoveBird.Tick += new System.EventHandler(this.tmrMoveBird_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(725, 60);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 31);
            this.lblScore.TabIndex = 8;
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
            this.picTree1.Location = new System.Drawing.Point(128, 273);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblScore);
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
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox birdPlayer;
        private System.Windows.Forms.Timer tmrMoveBird;
        private System.Windows.Forms.Label lblScore;
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
    }
}

