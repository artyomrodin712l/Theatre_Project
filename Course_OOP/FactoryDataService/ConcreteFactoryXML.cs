using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP
{
    class ConcreteFactoryXML : IAbstractFactory
    {
        public ConcreteFactoryXML()
        {
        }
        public Write CreateWriteData()
        {
            return new WriteClass();
        }
        public Read CreateReadData()
        {
            return new ReadClass();
        }
    }
}
