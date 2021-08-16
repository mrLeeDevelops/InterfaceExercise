using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int BedSize { get; set; }
        public int NumberOfTruckWindows { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfHeadlights { get; set; }
        public bool HornWorks { get; set; }
        public bool WorkingBrakeLights { get; set; }
        public string LogoColor { get; set; }
        public int NumberOfEmployees { get; set; }
    }
}
