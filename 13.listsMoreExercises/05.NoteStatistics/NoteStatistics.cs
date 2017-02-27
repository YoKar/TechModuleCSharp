using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NoteStatistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            var listOfNotes = new string[]{ "C","C#","D","D#","E","F","F#","G","G#","A","A#","B" } ;
            var HZList = new double[] { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            var freq = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var notes = string.Empty;
            var naturals = string.Empty;
            var sharps = string.Empty;
            var NaturalsSum = 0.0;
            var SharpSum = 0.0;
            var counter = 0;
            foreach (var num in freq)
            {
                if (HZList.Contains(num))
                {
                    int index = Array.IndexOf(HZList, num);
                    if (listOfNotes[index].Contains("#"))
                    {
                         sharps += listOfNotes[index]+", ";
                            SharpSum += HZList[index];
                     }
                    else
                    {
                           naturals += listOfNotes[index] + ", ";
                            NaturalsSum += HZList[index];
                       }
                    notes += listOfNotes[index]+" ";
                }
                counter++;
            }
            if (naturals.Length>=2)
            {
                naturals = naturals.Remove(naturals.Length - 2);
            }
            if (sharps.Length>=2)
            {
                sharps = sharps.Remove(sharps.Length - 2);
            }
            if (notes.Length>=1)
            {
                notes = notes.Remove(notes.Length - 1);
            }
            
            Console.WriteLine($"Notes: {notes}");
            Console.WriteLine($"Naturals: { naturals}");
            Console.WriteLine($"Sharps: {sharps}");
            Console.WriteLine($"Naturals sum: {NaturalsSum}");
            Console.WriteLine($"Sharps sum: {SharpSum}");





            //foreach (var num in HZList)
            //{
            //    Console.Beep((int)num, 500);
            //}

        }
    }
}
