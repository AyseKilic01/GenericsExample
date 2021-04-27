using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    //oluşturduğunda attribute için de tanımlı olan attributeleri kullanabilirsin
    //örnek olarak attributeusage senin attribute yapının nerelerde kullanılabileceğini tutuyor.
    class RequiredPropertyAttribute:Attribute
    {

    }
}
