using System;

namespace TimeProviderLib.Implementation
{
    public abstract class TimeProvider
    {
        private static TimeProvider current;

        static TimeProvider()
        {
            TimeProvider.current = new DefaultTimeProvider();
        }

        public abstract DateTime UtcNow { get; }
        public abstract DateTime Today { get; }

        public static TimeProvider Current
        {
            get { return TimeProvider.current; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                TimeProvider.current = value;
            }
        }

        public static void ResetToDefault()
        {
            TimeProvider.current = new DefaultTimeProvider();
        }
    }
}
