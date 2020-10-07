using System;

namespace BehavioralPatterns.ObserverPattern.Technique3
{
    public class WeatherDataEventArgs3 : EventArgs
    {
        public WeatherData Data { get; private set; }

        public WeatherDataEventArgs3(WeatherData data)
        {
            Data = data;
        }
    }
}
