using GenericsExample.Attributes;
using GenericsExample.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.GenericsClass
{
    [ToTable("Customers")]
    class Customer:IEntity
    {
        public int ID { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
