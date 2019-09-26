using System.Windows.Forms;

namespace ControllerView
{
    public partial class View : Form
    {
        public PictureBox[][] grid;
        public GameController controller;

        //public View()
        //{
        //    InitializeComponent();
        //}

        public void SetController(GameController newController)
        {
            controller = newController;
        }
    }
}
