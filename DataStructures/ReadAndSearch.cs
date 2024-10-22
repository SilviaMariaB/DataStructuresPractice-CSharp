using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class ReadAndSearch
    {
        public void MainReadAndSearch()
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Insert number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Insert the number you want to search: ");
            int searchFor = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] == searchFor)
                {
                    found = true;
                }
            }
            if (found) { Console.WriteLine("Number found!"); }
            else
            { Console.WriteLine("Number not in the array!"); }
        }
    }
}
