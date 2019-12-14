using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Course_OOP
{
    [Serializable]
    public class User
    {
        public User()
        {
            this.AccessModifier = 0; 
        }
        public enum Access : int
        {
            Guest = 0, Registered, Admin
        }
        [XmlAttribute("access")]
        public Access AccessModifier { get; set; }

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("login")]
        public string Login { get; set; }

        [XmlAttribute("password")]
        public string Password { get; set; }

    }
}

