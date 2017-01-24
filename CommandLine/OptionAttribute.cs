using System;

namespace BrueForceGenerator.CommandLine
{
    
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class OptionAttribute : Attribute
    {
        private readonly string longName;
        private readonly string shortName;
        private string setName;
        private char separator;
        private string helpText;

        private OptionAttribute(string shortName, string longName)
        {
            if (shortName == null) throw new ArgumentNullException("shortName");
            if (longName == null) throw new ArgumentNullException("longName");
            if (helpText == null) throw new ArgumentNullException("helpText");

            this.shortName = shortName;
            this.longName = longName;
            setName = string.Empty;
            separator = '\0';

            helpText = string.Empty;
        }

        public OptionAttribute()
            : this(string.Empty, string.Empty)
        {
        }

        public OptionAttribute(string longName)
            : this(string.Empty, longName)
        {   
        }

        public OptionAttribute(char shortName, string longName)
            : this(shortName.ToString(), longName)
        {
        }

        public OptionAttribute(char shortName)
            : this(shortName.ToString(), string.Empty)
        {
        }

        public string ShortName
        {
            get { return shortName; }
        }

        public string LongName
        {
            get { return longName; }
        }

        public string SetName
        {
            get { return setName; }
            set {
                if (value == null) throw new ArgumentNullException("value");

                setName = value;
            }
        }

        public char Separator
        {
            get { return separator; }
            set { separator = value; }
        }

        public string HelpText
        {
            get { return helpText; }
            set {
                if (value == null) new ArgumentException("value");

                helpText = value;
            }
        }
    }
}