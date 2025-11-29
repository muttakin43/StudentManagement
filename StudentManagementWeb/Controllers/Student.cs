using Microsoft.AspNetCore.Mvc;
using StudentManagementBLL.Services;

namespace StudentManagementWeb.Controllers
{
    public class Student : Controller
    {
        private readonly StudentService _studentService;

        public Student(StudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentManagementModel.Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.AddStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        
    }
}

