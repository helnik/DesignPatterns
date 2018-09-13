using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns.Other.Creational.Multiton
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> familyMembers = new HashSet<string>{"Nick", "Gus", "George" };

            //use family members twice to prove Multiton is doing it's Job. Constructor message should Appear only once while play 2
            Parallel.ForEach(familyMembers, fm => EpisodeMultiton.GetTvInstance(fm).Play());
            Parallel.ForEach(familyMembers, fm => EpisodeMultiton.GetTvInstance(fm).Play());

            Console.ReadKey();
        }
    }
}
