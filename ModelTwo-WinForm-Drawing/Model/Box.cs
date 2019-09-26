using System.Drawing;

namespace Model
{
    public class Box : Actor
    {
        public bool isOnTheGoal;

        public Box() { }

        public Box(Point newPos, bool isOnTheGoal) : base(newPos)
        {
            this.isOnTheGoal = isOnTheGoal;
        }

        public new void ProcessMove(Point direction, Warehouse warehouse)
        {
            base.ProcessMove(GetNextPos(direction), warehouse);
        }
    }
}
