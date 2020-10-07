using System;

namespace BehavioralPatterns.Strategy
{
    public class Cooler : ICoolingSystem
    {
        public void Print()
        {
            Console.Write("Cooler is turned on!");
        }
    }
}
