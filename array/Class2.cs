using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Class2
    {
        //maximum
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("maximum value is {0}", max);
        }
    }
}
