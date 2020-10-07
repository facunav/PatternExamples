using System;

namespace BehavioralPatterns.ObserverPattern.Technique3
{
    public class CurrentConditionsDisplay3 : IObserver<WeatherData>
    {
        WeatherData data;
        private IDisposable unsubscriber;

        public CurrentConditionsDisplay3()
        {

        }
        public CurrentConditionsDisplay3(IObservable<WeatherData> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }
        public void Display()
        {
            Console.WriteLine($"Current Conditions : Temp = {data.Temperature} Deg | Humidity = {data.Humidity}% | Pressure = {data.Pressure} bar");
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
