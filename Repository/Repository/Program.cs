using Repository.DAL.InterFaces;
using Repository.DAL.Repositories;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<StudentModel> students = new List<StudentModel>();
            StudentsRepository<StudentModel> studentRepo = new StudentsRepository<StudentModel>(students);
            int createRes = studentRepo.Create(new StudentModel { Id = 1, Age = 18, FirstName = "F1", LastName = "L1", Grade = 1 });
            StudentModel student = studentRepo.GetItem(1);
            int editRes = studentRepo.Edit(new StudentModel { Id = 1, Age = 19, FirstName = "F1", LastName = "L1", Grade = 1 });
            int createRes1 = studentRepo.Create(new StudentModel { Id = 2, Age = 21, FirstName = "F2", LastName = "L2", Grade = 2 });
            List<StudentModel> curStudents = studentRepo.GetItems().ToList();
            bool delRes = studentRepo.Delete(1);
            List<StudentModel> curStudents1 = studentRepo.GetItems().ToList();
            int createRes2 = studentRepo.Create(new StudentModel { Id = 3, Age = 24, FirstName = "F3", LastName = "L3", Grade = 2 });

            IList<TeacherModel> teachers = new List<TeacherModel>();
            TeacherRepository<TeacherModel> teacherRepository = new TeacherRepository<TeacherModel>(teachers);
            int creatTRes = teacherRepository.Create(new TeacherModel{ Id = 1, Age = 48, FirstName = "T1", LastName = "T1", Grade = 1 });
            int creatTRes1 = teacherRepository.Create(new TeacherModel{ Id = 2, Age = 54, FirstName = "T2", LastName = "T2", Grade = 2 });
            bool locRes = teacherRepository.LocateStudents(2, students);

        }
    }
}
