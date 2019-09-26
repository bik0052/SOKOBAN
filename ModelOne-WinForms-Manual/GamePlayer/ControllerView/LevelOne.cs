using Model;
using System.Windows.Forms;

namespace ControllerView
{
    public partial class LevelOne : View
    {
        public LevelOne()
        {
            InitializeComponent();
        }

        private void LevelOne_KeyDown(object sender, KeyEventArgs e)
        {
            controller.KeyDownEvent(e.KeyCode);
        }

        private void saveGameToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            controller.SaveGame();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void resetLevelToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            controller.Reset(Level.LevelOne(), "Level One ( 8 X 8 )");
        }
    }
}
