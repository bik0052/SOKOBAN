using System.Drawing;
namespace Model
{
    public class Actor
    {
        public Point pos;

        public Actor() { }

        public Actor(Point newPos)
        {
            pos = newPos;
        }

        protected void ProcessMove(Point newPos, Warehouse warehouse)
        {
            if (warehouse.CanMoveAt(newPos))
            {
                DoMove(newPos);
            }
        }

        protected void DoMove(Point newPos)
        {
            pos = newPos;
        }

        protected Point GetNextPos(Point direction)
        {
            return new Point(pos.X + direction.X, pos.Y + direction.Y);
        }
    }
}
