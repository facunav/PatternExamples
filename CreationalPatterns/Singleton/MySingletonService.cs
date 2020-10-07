namespace CreationalPatterns.Singleton
{
    public class MySingletonService
    {
        private static int creationCount = 0;

        private static readonly MySingletonService _mySingletonServiceInstance = new MySingletonService();

        private MySingletonService()
        {
            creationCount++;
        }

        public static MySingletonService GetInstance() => _mySingletonServiceInstance;

        public int GetCreationCount() => creationCount;
    }
}
