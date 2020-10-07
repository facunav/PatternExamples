using System;

namespace BehavioralPatterns.ObserverPattern.Technique2
{
    public class ForecastDisplay2
    {
        WeatherData Data;
        WeatherDataProvider2 WDprovider;

        public ForecastDisplay2(WeatherDataProvider2 provider)
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
            Console.WriteLine($"Forecast Conditions : Temp = {Data.Temperature + 12} Deg | Humidity = {Data.Humidity + 20}% | Pressure = {Data.Pressure - 3} bar");
        }

        public void Unsubscribe()
        {
            WDprovider.RaiseWeatherDataChangedEvent -= provider_RaiseWeatherDataChangedEvent;
        }
    }
}
