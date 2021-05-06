using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int counter = 0;
        
        
        public Form1()
        {
           
            InitializeComponent();

        }

        private void MoveRock1(int speed)
        {

            if (rock1.Left >= 0)
            {
                rock1.Left += -speed;

            }
            else {
                tmrMove2.Enabled = true;
                rock2.Visible = true;
                rock1.Left = 1020; }
        }
        private void MoveRock2(int speed)
        {
            if (rock2.Left >= 0)
            {
                rock2.Left += -speed;

            }
            else {
                tmrMove3.Enabled = true;
                rock3.Visible = true;
                rock2.Left = 1020; }
        }
        private void MoveRock3(int speed)
        {
            if (rock3.Left >= 0)
            {
                rock3.Left += -speed;

            }
            else { rock3.Left = 1020; }
        }

        private void tmrMove1_Tick(object sender, EventArgs e)
        {
            lblScore.Text = counter++.ToString();

            MoveRock1(15);

        }

        private void tmrMove3_Tick(object sender, EventArgs e)
        {
            MoveRock3(15);
        }

        private void tmrMove2_Tick(object sender, EventArgs e)
        {
            MoveRock2(15);
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            rock1.Location= new Point(762,422);
            rock2.Location= new Point(762, 422);
            rock3.Location= new Point(762, 422);

            rock1.Visible = true;
            birdPlayer.Visible = true;
            tmrMove1.Start();



        }

        private void GameOver()
        {
            rock1.Visible = false;
            rock2.Visible = false;
            rock3.Visible = false;
            birdPlayer.Visible = false;
            tmrMove1.Stop();
            tmrMove2.Stop();
            tmrMove3.Stop();
            counter = 0;
        }
        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameOver();
        }

        private void tmrMoveBird_Tick(object sender, EventArgs e)
        {
            if (birdPlayer.Location.Y <= 399)
            {
                birdPlayer.Top+=2;

            }


            CheckError();
        }

        private void CheckError()
        {
            if (birdPlayer.Bounds.IntersectsWith(rock1.Bounds)|| birdPlayer.Bounds.IntersectsWith(rock2.Bounds)  || birdPlayer.Bounds.IntersectsWith(rock3.Bounds))
            {
                GameOver();
            }
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode==Keys.Space)
            {
                
                birdPlayer.Top -= 40;
            }
          
        }

       
    }
}
