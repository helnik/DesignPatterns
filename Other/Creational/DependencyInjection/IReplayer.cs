using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Other.Creational.DependencyInjection
{
    /// <summary>
    /// abstract serice, will be used for method injection
    /// </summary>
    public interface IReplayer
    {
        void Replay();
    }

    /// <summary>
    /// concrete implementation 
    /// </summary>
    public class AndroidReplayer : IReplayer
    {
        public void Replay()
        {
            Console.WriteLine("Replaying that huge moment");
        }
    }

    /// <summary>
    /// concrete implementation 
    /// </summary>
    public class AppleReplayer : IReplayer
    {
        public void Replay()
        {
            Console.WriteLine("Replaying that weird moment");
        }
    }
}
