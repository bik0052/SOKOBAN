using Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ControllerView
{
    public static class Filer
    {
        public static void WriteGame(GameBoard board)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream("savedGame.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (stream)
                {
                    formatter.Serialize(stream, board);
                }
                MessageBox.Show("Game Saved");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            stream.Close();
        }

        public static GameBoard RetrieveGame()
        {
            GameBoard board = null;
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream("savedGame.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (stream)
                {
                    board = (GameBoard)formatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            stream.Close();
            return board;
        }
    }
}
