using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FootBallGame
{
    public partial class FormGame : Form
    {
        PictureBox player = new PictureBox(); 
        PictureBox Goal = new PictureBox();
        PictureBox plus = new PictureBox();
        GoalShot shot;
        Random rnd = new Random();
        int playerX, pr = 0, pl = 0,sec, score;
        bool space, Shoted;
        System.Windows.Forms.Timer HitCheck = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer addGoal = new System.Windows.Forms.Timer();
        public FormGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame() 
        {
            label5.Visible = false;
            gameOver.Visible = false;
            score = 0;
            scrlbl.Text = Convert.ToString(score);
            Shoted = false;
            sec = 60;
            playerX = 250;
            HitCheck.Tick += new EventHandler(check);
            HitCheck.Interval = 50; 
            addGoal.Tick += new EventHandler(newGoal);
            addGoal.Interval = 2500;
            HitCheck.Start();
            addGoal.Start();
            timer3.Start();
            player.Image = global::FootBallGame.Properties.Resources.Player;
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.SetBounds(playerX, 350, 100, 100);
            Controls.Add(player);
            plus.Image = global::FootBallGame.Properties.Resources.PlusS;
            plus.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Right)
            {
                timer1.Start();
                pr = 1;
                if (playerX < 500) 
                {
                    player.Left += 10;
                    playerX += 10; 
                }
            }
            if (e.KeyCode == Keys.Left) 
            {
                timer2.Start(); 
                pl = 1;
                if (playerX > 0)
                {
                    player.Left -= 10;
                    playerX -= 10;
                }
            }
            if (e.KeyCode == Keys.Space)
                space = true; 

            if (e.KeyCode == Keys.Escape) 
                this.Close();

            if (e.KeyCode == Keys.Enter) 
                StartGame();
        }

        public void FormGame_KeyUp(object sender, KeyEventArgs e) 
        {
            if (pr == 1) 
            {
                timer1.Stop(); 
                pr = 0; 
                player.Image = global::FootBallGame.Properties.Resources.Player;
                player.SizeMode = PictureBoxSizeMode.Zoom;
                player.SetBounds(playerX, 350, 100, 100); 
            }

            if (pl == 1) 
            {
                timer2.Stop();
                pl = 0; 
                player.Image = global::FootBallGame.Properties.Resources.Player;
                player.SizeMode = PictureBoxSizeMode.Zoom;
                player.SetBounds(playerX, 350, 100, 100); 
            }

            if (space == true) 
            {
                Point p = new Point(playerX + 34, 330); 
                shot = new GoalShot(10, p, this); 
                Shoted = true; 
                space = false; 
            }
        }

        private void check(object sender, EventArgs e) 
        {
            if (Shoted == true)
            {
                if (Goal.Bounds.IntersectsWith(shot.getBounds())) 
                {
                    Shoted = false; 
                    Controls.Remove(Goal); 
                    shot.th.Abort(); 
                    Controls.Remove(shot.pic); 
                    plus.SetBounds(Goal.Left, Goal.Top + 5, 50, 50);
                    Controls.Add(plus); 
                    plus.Visible = true; 
                    Goal.SetBounds(0, 0, 50, 50); 
                    scrlbl.Text = Convert.ToString(score += 10); 
                }

                if (shot.pic.Top == 70) 
                { 
                    scrlbl.Text = Convert.ToString(score -= 5); 
                    shot.pic.Top--; 
                }
            }
        }

        private void newGoal(object sender, EventArgs e) 
        {
            plus.Visible = false; 
            Goal.Image = global::FootBallGame.Properties.Resources.FGoal;
            Goal.SizeMode = PictureBoxSizeMode.Zoom;
            Goal.SetBounds(rnd.Next(25, 400), rnd.Next(80, 230), 150, 100); 
            Controls.Add(Goal);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Image = global::FootBallGame.Properties.Resources.RunR;
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.SetBounds(playerX, 350, 100, 100);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            player.Image = global::FootBallGame.Properties.Resources.RunL;
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.SetBounds(playerX, 350, 100, 100);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sec -= 1;
            if (sec == 0)
            {
                timer3.Stop();
                timer2.Stop();
                timer1.Stop();
                HitCheck.Stop();
                addGoal.Stop();
                gameOver.Visible = true;
                label5.Visible = true;
            }
            seclbl.Text = Convert.ToString(sec);
        }
        private void FormGame_FormClosing(object sender, FormClosingEventArgs e) 
        {
            Environment.Exit(1);
        }
    }
}

