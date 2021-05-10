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
        private int counter = 0;
        private PictureBox temp=new PictureBox(); //משתנה עזר שיחזיק את התמונה של הציפור כדי שנוכל לבצע את החלפת התמונות 
        readonly PictureBox[] plants = new PictureBox[6];//מערך של תמונות 

        public Form1()
        {

            InitializeComponent();
            orderArray();//קורא לפונקציה שתשים את הערכים המתאימים במערך שלנו
            temp.Image = (Image)birdPlayer.Image.Clone();

        }

        private void orderArray()// פונקציה ששמה בתאים של המערך את התמונות
        {
            plants[0] = picTree1;
            plants[1] = picTree2;
            plants[2] = picTree3;
            plants[3] = picShrub1;
            plants[4] = picShrub2;
            plants[5] = picShrub3;


        }
        private void MoveRock1(int speed) //אחראי על הזזת התמונה של אחת האבנים
        {

            if (rock1.Left >= 0)//אם הערך השמאלי של התמונה חיובי נמשיך להזיז את התמונה
            {
                rock1.Left += -speed;//מזיז לנו את התמונה שמאלה

            }
            else
            {
                tmrMove2.Enabled = true;//התחלה של הטיימר האחראי על התמונה של האבן השנייה
                rock2.Visible = true;//התמונה של האבן השניה תיראה על המסך
                rock1.Left = 1020;//"איפוס" מיקום התמונה 
            }
        }
        private void MoveRock2(int speed)//אחראי על הזזת התמונה של האבן השנייה , מבצעת אותו הדבר עבור התמונה השניה
        {
            if (rock2.Left >= 0)
            {
                rock2.Left += -speed;

            }
            else
            {
                tmrMove3.Enabled = true;//התחלה של הטיימר של האבן השלישית
                rock3.Visible = true;//תתמונה של האבן השלישית תיראה על המסך
                rock2.Left = 1020;//איפוס 
            }
        }
        private void MoveRock3(int speed)//כנ"ל עבור האבן השלישית
        {
            if (rock3.Left >= 0)
            {
                rock3.Left += -speed;

            }
            else { rock3.Left = 1020; }
        }
        private void tmrMove1_Tick(object sender, EventArgs e)//טיימר האחראי על האבן הראשונה
        {
            lblScore.Text = counter++.ToString();// יראה לנו את הניקוד במהלך המשחק

            MoveRock1(15);//שולח לפונקציה בכמה להזיז


        }
        private void tmrMove2_Tick_1(object sender, EventArgs e)//טיימר האחראי על האבן השניה
        {
            MoveRock2(15);//שולח לפונקציה בכמה להזיז
        }


        private void tmrMove3_Tick_1(object sender, EventArgs e)//טיימר האחראי על האבן השלישית
        {
            MoveRock3(15);//שולח לפונקציה בכמה להזיז
        }
   

        private void GameOver()//פונקציה שקוראים לה כשהמשחק נגמר מפסילה או ממשתמש
        {// העברת התמונות למצב שלא רואים אותם, הפסקת הטיימרים
            rock1.Visible = false;
            rock2.Visible = false;
            rock3.Visible = false;
            birdPlayer.Visible = false;
            tmrMove1.Stop();
            tmrMove2.Stop();
            tmrMove3.Stop();
            tmrPlant.Stop();
          
            lblScore.Visible = false;//הסתרת ליבל של הניקוד שמופיע במהלך המשחק
            lblYourScore.Visible = true;//הצגת תגית של הניקוד הסופי
            lblGameOver.Visible = true;//הצגה של טקסט סיום המשחק
            txtFinalScore.Visible = true;
            txtFinalScore.Text = counter.ToString();//הצגת הניקוד הסופי בתגית
            listView1.Items.Add(counter.ToString());
            counter = 0;//איפוס המונה
        }
        private void endGameToolStripMenuItem_Click(object sender, EventArgs e)//כשיש לחיצה יזומה מהמשתמש, המשחק יסתיים
        {
            GameOver();//קורא לפונקציה שמסיימת את המשחק
        }

        private void tmrMoveBird_Tick(object sender, EventArgs e)//טיימר האחראי על השחקן 
        {
            if (birdPlayer.Location.Y <= 399)//בודק שאין חריגה והציפור תצא מהפריים
            {
                birdPlayer.Top += 10;// מוריד את התמונה של הציפור כלפיי מטה
            }


            CheckError();//בודק אם השחקן נתקע במכשול
        }

        private void CheckError()//פונקציה שתבדוק האם השחקן נתקל באחת מהאבנים
        {   
            if (birdPlayer.Bounds.IntersectsWith(rock1.Bounds) || birdPlayer.Bounds.IntersectsWith(rock2.Bounds) || birdPlayer.Bounds.IntersectsWith(rock3.Bounds))
            { //אם השחקן נתקל באחת מהאבנים נקרא לפונקציה שמסיימת את המשחק
                GameOver();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//כשיש לחיצה על מקש כלשהו במקלדת 
        {

            if (e.KeyCode == Keys.A)//בודק אם המקש הזה הוא רווח
            {
                if (!birdPlayer.Bounds.IntersectsWith(lblLimit.Bounds))//מגביל את הגובה שאליו השחקן יכול לקפוץ
                {
                    birdPlayer.Top -= 30;//גורם לתמונה של הציפור לעלות כלפי מעלה

                }

            }

        }
        private void tmrPlant_Tick(object sender, EventArgs e)//טיימר של הצמחים
        {
            //עובר על המערך של הצמחים 
            for (int i = 0; i < plants.Length; i++)
            {
                plants[i].Left -= 10;//מזיז את הצח שמאלה
                if (plants[i].Left >= 0)//בדיקה אם הערך השמאלי של הצמח חיובי
                {
                    plants[i].Left += -10;//מזיז שמאלה את התמונה של הצמח
                }
                else
                {
                    plants[i].Left = 1020;//איפוס מיקום התמונה של הצמח
                }
            }

        }

        private void birdPlayer_Click(object sender, EventArgs e)//כשלוחצים על הדמות
        {
           
            birdPlayer.Image = (Image)BunnyPlayer.Image.Clone();//מבצע העתקה של דמות אחת לאחרת

        }

        private void birdPlayer_MouseDoubleClick(object sender, MouseEventArgs e)//כשלוחצים פעמיים על הדמות
        {
            birdPlayer.Image = (Image)temp.Image.Clone();//מבצע העתקה של דמות אחת לאחרת
        }

      
       
        private void lblStartGame_MouseHover(object sender, EventArgs e)//כשהסמן של העכבר מעל התגית 
        {
            lblStartGame.BackColor = Color.Green;//ישנה את הצבע של התגית לירוק 
        }

        private void lblStartGame_MouseLeave(object sender, EventArgs e)//כשהסמן לא מעל התגית
        {
            lblStartGame.BackColor = Color.LightGreen; //ישנה את הצבע של התגית לירוק בהיר

        }

        private void lblStartGame_Click(object sender, EventArgs e)//תגית שמתחילה את המשחק
        {
            lblScore.Visible = true;
            txtFinalScore.Visible = false;
            lblYourScore.Visible = false;
            lblGameOver.Visible = false;
            //איפוס התמונות של האבנים, ממקמים אותם מההתחלה
            rock1.Location = new Point(762, 422);
            rock2.Location = new Point(762, 422);
            rock3.Location = new Point(762, 422);
            //אבן ראשונה תיראה והשמות של השחקן
            rock1.Visible = true;
            birdPlayer.Visible = true;
            //הצמחים יופיעו על המסך
            for (int i = 0; i < plants.Length; i++)
            {
                plants[i].Visible = true;
            }
            //התחלה של טיימר של האבן הראשונה וטיימר של הצמחים
            tmrMove1.Start();
            tmrPlant.Start();
        }

       

       
    }
}