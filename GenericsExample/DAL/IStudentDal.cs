using GenericsExample.GenericsClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample.DAL
{
    interface IStudentDal:IRepository<Student>
    {
    }
}
