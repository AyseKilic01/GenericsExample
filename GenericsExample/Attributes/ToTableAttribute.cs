using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Attributes
{
    class ToTableAttribute:Attribute
    {
        private string v;
        public ToTableAttribute(string v)
        {
            this.v = v;
        }
    }
}
