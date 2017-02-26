using System;

using System.Linq;


namespace _07.CountOfCapitalLettersInArray
{
    class CountOfCapitalLettersInArray
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');
            int countter = 0;
            for (int i = 0; i < words.Length; i++)
            {
                var capitalLeters = words[i];
                if (capitalLeters.Length==1)
                {
                    char capital = capitalLeters[0];
                    if (capital>='A' && capital<='Z')
                    {
                        countter++;
                    }

                }
            }
            Console.WriteLine(countter);
        }
    }
}
