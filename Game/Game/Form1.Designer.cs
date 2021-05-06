
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
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birdPlayer)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.birdPlayer);
            this.Controls.Add(this.rock3);
            this.Controls.Add(this.rock2);
            this.Controls.Add(this.rock1);
            this.Controls.Add(this.menuStrip1);
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
    }
}

