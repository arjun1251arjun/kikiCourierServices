using DeliveryCostEstimation.Models;
using DeliveryCostEstimation.Offers;
using DeliveryCostEstimation.Services;

namespace KikiCourierService.Tests
{
    public class OfferServiceTests
    {
        [Fact]
        public void InvalidOfferCode_ReturnsZeroDiscount()
        {
            var offers = new List<DeliveryCostEstimation.Interfaces.IOffer>
            {
                new OfferOFR001(),
                new OfferOFR002(),
                new OfferOFR003()
            };

            var service = new OfferService(offers);
            var package = new Package("PKG2", 75, 125, "INVALID");

            var discount = service.GetDiscount(package, 1000);

            Assert.Equal(0, discount);
        }

        [Fact]
        public void ValidOfferButCriteriaNotMet_ReturnsZeroDiscount()
        {
            var offers = new List<DeliveryCostEstimation.Interfaces.IOffer>
            {
                new OfferOFR001()
            };

            var service = new OfferService(offers);
            var package = new Package("PKG1", 50, 30, "OFR001");

            var discount = service.GetDiscount(package, 750);

            Assert.Equal(0, discount);
        }
    }
}
