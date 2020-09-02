using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cessna
            Cessna newPlane = new Cessna();
            newPlane.FuelCapacity = 200.50;
            newPlane.MainColor = "green";
            newPlane.MaximumOccupancy = "4";
            //methods
            newPlane.Drive(newPlane);
            newPlane.Turn("east");
            newPlane.Stop("airport");

            //Zero
            Zero newMoto = new Zero();
            newMoto.BatteryKwh = 5000;
            newMoto.MainColor = "matte black";
            newMoto.MaximumOccupancy = "6";
            //methods
            newMoto.Drive(newMoto);
            newMoto.Turn("west");
            newMoto.Stop("grocery store");

            //Tesla
            Tesla modelS = new Tesla();
            modelS.BatteryKWh = 10000;
            modelS.MainColor = "blue";
            modelS.MaximumOccupancy = "20";
            modelS.Drive(modelS);
            modelS.Turn("north");
            modelS.Stop("aquarium");

            //Ram
            Ram rebel = new Ram();
            rebel.FuelCapacity = 20.10;
            rebel.MainColor = "black";
            rebel.MaximumOccupancy = "100";
            //methods
            rebel.Drive(rebel);
            rebel.Turn("south");
            rebel.Stop("park");

        }
    }
}