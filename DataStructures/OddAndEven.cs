using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class OddAndEven
    {
        public void MainOddAndEven()
        {
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();

            for (int i = 1; i <= 35; i++)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(i);
                }
                else
                {
                    oddList.Add(i);
                }
            }

            Console.WriteLine("The odd list is: ");

            for (int i = 0; i < oddList.Count; i++) {
                Console.Write(oddList[i] + " ");
            }

            Console.WriteLine("\nThe even list is:");

            for (int i = 0; i < evenList.Count; i++)
            {
                Console.Write(evenList[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
