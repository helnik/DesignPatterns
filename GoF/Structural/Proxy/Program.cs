using System;

namespace DesignPatterns.GoF.Structural.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IScreenWriter sw = new InternScreenWriter();
            sw.ThinkACoolPlot();
            sw.WriteGoodScenario();
            sw.OverviewFilming();

            Console.ReadKey();
        }
    }
}
