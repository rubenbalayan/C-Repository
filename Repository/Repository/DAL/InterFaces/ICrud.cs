using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL.InterFaces
{
    public interface ICrud<T>
    {
        int Create(T source);
        int Edit(T source);
        bool Delete(int id);
    }
}
