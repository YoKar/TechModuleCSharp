using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.HappinessIndex
{
    class HappinessIndex
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var HappySmall = @"((\(|\[|c|\*)(:|;))|((:|;)(\)|]|D|\*|}))";
            Regex Happy = new Regex(HappySmall);
            MatchCollection HappyMatch = Happy.Matches(inputLine);
            double counterHappy = 0;
            foreach (Match imoticone in HappyMatch)
            {
                counterHappy++;
            }
            var Sadnes = @"((\)|\]|D)(:|;))|((:|;)(\(|\[|c|{))";
            Regex Sad = new Regex(Sadnes);
            MatchCollection Sadneses = Sad.Matches(inputLine);
            double counterSad = 0;
            foreach (Match SadImoticones in Sadneses)
            {
                counterSad++;
            }
            double counter = counterHappy / counterSad;
            if (counter>=2)
            {
                Console.WriteLine("Happiness index: {0:f2} :D",counter);
                Console.WriteLine("[Happy count: {0}, Sad count: {1}]",counterHappy,counterSad);
            }
            else if (counter>1)
            {
                Console.WriteLine("Happiness index: {0:f2} :)", counter);
                Console.WriteLine("[Happy count: {0}, Sad count: {1}]", counterHappy, counterSad);
            }
            else if (counter==1)
            {
                Console.WriteLine("Happiness index: {0:f2} :|", counter);
                Console.WriteLine("[Happy count: {0}, Sad count: {1}]", counterHappy, counterSad);
            }
            else if (counter<1)
            {
                Console.WriteLine("Happiness index: {0:f2} :(", counter);
                Console.WriteLine("[Happy count: {0}, Sad count: {1}]", counterHappy, counterSad);
            }
        }
    }
}
