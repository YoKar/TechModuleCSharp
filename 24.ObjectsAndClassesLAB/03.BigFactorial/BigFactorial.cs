﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
           
            for (int i = n; i > 0; i--)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
            
        }
    }
}
