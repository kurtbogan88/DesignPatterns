using System;

namespace SingletonPattern
{
    public class GuideService
    {
        private static Guid _guid;
        private static object _lock = new object();
        private GuideService()
        {

        }

        public static Guid CreateAsGuid()
        {
            lock (_lock)
            {
                if (_guid == Guid.Empty)
                    _guid = Guid.NewGuid();
            }

            return _guid;
        }
    }
}
