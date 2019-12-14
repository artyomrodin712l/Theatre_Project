using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Drawing;

namespace Course_OOP
{
    [Serializable()]
    public class TKT
    {
        public TKT()
        { }

        public enum Category : int
        {
            First, Second, Third
        }
        [XmlAttribute("category")]
        public Category CategoryModifier { get; set; }

        [XmlAttribute("price")]
        public float price { get; set; }

        [XmlAttribute("amount")]
        public int amount { get; set; }

    }
}