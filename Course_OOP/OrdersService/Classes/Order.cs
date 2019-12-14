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
    public class Order
    {
        public Order()
        { }

        [XmlAttribute("id")]
        public int id { get; set; }

        [XmlAttribute("perfomance")]
        public string Perfomance { get; set; }

        [XmlAttribute("category")]
        public string Category { get; set; }

        [XmlAttribute("user")]
        public string User { get; set; }

        [XmlAttribute("date")]
        public DateTime date { get; set; }
    }
}