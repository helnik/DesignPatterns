using System;

namespace DesignPatterns.Other.Creational.Multiton
{
    public class FavoriteEpisode
    {
        public readonly string Fan;

        public FavoriteEpisode(string fan)
        {
            Fan = fan;
            Console.WriteLine($"{Fan} added his favorite episode");
        }

        public void Play()
        {
            Console.WriteLine($"{Fan} is watching his favorite episode");
        }
    }
}
