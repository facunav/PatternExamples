using System;

namespace BehavioralPatterns.ObserverPattern.Technique2
{
    public class WeatherDataEventArgs2 : EventArgs
    {
        public WeatherData Data { get; private set; }

        public WeatherDataEventArgs2(WeatherData data)
        {
            Data = data;
        }
    }
}
