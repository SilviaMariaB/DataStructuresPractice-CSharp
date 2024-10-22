using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class ReadAndPrint
    {
        public void MainReadAndPrint()
        {
            const int countNumbers = 10;
            int[] numbers = new int[countNumbers];
            int sum = 0;

            for (int i = 0; i < countNumbers; i++)
            {
                Console.Write($"Insert number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < countNumbers; i++)
            {
                sum = sum + numbers[i];
            }

            for (int i = 0; i < countNumbers; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine($"\nThe sum is {sum}.");
            double average = sum/ Convert.ToDouble(countNumbers);
            Console.WriteLine($"The average is {average}.");

            Console.ReadLine();
        }
    }
}
