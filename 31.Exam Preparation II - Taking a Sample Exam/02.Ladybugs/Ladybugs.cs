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
            var sizeOfField = int.Parse(Console.ReadLine());
            var LadyBugsIndexes = Console.ReadLine().Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var field = new int[sizeOfField];
            foreach (var ledyBugIndex in LadyBugsIndexes)
            {
                if (ledyBugIndex < 0 || ledyBugIndex > sizeOfField)
                {
                    continue;
                }
                field[ledyBugIndex] = 1;

            }
            while (true)
            {
                var wayToMove = Console.ReadLine().Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (wayToMove[0] == "end")
                {
                    break;
                }
                var currentLadyBugIndex =int.Parse( wayToMove[0]);
                var direction = wayToMove[1];
                var LandingDirection = int.Parse(wayToMove[2]);
                var flyLenght = currentLadyBugIndex;
               
                if (field[currentLadyBugIndex]==0)
                {
                    continue;
                }
                var position = currentLadyBugIndex;
                if (direction == "right")
                {
                    position += LandingDirection;
                }
                else
                {
                    flyLenght -= LandingDirection;
                }
                if (flyLenght < 0 || flyLenght > sizeOfField)
                {
                    continue;
                }
            }
        }
//        int fieldSize = int.Parse(Console.ReadLine());
//        int[] indexesWithBugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//        int[] field = new int[fieldSize];
 
//            for (int i = 0; i<fieldSize; i++)
//            {
//                if (indexesWithBugs.Contains(i))
//                {
//                    field[i] = 1;
//                }
//                else
//                {
//                    field[i] = 0;
//                }
//            }
 
//            string[] command = Console.ReadLine().Split(' ').ToArray();
//            while (command[0] != "end")
//            {
//                int index = int.Parse(command[0]);
//int moving = int.Parse(command[2]);
//                if (index< 0 || index >= field.Length)
//                {
//                    command = Console.ReadLine().Split();
//                    continue;
//                }
//                else if (field[index] == 0)
//                {
//                    command = Console.ReadLine().Split();
//                    continue;
//                }
//                else if (field[index] == 1)
//                {
//                    if (command[1] == "right")
//                    {
//                        index = int.Parse(command[0]);
//moving = int.Parse(command[2]);
 
//                        if (moving > 0)
//                        {
//                            MoveRight(field, index, moving);
//                        }
//                        else if (moving< 0)
//                        {
//                            MoveLeft(field, index, Math.Abs(moving));
//                        }
//                    }
 
//                    else if (command[1] == "left")
//                    {
//                        if (moving > 0)
//                        {
//                            MoveLeft(field, index, moving);
//                        }
//                        else if (moving< 0)
//                        {
//                            MoveRight(field, index, Math.Abs(moving));
//                        }
//                    }
 
//                    command = Console.ReadLine().Split(' ').ToArray();
//                }
 
//            } // End of the loop
 
//            Console.WriteLine(string.Join(" ", field));
 
//        } // End of Main method
 
//        static void MoveRight(int[] field, int index, int moving)
//{

//    if (index + moving >= field.Length)
//    {
//        field[index] = 0;
//    }
//    else
//    {
//        field[index] = 0;
//        for (int i = index + moving; i < field.Length; i += moving)
//        {
//            if (field[i] == 1)
//            {
//                continue;
//            }

//            else
//            {
//                field[i] = 1;
//                break;
//            }
//        }
//    }
//    return;
//}

//static void MoveLeft(int[] field, int index, int moving)
//{

//    if (index - moving < 0)
//    {
//        field[index] = 0;
//    }
//    else
//    {
//        field[index] = 0;

//        for (int i = index - moving; i > -1; i -= moving)
//        {
//            if (field[i] == 1)
//            {
//                continue;
//            }
//            else
//            {
//                field[i] = 1;
//                break;
//            }
//        }
//    }
//    return;
//}
    }
}
