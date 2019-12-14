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
    public class Perfomance
    {
        public Perfomance()
        { }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("author")]
        public string Author { get; set; }

        [XmlAttribute("genre")]
        public string Genre { get; set; }

        [XmlAttribute("path")]
        public string Path { get; set; }

        [XmlIgnore]
        public Image Picture { get; set; }
    }
}