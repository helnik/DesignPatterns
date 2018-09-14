using System;

namespace DesignPatterns.GoF.Structural.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITvShow show = new TvShow("Other Show");
            show.DisplayShowInfo();

            show = new TvShowApiAdapter("Doctor Who");
            show.DisplayShowInfo();

            show = new TvShowApiAdapter("Firefly");
            show.DisplayShowInfo();

            show = new TvShowApiAdapter("Battlestar Galactica");
            show.DisplayShowInfo();

            Console.ReadKey();
        }
    }
}
