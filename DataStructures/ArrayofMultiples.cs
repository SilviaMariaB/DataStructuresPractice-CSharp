using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class ArrayofMultiples
    {
        public void MainArrayofMultiples()
        {
            Console.WriteLine("Please insert the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please insert the length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] result = new int[length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] =(i+1) * num;
            }

            Console.WriteLine("The result is: ");

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
