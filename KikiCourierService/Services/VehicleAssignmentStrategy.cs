using DeliveryCostEstimation.Interfaces;
using DeliveryCostEstimation.Models;

namespace DeliveryCostEstimation.Services
{
    public class VehicleAssignmentStrategy : IVehicleAssignmentStrategy
    {
        public Vehicle GetAvailableVehicle(List<Vehicle> vehicles, double packageWeight)
        {
            return vehicles
                .Where(v => v.MaxWeight >= packageWeight)
                .OrderBy(v => v.AvailableAt)
                .First();
        }
    }
}
