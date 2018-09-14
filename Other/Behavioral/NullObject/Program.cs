using System;

namespace DesignPatterns.Other.Behavioral.NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            ITvSeries unfilmed = TvSeries.Null;
            unfilmed.Play(); //no exception
            
            ITvSeries dw = new DoctorWho();
            dw.Play();

            Console.ReadKey();
        }
    }
}
