using System;

namespace DesignPatterns.GoF.Creational.Singleton
{
    public sealed class TvSingleton
    {
        private static TvSingleton instance;
        private static int channelChanged;
        private static readonly object lockObject = new object();

        private TvSingleton() {}

        public static TvSingleton Instance
        {
            get {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new TvSingleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void UseTv(string name)
        {
            lock (lockObject)
            {
                Console.WriteLine(channelChanged == 0
                    ? $"{name} is opening tv"
                    : $"{name} will change the channel. Channel will change for time no:{channelChanged}");
                channelChanged++;
            }
        }
    }
}
