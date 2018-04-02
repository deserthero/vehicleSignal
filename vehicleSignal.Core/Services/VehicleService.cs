using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicleSignal.Core.Interfaces.IServices;
using VehicleSignal.Models;

namespace vehicleSignal.Core.Services
{
    public class VehicleService : IVehicleService
    {
        public List<Vehicle> Get()
        {
            return new List<Vehicle>
            {
                new Vehicle
                {
                    Id = 1,
                    CustomerId = 2,
                    VehicleIdentifier = "1",
                    LastSignalTime = DateTime.Now,
                    RegisterNumber = "2",
                    StatusId = 1
                }
            };
        }

        public Vehicle Get(long id)
        {
            throw new NotImplementedException();
        }

        public bool Update(long id)
        {
            throw new NotImplementedException();
        }
    }
}
