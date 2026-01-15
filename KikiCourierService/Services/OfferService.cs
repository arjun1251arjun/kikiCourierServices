using DeliveryCostEstimation.Interfaces;
using DeliveryCostEstimation.Models;

namespace DeliveryCostEstimation.Services
{
    public class OfferService
    {
        private readonly IEnumerable<IOffer> _offers;

        public OfferService(IEnumerable<IOffer> offers)
        {
            _offers = offers;
        }

        public decimal GetDiscount(Package package, decimal deliveryCost)
        {
            var offer = _offers.FirstOrDefault(o => o.Code == package.OfferCode);

            if (offer == null || !offer.IsApplicable(package))
                return 0;

            return offer.CalculateDiscount(deliveryCost);
        }
    }
}
