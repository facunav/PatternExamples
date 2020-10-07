using System;

namespace BehavioralPatterns.ObserverPattern.Technique3
{
    public class ForecastDisplay3 : IObserver<WeatherData>
    {
        WeatherData data;

        private IDisposable unsubscriber;
        public ForecastDisplay3()
        {

        }

        public ForecastDisplay3(IObservable<WeatherData> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }

        public void Display()
        {
            Console.WriteLine("Forecast Conditions : Temp = {0}Deg | Humidity = {1}% | Pressure = {2}bar", data.Temperature + 10, data.Humidity - 30, data.Pressure + 3);
        }

        public void Subscribe(IObservable<WeatherData> provider)
        {
            if (unsubscriber == null)
            {
                unsubscriber = provider.Subscribe(this);
            }
        }

        public void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine("Additional temperature data will not be transmitted.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Some error has occurred..");
        }

        public void OnNext(WeatherData value)
        {
            this.data = value;
            Display();
        }
    }
}
