using System;

namespace DesignPatterns.GoF.Structural.Proxy
{
    /// <summary>
    /// real subject
    /// </summary>
    public class ScreenWriter : IScreenWriter
    {
        public void ThinkACoolPlot()
        {
            Console.WriteLine("ScreenWriter has a cool idea");
        }

        public void WriteGoodScenario()
        {
            Console.WriteLine("ScreenWriter writes a cool scenario from the cool idea");
        }

        public void OverviewFilming()
        {
            Console.WriteLine("ScreenWriter is overviewing the filming of the episode");
        }
    }

    /// <summary>
    /// the proxy
    /// </summary>
    public class InternScreenWriter : IScreenWriter
    {
        private IScreenWriter seniorScreenWriter = new ScreenWriter();
        public void ThinkACoolPlot()
        {
            Console.WriteLine("Intern ScreenWriter has trendy idea");
        }

        public void WriteGoodScenario()
        {
            Console.WriteLine("Intern ScreenWriter writes a trendy scenario from the trendy idea");
        }

        public void OverviewFilming()
        {
            Console.WriteLine("Intern ScreenWriter cannot overview a filming so...");
            seniorScreenWriter.OverviewFilming();
        }
    }
}
