using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Direction
    {
        public static Coordinate UP = new Coordinate(0,-1);
        public static Coordinate DOWN = new Coordinate(0,1);
        public static Coordinate RIGHT = new Coordinate(1,0);
        public static Coordinate LEFT = new Coordinate(-1,0);
    }
}
