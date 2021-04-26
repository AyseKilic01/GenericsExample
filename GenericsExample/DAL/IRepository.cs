using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.DAL
{
    interface IRepository<Base>
    {
        List<Base> GetAll();
        Base Get(int id);
        void Add(Base entity);
        void Delete(Base entity);
        void Update(Base entity);
    }
}
