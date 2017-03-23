
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RegisteredUsers
{
    class RegisteredUsers
    {
        static void Main(string[] args)
        {
            var Dic = new Dictionary<string, DateTime>();
            var NameAndDate = Console.ReadLine();
            while (NameAndDate!="end")
            {
                var tokens = NameAndDate.Split(" ->".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var date = tokens[1];
                var nums = new DateTime();
                if (DateTime.TryParse(date , out nums))
                {
                    Dic[name] = nums;
                }
                NameAndDate = Console.ReadLine();
            }
            var Dics = Dic.Values.OrderBy(x => x).Take(5);
            var finalDic = new Dictionary<string, string>();
            foreach (var item in Dic)
            {
                if ()
                {

                }
            }
            
        }
    }
}
