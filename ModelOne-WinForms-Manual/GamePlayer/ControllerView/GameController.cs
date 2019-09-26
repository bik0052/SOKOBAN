using Model;
using System.Windows.Forms;

namespace ControllerView
{
    public class GameController
    {
        public GameBoard level;
        public View gameView;

        public GameController(GameBoard newLevel, View newView)
        {
            level = newLevel;
            gameView = newView;
            SetGrid();
            UpdateView();
            UpdateMoveCount();
            gameView.SetController(this);
            gameView.ShowDialog();
        }

        private void UpdateMoveCount()
        {
            Label moveCount = (Label)gameView.Controls.Find("moveCount", true)[0];
            moveCount.Text = "Moves : " + level.moveCounts;
        }

        public void SetGrid()
        {
            gameView.grid = new PictureBox[level.currBoard.Length][];
            for (int i = 0; i < gameView.grid.Length; i++)
            {
                gameView.grid[i] = new PictureBox[level.currBoard[i].Length];
                for (int j = 0; j < gameView.grid[i].Length; j++)
                {
                    string id = "space" + i + j;
                    gameView.grid[i][j] = (PictureBox)gameView.Controls.Find(id, true)[0];
                }
            }
        }

        internal void Reset(Actor[][] actor, string levelName)
        {
            LevelLoder loader = new LevelLoder(new GameBoard(), actor);
            loader.Load(levelName);
            level = loader.GetBoard();
            UpdateView();
            UpdateMoveCount();
        }

        private void UpdateView()
        {
            for (int i = 0; i < level.currBoard.Length; i++)
            {
                for (int j = 0; j < level.currBoard[i].Length; j++)
                {
                    switch (level.currBoard[i][j])
                    {
                        case Actor.Player:
                            gameView.grid[i][j].Image = Properties.Resources.Player;
                            break;
                        case Actor.PlayerGoal:
                            gameView.grid[i][j].Image = Properties.Resources.playerGoal;
                            break;
                        case Actor.Wall:
                            gameView.grid[i][j].Image = Properties.Resources.wall;
                            break;
                        case Actor.Box:
                            gameView.grid[i][j].Image = Properties.Resources.box;
                            break;
                        case Actor.BoxGoal:
                            gameView.grid[i][j].Image = Properties.Resources.boxGoal;
                            break;
                        case Actor.Goal:
                            gameView.grid[i][j].Image = Properties.Resources.goal;
                            break;
                        case Actor.Tile:
                            gameView.grid[i][j].Image = null;
                            break;
                    }
                }
            }

        }

        public void KeyDownEvent(Keys newKeyCode)
        {
            Coordinate direction = null;
            switch (newKeyCode)
            {
                case Keys.Left: direction = Direction.LEFT; break;
                case Keys.Right: direction = Direction.RIGHT; break;
                case Keys.Up: direction = Direction.UP; break;
                case Keys.Down: direction = Direction.DOWN; break;
            }
            level.Move(direction);
            UpdateView();
            UpdateMoveCount();
            level.IsGameComplete();
            if (level.boardComplete)
            {
                PlaySound();
                MessageBox.Show("Congradulations !!\nLevel Complete");
                
            }
        }

        private void PlaySound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
            {
                SoundLocation = @"..\..\Resources\\win.wav"
            };
            player.Play();
        }

        public void SaveGame()
        {
            Filer.WriteGame(level);
        }
    }
}
