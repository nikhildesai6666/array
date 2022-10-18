using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Class1
    {
        //minimum
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            Console.WriteLine("minimum value is {0}");
        }
    }
}
