using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql {
    public class WellData {
        public WellData(string wellName, int xCoord, int yCoord, string wellType, double kellyBushing, double totalDepth) {
            WellName = wellName;
            XCoord = xCoord;
            YCoord = yCoord;
            WellType = wellType;
            KellyBushing = kellyBushing;
            TotalDepth = totalDepth;
            RecordDate = DateTime.Now;
        }

        public int Id { get; }
        public string WellName { get; set; }
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public string WellType { get; set; }
        public double KellyBushing { get; set; }
        public double TotalDepth { get; set; }
        public DateTime RecordDate { get;}
    }
}






