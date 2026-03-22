using ModelinASPCore.Models;
using System.Linq;

namespace ModelinASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<Student> GetAllStudents()
        {
            return Datasource();
        }

        public Student? GetStudent(int id)
        {
            return Datasource().Where(x => x.RollNo == id).FirstOrDefault();
        }


        private List<Student> Datasource()
        {
            return new List<Student>
            {

                new Student{ RollNo=1,Name="Rima",Gender='F',Standard=5},
                new Student{ RollNo=2,Name="Raam",Gender='M',Standard=5},
                new Student{ RollNo=3,Name="Riya",Gender='F',Standard=5}
            };


        }

    }
}
