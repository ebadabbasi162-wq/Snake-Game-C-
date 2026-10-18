
using System;

namespace SNAKE_GAME
{
    public class GameManager
    {
        public Snake PlayerSnake { get; private set; }
        public Food GameFood { get; private set; }
        public int Score { get; private set; }

        private Random random = new Random();

        public GameManager()
        {
            Restart();
        }

        public void AddScore()
        {
            Score += 10;
        }

        public void CreateFood()
        {
            int x = random.Next(0, 29);
            int y = random.Next(0, 19);

            GameFood = new Food(x, y);
        }

        public void Restart()
        {
            PlayerSnake = new Snake();
            Score = 0;
            CreateFood();
        }
    }
}
