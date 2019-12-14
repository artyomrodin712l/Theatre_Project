using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Course_OOP
{
    [Serializable]
    public class Author
    {
        public Author()
        { }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}