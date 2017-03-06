using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RabbitHole
{
    class RabbitHole
    {
        static void Main(string[] args)
        {
            var rabbitListHole = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());
            bool RabbiteHole = false;
            bool DEADfromBOMB = true;
            if (rabbitListHole[0]=="RabbitHole")
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
            }
            else
            {
                var currentIndex = 0;
                while (energy > 0 && !RabbiteHole)
                {
                    DEADfromBOMB = false;
                   
                    List<string> positions = rabbitListHole[currentIndex].Split('|').ToList();
                    if (positions[0]=="RabbitHole")
                    {
                        RabbiteHole = true;
                        break;
                    }
                    
                        string direction = positions[0];
                        int loseEnergy = int.Parse(positions[1]);
                    
                    switch (direction)
                    {
                        case "Right":
                            currentIndex = (currentIndex + loseEnergy) % rabbitListHole.Count;
                            energy -= loseEnergy;
                            break;
                        case "Left":
                            currentIndex = Math.Abs(currentIndex - loseEnergy) % rabbitListHole.Count;
                            energy -= loseEnergy;
                            break;
                        case "Bomb":
                            rabbitListHole.RemoveAt(currentIndex);
                            currentIndex = 0;
                            energy -= loseEnergy;
                            DEADfromBOMB = true;
                            break;
                        case "RabbitHole":
                            RabbiteHole = true;
                            break;
                    }
                    if (rabbitListHole[rabbitListHole.Count - 1] == "RabbitHole")
                    {
                        rabbitListHole.Add("Bomb|" + energy);
                    }
                    else
                    {
                        rabbitListHole.RemoveAt(rabbitListHole.Count - 1);
                        rabbitListHole.Add("Bomb|" + energy);
                    }

                }
                if (RabbiteHole)
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                }
                else if (energy <= 0&&!DEADfromBOMB)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                }
                else if (energy<=0&&DEADfromBOMB)
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                }
            }
            
        }
    }
}
