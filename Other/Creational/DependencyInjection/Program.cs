using System;

namespace DesignPatterns.Other.Creational.DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor injection. Prefered way. Clear about dependencies needed
            DemonstrateConstructorInjection();

            //Property injection. Used when implementation must be swapped (e.g logging). Overall avoid
            DemonstratePropertyInjection();

            //Method injection. Used when only a method need the dependency. Rarely used
            DemonstrateMethodInjection();

            Console.ReadKey();
        }

        private static void DemonstrateMethodInjection()
        {
            TelevisionUHD tv = new TelevisionUHD();
            IReplayer adroidReplayer = new AndroidReplayer();
            //method injection
            tv.PlayFootballMatch(adroidReplayer);

            IReplayer appleReplayer = new AppleReplayer();
            //method injection no need for new client
            tv.PlayFootballMatch(appleReplayer);
        }

        private static void DemonstrateConstructorInjection()
        {
            ITvEpisode communityEpisode = new CommunityEpisode();
            //constructor injection
            Television tv = new Television(communityEpisode);
            tv.OpenTv();

            ITvEpisode dexterEpisode = new DexterEpisode();
            //constructor injection
            tv = new Television(dexterEpisode);
            tv.OpenTv();
        }

        private static void DemonstratePropertyInjection()
        {
            TelevisionHD tv = new TelevisionHD();
            IRecorder videoRecorder = new VideoRecorder();
            //property injection
            tv.Recorder = videoRecorder;
            tv.RecordShow();

            IRecorder dvdRecorder = new DvdRecorder();
            //property injection, no need to create new client
            tv.Recorder = dvdRecorder;
            tv.RecordShow();
        }
    }
}
