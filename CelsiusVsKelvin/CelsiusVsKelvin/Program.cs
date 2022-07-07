using CelsiusVsKelvin.Models;
using System;

namespace CelciusVsKelvin
{
    class Program
    {
       public static void Main(string[] args)
        {
            Celcius celcius = new Celcius(5);
            Kelvin kelvin = celcius;

            Console.WriteLine(kelvin.Degree);
           
        }


      

        
    }
}
