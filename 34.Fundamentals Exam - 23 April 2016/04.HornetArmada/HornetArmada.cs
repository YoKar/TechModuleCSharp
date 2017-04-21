using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HornetArmada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            Dictionary<string, int> GourdDic = new Dictionary<string, int>();
            Dictionary<string, int> LegionDic = new Dictionary<string, int>();
            var previouseGuardInt = 0;
            var PreviouseLegionInt = 0;
            for (int i = 0; i < N; i++)
            {
                var inputLine = Console.ReadLine();
                var tokens = inputLine.Split(" =->:".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                var GuardInt = int.Parse(tokens[0]);
                var GourdString = tokens[1];
                var LegionString = tokens[2];
                var LegionInt = int.Parse(tokens[3]);
                if (previouseGuardInt<GuardInt)
                {
                    previouseGuardInt = GuardInt;
                }
                if (!GourdDic.ContainsKey(GourdString))
                {
                    GourdDic[GourdString] = 0;
                }
                if (!GourdDic.ContainsValue(previouseGuardInt))
                {
                    GourdDic[GourdString] = previouseGuardInt;
                }
                if (GourdDic[GourdString].<GuardInt)
                {

                }
        }
    }
}
