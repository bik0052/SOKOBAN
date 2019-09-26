using System;

namespace Model
{
    [Serializable]
    public class Coordinate
    {
        public int posX;
        public int posY;

        public Coordinate(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        override
        public string ToString()
        {
            return "X : " + posX + " " + "Y : " + posY;
        }
    }
}
