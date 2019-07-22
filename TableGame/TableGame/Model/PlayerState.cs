using System;

namespace TableGame.Model
{
    class PlayerState
    {
        private int[] position;
        private Direction forbiddenDirection;
        private string name;
        private int steps;

        public PlayerState()
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

        public int GetRow()
        {
            return position[0];
        }

        public int GetCol()
        {
            return position[1];
        }

        public Direction ForbiddenDirection
        {
            get
            {
                return forbiddenDirection;
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
            if (position[0] + distance < 8 && position[0] + distance >= 0)
            {
                position[0] += distance;
                forbiddenDirection = DirectionMethods.RevertDirection(direction);
                steps++;
            }
        }

        private void setCol(Direction direction, int distance)
        {
            if (position[1] + distance < 8 && position[1] + distance >= 0)
            {
                position[1] += distance;
                forbiddenDirection = DirectionMethods.RevertDirection(direction);
                steps++;
            }
        }
    }
}
