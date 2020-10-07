using System;

namespace BehavioralPatterns.Strategy
{
    public class AC : ICoolingSystem
    {
        public void Print()
        {
            Console.Write("A.C. is turned on!");
        }
    }
}
