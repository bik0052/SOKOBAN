using System;
using System.Drawing;

namespace Model
{
    public class Mover : Actor
    {
        public int moveCount = 0;

        public Mover() { }

        public Mover(Point newPos) : base(newPos) { }

        public new void ProcessMove(Point direction, Warehouse warehouse)
        {
            Point newPos = GetNextPos(direction);
            if (warehouse.IsThereABoxAt(newPos))
            {
                MoveBox(warehouse.GetBoxAt(newPos), direction, warehouse);
            }
            if (warehouse.CanMoveAt(newPos))
            {
                moveCount++;
            }
            base.ProcessMove(newPos, warehouse);
        }

        private void MoveBox(Box theBox, Point direction, Warehouse wharehouse)
        {
            theBox.ProcessMove(direction, wharehouse);
        }
    }
}
