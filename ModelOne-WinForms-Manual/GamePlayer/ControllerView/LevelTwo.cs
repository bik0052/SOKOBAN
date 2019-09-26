using Model;
using System.Windows.Forms;

namespace ControllerView
{
    public partial class LevelTwo : View
    {
        public LevelTwo()
        {
            InitializeComponent();
        }

        private void LevelTwo_KeyDown(object sender, KeyEventArgs e)
        {
            controller.KeyDownEvent(e.KeyCode);
        }

        private void saveGameToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            controller.SaveGame();
        }

        private void resetLevelToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            controller.Reset(Level.LevelTwo(), "Level Two ( 8 X 6 )");
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
