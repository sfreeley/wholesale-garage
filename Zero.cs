using System;

namespace Vehicles
{
    public class Zero : Vehicle
    {
        public double BatteryKwh { get; set; }
        public override void Drive(Vehicle aVehicle)
        {
            Console.WriteLine($"The {aVehicle.MainColor} Zero silently passes!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero turned {direction} and silently parked.");
        }

        public override void Stop(string location)
        {
            Console.WriteLine($"The {MainColor} Zero stopped at the {location} and silently parked.");
        }

    }
}