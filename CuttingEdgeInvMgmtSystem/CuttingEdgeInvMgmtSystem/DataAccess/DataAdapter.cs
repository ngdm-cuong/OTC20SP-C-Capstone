using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingEdgeInvMgmtSystem.DataAccess
{
    class DataAdapter
    {

       public static dbCounterTopsDataContext dbContext = new dbCounterTopsDataContext();

        public static string GetColor(int colorID)
        {
            Color color = dbContext.Colors.FirstOrDefault(o => o.ColorID.Equals(colorID));

            return color.Color1;
        }
    }
}
