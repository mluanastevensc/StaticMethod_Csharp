using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var Far = TempConverter.CelsiusToFahrenheit(44);
            Console.WriteLine(celsius);
            Console.WriteLine(Far);
        }
      
    }
}
