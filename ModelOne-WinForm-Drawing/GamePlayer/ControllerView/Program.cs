using System;
using System.Windows.Forms;
using Model;

namespace ControllerView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //String name = "Level 1";

            //Player player = new Player(new Coordinate(6, 6));

            //Box[] boxes = new Box[] { new Box(new Coordinate(4,2), false), new Box(new Coordinate(4,3), false), new Box(new Coordinate(5,3), false), new Box(new Coordinate(4,5), false) };

            //Coordinate[] goals = new Coordinate[] { new Coordinate(1,5), new Coordinate(2,5), new Coordinate(1,6), new Coordinate(2,6) };

            //GameBoard g = new GameBoard(name, Level.NewLevel(), player, boxes, goals);

            //GameController controller = new GameController(g, new LevelOne());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
