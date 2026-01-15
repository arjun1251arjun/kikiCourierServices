namespace DeliveryCostEstimation.Models
{
    public class Vehicle
    {
        public string Id { get; }
        public double MaxWeight { get; }
        public double Speed { get; }
        public double AvailableAt { get; set; }

        public Vehicle(string id, double maxWeight, double speed)
        {
            Id = id;
            MaxWeight = maxWeight;
            Speed = speed;
            AvailableAt = 0;
        }
    }
}
