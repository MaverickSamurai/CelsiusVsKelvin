using System;
using System.Collections.Generic;
using System.Text;
using static CelciusVsKelvin.Program;

namespace CelsiusVsKelvin.Models
{
   public class Celcius
   {
       
        
            public double Degree { get; set; }

            public Celcius(double degree)
            {
                Degree = degree;
            }

            public static implicit operator Kelvin(Celcius celcius)
            {
                return new Kelvin(celcius.Degree + 273.15);
            }
        
   }
}
