using System;
using System.Windows.Forms;

namespace ModelTwo_WinForm_Drawing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GameController controller = new GameController();
            controller.NewGame(Model.Level.LevelOne(), 0);
            Application.Run(controller.view);
        }
    }
}
