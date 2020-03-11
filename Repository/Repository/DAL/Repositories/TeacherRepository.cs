using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL.Repositories
{
    public class TeacherRepository<IEntity> : BaseRepository<TeacherModel>
    {

        public TeacherRepository(IList<TeacherModel> _context)
        {
            context = _context;
        }

        public bool LocateStudents(int teacherID, IList<StudentModel> students)
        {
            var res = false;
            int idx = context.IndexOf(context.FirstOrDefault(x => x.Id == teacherID));
            if (students.Any())
            {
                foreach (var item in students)
                {
                    if (context[idx].Grade == item.Grade)
                    {
                        context[idx].StudList.Add(item);
                    }
                }

                res = true;
            }

            return res;
        }

    }
}
