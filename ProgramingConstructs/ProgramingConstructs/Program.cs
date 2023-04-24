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
            Console.WriteLine("1.Equality of two integers");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    SelectionAndRepetation constructs = new SelectionAndRepetation();
                    constructs.EqualityOfTwoIntegers();
                    Console.ReadKey();
                    break;
            }
           
        }
    }
}
