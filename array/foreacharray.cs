using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class foreacharray
    {
        static void Main(string[]args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            double[] rainfall =  { 1, 2, 3, 4, 5, 6, 7 };
            string[] names =  { "Nikhil", "Shubham", "Sushant" };
             
            foreach(int n in numbers)
            {
                    Console.WriteLine(n);   
            }
            foreach(double r in rainfall)
            {
                Console.WriteLine(r);

            }
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
