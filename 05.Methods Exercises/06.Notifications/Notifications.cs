using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string messege = Console.ReadLine();

                string SuccesOrError = messege;

                if (messege == "success")
                {
                    ShowSuccess();

                }
                else if (messege == "error")
                {
                    ShowError();
                }
                else
                {
                    Console.WriteLine(SuccesOrError);
                }
            }

        }

        private static void ShowError()
        {
            string operation = Console.ReadLine();
            int code = int.Parse(Console.ReadLine());
            string reason = string.Empty;
            if (code > 0)
            {
                reason += "Invalid Client Data";
                Console.WriteLine($"Error: Failed to execute {operation}.");
                Console.WriteLine("==============================");
                Console.WriteLine($"Error Code: {code}.");
                Console.WriteLine($"Reason: {reason}.");
            }
            else
            {
                reason += "Internal System Failure";
                Console.WriteLine($"Error: Failed to execute {operation}.");
                Console.WriteLine("==============================");
                Console.WriteLine($"Error Code: {code}.");
                Console.WriteLine($"Reason: {reason}.");
            }
        }

        private static void ShowSuccess()
        {
            string operation = Console.ReadLine();
            string messeges = Console.ReadLine();
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {messeges}.");
        }
    }
}
