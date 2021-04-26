using GenericsExample.GenericsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.DAL
{
    interface ICustomerDal:IRepository<Customer>
    {
        //List<Customer> GetAll();
        //Customer Get(int id);
        //void Add(Customer product);
        //void Delete(Customer product);
        //void Update(Customer product);
        //IRepository e parametre olarak Customer clss göndererek bu kodları yazmana gerek yok
        void Custom();
    }
}
