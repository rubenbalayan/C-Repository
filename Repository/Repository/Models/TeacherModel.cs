using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class TeacherModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int Grade { get; set; }
    }
    public partial class TeacherModel
    {
        public string FullName { get => $"{FirstName} {LastName}"; }

        public IList<StudentModel> StudList { get; private set; }


    }

  
}
