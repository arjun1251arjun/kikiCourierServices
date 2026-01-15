using DeliveryCostEstimation.Interfaces;
using DeliveryCostEstimation.Models;

namespace DeliveryCostEstimation.Offers
{
    public class OfferOFR002 : IOffer
    {
        public string Code => "OFR002";

        public bool IsApplicable(Package package)
        {
            return package.Distance >= 50 &&
                   package.Distance <= 150 &&
                   package.Weight >= 100 &&
                   package.Weight <= 250;
        }

        public decimal CalculateDiscount(decimal deliveryCost)
        {
            return deliveryCost * 0.07m;
        }
    }
}
