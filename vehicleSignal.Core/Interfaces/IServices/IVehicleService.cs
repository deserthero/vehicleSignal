using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleSignal.Models;

namespace vehicleSignal.Core.Interfaces.IServices
{
    public interface IVehicleService
    {
        Vehicle Get(long id);

        List<Vehicle> Get();

        List<Vehicle> GetVehiclesByCustomerId(long customerId);

        bool Update(long id);


    }
}
