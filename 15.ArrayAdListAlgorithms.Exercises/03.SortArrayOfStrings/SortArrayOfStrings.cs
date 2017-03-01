using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayOfStrings
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                var greater = string.Compare(input[i], input[j]);
                if (greater == 1)
                {
                    var temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(" ", input));
    }
}