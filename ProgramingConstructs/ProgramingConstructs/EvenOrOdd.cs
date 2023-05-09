using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingConstructs
{
    public class EvenOrOdd
    {
        public void CheckEvenOdd()
        {
            //UC2-Write a C# Sharp program to check whether a given number is even or odd.
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine($"The given number '{number}' is even ");
            else
                Console.WriteLine($"The given number '{number}' is odd ");
        }
    }
}
