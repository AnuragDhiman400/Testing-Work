using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public static class TriangleSolverTest
    {
        public static bool triangleExists(int side_A, int side_B, int side_C)
        {
            if (side_A + side_B > side_C && side_B + side_C > side_A && side_C + side_A > side_B)
            {
                return true;
            }
                return false;
        }

        public static string Analyze(int side_A,int side_B,int side_C)
        {
            if(side_A + side_B>side_C && side_B+side_C>side_A && side_C+side_A>side_B)
            {
Console.WriteLine("Triangle Exits");
                if (side_A==side_B && side_B==side_C && side_C==side_A){
                  return  "Equilateral Triangle";
                }
                else if (side_A == side_B ||side_B == side_C || side_C == side_A)
               {
                   return "Isoscles Triangle";
              }
                else if (side_A != side_B && side_B != side_C || side_C != side_A)
            {
                   return "Scalene Triangle";
            }
            }
            else
            {
               return "It doest not form any triangle";
              }
            return "";
           }
       }
   }
