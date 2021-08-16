using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE--Create 2 Interfaces called IVehicle & ICompany

            //DONE--Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE--Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*DONE--Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*DONE--Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var Explorer = new SUV()
            {
            CargoHoldSize  = 30,
            NumberOfSUVWindows = 8,
            NumberOfWheels = 4,
            NumberOfHeadlights = 2,
            HornWorks = false,
            WorkingBrakeLights = true,
            LogoColor  = "goldenrod",
            NumberOfEmployees = 250
            };

            Console.WriteLine("New SUV STATS");
            Console.WriteLine("-------------");
            Console.WriteLine("");
            Console.WriteLine($"Cargo Hold Size: {Explorer.CargoHoldSize}ft");
            Console.WriteLine($"Number Of SUV Windows: {Explorer.NumberOfSUVWindows}");
            Console.WriteLine($"Number Of Wheels: {Explorer.NumberOfWheels}");
            Console.WriteLine($"Number Of Headlights: {Explorer.NumberOfHeadlights}");
            Console.WriteLine($"Horn Works: {Explorer.HornWorks}");
            Console.WriteLine($"Working Brake Lights: {Explorer.WorkingBrakeLights}");
            Console.WriteLine($"Logo Color: {Explorer.LogoColor}");
            Console.WriteLine($"Number Of Employees: {Explorer.NumberOfEmployees}");
            Console.WriteLine("");

            var F150 = new Truck() 
            { 
            BedSize = 10,
            NumberOfTruckWindows = 4,
            NumberOfWheels = 4,
            NumberOfHeadlights = 4, 
            HornWorks = true,
            WorkingBrakeLights = true,
            LogoColor = "magenta",
            NumberOfEmployees = 250
            };

            Console.WriteLine("New Truck STATS");
            Console.WriteLine("---------------");
            Console.WriteLine("");
            Console.WriteLine($"Truck Bed Size: {F150.BedSize}ft");
            Console.WriteLine($"Number OfTruck Windows: {F150.NumberOfTruckWindows}");
            Console.WriteLine($"Number Of Wheels: {F150.NumberOfWheels}");
            Console.WriteLine($"Number Of Headlights: {F150.NumberOfHeadlights}");
            Console.WriteLine($"Horn Works: {F150.HornWorks}");
            Console.WriteLine($"Working Brake Lights: {F150.WorkingBrakeLights}");
            Console.WriteLine($"Logo Color: {F150.LogoColor}");
            Console.WriteLine($"Number Of Employees: {F150.NumberOfEmployees}");
            Console.WriteLine("");

            Car Tesla = new Car()
            {
            TrunkSize = 25,
            NumberOfCarWindows = 6,
            NumberOfWheels = 4,
            NumberOfHeadlights = 2,
            HornWorks = true,
            WorkingBrakeLights = true,
            LogoColor = "black",
            NumberOfEmployees = 20
            };

            Console.WriteLine("New Tesla STATS");
            Console.WriteLine("---------------");
            Console.WriteLine("");
            Console.WriteLine($"Trunk Size: {Tesla.TrunkSize}ft");
            Console.WriteLine($"Number Of Car Windows: {Tesla.NumberOfCarWindows}");
            Console.WriteLine($"Number Of Wheels: {Tesla.NumberOfWheels}");
            Console.WriteLine($"Number Of Headlights: {Tesla.NumberOfHeadlights}");
            Console.WriteLine($"Horn Works: {Tesla.HornWorks}");
            Console.WriteLine($"Working Brake Lights: {Tesla.WorkingBrakeLights}");
            Console.WriteLine($"Logo Color: {Tesla.LogoColor}");
            Console.WriteLine($"Number Of Employees: {Tesla.NumberOfEmployees}");
            Console.WriteLine("");

        }
    }
}
