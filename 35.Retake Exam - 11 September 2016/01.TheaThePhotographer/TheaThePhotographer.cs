using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            
           
            var AllPhotos = long.Parse(Console.ReadLine());
            var timeForFilter = long.Parse(Console.ReadLine());
            var PrecentOfFilteredPictures = double.Parse(Console.ReadLine());
            var timeForUpload = long.Parse(Console.ReadLine());
            var FilteredTime = AllPhotos * timeForFilter;
            var filterdPictures = (long)Math.Ceiling((AllPhotos * (PrecentOfFilteredPictures / 100)));
            var uploadingTime = filterdPictures * timeForUpload;
            BigInteger TheTime = FilteredTime + uploadingTime;
            Console.WriteLine(
                TimeSpan.FromSeconds((double)TheTime)
                    .ToString(new string('d', 1) + @"\:hh\:mm\:ss"));
             
        }
    }
}
