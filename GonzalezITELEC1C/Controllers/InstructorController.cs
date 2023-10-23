using Microsoft.AspNetCore.Mvc;
using GonzalezITELEC1C.Models;
using GonzalezITELEC1C.Services;
using GonzalezITELEC1C.Data;
using Microsoft.EntityFrameworkCore;

namespace GonzalezITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
       
            private readonly AppDbContext _dbContext;

            public InstructorController(AppDbContext dbContext)
            {
                  _dbContext = dbContext; 
            }
            /*
            List<Instructor> InstructorList = new List<Instructor>()
                {
                    new Instructor()
                    {
                        Id = 1,
                        FirstName = "Ezequiel",
                        LastName = "Gonzalez",
                        IsTenured = true,
                        Rank = Rank.Professor,
                        HiringDate = DateTime.Parse("11/09/2019")


                     },
                    new Instructor()
                    {
                         Id = 2,
                        FirstName = "Kirsten",
                        LastName = "Zulaybar",
                        IsTenured = false,
                        Rank = Rank.Instructor,
                        HiringDate = DateTime.Parse("11/09/2023")


                    },
                    new Instructor()
                  {
                         Id = 3,
                        FirstName = "Edmund Lecter",
                        LastName = "Garraton",
                        IsTenured = true,
                        Rank = Rank.AssociateProfessor,
                        HiringDate = DateTime.Parse("11/09/2023")
                  }
                  };*/
            public IActionResult Index()
        {
           
            return View(_dbContext.Instructors);
        }
        public IActionResult ShowDetails(int id)
        {
            
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null) {
                return View(instructor);
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            _dbContext.Instructors.Add(newInstructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditInstructor(int id)
        {

            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult EditInstructor(Instructor updateInstructor)
        {

            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == updateInstructor.Id);

            if (instructor != null)
            {
                instructor.Id = updateInstructor.Id;
                instructor.FirstName = updateInstructor.FirstName;
                instructor.LastName = updateInstructor.LastName;
                instructor.Rank = updateInstructor.Rank;
                instructor.IsTenured = updateInstructor.IsTenured;
                instructor.HiringDate = updateInstructor.HiringDate;
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
            {
                return View(instructor);
            }

            return NotFound();

        }
        [HttpPost]
        public IActionResult DeleteInstructor(Instructor delInstructor)
        {
           Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == delInstructor.Id);
            _dbContext.Instructors.Remove(instructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}

            
        
    
