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
    public class Poster
    {
        public Poster()
        { }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("Time")]
        public string Time { get; set; }

        [XmlAttribute("date")]
        public DateTime Date { get; set; }
       
        
    }
}