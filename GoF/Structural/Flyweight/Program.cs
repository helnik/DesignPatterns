using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.GoF.Structural.Flyweight
{
    class Program
    {
        private static List<char> choises = new List<char> { 'F', 'S' };
        private static Random random = new Random();

        static void Main(string[] args)
        {
            var flyweightFactory = new EpisodeFactory();
            //episodes are filmed on the first time then played on repeat
            for (int i = 0; i < 20; i++)
            {
                var c = random.Next(choises.Count());
                var ep = flyweightFactory.GetEpisode(choises[c]);
                ep.Play();
            }

            Console.ReadKey();
        }
    }
}
