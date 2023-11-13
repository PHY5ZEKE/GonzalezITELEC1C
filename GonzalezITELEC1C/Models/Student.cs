using System.ComponentModel.DataAnnotations;

namespace GonzalezITELEC1C.Models
{
    public enum Major
    {
        BSIT, BSCS, BSIS
    }
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Enter your First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter your Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Enter your email")]
        public string Email { get; set; }
        [Display(Name = "Birthday")]
        [Required(ErrorMessage = "Enter your Birthday")]
        public DateTime Birthday { get; set; }
        [Display(Name = "Major")]
        [Required(ErrorMessage = "Select your Major")]
        public Major Major { get; set; }





    }
}

