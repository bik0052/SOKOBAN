using System.Drawing;

namespace Model
{
    public class WarehouseLoader
    {
        public Component[][] Layout { get; set; }
        public Warehouse Warehouse { get; set; }

        public void Load()
        {
            SetBoard();
            SetWidth();
            SetHeight();
            Warehouse.allMyBoxes.Clear();
            Warehouse.allMyGoals.Clear();
            for (int i = 0; i < Layout.Length; i++)
            {
                for (int j = 0; j < Layout[i].Length; j++)
                {
                    switch (Layout[i][j])
                    {
                        case Component.Player:
                            SetMover(new Point(j, i));
                            break;
                        case Component.PlayerGoal:
                            SetMover(new Point(j, i));
                            SetGoal(new Point(j, i));
                            break;
                        case Component.Box:
                            SetBox(new Point(j, i), false);
                            break;
                        case Component.BoxGoal:
                            SetBox(new Point(j, i), true);
                            SetGoal(new Point(j, i));
                            break;
                        case Component.Goal:
                            SetGoal(new Point(j, i));
                            break;
                    }
                }
            }
        }

        private void SetHeight()
        {
            Warehouse.height = Layout.Length;
        }

        private void SetWidth()
        {
            Warehouse.width = Layout[0].Length;
        }

        private void SetBoard()
        {
            Warehouse.layout = Layout;
        }

        private void SetBox(Point position, bool isOnTheGoal)
        {
            Warehouse.allMyBoxes.Add(new Box(position, isOnTheGoal));
        }

        private void SetGoal(Point position)
        {
            Warehouse.allMyGoals.Add(position);
        }

        private void SetMover(Point position)
        {
            Warehouse.mover = new Mover(position);
        }

        public Warehouse GetWarehouse()
        {
            return Warehouse;
        }
    }
}
