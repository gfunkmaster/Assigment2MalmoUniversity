using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Selection and interation in C#";
            SelectionAndIteration warmupObj = new SelectionAndIteration();
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
          
            Console.Title = "Fahrenheit and Celsius Converter";
            TemperatureConverter converter = new TemperatureConverter();
            Console.WriteLine("Press any key to Exit!");
            Console.ReadLine();

            Console.Title = "Working Schedule";
            WorkingSchedule schedule = new WorkingSchedule();
            Console.WriteLine("Press any key to Exit!");
            Console.ReadLine();
           
        }
    }
}
