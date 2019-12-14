using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_OOP
{
    interface IAbstractFactory
    {
        Write CreateWriteData();
        Read CreateReadData();
    }
    interface Write
    {
        Object SetObject(Object obj);
    }
    interface Read
    {
        Object GetObject(Object obj);
    }
}
