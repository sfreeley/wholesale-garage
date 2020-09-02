using System;

namespace Vehicles
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public override void Drive(Vehicle aVehicle)
        {
            Console.WriteLine($"The {aVehicle.MainColor} Ram rumbles past!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram turned {direction} and drove over the grass.");
        }

        public override void Stop(string location)
        {
            Console.WriteLine($"The {MainColor} Ram stopped at the {location} and parked.");
        }

    }
}