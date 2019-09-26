using Model;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ModelTwo_WinFrom_Programmatically
{
    public partial class View : Form
    {
        const int STARTING_X_POSITION = 0;
        const int STARTING_Y_POSITION = 50;
        Warehouse warehouse;
        GameController controller;
        Point cellSize;

        public View()
        {
            InitializeComponent();
        }

        public void InitializeView(Warehouse newWarehouse, GameController newController)
        {
            warehouse = newWarehouse;
            controller = newController;
            ResetView();
        }

        public void ResetView()
        {
            SetCellSize();
            DrawGrid();
            UpdateView();
        }

        public void UpdateView()
        {
            ResetGrid();
            DrawLayout();
            DrawMover();
            DrawBoxes();
            UpdateMoveCount();
        }

        private void ResetGrid()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox box)
                {
                    box.Image = null;
                }
            }
        }

        private void CreateBox(Point newSize, Point newLocation, string newName)
        {
            PictureBox box = new PictureBox
            {
                Size = new Size(newSize),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = newLocation,
                Name = newName
            };
            Controls.Add(box);
        }

        private void DrawGrid()
        {
            int x = STARTING_X_POSITION;
            int y = STARTING_Y_POSITION;
            for (int i = 0; i < warehouse.layout.Length; i++)
            {
                for (int j = 0; j < warehouse.layout[i].Length; j++)
                {
                    string id = "space" + j + i;
                    CreateBox(cellSize, new Point(x, y), id);
                    x += cellSize.X;
                }
                x = STARTING_X_POSITION;
                y += cellSize.Y;
            }
        }

        private void DrawMover()
        {
            string id = "space" + warehouse.mover.pos.X + warehouse.mover.pos.Y;
            PictureBox mover = (PictureBox)Controls.Find(id, true)[0];
            mover.Image = Properties.Resources.player;
        }


        private void DrawBoxes()
        {
            foreach (Box box in warehouse.allMyBoxes)
            {
                string id = "space" + box.pos.X + box.pos.Y;
                PictureBox aBox = (PictureBox)Controls.Find(id, true)[0];
                if (box.isOnTheGoal)
                {
                    aBox.Image = Properties.Resources.boxGoal;
                }
                else
                {
                    aBox.Image = Properties.Resources.box;
                }
            }
        }

        private void DrawLayout()
        {
            for (int i = 0; i < warehouse.layout.Length; i++)
            {
                for (int j = 0; j < warehouse.layout[i].Length; j++)
                {
                    PictureBox box = (PictureBox)Controls.Find("space" + j + i, true)[0];
                    if (warehouse.layout[i][j] == Component.Wall)
                    {
                        box.Image = Properties.Resources.wall;
                    }
                    else if (warehouse.layout[i][j] == Component.Goal || warehouse.layout[i][j] == Component.PlayerGoal || warehouse.layout[i][j] == Component.BoxGoal)
                    {
                        box.Image = Properties.Resources.goal;
                    }
                }
            }
        }

        public void SetWarehouse(Warehouse newWarehouse)
        {
            warehouse = newWarehouse;
        }

        private void SetCellSize()
        {
            int width = ClientSize.Width / warehouse.width;
            int height = (ClientSize.Height - STARTING_Y_POSITION) / warehouse.height;
            cellSize = new Point(width, height);
        }

        private void UpdateMoveCount()
        {
            moves.Text = "Moves : " + warehouse.mover.moveCount;
        }

        private void View_KeyDown(object sender, KeyEventArgs e)
        {
            controller.Move(e.KeyCode);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.SaveGame();
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.LoadGame();
        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.NewGame(new Level().levels[warehouse.warehouseNumber], warehouse.warehouseNumber);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.NewGame(Level.LevelOne(), 0);
            UpdateView();
        }
    }
}
