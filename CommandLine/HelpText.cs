using System.Collections.Generic;

namespace BrueForceGenerator.CommandLine
{
    public class HelpText
    {
        private HeadingInfo header;

        private CopyrightInfo copyright;

        private List<string> preOptions;
        
        private object target;

        public bool AdditionalNewLineAfterOption {get; set;}

        public HelpText(HeadingInfo header)
        {
            this.header = header;
            copyright = new CopyrightInfo(string.Empty, 0);
            preOptions = new List<string>();
            this.AdditionalNewLineAfterOption = false;
        }

        public CopyrightInfo Copyright
        {
            get { return copyright; }
            set { copyright = value; }
        }

        public void AddPreOptionsLine(string line)
        {
            this.preOptions.Add(line);
        }

        public void AddOptions(object target)
        {
            this.target = target;
        }

        public override string ToString()
        {
            const char DELIMINATER = '\n';
            return this.header.ToString() + DELIMINATER
                + this.copyright.ToString() + DELIMINATER
                + string.Join(DELIMINATER.ToString(), this.preOptions) + DELIMINATER;
        }
    }
}