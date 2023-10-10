using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9.0) * (fahrenheit - 32);
            return celsius;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * (9.0 / 5.0)) + 32;
            return fahrenheit;
        }
    }
}
