using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_TheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var eventsById = new Dictionary<int, string>();
            var organizer = new Dictionary<string, List<string>>();

            while (input != "Time for Code")
            {

                if (input.Contains("#"))
                {
                    var eventInfo = input
                        .Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    var ID = int.Parse(eventInfo[0]);

                    var eventName = eventInfo[1];

                    var participants = new List<string>();

                    for (int i = 2; i < eventInfo.Count; i++)
                    {
                        participants.Add(eventInfo[i]);
                    }


                    if (!eventsById.ContainsKey(ID))
                    {
                        eventsById.Add(ID, eventName);
                        organizer.Add(eventName, participants);
                    }

                    else if (eventsById[ID] == eventName)
                    {
                        organizer[eventName].AddRange(participants);
                    }
                }

                input = Console.ReadLine();
            }


            foreach (var events in organizer.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{events.Key} - {events.Value.Distinct().Count()}");
                foreach (var participant in events.Value.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
