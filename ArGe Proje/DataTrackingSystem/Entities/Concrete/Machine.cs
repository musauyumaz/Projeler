using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Machine
    {
        public int Id { get; set; }
        public string MachineName { get; set; }
        public double Voltage { get; set; }
        public double Frequency { get; set; }
        public double Power { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
    }
}
