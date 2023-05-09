using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingConstructs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Equality of two integers\n2.Check even or odd\n3.Check eligibility to vote\n4.Largest number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SelectionAndRepetation constructs = new SelectionAndRepetation();
                    constructs.EqualityOfTwoIntegers();
                    break;
                case 2:
                    EvenOrOdd selection = new EvenOrOdd();
                    selection.CheckEvenOdd();
                    break;
                case 3:
                    EligibilityToVote vote = new EligibilityToVote();
                    Console.Write("Enter the age : ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    vote.Voting(age);
                    break;
                case 4:
                    LargestNumber number = new LargestNumber();
                    Console.WriteLine("Enter the three numbers : ");
                    Console.Write("1 : ");
                    int numOne = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2 : ");
                    int numTwo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("3 : ");
                    int numThree = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Largest of three numbers is : " + number.OfThreeNumbers(numOne, numTwo, numThree));
                    break;
            }
            Console.ReadKey();
        }
    }
}
