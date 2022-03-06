using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks_Mapper
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter Marks");
            var input = Console.ReadLine();

           int marks = Int32.Parse(input);

            if((marks - 0) * (39 - marks) >= 0)
            {    
               Console.WriteLine("You have failed");
            }
            if ((marks - 40) * (49 - marks) >= 0)
            {
                Console.WriteLine("You have passed");
            }
            if ((marks - 50) * (59 - marks) >= 0)
            {
                Console.WriteLine("You have passed with a lower credit");
            }
            if ((marks - 60) * (69 - marks) >= 0)
            {
                Console.WriteLine("You have passed with a Higher credit");
            }
            if ((marks - 70) * (79 - marks) >= 0)
            {
                Console.WriteLine("You have passed with a Distinction");
            }
            if ((marks - 80) * (100 - marks) >= 0)
            {
                Console.WriteLine("You have passed with undoubled Distinction");
            }
            if(marks < 0 || marks > 100)
            {
                Console.WriteLine("Marks out of range please enter correct marks");
            }
            Console.ReadKey();
            
        }
        
    }
}
