using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StuckZipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numberUP = new List<int>();
            var numberDOWN = new List<int>();
            var digits = int.MaxValue;
            var digits2 = int.MaxValue;
            foreach (var item in firstList)
            {
              var num=  calculateNUmbers(item);
                if (digits>num)
                {
                    digits = num;
                }
            }
            foreach (var item in secondList)
            {
                var num2 = calculateNUmbers(item);
                if (digits2 > num2)
                {
                    digits2 = num2;
                }
            }
            var idealNumber = 0;
            if (digits>digits2)
            {
                idealNumber = digits2;
            }
            else
            {
                idealNumber = digits;
            }
            foreach (var num in firstList)
            {
                if (num<=idealNumber-1)
                {
                    numberUP.Add(num);
                }
                
            }
            foreach (var num in secondList)
            {
                if (num<=idealNumber-1)
                {
                    numberDOWN.Add(num);
                }
            }
            var finalLIST = new List<int>();
            if (numberUP.Count>=numberDOWN.Count)
            {
                var counterUP = 0;
                var counterDOWN = 0;
                while (counterUP!=numberUP.Count)
                {
                    if (counterDOWN<numberDOWN.Count)
                    {
                        finalLIST.Add(numberDOWN[counterDOWN]);
                        counterDOWN++;
                    }
                    if (counterUP<numberUP.Count)
                    {
                        finalLIST.Add(numberUP[counterUP]);
                        counterUP++;
                    }
                  }
              
            }
            else
            {
                var counterUP = 0;
                var counterDOWN = 0;
                while (counterDOWN != numberDOWN.Count)
                {
                    if (counterDOWN < numberDOWN.Count)
                    {
                        finalLIST.Add(numberDOWN[counterDOWN]);
                        counterDOWN++;
                    }
                    if (counterUP < numberUP.Count)
                    {
                        finalLIST.Add(numberUP[counterUP]);
                        counterUP++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", finalLIST));
        }

        private static int calculateNUmbers(int item)
        {
            var counter = 1;
            while (Math.Abs(item)>0)
            {
                item /= 10;
                counter *= 10;
            }
            return counter;
        }
    }
}
