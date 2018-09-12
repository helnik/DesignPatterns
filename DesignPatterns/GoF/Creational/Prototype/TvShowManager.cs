using System.Collections.Generic;

namespace DesignPatterns.Creational.Prototype
{
    public class TvShowManager
    {
        private Dictionary<string, TvShowPrototype> shows = new Dictionary<string, TvShowPrototype>();
        
        public TvShowPrototype this[string key]
        {
            get { return shows[key]; }
            set { shows.Add(key, value);}
        }
    }
}
