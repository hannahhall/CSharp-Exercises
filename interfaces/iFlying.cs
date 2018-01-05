using System;
using System.Linq;
using System.Collections.Generic;

namespace interfaces
{
    public interface IFlying
    {
        bool Winged { get; set; }
        double MaxAirSpeed { get; set; }
        void Fly();
        int Wheels { get; set; }
    }
    
    
}