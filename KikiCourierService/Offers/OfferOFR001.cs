using DeliveryCostEstimation.Interfaces;
using DeliveryCostEstimation.Models;

namespace DeliveryCostEstimation.Offers
{
    public class OfferOFR001 : IOffer
    {
        public string Code => "OFR001";

        public bool IsApplicable(Package package)
        {
            return package.Distance < 200 &&
                   package.Weight >= 70 &&
                   package.Weight <= 200;
        }

        public decimal CalculateDiscount(decimal deliveryCost)
        {
            return deliveryCost * 0.10m;
        }
    }
}
