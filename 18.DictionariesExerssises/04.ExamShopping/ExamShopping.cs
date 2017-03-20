using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            var shops = Console.ReadLine();
            var products = new Dictionary<string, int>();
            var OutOfStock = new List<string>();
            var DoesntExist = new List<string>();
            
            while (shops!= "shopping time")
            {
                var tokens = shops.Split(" ".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                var firstElement = tokens[1];
                var secondElement = tokens[tokens.Length-1];
                var number = 0;
                if (int.TryParse(secondElement,out number))
                {
                    if (products.ContainsKey(firstElement))
                    {
                        products[firstElement] += number;
                    }
                    else
                    {
                        products[firstElement] = number;
                    }
                    
                }
              
                shops = Console.ReadLine();
            }
            shops = Console.ReadLine();
            while (shops != "exam time")
            {
               
                
                var tokens = shops.Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var firstElement = tokens[1];
                var secondElement = tokens[tokens.Length - 1];
                var number = 0;
                if (products.ContainsKey(firstElement))
                {
                    if (int.TryParse(secondElement,out number))
                    {
                         if (products[firstElement]>0)
                        {
                            products[firstElement] -= number;
                            
                        }
                        else
                        {
                            Console.WriteLine($"{firstElement} out of stock");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{firstElement} doesn't exist");
                }
                shops = Console.ReadLine();

            }
            
            
            foreach (var ItemPart in products)
            {
                var Item = ItemPart.Key;
                var Part = ItemPart.Value;
                if (Part>0)
                {
                    Console.WriteLine($"{Item} -> {Part}");
                }
            }
        }
    }
}
