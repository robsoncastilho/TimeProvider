using System;

namespace TimeProviderLib.Implementation
{
    public class DefaultTimeProvider : TimeProvider
    {
        public override DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }

        public override DateTime Today
        {
            get { return DateTime.Today; }
        }
    }
}
