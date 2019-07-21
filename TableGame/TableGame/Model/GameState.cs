using System;

namespace TableGame.Model
{
    class GameState
    {
        private int[] position;
        private Direction forbiddenDirection;
        private string name;
        private int steps;

        public GameState()
        {
            position = new int[2];
            forbiddenDirection = Direction.Left;
            steps = 0;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be at least 1 character long");
                }

                name = value;
            }
        }

        public int Steps
        {
            get
            {
                return steps;
            }
        }

        public void UpdateState(Direction direction, int distance)
        {
            switch (direction)
            {
                case Direction.Up:
                    {
                        setRow(direction, -distance);
                        break;
                    }
                case Direction.Down:
                    {
                        setRow(direction, distance);
                        break;
                    }
                case Direction.Left:
                    {
                        setCol(direction, -distance);
                        break;
                    }
                case Direction.Right:
                    {
                        setCol(direction, distance);
                        break;
                    }
            }
        }

        private void setRow(Direction direction, int distance)
        {
            position[0] += distance;
            forbiddenDirection = DirectionMethods.RevertDirection(direction);
            steps++;
        }

        private void setCol(Direction direction, int distance)
        {
            position[1] += distance;
            forbiddenDirection = DirectionMethods.RevertDirection(direction);
            steps++;
        }
    }
}
