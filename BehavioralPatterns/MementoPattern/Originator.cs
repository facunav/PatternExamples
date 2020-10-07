namespace BehavioralPatterns.MementoPattern
{
    public class Originator
    {
        public LedTv LedTV;

        public Memento CreateMemento()
        {
            return new Memento(LedTV);
        }
        public void SetMemento(Memento memento)
        {
            LedTV = memento.LedTV;
        }
        public string GetDetails()
        {
            return "Originator [LedTV=" + LedTV.GetDetails() + "]";
        }
    }
}
