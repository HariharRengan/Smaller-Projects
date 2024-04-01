namespace Snake
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int speed = 1;
        int cdirec = 0;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTick(object sender, EventArgs e)
        {
            switch (cdirec) {
                case 0:
                    Snake.Left += speed;
                    break;
                case 1: 
                    Snake.Top += speed;
                    break;
                case 2:
                    Snake.Left -= speed;
                    break;
                case 3:
                    Snake.Top -= speed;
                    break;
                case 4:
                    Snake.Left += speed;
                    break;
            }
            if (Snake.Location.X == apple.Location.X && Snake.Location.Y == apple.Location.Y)
            {
                score++;
                int aX = rnd.Next(20, 780);
                int aY = rnd.Next(20, 450);
                apple.Location = new Point(aX, aY);
                int xs = 30;
                int i = score + 1;
                int ys = 30 * i;
                if (cdirec % 2 == 0)
                {
                    Snake.Size = new Size(ys--, xs--);
                }
                else
                {
                    Snake.Size = new Size(xs--, ys--);
                }
            }
            if (Snake.Location.X == apple.Location.X+1 && Snake.Location.Y+1 == apple.Location.Y)
            {
                score++;
                int aX = rnd.Next(20, 780);
                int aY = rnd.Next(20, 450);
                apple.Location = new Point(aX, aY);
                int xs = 30;
                int i = score + 1;
                int ys = 30 * i;
                if (cdirec % 2 == 0)
                {
                    Snake.Size = new Size(ys--, xs--);
                }
                else
                {
                    Snake.Size = new Size(xs--, ys--);
                }
            }
            if (Snake.Location.X == apple.Location.X-1 && Snake.Location.Y-1 == apple.Location.Y)
            {
                score++;
                int aX = rnd.Next(20, 780);
                int aY = rnd.Next(20, 450);
                apple.Location = new Point(aX, aY);
                int xs = 30;
                int i = score + 1;
                int ys = 30 * i;
                if (cdirec % 2 == 0)
                {
                    Snake.Size = new Size(ys--, xs--);
                }
                else
                {
                    Snake.Size = new Size(xs--, ys--);
                }
            }
            if (Snake.Location.X == apple.Location.X+2 && Snake.Location.Y+2 == apple.Location.Y)
            {
                score++;
                int aX = rnd.Next(20, 780);
                int aY = rnd.Next(20, 450);
                apple.Location = new Point(aX, aY);
                int xs = 30;
                int i = score + 1;
                int ys = 30 * i;
                if (cdirec % 2 == 0)
                {
                    Snake.Size = new Size(ys--, xs--);
                }
                else
                {
                    Snake.Size = new Size(xs--, ys--);
                }
            }
            if (Snake.Location.X == apple.Location.X-2 && Snake.Location.Y-2 == apple.Location.Y)
            {
                score++;
                int aX = rnd.Next(20, 780);
                int aY = rnd.Next(20, 450);
                apple.Location = new Point(aX, aY);
                int xs = 30;
                int i = score + 1;
                int ys = 30 * i;
                if (cdirec % 2 == 0)
                {
                    Snake.Size = new Size(ys--, xs--);
                }
                else
                {
                    Snake.Size = new Size(xs--, ys--);
                }
            }
            if (Snake.Location.X < 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Game over. Your score was "+Convert.ToString(score), "Game over");
            }
            if (Snake.Location.Y < 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Game over. Your score was " + Convert.ToString(score), "Game over");
            }
            if (Snake.Location.X > 822)
            {
                gameTimer.Stop();
                MessageBox.Show("Game over. Your score was " + Convert.ToString(score), "Game over");
            }
            if (Snake.Location.Y > 506)
            {
                gameTimer.Stop();
                MessageBox.Show("Game over. Your score was " + Convert.ToString(score), "Game over");
            }
            
        }

        private void snakedown(object sender, KeyEventArgs e)
        {

        }

        private void snakechange(object sender, KeyEventArgs e)
        {
            int xs = 30;
            int i = score + 1;
            int ys = 30 * i;
            if (cdirec == 4)
            {
                cdirec = 0;
            }

            if (e.KeyCode == Keys.Right)
            { 
                cdirec = 0;
            }
            else if (e.KeyCode == Keys.Left)
            { 
                cdirec = 2;
            }
            else if (e.KeyCode == Keys.Up)
            { 
                cdirec = 3;
            }
            else if (e.KeyCode == Keys.Down)
            { 
                cdirec = 1;
            }
            
            if (cdirec % 2 == 0)
            {
                Snake.Size = new Size(ys--, xs--);
            }
            else
            {
                Snake.Size = new Size(xs--, ys--);
            }
        }
    }
}