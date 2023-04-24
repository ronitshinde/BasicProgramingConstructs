using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingConstructs
{
    public class SelectionAndRepetation
    {
        public void EqualityOfTwoIntegers()
        {
            /*UC1-Write a C# Sharp program to accept two integers and check whether
            they are equal or not.*/
            Console.WriteLine("Enter the first integer");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer");
            int secondInteger = Convert.ToInt32(Console.ReadLine());
            if(firstInteger.Equals(secondInteger))
                Console.WriteLine("Both integers are equal");
            else
                Console.WriteLine("Both integers are unequal");
        }
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
