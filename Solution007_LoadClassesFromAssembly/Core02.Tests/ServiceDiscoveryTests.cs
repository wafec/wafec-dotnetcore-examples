using System;
using Xunit;
using System.Linq;
using Core01;

namespace Core02.Tests
{
    public class ServiceDiscoveryTests
    {
        [Fact]
        public void GetClassNames_ShouldReturnCarAndDoctorServices()
        {
            var serviceDiscovery = new ServiceDiscovery();

            var classNames = serviceDiscovery.GetClassNames("Core01");

            Assert.Equal(2, classNames.Count());
            var sorted = classNames.OrderBy(s => s);
            Assert.Equal("Core01.CarService", sorted.Skip(0).First());
            Assert.Equal("Core01.DoctorService", sorted.Skip(1).First());
        }

        [Fact]
        public void GetServiceNames_ShouldReturnCarAndDoctorServices()
        {
            var serviceDiscovery = new ServiceDiscovery();

            var classNames = serviceDiscovery.GetServiceNames<IService>("Core01", "Core02");

            Assert.Equal(2, classNames.Count());
            var sorted = classNames.OrderBy(s => s);
            Assert.Equal("Core01.CarService", sorted.First());
            Assert.Equal("Core01.DoctorService", sorted.Skip(1).First());
        }
    }
}
