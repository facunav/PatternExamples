using System;

namespace BehavioralPatterns.Strategy
{
    public class Fan : ICoolingSystem
    {
        public void Print()
        {
            Console.Write("Fan is turned on!");
        }
    }
}
