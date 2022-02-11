using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SelectionAndIteration
    {
        private string myFullName = "Elmin Nurkic"; // my full name 
        private string myCurrentSemester = "VT22"; // my current semster
        private int lenghtOfString;
        private bool done = false;
        private int sum;
        public SelectionAndIteration()
        {
            Console.WriteLine();
            Console.WriteLine($"My name is: {myFullName}. I am a student of the {myCurrentSemester} semester");
            Console.WriteLine();

            //call method to read a text, calculate and display the num of charachters
            if (!done)
            {
                ShowStringLenght();
            }
            else
            {
                Console.ReadLine();
                Console.WriteLine("You pressed Enter! see you!");
            }
            Console.WriteLine();

            //call method to read a number 1 to 7  and display  corresponding 
            //name of the day (1= monday, 7 = sunday = 7)
            MakeMyDay();
            Console.WriteLine();

            //call method to sum up all the values  between two intergas number 
            //calculate sum and display it
            SumNumbers();
            Console.WriteLine();

        }

        private void ShowStringLenght()
        {
            Console.WriteLine("Let me calculate the lenght of strings for you");
            do
            {
                Console.WriteLine("Give me text of any lenght, or press Enter to exit");
                DisplayText();
            } while (!done);
          
        }

        //method for textinput, we return a string
        private string WriteTextInput()
        {
            string input = Console.ReadLine();
            return input;
        }
     
        //display the info
        private void DisplayText()
        {
            string inputText = WriteTextInput();
            lenghtOfString = inputText.Length;

            if(lenghtOfString == 0)
            {
                done = true;
                Console.ReadKey();

            } else
            {
                done = false;
                Console.WriteLine($"{inputText.ToUpper()}"); // to Uppercase
                Console.WriteLine($"Number of charachter = {lenghtOfString}");
            } 
        }


        private void MakeMyDay() //method for MAkeMyDay
        {
            Console.WriteLine("I can predict your day for you");
            Console.WriteLine("Give a number between 1 and 7");
            int day = GiveNumber(); //our number
            string dayFortune = string.Empty; //empty string to have our text in

            switch (day) // our switch statement to compare the number and then give output 
            {
                case 1:
                    dayFortune = "Monday: Keep calm! You can fall apart!";
                    break;
                case 2:
                case 3:
                    dayFortune = "Tuesday and Wednesday break your heart!";
                    break;
                case 4:
                    dayFortune = "Thursday, Uuush, still one day to Friday!";
                    break;
                case 5:
                    dayFortune = "It's Friday! You are in love!";
                    break;
                case 6:
                    dayFortune = "Saturday, do nothing and do plenty of it!";
                    break;
                case 7:
                    dayFortune = "And Sunday always comes too soon!";
                    break;
                   

                default:
                    dayFortune = "Not in a good mode? This is not a valid date!";
                    break;
            }

            Console.WriteLine(dayFortune); // writes the text

        }

        //metohd to give number and return a int
        private int GiveNumber()
        {
            string input = Console.ReadLine(); //give value
            int inputString = int.Parse(input); //parse it to a int

            return inputString; //return 
        }

        private void SumNumbers()
        {
            Console.WriteLine("Give start number: ");
            int start;
          
            int.TryParse(Console.ReadLine(), out start);
            Console.WriteLine("Give end number: ");
            int end;
            int.TryParse(Console.ReadLine(), out end);
            Console.WriteLine($"start: {start}, end: {end}");

          
                if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }
            
                  

            
          
            sum = SumNumbers(start, end); // our returing totalsum

            Console.WriteLine($"{sum}"); // writing it out
        }

        private int SumNumbers(int start, int end) //return int and our parameters
        {
            int sum = 0; //startvalue 
            for (int i = start; i <= end; i++)
            {
                sum = sum + i;

            }
            return sum; //return the sum 
        }
    }
}
