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
            string[] vacationSpots = { "Miami", "Cancun", "Egypt", "L.A.", "Austin", "Paris", "Rome", "Barcelona", "Japan", "Hawaii" };
            Console.WriteLine(vacationSpots[0]);
            Console.WriteLine(vacationSpots[9]);

            int[] childrenAges = { 12, 10, 7 };
            Console.WriteLine(childrenAges[0]);
            Console.WriteLine(childrenAges[1]);
            Console.WriteLine(childrenAges[2]);

            double[] studentGpa = { 4.0, 2.8, 3.5, 3.25, 2.9, 3.0, 2.0, 1.7 };
            Console.WriteLine(studentGpa[7]);

            string[] peersInitials = { "R", "A", "M", "D" };
            Console.WriteLine(peersInitials[1]);
        }
    }
}
