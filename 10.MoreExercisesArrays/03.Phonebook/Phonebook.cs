using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] phoneNames = Console.ReadLine().Split(' ');

            while (true)
            {
                string enterName = Console.ReadLine();
                if (enterName == "done")
                {
                    break;
                }

                if (phoneNames.Contains(enterName))
                {
                    int enteredNameIndex = Array.IndexOf(phoneNames, enterName);
                    Console.WriteLine($"{phoneNames[enteredNameIndex]} -> {phoneNumbers[enteredNameIndex]}");
                }
            }
        }
    }
}
