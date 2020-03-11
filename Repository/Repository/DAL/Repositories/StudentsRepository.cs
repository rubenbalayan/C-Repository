using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL.Repositories
{
    public class StudentsRepository<IEntity> : BaseRepository<StudentModel>
    {
        public StudentsRepository(IList<StudentModel> _context)
        {
            context = _context;
        }
    }
}
