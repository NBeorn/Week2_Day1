using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //how to write an array
            //int[] favoriteNumbers = { 1, 2, 3, 4, 5, 6 };
            //string[] studentNames = { "Raz", "Monica", "David", "Brian", "Ali" };

            ////how to print a value from an array
            //Console.WriteLine(favoriteNumbers[0]);
            //Console.WriteLine(studentNames[2]);

            //Practice from Github
            //string[] vacationSpots = { "Miami", "Cancun", "Egypt", "L.A.", "Austin", "Paris", "Rome", "Barcelona", "Japan", "Hawaii" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);

            //int[] childrenAges = { 12, 10, 7 };
            //Console.WriteLine(childrenAges[0]);
            //Console.WriteLine(childrenAges[1]);
            //Console.WriteLine(childrenAges[2]);

            //decimal[] studentGpa = { 4.0m, 2.8m, 3.5m, 3.25m, 2.9m, 3.0m, 2.0m, 1.7m };
            //Console.WriteLine(studentGpa[0]);

            //string[] peersInitials = { "R", "A", "M", "D" };
            //Console.WriteLine(peersInitials[1]);

            //how to initialize when we do not know all elements from the start
            int[] numbers = new int[4];
            //the 4 is how many elements will exist within the new array
            numbers[0] = 43;
            numbers[1] = 12;
            Console.WriteLine("Please enter a number");
            numbers[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            numbers[3] = int.Parse(Console.ReadLine());

            Console.WriteLine(numbers[3]);
        }
    }
}
