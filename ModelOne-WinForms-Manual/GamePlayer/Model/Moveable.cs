using System;

namespace Model
{
    [Serializable]
    public abstract class Moveable : IMoveable
    {
        public Coordinate currPos;
        public Coordinate prevPos;
        public string type;

        public Moveable(Coordinate pos, string newType)
        {
            type = newType;
            currPos = pos;
        }

        public Coordinate NextPos(Coordinate direction)
        {
            return new Coordinate((currPos.posX + direction.posX), (currPos.posY + direction.posY));
        }

        public void MovePos(Coordinate direction)
        {
            currPos.posX += direction.posX;
            currPos.posY += direction.posY;
        }

        public void UpdatePrevPos()
        {
            prevPos = new Coordinate(currPos.posX, currPos.posY);
        }

        override
        public string ToString()
        {
            return "X : " + currPos.posX + " " + "Y : " + currPos.posY;
        }
    }
}
