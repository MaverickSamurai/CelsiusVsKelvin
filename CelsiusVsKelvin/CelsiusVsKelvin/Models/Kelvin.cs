using System;
using System.Collections.Generic;
using System.Text;

namespace CelsiusVsKelvin.Models
{
   public class Kelvin
   { 
        public double Degree { get;  set; }

        public Kelvin(double degree)
        {
            Degree = degree;
            
        }
    }
}
