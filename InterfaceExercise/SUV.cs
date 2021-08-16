using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int CargoHoldSize {get;set;}
        public int NumberOfSUVWindows { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfHeadlights { get; set; }
        public bool HornWorks { get; set; }
        public bool WorkingBrakeLights { get; set; }
        public string LogoColor { get; set; }
        public int NumberOfEmployees { get; set; }
    }
}
