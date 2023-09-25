using System;
using GonzalezITELEC1C.Models;
namespace GonzalezITELEC1C.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentLists { get; }
        List<Instructor>InstructorLists { get; }
    }
}
