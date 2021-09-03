using System;

namespace number_5_pg_190
{
    class Program
    {
        static void Main()
        {
            double ftemp;

            Console.Write("Enter Heat Temperature in Fahrenheit: ");
            ftemp = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEntered Temperature in Fahrenheit: {0} °F", ftemp);
            Console.WriteLine("Temperature Value in Celcius: {0:N0} °C", FtoC(ftemp));
            Console.WriteLine("\nPress Enter Twice to Quit.");
            Console.Read();
        }
        public static double FtoC (double ToCelcius)
        {
            return ((ToCelcius - 32) * 5) / 9;
        }
    }
}
