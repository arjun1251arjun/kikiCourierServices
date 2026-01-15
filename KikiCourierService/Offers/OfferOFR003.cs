using DeliveryCostEstimation.Interfaces;
using DeliveryCostEstimation.Models;

namespace DeliveryCostEstimation.Offers
{
    public class OfferOFR003 : IOffer
    {
        public string Code => "OFR003";

        public bool IsApplicable(Package package)
        {
            return package.Distance >= 50 &&
                   package.Distance <= 250 &&
                   package.Weight >= 10 &&
                   package.Weight <= 150;
        }

        public decimal CalculateDiscount(decimal deliveryCost)
        {
            return deliveryCost * 0.05m;
        }
    }
}
