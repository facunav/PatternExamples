namespace BehavioralPatterns.Strategy
{
    public class CoolingContext
    {
        private ICoolingSystem _coolingSystem;
        /// <summary>
        /// Set appropriate cooling strategy
        /// </summary>
        /// <param name="coolingSystem"></param>
        public void SetCoolingStrategy(ICoolingSystem coolingSystem)
        {
            _coolingSystem = coolingSystem;
        }
        /// <summary>
        /// Prints the strategy set
        /// </summary>
        public void Print()
        {
            _coolingSystem?.Print();
        }
    }
}
