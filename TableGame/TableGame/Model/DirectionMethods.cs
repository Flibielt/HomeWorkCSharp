namespace TableGame.Model
{
    class DirectionMethods : IDirectionMethods
    {
        public static Direction RevertDirection(Direction direction)
        {
            if (direction == Direction.Left)
            {
                return Direction.Right;
            }
            else if (direction == Direction.Right)
            {
                return Direction.Left;
            }
            else if (direction == Direction.Up)
            {
                return Direction.Down;
            }
            return Direction.Up;
        }
    }
}
