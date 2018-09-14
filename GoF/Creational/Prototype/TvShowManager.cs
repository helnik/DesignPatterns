using System.Collections.Generic;

namespace DesignPatterns.Creational.Prototype
{
    public class TvShowManager
    {
        private Dictionary<string, ITvShowPrototype> shows = new Dictionary<string, ITvShowPrototype>();
        
        public ITvShowPrototype this[string key]
        {
            get { return shows[key]; }
            set { shows.Add(key, value);}
        }
    }
}
