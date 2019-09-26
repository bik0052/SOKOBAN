using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Model;

namespace ModelTwo_WinFrom_Programmatically
{
    public class FileHandler
    {
        public static void SaveGame(Warehouse warehouse)
        {
            try
            {
                using (var stream = new FileStream("game.xml", FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Warehouse));
                    serializer.Serialize(stream, warehouse);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        internal static Warehouse LoadGame(Warehouse warehouse)
        {
            Warehouse savedGame = null;
            try
            {
                using (var stream = new FileStream("game.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Warehouse));
                    savedGame = (Warehouse)serializer.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return savedGame;
        }
    }
}
