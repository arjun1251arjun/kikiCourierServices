using DeliveryCostEstimation.Models;
using DeliveryCostEstimation.Services;

namespace KikiCourierService.Tests
{
    public class DeliveryCostServiceTests
    {
        [Fact]
        public void CalculateDeliveryCost_ReturnsCorrectCost()
        {
            var service = new DeliveryCostService();
            var package = new Package("PKG1", 50, 30, "NA");

            var cost = service.CalculateDeliveryCost(package);

            Assert.Equal(750, cost);
        }
    }
}
