namespace BehavioralPatterns.MementoPattern
{
    public class Memento
    {
        public LedTv LedTV { get; set; }

        public Memento(LedTv ledTV)
        {
            LedTV = ledTV;
        }
        public string GetDetails()
        {
            return "Memento [ledTV=" + LedTV.GetDetails() + "]";
        }
    }
}
