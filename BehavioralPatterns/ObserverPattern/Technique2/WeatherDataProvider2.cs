using System;

namespace BehavioralPatterns.ObserverPattern.Technique2
{
    public class WeatherDataProvider2 : IDisposable
    {
        public event EventHandler<WeatherDataEventArgs2> RaiseWeatherDataChangedEvent;

        protected virtual void OnRaiseWeatherDataChangedEvent(WeatherDataEventArgs2 e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler<WeatherDataEventArgs2> handler = RaiseWeatherDataChangedEvent;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void NotifyDisplays(float temp, float humid, float pres)
        {
            OnRaiseWeatherDataChangedEvent
                 (new WeatherDataEventArgs2(new WeatherData(temp, humid, pres)));
        }

        public void Dispose()
        {
            if (RaiseWeatherDataChangedEvent != null)
            {
                foreach (EventHandler<WeatherDataEventArgs2>
                item in RaiseWeatherDataChangedEvent.GetInvocationList())
                {
                    RaiseWeatherDataChangedEvent -= item;
                }
            }
        }
    }
}
