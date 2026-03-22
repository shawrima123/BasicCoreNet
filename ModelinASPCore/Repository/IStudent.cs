using ModelinASPCore.Models;

namespace ModelinASPCore.Repository
{
    public interface IStudent
    {
        List<Student> GetAllStudents(); //retrivr all data
        Student GetStudent(int id); //retrive only for particular id
    }
}
