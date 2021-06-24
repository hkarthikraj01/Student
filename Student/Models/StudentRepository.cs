using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Models
{
    public class StudentRepository : IStudentRepository
    {

        private readonly ApplicationDbContext _db = null;
        public StudentRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        //Create
        public async Task AddStudent(StudentList student)
        {
            await _db.Students.AddAsync(student);
            await _db.SaveChangesAsync();
        }
        //Read
        public async Task<List<StudentList>> GetAllStudents()
        {
            var list = await _db.Students.ToListAsync();
            return list;
        }

        public async Task<StudentList> GetStudentById(int? id)
        {
            StudentList student = await _db.Students.FindAsync(id);
            return student;
        }

        //Delete
        public async Task DeleteStudent(int? id)
        {
            StudentList student = await _db.Students.FindAsync(id);
            _db.Students.Remove(student);
            await _db.SaveChangesAsync();
        }

        public async Task SaveDetails()
        {
            await _db.SaveChangesAsync();
        }
    }
}
