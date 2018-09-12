using System;

namespace DesignPatterns.GoF.Creational.AbstractFactory
{
    /// <summary>
    /// Abstract show
    /// </summary>
    public abstract class MorningTime
    {
        public abstract void ShowMorningStuff();
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class MensMorning : MorningTime
    {
        public override void ShowMorningStuff()
        {
            Console.WriteLine("Showing women washing cars in bikinis");
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class WomensMorning : MorningTime
    {
        public override void ShowMorningStuff()
        {
            Console.WriteLine("Showing firemen working out");
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class KidsMorning : MorningTime
    {
        public override void ShowMorningStuff()
        {
            Console.WriteLine("Showing Donald Duck");
        }
    }
}
