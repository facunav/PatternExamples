using System.Collections.Generic;

namespace BehavioralPatterns.ObserverPattern.Technique1
{
    public class WeatherDataProvider1 : IPublisher
    {
        List<ISubscriber> ListOfSubscribers;
        WeatherData data;
        public WeatherDataProvider1()
        {
            ListOfSubscribers = new List<ISubscriber>();
        }
        public void RegisterSubscriber(ISubscriber subscriber)
        {
            ListOfSubscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            ListOfSubscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var sub in ListOfSubscribers)
            {
                sub.Update(data);
            }
        }

        private void MeasurementsChanged()
        {
            NotifySubscribers();
        }
        public void SetMeasurements(float temp, float humid, float pres)
        {
            data = new WeatherData(temp, humid, pres);
            MeasurementsChanged();
        }
    }
}
