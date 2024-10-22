using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class MenuOptions
    {
        public void MainMenuOptions()
        {
            string[] menuOptions = new string[]
            {
                "1. Create a new file",
                "2. Open a file",
                "3. Update a file",
                "4. Remove a file"
            };

            foreach (string menuOption in menuOptions)
            {
                Console.WriteLine(menuOption);
            }

            Console.WriteLine("\nPlease insert a menu option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option < 1 || option > menuOptions.Length)
            {
                Console.WriteLine("Invalid choice!");
            }
            else { Console.WriteLine("Valid choice!"); }
        }
    }
}
