using DeliveryCostEstimation.Models;

namespace DeliveryCostEstimation.Services
{
    public class DeliveryTimeService
    {
        public double CalculateDeliveryTime(Package package, Vehicle vehicle)
        {
            return package.Distance / vehicle.Speed;
        }
    }
}
