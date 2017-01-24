using System.Collections.Generic;

namespace BrueForceGenerator
{
    public class Element
    {
        public string Name {get; set;}

        public List<string> Attributes {get; set;}

        public Element()
        {
            this.Name = string.Empty;
            this.Attributes = new List<string>();
        }
    }
}