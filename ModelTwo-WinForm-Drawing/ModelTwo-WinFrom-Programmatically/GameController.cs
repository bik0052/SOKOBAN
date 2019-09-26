using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace ModelTwo_WinFrom_Programmatically
{
    public class GameController
    {
        public View view;
        Warehouse warehouse;
        WarehouseLoader loader;
        List<Component[][]> levels;

        public GameController()
        {
            levels = new Level().levels;
            view = new View();
            warehouse = new Warehouse();
            loader = new WarehouseLoader();
        }

        public void NewGame(Component[][] newLayOut, int wareNumber)
        {
            warehouse.warehouseNumber = wareNumber;
            loader.Warehouse = warehouse;
            loader.Layout = newLayOut;
            loader.Load();
            view.InitializeView(warehouse, this);
        }

        internal void Move(Keys keyCode)
        {
            switch (keyCode)
            {
                case Keys.Up:
                    warehouse.Organise(Direction.up);
                    break;
                case Keys.Down:
                    warehouse.Organise(Direction.down);
                    break;
                case Keys.Left:
                    warehouse.Organise(Direction.left);
                    break;
                case Keys.Right:
                    warehouse.Organise(Direction.right);
                    break;
            }
            view.UpdateView();
            AndThen();
        }

        private void AndThen()
        {
            if (AllLevelCompleted())
            {
                PlaySound();
                MessageBox.Show("You Win. All the Levels Completed");

            }
            else if (warehouse.AllTheBoxesAreOnTheGoals())
            {
                MessageBox.Show("You Win.");
                NewGame(levels[warehouse.warehouseNumber + 1], warehouse.warehouseNumber + 1);
            }
        }

        private bool AllLevelCompleted()
        {
            return warehouse.AllTheBoxesAreOnTheGoals() && warehouse.warehouseNumber == levels.Count - 1;
        }

        internal void SaveGame()
        {
            FileHandler.SaveGame(warehouse);
        }

        internal void LoadGame()
        {
            warehouse = FileHandler.LoadGame(warehouse);
            view.SetWarehouse(warehouse);
            view.ResetView();
        }

        private void PlaySound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
            {
                SoundLocation = @"..\..\Resources\\win.wav"
            };
            player.Play();
        }
    }
}
