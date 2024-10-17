using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class ArraysPractice
    {
        public void MainArraysPractice()
        {
            //task1 - array, shopping list

            Console.WriteLine("Insert how many items will you have in the list: ");
            int items = Convert.ToInt32(Console.ReadLine());
            string[] shoppingList = new string[items];

            for (int i = 0; i < shoppingList.Length; i++)
            {
                Console.Write($"Insert item no {i + 1}: ");
                shoppingList[i] = Console.ReadLine();
            }

            Console.WriteLine("\nThe list displayed with for loop is:");
            for (int i = 0; i < shoppingList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {shoppingList[i]}");
            }

            //int index = 1;
            //Console.WriteLine("\nThe list displayed with foreach loop is:");
            //foreach (string item in shoppingList) {
            //    Console.WriteLine($"{index}. {item}");
            //    index++;
            //}

            //task2 - sort&print shopping list
            Array.Sort(shoppingList);

            Console.WriteLine("\nThe list sorted displayed with for loop is:");
            for (int i = 0; i < shoppingList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {shoppingList[i]}");
            }

            //task3 - reverse&print shopping list
            Array.Reverse(shoppingList);

            Console.WriteLine("\nThe list reversed displayed with for loop is:");
            for (int i = 0; i < shoppingList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {shoppingList[i]}");
            }

            //task4 - copy, clear & print shopping list
            Console.Write("\nHow many items do you want to copy? ");
            int copyNo = Convert.ToInt32(Console.ReadLine());
            string[] copyOfList = new string[copyNo];

            Array.Copy(shoppingList, copyOfList, copyOfList.Length);
            //Array.Copy(shoppingList, copyOfList, 2, 9); //copies from position 3 to position 10

            Console.WriteLine("\nThe new copied list is:");
            for (int i = 0; i < copyOfList.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {copyOfList[i]}");
            }

            //0 - is where you want to start 
            Array.Clear(copyOfList, 0, copyOfList.Length);

            Console.WriteLine("\nThe cleared list is:");
            for (int i = 0; i < copyOfList.Length; i++)
            {
                if (!string.IsNullOrEmpty(copyOfList[i]))
                {
                    Console.WriteLine($"{i + 1}. {copyOfList[i]}");
                }
            }

            //task5 - search&print shopping list item
            Console.WriteLine("\nInsert the item you want to search: ");
            string searchItem = Console.ReadLine();
            int position = Array.IndexOf(shoppingList, searchItem);

            if (position > -1)
            {
                Console.WriteLine($"\nItem '{searchItem}' is in the list!");
            }
            else { Console.WriteLine("\nItem not found. :("); }

            Console.ReadLine();
        }
    }
}
