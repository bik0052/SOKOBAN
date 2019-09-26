using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControllerView
{
    public partial class View : Form
    {
        public GameController controller;
        public Bitmap player;
        public Bitmap goal;
        public Bitmap box;
        public Bitmap wall;
        public Bitmap tile;
        public Bitmap playerGoal;
        public Bitmap boxGoal;


        public View()
        {
            //InitializeComponent();
            player = Properties.Resources.Player;
            goal = Properties.Resources.goal;
            box = Properties.Resources.box;
            wall = Properties.Resources.wall;
            wall = new Bitmap(wall, 70, 70);
            tile = Properties.Resources.tile;
            playerGoal = Properties.Resources.playerGoal;
            boxGoal = Properties.Resources.boxGoal;
        }

        public void SetController(GameController newController)
        {
            controller = newController;
        }
    }
}
