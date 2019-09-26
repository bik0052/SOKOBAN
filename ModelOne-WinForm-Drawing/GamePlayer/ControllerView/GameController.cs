using Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace ControllerView
{
    public class GameController
    {
        GameBoard level;
        View gameView;

        public GameController(GameBoard newLevel, View newView)
        {
            level = newLevel;
            gameView = newView;
            UpdateMoveCount();
            gameView.SetController(this);
            gameView.ShowDialog();
        }

        private void UpdateMoveCount()
        {
            Label moveCount = (Label)gameView.Controls.Find("moveCount", true)[0];
            moveCount.Text = "Moves : " + level.moveCounts;
        }
        internal void Reset(Actor[][] actor, string levelName)
        {
            LevelLoder loader = new LevelLoder(new GameBoard(), actor);
            loader.Load(levelName);
            level = loader.GetBoard();
            gameView.Invalidate();
            UpdateMoveCount();
        }

        public void UpdateView(PaintEventArgs canvas)
        {
            int x = 0;
            int y = 40;
            for (int i = 0; i < level.currBoard.Length; i++)
            {
                for (int j = 0; j < level.currBoard[i].Length; j++)
                {
                    switch (level.currBoard[i][j])
                    {
                        case Actor.Player:
                            canvas.Graphics.DrawImage(gameView.player, x, y);
                            break;
                        case Actor.PlayerGoal:
                            canvas.Graphics.DrawImage(gameView.playerGoal, x, y);
                            break;
                        case Actor.Wall:
                            canvas.Graphics.DrawImage(gameView.wall, x, y);
                            break;
                        case Actor.Box:
                            canvas.Graphics.DrawImage(gameView.box, x, y);
                            break;
                        case Actor.BoxGoal:
                            canvas.Graphics.DrawImage(gameView.boxGoal, x, y);
                            break;
                        case Actor.Goal:
                            canvas.Graphics.DrawImage(gameView.goal, x, y);
                            break;
                        case Actor.Tile:
                            canvas.Graphics.DrawImage(gameView.tile, x, y);
                            break;
                    }
                    x += 70;
                }
                x = 0;
                y += 70;
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
