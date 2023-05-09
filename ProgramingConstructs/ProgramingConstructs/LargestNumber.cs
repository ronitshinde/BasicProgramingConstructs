using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingConstructs
{
    public class LargestNumber
    {
        //1. Write a C# Sharp program to find the largest of three numbers.
        int greaterNum = 0;
        public int OfThreeNumbers(int digitOne, int digitTwo, int digitThree)
        {
            if (digitOne > digitTwo)
            {
                if (digitOne > digitThree)
                    greaterNum = digitOne;
                else 
                    greaterNum = digitThree;
            }
            else if (digitTwo > digitThree)
            {
                greaterNum = digitTwo;
            }
            else
                greaterNum = digitThree;
            return greaterNum;
        }
    }
}
