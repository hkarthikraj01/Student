using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Models
{
    public interface IStudentRepository
    {
        Task AddStudent(StudentList s);
        Task<List<StudentList>> GetAllStudents();
        Task<StudentList> GetStudentById(int? id);
        Task DeleteStudent(int? id);

    }
}
