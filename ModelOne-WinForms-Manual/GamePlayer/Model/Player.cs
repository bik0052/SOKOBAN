using System;

namespace Model
{
    [Serializable]
    public class Player : Moveable
    {
        public Player(Coordinate currPos) : base(currPos, "player") { }
    }
}
