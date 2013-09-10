using System;
using System.Collections.Generic;

namespace TeenPatti.Model
{
    public class Hand
    {
        public List<Card> Cards { get; set; }

        public Dictionary<string, string> Attributes { get; set; }

        public Hand()
        {
            Cards=new List<Card>();
            Attributes=new Dictionary<string, string>();
        }

        public string this[string name]
        {
            get
            {
                if (this.Attributes == null)
                    return null;
                string match = null;
                if (this.Attributes.TryGetValue(name, out match) == true)
                    return match;
                else return null;
            }
            set
            {
                if (this.Attributes == null)
                    this.Attributes = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
                this.Attributes[name] = value;
            }
        }
    }
}