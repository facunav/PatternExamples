using System;

namespace BehavioralPatterns.ObserverPattern.Technique1
{
    public class CurrentConditionsDisplay1 : ISubscriber
    {
        WeatherData Data;
        IPublisher WeatherData;

        public CurrentConditionsDisplay1(IPublisher weatherDataProvider)
        {
            WeatherData = weatherDataProvider;
            WeatherData.RegisterSubscriber(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions : Temp = {Data.Temperature} Deg | Humidity = {Data.Humidity}% | Pressure = {Data.Pressure} bar");
        }

        public void Update(WeatherData data)
        {
            Data = data;
            Display();
        }
    }
}
