using System;

namespace RemoveCows
{
    public sealed class Settings
    {
        private Settings()
        {
            Tag = "[ARIS] Remove Cows";
        }

        private static readonly Settings _Instance = new Settings();
        public static Settings Instance { get { return _Instance; } }

        public readonly string Tag;
    }
}