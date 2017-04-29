using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var field = new int[size];

            foreach (var ladyBug in ladybugIndexes)
            {
                if (ladyBug<0||ladyBug>=size)
                {
                    continue;
                }
                field[ladyBug] = 1;
            }
            while (true)
            {
                var command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }
                var commandParts = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentLadyBugIndex = int.Parse(commandParts[0]);
                var direction = commandParts[1];
                var flyLenght = int.Parse(commandParts[2]);
                if (currentLadyBugIndex<0||currentLadyBugIndex>=size)
                {
                    continue;
                }
                if (field[currentLadyBugIndex]==0)
                {
                    continue;
                }
                field[currentLadyBugIndex] = 0;
                var position = currentLadyBugIndex;
                while (true)
                {
                    if (direction=="right")
                    {
                        position += flyLenght;
                    }
                    else
                    {
                        position -= flyLenght;
                    }
                    if (position<0||position>=size)
                    {
                        break;
                    }
                    if (field[position]==1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",field));
        }
    }
}
