using System.Collections.Generic;
using DeliveryCostEstimation.Models;

namespace DeliveryCostEstimation.Interfaces
{
    public interface IVehicleAssignmentStrategy
    {
        Vehicle GetAvailableVehicle(List<Vehicle> vehicles, double packageWeight);
    }
}
