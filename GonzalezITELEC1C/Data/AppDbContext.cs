using GonzalezITELEC1C.Models;
using Microsoft.EntityFrameworkCore;

namespace GonzalezITELEC1C.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(


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
                );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Ezequiel",
                    LastName = "Gonzalez",
                    IsTenured = true,
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("11/09/2019"),
                    Phone = "00-0000-0000"


                },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Kirsten",
                    LastName = "Zulaybar",
                    IsTenured = false,
                    Rank = Rank.Instructor,
                    HiringDate = DateTime.Parse("11/09/2023"),
                     Phone = "00-0000-0000"

                },
                new Instructor()
                {
                    Id = 3,
                    FirstName = "Edmund Lecter",
                    LastName = "Garraton",
                    IsTenured = true,
                    Rank = Rank.AssociateProfessor,
                    HiringDate = DateTime.Parse("11/09/2023"),
                     Phone = "00-0000-0000"
                }
                );


            }
        }

    }

