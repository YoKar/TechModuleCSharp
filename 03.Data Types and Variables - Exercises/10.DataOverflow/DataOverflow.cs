using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DataOverflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            byte Byte = byte.MaxValue;
            ushort Ushort = ushort.MaxValue;
            uint Uint = uint.MaxValue;
            ulong Ulong = ulong.MaxValue;
            decimal bigger = 0.0m;
            decimal smaller = 0.0m;
            if (num1>num2)
            {
                 bigger = num1;
                 smaller = num2;
            }
            else
            {
                 bigger = num2;
                smaller = num1;
            }
            if (bigger<= Byte)
            {
                Console.WriteLine("bigger type: byte");

            }
            else if (bigger>Byte&&bigger<=Ushort)
            {
                Console.WriteLine("bigger type: ushort");
            }
            else if (bigger>Ushort&&bigger<=Uint)
            {
                Console.WriteLine("bigger type: uint");
            }
            else if (bigger>Uint&&bigger<=Ulong)
            {
                Console.WriteLine("bigger type: ulong");
            }
            if (smaller <= Byte)
            {
                Console.WriteLine("smaller type: byte");
                Console.WriteLine("{0} can overflow byte {1} times", bigger, Math.Round(bigger / Byte));
            }
            else if (smaller > Byte && smaller <= Ushort)
            {
                Console.WriteLine("smaller type: ushort");
                Console.WriteLine("{0} can overflow ushort {1} times", bigger,Math.Round(bigger / Ushort));
            }
            else if (smaller > Ushort && smaller <= Uint)
            {
                Console.WriteLine("smaller type: uint");
                Console.WriteLine("{0} can overflow uint {1} times", bigger, Math.Round(bigger /Uint));
            }
            else if (smaller > Uint && smaller <= Ulong)
            {
                Console.WriteLine("smaller type: ulong");
                Console.WriteLine("{0} can overflow ulong {1} times", bigger, Math.Round(bigger / Ulong));
            }

        }
    }
}
