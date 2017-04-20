using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        public static void Main(string[] args)
        {
           

            while (true)
            {

                Console.WriteLine("Enter 1: To enter the dimensions of triangle");
                Console.WriteLine("Enter 2: To Exit");

                int casevalue = Int32.Parse(Console.ReadLine());
                switch(casevalue)
                {

                    case 1:
                Console.WriteLine("Please write the values for sides of Traingle");
                        Console.WriteLine("Please write the values of side A");
                        int side_A=Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Please write the values of side B");
                        int side_B = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Please write the values of side C");
                        int side_C = Int32.Parse(Console.ReadLine());
                        string answer = TriangleSolverTest.Analyze(side_A, side_B, side_C);
                        Console.WriteLine(answer);
                       
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;

                    default:
                       break;
                }




            }


        }
    }
}
