using System;

using System.Linq;


namespace _09.MoreExercisesArrays
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            int counter = 1;
            for (int i = words.Length-1; i > 0; i--)
            {
                if (words[i]==words[i-1])
                {
                    counter++;
                    if (counter == 3)
                    {
                        Console.WriteLine("{0} {0} {0}", words[i]);
                        break;
                    }
                    
                }
                else
                {
                    counter = 1;
                }

            }
        }
    }
}
