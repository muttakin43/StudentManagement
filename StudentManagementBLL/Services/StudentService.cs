using StudentManagement.DAL.Repository;
using StudentManagementModel;

namespace StudentManagementBLL.Services
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }

        public void AddStudent(Student student)
        {
            _studentRepository.Add(student);
        }
    }
}
