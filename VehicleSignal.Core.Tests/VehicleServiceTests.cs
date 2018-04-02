using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicleSignal.Core.Services;
using VehicleSignal.Models;
using Xunit;

namespace VehicleSignal.Core.Tests
{
    public class VehicleServiceTests
    {
        [Fact]
        public void Get_Calling_ReturnData()
        {
            var service = new VehicleService();
            var result = service.Get();
            result.Should().NotBeNullOrEmpty();
        }
    }
}
