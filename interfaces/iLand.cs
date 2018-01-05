using System;
using System.Linq;
using System.Collections.Generic;

namespace interfaces
{
    public interface ILand 
    {
        double MaxLandSpeed { get; set; }
        int Wheels { get; set; }
    }
}