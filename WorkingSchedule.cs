using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class WorkingSchedule
    {
        private int[] weeksOfYear = new int[52]; //weeks of year
        private  List<int> weekends = new List<int>(); //list for wekkends
        private  List<int> nights = new List<int>(); //list for nights
        private int num = 0; //count 
        private  int choice;

        public WorkingSchedule()
        {
            CalcWeekends();
            //do while too run unitll the user press 0
            do
            {
                ShowMenu();

            } while (choice != 0);

            
        }

        //calculate with help of modulus, iterate through the weeks
        private void CalcWeekends()
        {
            for (int i = 0; i < weeksOfYear.Length; i++)
            {
                if(i % 3 == 0)
                {
                    //add to the list 
                    num = i+2;
                    weekends.Add(num);

                }

                if(i % 4 == 0)
                {
                    //add to the list 
                    num = i +=1;
                    nights.Add(num);
                }
            }
        }

        //display information 
       private void DisplayInformatonWeekends()
        {
            foreach (var w in weekends)
            {
                //just a checkup so that we dont go over 52 weeks 
                if(w < 53)
                {
                    Console.WriteLine($"Work schedudle for weekends:  {w}");
                }
            }
        }

        //same as method up 
        private void DisplayInformationNights()
        {
            Console.WriteLine(nights);
            foreach (var n in nights)
            {
                if (n < 53)
                {
                    Console.WriteLine($"Work schedudle for weekends:  {n}");
                }
            }
        }
        //the menu and switch statement for the dirrent options
        private void ShowMenu()
        {
            Console.WriteLine("1: Show a list of the weekends to work");
            Console.WriteLine("2: Show a list of nights to work");
            Console.WriteLine("0:  Exit");
            string choiceString = Console.ReadLine();
            int.TryParse(choiceString, out choice);

           // switch statement with bool values 
                switch (choice)
                {
                    case 0:
                        Console.ReadKey();
                        break;
                    case 1:
                        DisplayInformatonWeekends(); //display information weekends
                        break;
                    case 2:
                        DisplayInformationNights(); //display information night
                        break;
                    default:
                    Console.WriteLine("Invalid options");
                        break;
                }

        }

    }
}
