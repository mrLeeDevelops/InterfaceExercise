using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfHeadlights { get; set; }
        public bool HornWorks { get; set; }
        public bool WorkingBrakeLights { get; set; }


    }
}
