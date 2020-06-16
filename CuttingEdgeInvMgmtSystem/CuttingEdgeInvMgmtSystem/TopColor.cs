using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingEdgeInvMgmtSystem
{
    /*
         This class is used for storing all the color numbers while the program is running.
     */
    class TopColor
    {
        static List<string> colorNum = new List<string>();
        static List<string> colorID = new List<string>();

        public static List<string> ColorNum
        {
            get => colorNum;

            // In final build this will need to retrieve all colors stored in the colors table on SQL database.
        }

        public static List<string> ColorID
        {
            get => colorID;
        }

        public static void AddColor(string color)
        {
            colorNum.Add(color);

        }
        public static void AddId(string id)
        {
            colorID.Add(id);

        }
    }
}
