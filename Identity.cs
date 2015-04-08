using ICities;

namespace RemoveCows
{
    public class Identity : IUserMod
    {
        public string Name
        {
            get { return Settings.Instance.Tag; }
        }

        public string Description
        {
            get { return "Nonpermanently removes all cows. Disable to get the cows back. Requires [ARIS] Skylines Overwatch."; }
        }
    }
}