using Microsoft.AspNetCore.Mvc;
using GonzalezITELEC1C.Models;
using GonzalezITELEC1C.Services;
using GonzalezITELEC1C.Data;

namespace GonzalezITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbContext;
        
        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /*
        List<Student> StudentList = new List<Student>()
            {
            new Student()
            {
                Id = 1,
                FirstName = "Ezequiel",
                LastName = "Gonzalez",
                Birthday = DateTime.Parse("09/07/2001"),
                Major = Major.BSIT,
                Email = "ezequiel.gonzalez.cics@ust.edu.ph"
            },
             new Student()
             {
                 Id = 2,
                 FirstName = "Rico",
                 LastName = "Nieto",
                 Birthday = DateTime.Parse("04/01/2002"),
                 Major = Major.BSIT,
                 Email = "rico.nieto.cics@ust.edu.ph"
             },
              new Student()
              {
                  Id = 3,
                  FirstName = "Jakob",
                  LastName = "Palomo",
                  Birthday = DateTime.Parse("08/12/2002"),
                  Major = Major.BSIT,
                  Email = "jakob.palomo.cics@ust.edu.ph"
              }
              };*/
        public IActionResult Student()
        {
            return View(_dbContext.Students);
               }
        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _dbContext.Students.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Student");
        }
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult EditStudent(Student updateStudent)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == updateStudent.Id);
            if (student != null)
            {
                student.Id = updateStudent.Id;
                student.FirstName = updateStudent.FirstName;
                student.LastName = updateStudent.LastName;
                student.Email = updateStudent.Email;
                student.Birthday = updateStudent.Birthday;
                student.Major = updateStudent.Major;
            }//was an student found?
            _dbContext.SaveChanges();
            return RedirectToAction("Student");
        }
        [HttpGet]
        public IActionResult DeleteStud(int id)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
           
        }
        [HttpPost]
        public IActionResult DeleteStud(Student delStudent)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == delStudent.Id);
            _dbContext.Students.Remove(student);
            _dbContext.SaveChanges();
            return RedirectToAction("Student");

        }
    }
}
