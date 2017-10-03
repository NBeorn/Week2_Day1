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
            //int[] numbers = new int[4];
            ////the 4 is how many elements will exist within the new array
            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number");
            //numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine(numbers[3]);

            //Practice
            //string[] weekDays = new string[7];
            //weekDays[0] = "Monday";
            //weekDays[1] = "Tuesday";
            //weekDays[2] = "Wednesday";
            //weekDays[3] = "Thursday";
            //weekDays[4] = "Friday";
            //weekDays[5] = "Saturday";
            //weekDays[6] = "Sunday";

            //int[] studentAge = new int[5];
            //studentAge[0] = 25;
            //studentAge[1] = 27;
            //studentAge[2] = 23;
            //studentAge[3] = 30;
            //studentAge[4] = 24;

            ////Counts indexes due to weekDays being an array
            //Console.WriteLine(weekDays.Length);

            //Practice
            //string[] name = { "B", "E", "O", "R", "N" };
            //Console.WriteLine(name.Length);

            //string[] powers = { "invisibility", "flying", "superspeed", "superstrength" };
            //int index = powers.Length;
            //index = index - 2;
            //Console.WriteLine(powers[index]);

            //To allow the user to create array size
            //Console.WriteLine("Please enter the size of your array");
            //int arraySize = int.Parse(Console.ReadLine());
            //int[] newArray = new int[arraySize];

            //Console.WriteLine("The array is of length " + newArray.Length);

            //How to use IndexOf
            //string[] birthMonths = { "October", "July", "October", "May" };
            //Console.WriteLine(Array.IndexOf(birthMonths, "October"));
            //if not found it will return -1

            //How to use LastIndexOf
            int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            Console.WriteLine(Array.LastIndexOf(numbers, 4));

            //How to use Reverse
            Array.Reverse(numbers);
            Console.WriteLine(numbers[0]);

            Array.Sort(numbers);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}
