using System.Threading;

namespace ArchitectureTesting.Patterns.Singleton
{
    //Must be sealed, means they are immutable, delegates are also sealed
    public sealed class Singleton
    {
        //used to hold the instance
        private static Singleton _instance;

        //lock required to keep threads synchronised
        private static readonly object _instanceLock = new object();
        public int Multiplier { get; set; }

        public static Singleton GetSingleton(int value)
        {
            if (_instance is null)
            {
                //need this locked until it is initialised and set, then returned so all threads use the same Singleton
                Lock(value);
            };
            return _instance;
        }

        public static void Lock(int value)
        {
            lock (_instanceLock)
            {
                if (_instance is null)
                {
                    _instance = new Singleton();
                    _instance.Multiplier = value;
                }
            }
        }
    }
}
