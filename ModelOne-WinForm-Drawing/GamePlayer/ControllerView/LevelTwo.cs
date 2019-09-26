using Model;
using System.Windows.Forms;

namespace ControllerView
{
    public partial class LevelTwo : View
    {
        public LevelTwo()
        {
            InitializeComponent();
            Paint += new PaintEventHandler(Paint_Canvas);
        }

        private void Paint_Canvas(object sender, PaintEventArgs e)
        {
            controller.UpdateView(e);
        }

        private void LevelTwo_KeyDown(object sender, KeyEventArgs e)
        {
            Invalidate();
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
