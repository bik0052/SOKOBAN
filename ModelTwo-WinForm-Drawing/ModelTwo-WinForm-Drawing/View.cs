using Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ModelTwo_WinForm_Drawing
{
    public partial class View : Form
    {
        const int STARTING_X_POSITION = 0;
        const int STARTING_Y_POSITION = 50;
        Warehouse warehouse;
        GameController controller;
        PointF cellSize;
        public Bitmap mover;
        public Bitmap goal;
        public Bitmap box;
        public Bitmap wall;
        public Bitmap boxGoal;

        public View()
        {
            InitializeComponent();
        }

        public void InitializeView(Warehouse newWarehouse, GameController newController)
        {
            warehouse = newWarehouse;
            controller = newController;
            Paint += new PaintEventHandler(ReDraw);
        }

        private void SetImages()
        {
            mover = GenerateBitmap(Properties.Resources.player);
            box = GenerateBitmap(Properties.Resources.box);
            boxGoal = GenerateBitmap(Properties.Resources.boxGoal);
            goal = GenerateBitmap(Properties.Resources.goal);
            wall = GenerateBitmap(Properties.Resources.wall);
        }

        private Bitmap GenerateBitmap(Bitmap image)
        {

            return new Bitmap(image, (int)Math.Ceiling(cellSize.X), (int)Math.Ceiling(cellSize.Y));
        }

        public void SetWarehouse(Warehouse newWarehouse)
        {
            warehouse = newWarehouse;
        }

        private void SetCellSize()
        {
            float width = (float)ClientSize.Width / warehouse.width;
            float height = (float)(ClientSize.Height - STARTING_Y_POSITION) / warehouse.height;
            cellSize = new PointF(width, height);
        }

        private void ReDraw(object sender, PaintEventArgs e)
        {
            SetCellSize();
            SetImages();
            DrawLayout(e.Graphics);
            DrawMover(e.Graphics, warehouse.mover);
            DrawBoxs(e.Graphics);
            UpdateMoveCount();
        }

        private void DrawMover(Graphics canvas, Mover mover)
        {
            canvas.DrawImage(this.mover, mover.pos.X * cellSize.X, mover.pos.Y * cellSize.Y + STARTING_Y_POSITION);
        }

        private void UpdateMoveCount()
        {
            moves.Text = "Moves : " + warehouse.mover.moveCount;
        }

        private void DrawBoxs(Graphics canvas)
        {
            foreach (Box box in warehouse.allMyBoxes)
            {
                Image image = this.box;
                if (box.isOnTheGoal)
                {
                    image = boxGoal;
                }
                canvas.DrawImage(image, box.pos.X * cellSize.X, box.pos.Y * cellSize.Y + STARTING_Y_POSITION);
            }
        }
        private void DrawLayout(Graphics canvas)
        {
            float x = STARTING_X_POSITION;
            float y = STARTING_Y_POSITION;

            for (int i = 0; i < warehouse.layout.Length; i++)
            {
                for (int j = 0; j < warehouse.layout[i].Length; j++)
                {
                    if (warehouse.layout[i][j] == Component.Wall)
                    {
                        canvas.DrawImage(wall, j * cellSize.X, i * cellSize.Y + STARTING_Y_POSITION);
                    }
                    else if (warehouse.layout[i][j] == Component.Goal || warehouse.layout[i][j] == Component.PlayerGoal || warehouse.layout[i][j] == Component.BoxGoal)
                    {
                        canvas.DrawImage(goal, j * cellSize.X, i * cellSize.Y + STARTING_Y_POSITION);
                    }
                    x += cellSize.X;
                }
                x = STARTING_X_POSITION;
                y += cellSize.Y;
            }
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
            Invalidate();
        }
    }
}
