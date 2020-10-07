using System;

namespace BehavioralPatterns.ObserverPattern.Technique1
{
    public class ForecastDisplay1 : ISubscriber, IDisposable
    {
        WeatherData Data;
        IPublisher WeatherData;

        public ForecastDisplay1(IPublisher weatherDataProvider)
        {
            WeatherData = weatherDataProvider;
            WeatherData.RegisterSubscriber(this);
        }

        public void Display()
        {
            Console.WriteLine($"Forecast Conditions : Temp = {Data.Temperature + 6} Deg | Humidity = {Data.Humidity + 20}% | Pressure = {Data.Pressure - 3} bar");
        }

        public void Update(WeatherData data)
        {
            Data = data;
            Display();
        }

        public void Dispose()
        {
            WeatherData.RemoveSubscriber(this);
        }
    }
}
