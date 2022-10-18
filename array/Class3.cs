using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Class3
    {
        //reverse
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}