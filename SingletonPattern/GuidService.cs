using System;

namespace SingletonPattern
{
    public class GuidService
    {
        private static Guid _guid;
        private static object _lock = new object();
        private GuidService()
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
