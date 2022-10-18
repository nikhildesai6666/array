using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class array2D
    {
        static void Main(string[] args)
        {
            //2D array ---> accept the number from user

            int[,] data = new int[3, 4];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; i < data.GetLength(1); j++)
                {
                    data[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            for (int i = 0; i < data.GetLength(0); i++)
            {

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.WriteLine($"data=[{i},{j}] ={data[i, j]}");

                }
                Console.WriteLine();




            }



        }
    }
}