using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

         static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintreceiptBody();
            PrintReceiptFooter();
        }

       static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        static void PrintreceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
