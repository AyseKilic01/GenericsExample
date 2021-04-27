using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericsExample.GenericsClass;

namespace GenericsExample.DAL
{
    class CustomerDal : ICustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew")]
        public void Add(Customer entity)
        {
            MessageBox.Show(" " + entity.ID + entity.FirstName +entity.LastName +entity.Age);
        }
        public void AddNew(Customer entity)
        {
            MessageBox.Show(" " + entity.ID + " " + entity.FirstName +
                " " +entity.LastName + " " + entity.Age);
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        
    }
}
