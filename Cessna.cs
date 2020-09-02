using System;

namespace Vehicles
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }
        public override void Drive(Vehicle aVehicle)
        {
            Console.WriteLine($"The {aVehicle.MainColor} Cessna zips past!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna turned {direction} and rolled some more.");
        }

        public override void Stop(string location)
        {
            Console.WriteLine($"The {MainColor} Cessna stopped at the {location} and ran out of gas.");
        }

    }
}