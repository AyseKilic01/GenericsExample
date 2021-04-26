using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.GenericsClass
{
    class Utilities
    {
        //sayısı belirli olmayan koşullarda params tipinde itemler 
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
        //Generic yapıyı kullandığımız takdirde sınıf içerisindeki değişkenlerin, parametrelerin ve 
        //metotların geri dönüş tiplerini o sınıftan bir nesne oluştururken belirleyebilmekteyiz.
    }
}
