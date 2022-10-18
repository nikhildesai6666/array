using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Class4
    {
        // Alternate
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < array.Length; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(array[i]);
                }

            }
        }
    }
}
