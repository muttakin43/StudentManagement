using Microsoft.EntityFrameworkCore;
using StudentManagementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAL.Repository
{
    public class StudentRepository
    {
        private readonly DBContext _context;
        public StudentRepository(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAll()
        {
            var query=_context.Students;
            var queryString=query.ToQueryString();
            return _context.Students.ToList();


        }
        public void Add(Student student)
            {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}

