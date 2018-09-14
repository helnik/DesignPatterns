using System;

namespace DesignPatterns.Creational.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            TvShowManager tvm = new TvShowManager();
            tvm["Money Heist"] = new PopularTvShow("Action", "Money Heist", "65","Very Good", true);
            tvm["The Simpsons"] = new PopularTvShow("Animation", "The Simpsons", "21", "Funny", false);

            //clone the objects
            var show1Copy = tvm["Money Heist"].SwallowClone() as PopularTvShow;
            var show2Copy = tvm["The Simpsons"].SwallowClone() as PopularTvShow;

            //care this is swallow copy:
            //if change happens to shallow's reference type original changes also since we point to same object
            DemonstrateChangeToReferenceType(tvm, show1Copy);

            //use deep clone to solve above issue
            DemonstrateDeepCopy(tvm);
            Console.ReadKey();
        }

        private static void DemonstrateChangeToReferenceType(TvShowManager tvm, PopularTvShow show1Copy)
        {
            Console.WriteLine($"Original Object Info before change to swallow copied {tvm["Money Heist"].ToString()}");
            show1Copy.ChangeAdditionalInfo("Really nice show", false);
            Console.WriteLine($"Original Object Info after change to swallow copied {tvm["Money Heist"].ToString()}");
            Console.WriteLine($"Swallow Copied Object Info {show1Copy.ToString()}");
        }

        private static void DemonstrateDeepCopy(TvShowManager tvm)
        {
            var show1DeepCopy = tvm["Money Heist"].DeepClone() as PopularTvShow;
            Console.WriteLine($"Original Object Info before change to deep copied {tvm["Money Heist"].ToString()}");
            show1DeepCopy.ChangeAdditionalInfo("Such a nice show", false);
            Console.WriteLine($"Original Object Info after change to deep copied {tvm["Money Heist"].ToString()}");
            Console.WriteLine($"Deep Copied Object Info {show1DeepCopy.ToString()}");
        }
    }
}
