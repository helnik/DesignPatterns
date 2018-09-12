using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns.GoF.Creational.Singleton
{
    class Program
    {
        static readonly HashSet<string> bigFamily = new HashSet<string>()
        {
            "Nick", "George", "Mary", "Depy", "Dean", "Sam", "Oliver", "Eliza", "Clair"
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Running Lazy");
            //prove same instance
            var tvl = TvSingletonLazy.Instance;
            ProveSameInstanceLazyImplementation(tvl);
            //run 
            Parallel.ForEach(bigFamily, familyMember => tvl.UseTv(familyMember));

            Console.WriteLine("Running second implementation");

            //prove same instance 
            var tv = TvSingleton.Instance;
            ProveSameInstance(tv);
            Parallel.ForEach(bigFamily, familyMember => tv.UseTv(familyMember));


            Console.ReadKey();
        }

        private static void ProveSameInstanceLazyImplementation(TvSingletonLazy tvl)
        {
            var tvl1 = TvSingletonLazy.Instance;
            var tvl2 = TvSingletonLazy.Instance;
            
            if (tvl == tvl1 && tvl1 == tvl2)
            {
                Console.WriteLine("House has only one tv!");
            }
        }

        private static void ProveSameInstance(TvSingleton tv)
        {
            var tv1 = TvSingleton.Instance;
            var tv2 = TvSingleton.Instance;

            if (tv == tv1 && tv1 == tv2)
            {
                Console.WriteLine("House has only one tv!");
            }
        }
    }
}
