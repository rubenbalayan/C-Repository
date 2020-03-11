using Repository.DAL.InterFaces;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL.Repositories
{
    public class BaseRepository<T> : ICrud<T>, IReadable<T> where T : class, IEntity
    {
        protected IList<T> context;

        //public BaseRepository(IList<T> context)
        //{
        //    this.context = context;
        //}
        public int Create(T source)
        {
            int res = 0;
            if (source != null)
            {
                context.Add(source);
                res = 1;
            }

            return res;
        }

        public bool Delete(int id)
        {
            bool res = false;
            if (id != 0)
            {
                var curStudent = context.FirstOrDefault(p => p.Id == id);
                context.Remove(curStudent);
                res = true;
            }
            return res;
        }

        public int Edit(T source)
        {
            int res = 0;
            if (source != null)
            {
                int idx = context.IndexOf(context.FirstOrDefault(x => x.Id == source.Id));
                context[idx] = source;

                res = 1;
            }
            return res;
        }

        public T GetItem(int id) => context.FirstOrDefault(elem => elem.Id == id);

        public IList<T> GetItems() => context;
    }
}
