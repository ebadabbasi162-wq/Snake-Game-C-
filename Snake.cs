
using System.Collections.Generic;

namespace SNAKE_GAME
{
    public class Snake
    {
        private List<Position> body;

        public List<Position> Body
        {
            get { return body; }
        }

        public int DirectionX { get; set; }
        public int DirectionY { get; set; }

        public Snake()
        {
            body = new List<Position>();

            body.Add(new Position(5, 5));
            body.Add(new Position(4, 5));
            body.Add(new Position(3, 5));

            DirectionX = 1;
            DirectionY = 0;
        }

        public void Move()
        {
            Position head = body[0];

            Position newHead = new Position(
                head.X + DirectionX,
                head.Y + DirectionY
            );

            body.Insert(0, newHead);
            body.RemoveAt(body.Count - 1);
        }
    }
}
