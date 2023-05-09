using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingConstructs
{
    public class EligibilityToVote
    {
        /*3. Write a C# Sharp program to read the age of a candidate and
        determine whether it is eligible for casting his/her own vote.*/
        public void Voting(int age)
        {
            if (age >= 18 && age <= 100)
                Console.WriteLine("The voter is eligible to vote");
            else
                Console.WriteLine("The voter is not eligible to vote");
        }
        
    }
}
