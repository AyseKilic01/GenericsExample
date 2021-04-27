using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.DAL
{
    interface IRepository<Base> where Base: class, IEntity, new()
        //struct ifadesi değer tiplerini çevirebilirdin.
        //interface IRepository<Base> where Base: struct
        //sadece class tipini kontrol edersen string ifadesini de kullanabilirsin
        //new() diye ekleersen nesne çekebileceğin bir yapı çevirmek zorunda kalır, string i kullanamaz
        //generic yapı olarak Base adında bir tip gönderdik 
    {
        List<Base> GetAll();
        Base Get(int id);
        void Add(Base entity);
        void Delete(Base entity);
        void Update(Base entity);
    }
}
