using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class ListDictPractice
    {
        public void MainListDictPractice()
        {
            //task1 - add,find,remove&iterate list
            List<string> shoppingList = new List<string>()
            {
                "Coffee",
                "Milk",
                "Bread"
            };

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.Write(shoppingList[i] + " ");
            }

            Console.WriteLine("\nAdd a new item: ");
            string newItem = Console.ReadLine();

            if (!shoppingList.Contains(newItem))
            {
                shoppingList.Add(newItem);
            }
            else
            {
                Console.WriteLine($"{newItem} is already in the list.\n");
            }

            Console.WriteLine("\nThe list is:");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.Write(shoppingList[i] + " ");
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\nPlease insert an item that you want to update: ");
            string updateItem = Console.ReadLine();

            int indexFound = shoppingList.IndexOf(updateItem);

            if (indexFound > -1)
            {
                Console.WriteLine("Enter your replacement: ");
                shoppingList[indexFound] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Item not found.");
            }

            Console.WriteLine("\nThe updated list is:");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.Write(shoppingList[i] + " ");
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\nPlease insert an item that you want to delete: ");
            string deleteItem = Console.ReadLine();

            indexFound = shoppingList.IndexOf(deleteItem);

            if (indexFound > -1)
            {
                shoppingList.RemoveAt(indexFound);
                Console.WriteLine($"Found and removed item {deleteItem}");
            }
            else
            {
                Console.WriteLine("Delete item not found.");
            }

            Console.WriteLine("\nThe updated list is:");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.Write(shoppingList[i] + " ");
            }

            Console.ReadLine();
            Console.Clear();

            //task2 - dictionary scoreboard
            Dictionary<string, int> scoreboard = new Dictionary<string, int>()
            {
                {"Silvia", 5 },
                {"Dode", 3 },
                {"Chimen", 8 }
            };

            Console.WriteLine("Insert a name to display it's score: ");
            string searchName = Console.ReadLine();

            bool nameFound = scoreboard.ContainsKey(searchName);

            if (nameFound)
            {
                Console.WriteLine($"{searchName} has score of {scoreboard[searchName]}");
            } else
            {
                Console.WriteLine("Name not found.");
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Insert a name: ");
            string inputName = Console.ReadLine();

            Console.WriteLine("Insert a score: ");
            int inputScore = Convert.ToInt32(Console.ReadLine());

            if (scoreboard.ContainsKey(inputName)) {
                scoreboard[inputName] += inputScore;
            }else
            {
                scoreboard.Add(inputName, inputScore);
            }

            foreach (var item in scoreboard) {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Insert a name to remove: ");
            string removeName = Console.ReadLine();

            //the below could have been if(!scoreboard.Remove(removeName)) {Console.WriteLine("Name not in the list!");}
            if (scoreboard.ContainsKey(removeName))
            {
                scoreboard.Remove(removeName);
            }
            else
            {
                Console.WriteLine("Name not in the list!");
            }

            foreach (var item in scoreboard)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
