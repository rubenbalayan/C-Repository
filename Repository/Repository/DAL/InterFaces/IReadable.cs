using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL.InterFaces
{
    public interface IReadable<T>
    {
        IList<T> GetItems();
        T GetItem(int id);
    }
}
