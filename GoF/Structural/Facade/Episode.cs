using System;

namespace DesignPatterns.GoF.Structural.Facade
{
    public class Episode
    {
        public Video Video { get; set; }
        public Audio Audio { get; set; }
        public SpecialEffect SpecialEffect { get; set; }

        public void Play()
        {
            Console.WriteLine($"Playing new episode with duration {Video.Duration}min ost name {Audio.Ost} and special effects of {SpecialEffect.Type}");
        }
    }
}
