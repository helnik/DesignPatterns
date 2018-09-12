using System;

namespace DesignPatterns.GoF.Creational.Singleton
{
    /// <summary>
    /// .Net implementation
    /// </summary>
    public sealed class TvSingletonLazy
    {
        private static readonly Lazy<TvSingletonLazy> lazy = new Lazy<TvSingletonLazy>(() => new TvSingletonLazy());
        private static int channelChanged;
        private static readonly object lockObject = new object();

        public static TvSingletonLazy Instance { get { return lazy.Value; } }

        private TvSingletonLazy()
        {
            channelChanged = 0;
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
