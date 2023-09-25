using System;
using GonzalezITELEC1C.Controllers;
using GonzalezITELEC1C.Models;
using GonzalezITELEC1C.Services;
namespace GonzalezITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
       
       public List<Student> StudentLists { get; }
        public List<Instructor> InstructorLists { get; }
        //Constructor

        public MyFakeDataService()
        {
             StudentLists = new List<Student>()
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
              };

             InstructorLists = new List<Instructor>()
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
              };
        }

      
    }
}
