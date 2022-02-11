using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TemperatureConverter
    {
        public TemperatureConverter()
        {
            Console.Clear(); //clears the console
            Start();
        }

        public void Start()
        {
            int choice = -1; //giving a start value that dosent exitst in our switch case, 

            while (choice != 0) // while loop where if we press 0 we exit
            {
                showMenu(); //showing the menu
                Console.Write("Your Choice:");
               int.TryParse(Console.ReadLine(), out choice); // the choice input

                switch (choice) // based on our choice we will run it
                {
                    case 0:
                        //no method to run, Exit
                        break;
                    case 1:
                       ShowTableCelsiusToFahrenheit();
                        break;
                    case 2:
                       ShowTableFahrenheitToCelsius();
                        break;
                    default:
                        Console.WriteLine("invalid choice, please select a valid number"); //this will appear if we don's select any of the cases
                        break;
                }

            }
        }

        private void ShowTableFahrenheitToCelsius()
        {
           
            const int max = 214; //max fahrenheit

            int count = 0;

            for (int i = 0; i < max; i+=10) // adding 10 
            {
                double result = FahrenheitToCelsius(i);
                Console.WriteLine($"{i} F =  {result.ToString("F")} C");
                count++;
            }

        }

        //method there we return a double, and where we calculate from fahrenheit to clesius
        private double FahrenheitToCelsius(double fahrenheit)
        {
            return  (double)5 / (double)9.0 * (fahrenheit - (double)32);
                
        }
        private void ShowTableCelsiusToFahrenheit()
        {
            const int max = 102; //max celsius deegrees 
            int count = 0;
           
            for (int i = 0; i < max; i+= 4)
            {
                double result = CelsiusToFahrenheit(i); // we assing double, bacause it can become like 9.5, and we use a method to calc
                
            Console.WriteLine($"{i} C =  {result.ToString("F")} F"); // write out the string

                count++;
               
            }

        }


        //method to calc celsius to fahrenheit and we return a double 
        private double CelsiusToFahrenheit(double celsius)
        {
            return (double)9.0 / (double)5.0 * celsius + (double)32.0; //the calculatation
        }

        private void showMenu() //Menu that will appear
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("        MAIN MENU         ");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("Celsius to Farenheit    : 1");
            Console.WriteLine("Farenheit to Celsius    : 2");
            Console.WriteLine("Exit the program        : 0");

        }

    }
}
