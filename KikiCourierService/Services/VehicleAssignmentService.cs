using DeliveryCostEstimation.Interfaces;
using DeliveryCostEstimation.Models;

namespace DeliveryCostEstimation.Services
{
    public class VehicleAssignmentService
    {
        private readonly IVehicleAssignmentStrategy _strategy;
        private readonly DeliveryTimeService _deliveryTimeService;

        public VehicleAssignmentService(
            IVehicleAssignmentStrategy strategy,
            DeliveryTimeService deliveryTimeService)
        {
            _strategy = strategy;
            _deliveryTimeService = deliveryTimeService;
        }

        public DeliveryResult Assign(Package package, List<Vehicle> vehicles)
        {
            var vehicle = _strategy.GetAvailableVehicle(vehicles, package.Weight);

            var deliveryTime = _deliveryTimeService.CalculateDeliveryTime(package, vehicle);
            var actualDeliveryTime = vehicle.AvailableAt + deliveryTime;

            // Update vehicle availability (round trip)
            vehicle.AvailableAt += deliveryTime * 2;

            return new DeliveryResult
            {
                PackageId = package.Id,
                DeliveryTime = Math.Round(actualDeliveryTime, 2)
            };
        }
    }
}
