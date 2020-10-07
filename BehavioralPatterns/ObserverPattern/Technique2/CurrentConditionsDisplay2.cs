using System;

namespace BehavioralPatterns.ObserverPattern.Technique2
{
    public class CurrentConditionsDisplay2
    {
        WeatherData Data;
        WeatherDataProvider2 WDprovider;

        public CurrentConditionsDisplay2(WeatherDataProvider2 provider)
        {
            WDprovider = provider;
            WDprovider.RaiseWeatherDataChangedEvent += provider_RaiseWeatherDataChangedEvent;
        }

        void provider_RaiseWeatherDataChangedEvent(object sender, WeatherDataEventArgs2 e)
        {
            Data = e.Data;
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            Console.WriteLine($"Current Conditions : Temp = {Data.Temperature} Deg | Humidity = {Data.Humidity}% | Pressure = {Data.Pressure} bar");
        }

        public void Unsubscribe()
        {
            WDprovider.RaiseWeatherDataChangedEvent -= provider_RaiseWeatherDataChangedEvent;
        }
    }
}
