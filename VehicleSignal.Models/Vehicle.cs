using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSignal.Models
{
    public class Vehicle
    {
        public long Id { get; set; }
        public string VehicleIdentifier { get; set; }
        public string RegisterNumber { get; set; }
        public long CustomerId { get; set; }
        public DateTime LastSignalTime { get; set; }
        public long StatusId { get; set; }
    }
}
