using System;
using System.Windows.Forms;
using Model;

namespace ControllerView
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            levelSelector.Show();
        }
        private void btn_cancle_Click(object sender, EventArgs e)
        {
            levelSelector.Visible = false;
        }

        private void btn_startGame_Click(object sender, EventArgs e)
        {
            Actor[][] level = null;
            View gameView = null;
            if (levels.Text == "Level One ( 8 X 8 )")
            {
                level = Level.LevelOne();
                gameView = new LevelOne();
            }
            else if (levels.Text == "Level Two ( 8 X 6 )")
            {
                level = Level.LevelTwo();
                gameView = new LevelTwo();
            }
            if (level != null)
            {
                LevelLoder loader = new LevelLoder(new GameBoard(), level);
                loader.Load(levels.Text);
                new GameController(loader.GetBoard(), gameView);
            }

            levelSelector.Hide();
        }

        private void btn_loadGame_Click(object sender, EventArgs e)
        {
            View gameView = null;
            GameBoard board = Filer.RetrieveGame();
            if (board.boardName == "Level One ( 8 X 8 )")
            {
                gameView = new LevelOne();
            }
            else if (levels.Text == "Level Two ( 8 X 6 )")
            {
                gameView = new LevelTwo();
            }
            GameController controller = new GameController(board, gameView);
        }
    }
}
