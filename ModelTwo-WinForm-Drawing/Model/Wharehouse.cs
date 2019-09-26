using System.Collections.Generic;
using System.Drawing;
namespace Model
{
    public class Warehouse
    {
        public Mover mover;
        public List<Point> allMyGoals;
        public List<Box> allMyBoxes;
        public Component[][] layout;
        public string name;
        public int width;
        public int height;
        public int warehouseNumber;

        public Warehouse()
        {
            allMyBoxes = new List<Box>();
            allMyGoals = new List<Point>();
            warehouseNumber = 0;
        }

        public Component ObstacleAt(Point pos)
        {
            return layout[pos.Y][pos.X];
        }

        public bool CanMoveAt(Point pos)
        {
            return ObstacleAt(pos) != Component.Wall && IsThereABoxAt(pos) == false;
        }

        internal Box GetBoxAt(Point pos)
        {
            Box box = allMyBoxes[0];
            foreach (Box aBox in allMyBoxes)
            {
                if (aBox.pos.X == pos.X && aBox.pos.Y == pos.Y)
                {
                    box = aBox;
                    break;
                }
            }
            return box;
        }

        public bool IsThereABoxAt(Point pos)
        {
            bool result = false;
            foreach (Box aBox in allMyBoxes)
            {
                if (aBox.pos.X == pos.X && aBox.pos.Y == pos.Y)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public void Organise(Point direction)
        {
            mover.ProcessMove(direction, this);
            CheckIfBoxesAreOnTheGoal();
        }

        private void CheckIfBoxesAreOnTheGoal()
        {
            foreach (Box aBox in allMyBoxes)
            {
                foreach (Point aGoal in allMyGoals)
                {
                    if (BoxIsOnTheGoal(aGoal, aBox))
                    {
                        aBox.isOnTheGoal = true;
                        break;
                    }
                    else
                    {
                        aBox.isOnTheGoal = false;
                    }
                }
            }

        }

        public bool AllTheBoxesAreOnTheGoals()
        {
            bool result = true;
            foreach (Box box in allMyBoxes)
            {
                if (box.isOnTheGoal == false)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private bool BoxIsOnTheGoal(Point goal, Box box)
        {
            return goal.X == box.pos.X && goal.Y == box.pos.Y;
        }
    }

    public enum Component
    {
        Player,
        Box,
        Goal,
        Tile,
        Wall,
        BoxGoal,
        PlayerGoal,
        None
    }
}
