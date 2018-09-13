using System;

namespace DesignPatterns.Other.Creational.DependencyInjection
{
    /// <summary>
    /// abstract serice, will be used for property injection
    /// </summary>
    public interface IRecorder
    {
        void Record();
    }
    
    /// <summary>
    /// concrete implementation
    /// </summary>
    public class VideoRecorder : IRecorder
    {
        public void Record()
        {
            Console.WriteLine("Recording episode on video...");
        }
    }

    /// <summary>
    /// concrete implementation
    /// </summary>
    public class DvdRecorder : IRecorder
    {
        public void Record()
        {
            Console.WriteLine("Recording episode on DVD...");
        }
    }
}
