using System.ComponentModel.DataAnnotations;

namespace GonzalezITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {

        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Enter your First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter your Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Status")]
        [Required(ErrorMessage = "Select your Status")]
        public bool IsTenured { get; set; }
        [Display(Name = "Rank")]
        [Required(ErrorMessage = "Select your Rank")]
        public Rank Rank { get; set; }
        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Select your Hiring Date")]
        public DateTime HiringDate { get; set; }
        [Display(Name ="Phone")]
        [RegularExpression("[0-9]{2}-[0-9]{4}-[0-9]{4}",ErrorMessage = "Must be this format 00-0000-0000")]
        [Required(ErrorMessage = "Select a Date")]
        public string Phone { get; set; }

    }
}
