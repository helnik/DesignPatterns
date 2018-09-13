using System;

namespace DesignPatterns.GoF.Creational.AbstractFactory
{
    /// <summary>
    /// Abstract show
    /// </summary>
    public interface IMorningTime
    {
        void ShowMorningStuff();
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class MensMorning : IMorningTime
    {
        public void ShowMorningStuff()
        {
            Console.WriteLine("Showing: Women washing cars in bikinis");
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class WomensMorning : IMorningTime
    {
        public void ShowMorningStuff()
        {
            Console.WriteLine("Showing: Firemen working out");
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class KidsMorning : IMorningTime
    {
        public void ShowMorningStuff()
        {
            Console.WriteLine("Showing: Donald Duck");
        }
    }
}
