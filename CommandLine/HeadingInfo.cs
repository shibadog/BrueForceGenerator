namespace BrueForceGenerator.CommandLine
{
    public class HeadingInfo
    {
        private string applicationName;
        private string versionStr;

        public HeadingInfo(string applicationName, string versionStr)
        {
            this.applicationName = applicationName;
            this.versionStr = versionStr;
        }

        public override string ToString()
        {
            return $"{applicationName} {versionStr}";
        }
    }
}