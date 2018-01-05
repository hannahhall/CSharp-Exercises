using System;
using System.Linq;
using System.Collections.Generic;

namespace interfaces
{
    public class Jetski : IVehicle, IWater
    {
        public int Doors {get; set;}
        public int PassengerCapacity {get; set;}
        public string TransmissionType {get; set;}
        public double EngineVolume {get; set;}
        public double MaxWaterSpeed {get; set;}

        public void Drive()
        {
            Console.WriteLine("Moving through the waves can't go faster than {this.MaxWaterSpeed}");
        }

        public void Start()
        {
            Console.WriteLine("Gurgle Gurgle");
        }

        public void Stop()
        {
            Console.WriteLine("Splashy Splash");
        }

        public Jetski ()
        {

        }
    }
}