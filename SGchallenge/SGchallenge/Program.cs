using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SGchallenge
{
    class Program
    {
        //Default file called "list" in the current directory
        //"list" will represent the list of people with their birth and end years
        static readonly string list = @"list.txt";

        static int[] years = new int[99]; //all years between 1900 and 2000

        static void Main(string[] args)
        {
            if (File.Exists(list)) {
                // Read the list of names and years line by line.
                string[] ppl = File.ReadAllLines(list);
                foreach (string line in ppl) //for each line, calcualte the years each person was alive
                    calculate(line);
            }
            else { Console.WriteLine("File does not exist"); }


            //Find the most populated year
            int mostPopulatedYear = years.Max();
            int maxYearIndex = years.ToList().IndexOf(mostPopulatedYear) + 1901;
            Console.WriteLine("\nThe year with the most number of people alive: " + maxYearIndex);
         
            Console.WriteLine("\nResults"); //Used to show the number of people living in each year
            int currentYear = 1901;
            for (int i = 0; i < 99; i++) {
                Console.WriteLine(currentYear + ": " + years[currentYear - 1901] + " people alive");               
                currentYear++;
            }

            Console.WriteLine("\nPress any key to exit results.");
            Console.ReadKey();
        }

        private static void calculate(string line)
        {
            string firstNum = string.Empty;  //used to represent the birth year
            string secondNum = string.Empty; //used to represent the end year
            int start, end;

            //Parse through the line and create sub-strings for the start and end years
            for (int i = 0; i < line.Length; i++) {
                if (Char.IsDigit(line[i]))
                    if (firstNum.Length < 4) { //check if 'firstNum' is a complete year
                        firstNum += line[i];
                    }
                    else
                        secondNum += line[i];
            }

            //Convert the strings representing the start and end years to integers
            start = int.Parse(firstNum);
            end = int.Parse(secondNum);

            //Now keep track of what years each person was alive
            for (int i = start - 1901; i <= end - 1901; i++) {
                years[i] ++;
            }
        }
    }
}
