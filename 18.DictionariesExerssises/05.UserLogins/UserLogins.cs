using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            var userNameAndPassword = Console.ReadLine();
            var NameAndPassword = new Dictionary<string, string>();
            while (userNameAndPassword != "login")
            {
                var tokens = userNameAndPassword.Split(" ->".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var Name = tokens[0];
                var Password = tokens[1];
                if (NameAndPassword.ContainsKey(Name))
                {
                    var changedPass = Password;
                    NameAndPassword[Name] = changedPass;
                }
                else
                {
                    NameAndPassword[Name] = Password;
                }
                userNameAndPassword = Console.ReadLine();
            }
            userNameAndPassword = Console.ReadLine();
            var counter = 0;
            while (userNameAndPassword != "end")
            {
                var tokens = userNameAndPassword.Split(" ->".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var Name = tokens[0];
                var Password = tokens[1];
                if (NameAndPassword.ContainsKey(Name))
                {
                    if (NameAndPassword.ContainsValue(Password))
                    {
                        Console.WriteLine($"{Name}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{Name}: login failed");
                        counter++;
                    }
                }
                else
                {
                    Console.WriteLine($"{Name}: login failed");
                    counter++;
                }
                userNameAndPassword = Console.ReadLine();
            }
            if (counter > 0)
            {
                Console.WriteLine("unsuccessful login attempts: {0}", counter);
            }
        }
    }
}
