using Microsoft.VisualBasic;

namespace Eggciting_game
{
    public partial class Form1 : Form
    {
        int change = 0;
        int vel = 10;
        int evel = 5;
        int score = 0;
        int gtime = 0;
        int rtime = 60;
        bool moving = false;
        int streak = 0;
        string lstreak = "0";
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void moveB(object sender, KeyEventArgs e)
        {
            moving = true;
            if (e.KeyCode == Keys.Left)
            {
                change = -1 * vel;
            }
            else if (e.KeyCode == Keys.Right)
            {
                change = vel;
            }
        }

        private void gameTick(object sender, EventArgs e)
        {
            egg.Top += evel;
            if (moving == true) {
                basket.Left += change;
            }
                
            if (egg.Location.Y >= 370 && egg.Location.X > basket.Location.X && egg.Location.X < basket.Location.X + 100)
            {
                score ++;
                evel ++;
                streak++;
                egg.Location = new Point(rnd.Next(50, 760), 12);
            }
            else if (egg.Location.Y > 415)
            {
                evel -= 1;
                egg.Location = new Point(rnd.Next(10, 812), 12);
                if (streak > Convert.ToInt32(lstreak))
                {
                    lstreak = Convert.ToString(streak);
                    streak = 0;
                }
            }
            gtime++;
            if (gtime == 20)
            {
                gtime = 0;
                rtime -= 1;
            }
            label1.Text = "" + score;
            label2.Text = "" + rtime;
            if (rtime == 0)
            {
                gameTimer.Stop();
                if (streak > Convert.ToInt32(lstreak)) {
                    lstreak = Convert.ToString(streak);
                    streak = 0;
                }
                MessageBox.Show("Your score was: " + score + ".\nYour longest streak was: " + lstreak + ".");

            }
            
        }

        private void stopmove(object sender, KeyEventArgs e)
        {
            moving = false;
        }
    }
}