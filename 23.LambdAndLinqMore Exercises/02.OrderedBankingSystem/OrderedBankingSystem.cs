using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OrderedBankingSystem
{
    class OrderedBankingSystem
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> BankDicitionary = new Dictionary<string, Dictionary<string, decimal>>();
            var inputLine = Console.ReadLine();
            while (inputLine!="end")
            {
                var tokens = inputLine.Split(" ->".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var Bank = tokens[0];
                var Acount = tokens[1];
                decimal Money = decimal.Parse(tokens[2]);
                if (!BankDicitionary.ContainsKey(Bank))
                {
                    BankDicitionary[Bank] = new Dictionary<string, decimal>();
                }
                if (!BankDicitionary[Bank].ContainsKey(Acount))
                {
                    
                    BankDicitionary[Bank].Add(Acount, 0);
                }
                BankDicitionary[Bank][Acount] += Money;



                inputLine = Console.ReadLine();
            }
            BankDicitionary.OrderByDescending(bank => bank.Value.Sum(acount => acount.Value))
                .ThenByDescending(bank=>bank.Value.Max(acount=>acount.Value))
                .ToList().ForEach(bank => bank.Value.ToList().ForEach(acount => Console.WriteLine("{0} -> {1} ({2})",acount.Key,acount.Value,bank.Key)));
            }
    }
}
