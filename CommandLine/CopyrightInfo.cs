
namespace BrueForceGenerator.CommandLine
{
    public class CopyrightInfo
    {
        private string auther;
        private int since;

        public CopyrightInfo(string auther, int since)
        {
            this.auther = auther;
            this.since = since;
        }

        public override string ToString()
        {
            return $"Copyright (C) {this.auther}. {this.since}.";
        }
    }
}