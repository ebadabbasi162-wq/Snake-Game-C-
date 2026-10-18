
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SNAKE_GAME
{
    public partial class Form1 : Form
    {
        private GameManager game;
        private System.Windows.Forms.Timer gameTimer;
        private bool isPaused = false;
        private bool gameOver = false;
        private const int CellSize = 20;

        public Form1()
        {
            InitializeComponent();

            panel1.TabStop = true;

            game = new GameManager();

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 200;
            gameTimer.Tick += GameTimer_Tick;

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            panel1.Paint += panel1_Paint;

            btnStart.Click += btnStart_Click;
            btnPause.Click += btnPause_Click;
            btnRestart.Click += btnRestart_Click;
            btnExit.Click += btnExit_Click;

            label2.Text = "Score: 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < game.PlayerSnake.Body.Count; i++)
            {
                Position part = game.PlayerSnake.Body[i];

                Brush snakeColor = i == 0
                    ? Brushes.Cyan
                    : Brushes.LawnGreen;

                e.Graphics.FillRectangle(
                    snakeColor,
                    part.X * CellSize,
                    part.Y * CellSize,
                    CellSize - 2,
                    CellSize - 2
                );
            }

            Position head = game.PlayerSnake.Body[0];

            e.Graphics.FillEllipse(
                Brushes.Black,
                head.X * CellSize + 4,
                head.Y * CellSize + 4,
                4,
                4
            );

            e.Graphics.FillEllipse(
                Brushes.Black,
                head.X * CellSize + 12,
                head.Y * CellSize + 4,
                4,
                4
            );

            Position food = game.GameFood.Location;

            e.Graphics.FillEllipse(
                Brushes.OrangeRed,
                food.X * CellSize,
                food.Y * CellSize,
                CellSize - 2,
                CellSize - 2
            );

            if (gameOver)
            {
                e.Graphics.DrawString(
                    "GAME OVER!",
                    new Font("Arial", 20, FontStyle.Bold),
                    Brushes.White,
                    150,
                    150
                );
            }
            else if (isPaused)
            {
                e.Graphics.DrawString(
                    "PAUSED",
                    new Font("Arial", 20, FontStyle.Bold),
                    Brushes.White,
                    180,
                    150
                );
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (gameOver)
                return;

            isPaused = false;
            SetDifficulty();
            gameTimer.Start();

            panel1.Focus();
            panel1.Invalidate();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (gameOver)
                return;

            isPaused = !isPaused;

            if (isPaused)
                gameTimer.Stop();
            else
                gameTimer.Start();

            panel1.Invalidate();
            panel1.Focus();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();

            game.Restart();

            isPaused = false;
            gameOver = false;

            SetDifficulty();

            label2.Text = "Score: 0";
            panel1.Invalidate();
            panel1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDifficulty()
        {
            if (cmbDifficuilty.Text == "Easy")
                gameTimer.Interval = 300;
            else if (cmbDifficuilty.Text == "Medium")
                gameTimer.Interval = 200;
            else if (cmbDifficuilty.Text == "Hard")
                gameTimer.Interval = 100;
            else
                gameTimer.Interval = 200;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            game.PlayerSnake.Move();

            Position head = game.PlayerSnake.Body[0];

            int maxX = panel1.ClientSize.Width / CellSize;
            int maxY = panel1.ClientSize.Height / CellSize;

            if (head.X < 0 || head.Y < 0 ||
                head.X >= maxX || head.Y >= maxY)
            {
                EndGame();
                return;
            }

            for (int i = 1; i < game.PlayerSnake.Body.Count; i++)
            {
                if (head.X == game.PlayerSnake.Body[i].X &&
                    head.Y == game.PlayerSnake.Body[i].Y)
                {
                    EndGame();
                    return;
                }
            }

            if (head.X == game.GameFood.Location.X &&
                head.Y == game.GameFood.Location.Y)
            {
                Position tail = game.PlayerSnake.Body[
                    game.PlayerSnake.Body.Count - 1];

                game.PlayerSnake.Body.Add(
                    new Position(tail.X, tail.Y)
                );

                game.AddScore();
                game.CreateFood();

                label2.Text = "Score: " + game.Score;
            }

            panel1.Invalidate();
        }

        private void EndGame()
        {
            gameTimer.Stop();
            gameOver = true;
            panel1.Invalidate();

            MessageBox.Show(
                "Game Over! Final Score: " + game.Score,
                "Snake Game"
            );
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                game.PlayerSnake.DirectionX = 0;
                game.PlayerSnake.DirectionY = -1;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                game.PlayerSnake.DirectionX = 0;
                game.PlayerSnake.DirectionY = 1;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                game.PlayerSnake.DirectionX = -1;
                game.PlayerSnake.DirectionY = 0;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                game.PlayerSnake.DirectionX = 1;
                game.PlayerSnake.DirectionY = 0;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
