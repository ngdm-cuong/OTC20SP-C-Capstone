using System.Linq;
using System.Data.Linq.Mapping;
namespace CuttingEdgeInvMgmtSystem
{
    partial class Vanity
    {
        public override string ToString()
        {
            return $"Vanity: {ColorID}| L: {Length}";
        }
    }

    partial class Kitchen
    {
        public override string ToString()
        {
            return $"Kitchen: {ColorID}| L: {Length}";
        }
    }

    partial class BarTop
    {        
        public override string ToString()
        {
            return $"BarTop: {ColorID}| L: {Length}, W: {Width}";
        }
    }
}