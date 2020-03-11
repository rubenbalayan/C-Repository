using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class StudentModel:BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }
    public partial class StudentModel
    {
        public string FullName { get=>$"{FirstName} {LastName}";}
    }
}
