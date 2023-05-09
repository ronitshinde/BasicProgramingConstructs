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
            Console.WriteLine("1.Equality of two integers\n2.Check even or odd");
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
            }
            Console.ReadKey();

        }
    }
}
