namespace SNAKE_GAME
{
    public class Food
    {
        public Position Location { get; set; }

        public Food(int x, int y)
        {
            Location = new Position(x, y);
        }
    }
}