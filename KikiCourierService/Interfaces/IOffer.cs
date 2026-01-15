using DeliveryCostEstimation.Models;

namespace DeliveryCostEstimation.Interfaces
{
    public interface IOffer
    {
        string Code { get; }
        bool IsApplicable(Package package);
        decimal CalculateDiscount(decimal deliveryCost);
    }
}
