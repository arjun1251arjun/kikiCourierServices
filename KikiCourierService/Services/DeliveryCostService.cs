using DeliveryCostEstimation.Models;

namespace DeliveryCostEstimation.Services
{
    public class DeliveryCostService
    {
        private const decimal BaseCost = 100;
        private const decimal CostPerKg = 10;
        private const decimal CostPerKm = 5;

        public decimal CalculateDeliveryCost(Package package)
        {
            return BaseCost +
                   (decimal)package.Weight * CostPerKg +
                   (decimal)package.Distance * CostPerKm;
        }
    }
}
