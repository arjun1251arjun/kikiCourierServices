using DeliveryCostEstimation.Models;
using DeliveryCostEstimation.Offers;
using DeliveryCostEstimation.Services;

namespace DeliveryCostEstimation
{
    class Program
    {
        static void Main()
        {
            var offers = new List<Interfaces.IOffer>
                {
                    new OfferOFR001(),
                    new OfferOFR002(),
                    new OfferOFR003()
                };

            var deliveryCostService = new DeliveryCostService();
            var offerService = new OfferService(offers);

            //Problem 1
            var deliveryPackages = new List<Package>
            {
                new Package("PKG1", 5, 5, "OFR001"),
                new Package("PKG2", 15, 5, "OFR002"),
                new Package("PKG3", 10, 100, "OFR003"),
            };

            foreach (var package in deliveryPackages)
            {
                deliveryCostService = new DeliveryCostService();
                offerService = new OfferService(offers);

                var deliveryCost = deliveryCostService.CalculateDeliveryCost(package);
                var discount = offerService.GetDiscount(package, deliveryCost);
                var finalCost = deliveryCost - discount;

                Console.WriteLine($"{package.Id} {discount} {finalCost}");
            }

            Console.WriteLine("\n");

            //Problem 2
            var packages = new List<Package>
            {
                new Package("PKG1", 50, 30, "OFR001"),
                new Package("PKG2", 75, 125, "OFFR0008"),
                new Package("PKG3", 175, 100, "OFFR003"),
                new Package("PKG4", 110, 60, "OFFR002"),
                new Package("PKG5", 155, 95, "NA")
            };

            var vehicles = new List<Vehicle>
            {
                new Vehicle("V1", 200, 70),
                new Vehicle("V2", 200, 70)
            };

            var assignmentService = new VehicleAssignmentService(
                new VehicleAssignmentStrategy(),
                new DeliveryTimeService()
            );

            Console.WriteLine(Environment.NewLine);

            foreach (var pkg in packages)
            {
                deliveryCostService = new DeliveryCostService();
                offerService = new OfferService(offers);

                var deliveryCost = deliveryCostService.CalculateDeliveryCost(pkg);
                var discount = offerService.GetDiscount(pkg, deliveryCost);
                var finalCost = deliveryCost - discount;

                var result = assignmentService.Assign(pkg, vehicles);
                Console.WriteLine($"{result.PackageId} {discount} {finalCost} {result.DeliveryTime}");
            }

            Console.ReadLine();
        }
    }
}
