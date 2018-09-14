using System;

namespace DesignPatterns.Other.Behavioral.NullObject
{
    public abstract class TvSeries : ITvSeries
    {
        public static  readonly  ITvSeries Null = new NullTvSeries();
        public abstract void Play();

        class NullTvSeries: ITvSeries
        {
            public void Play()
            {
                //Do nothing on purpose (or maybe log)
                Console.WriteLine("This tv series is not yet filmed");
            }
        }
    }

    public class DoctorWho : ITvSeries
    {
        public void Play()
        {
            Console.WriteLine("Playing Doctor Who tv series");
        }
    }
}

