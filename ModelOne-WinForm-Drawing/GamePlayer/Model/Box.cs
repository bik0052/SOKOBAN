using System;

namespace Model
{
    [Serializable]
    public class Box : Moveable
    {
        public bool isOnGoal;
        public Box(Coordinate currPos, bool isOnGoal) : base(currPos, "box")
        {
            this.isOnGoal = isOnGoal;
        }
    }
}
