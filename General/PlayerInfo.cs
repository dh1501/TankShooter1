using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankShooter.General
{
    class PlayerInfo
    {
        public static int level = 1;
        public static int rank = 0;

        public static void ReadPlayerLevel(string file)
        {
            using (StreamReader reader = new StreamReader(Common.path + file))
            {
                string[] token = reader.ReadLine().Split('#');
                PlayerInfo.level = int.Parse(token[0]);
                PlayerInfo.rank = int.Parse(token[1]);
            }
        }

        public static void WritePlayerLevel(string path)
        {
            using (StreamWriter writer = new StreamWriter(Common.path + path))
            {
                writer.WriteLine(PlayerInfo.level + "#" + PlayerInfo.rank);
            }
        }
    }
}
