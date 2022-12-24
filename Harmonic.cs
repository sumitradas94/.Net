using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Harmonic
    {
        public static void Har()
        {
            Console.WriteLine("Give the nth harminic value");
            int h = Convert.ToInt32(Console.ReadLine());
            {
                double result = 0.0;
                if (h != 0)
                {
                    for (int i = 1; i <= h; i++)
                    {

                        result += 1 / (float)i;


                    }
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("enter a valid number");

                }
            }
        }
    }
}

