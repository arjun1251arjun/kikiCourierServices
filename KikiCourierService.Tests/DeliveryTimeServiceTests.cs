using DeliveryCostEstimation.Models;
using DeliveryCostEstimation.Services;

namespace KikiCourierService.Tests
{
    public class DeliveryTimeServiceTests
    {
        [Fact]
        public void CalculateDeliveryTimeInHours_ReturnsCorrectTime()
        {
            var package = new Package("PKG1", 50, 140, "NA");
            var vehicle = new Vehicle("V1", 200, 70);

            var service = new DeliveryTimeService();

            var time = service.CalculateDeliveryTime(package, vehicle);

            Assert.Equal(2, time);
        }
    }
}
