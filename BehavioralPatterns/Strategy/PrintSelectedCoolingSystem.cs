namespace BehavioralPatterns.Strategy
{
    public static class PrintSelectedCoolingSystem
    {
        public static void PrintSelectedCoolingChoice(int collingType)
        {
            CoolingContext collingContext = new CoolingContext();

            switch (collingType)
            {
                case (int)CoolingSystemEnum.Fan:
                    collingContext.SetCoolingStrategy(new Fan());
                    break;
                case (int)CoolingSystemEnum.Cooler:
                    collingContext.SetCoolingStrategy(new Cooler());
                    break;
                case (int)CoolingSystemEnum.AC:
                    collingContext.SetCoolingStrategy(new AC());
                    break;
            }

            collingContext.Print();
        }
    }
}
