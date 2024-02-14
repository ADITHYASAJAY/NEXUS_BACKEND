using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NexusBackEndAPI
{
    public class Teacher
    {

        public string TeacherId { get; set; }

        [Required]
        public string TeacherFirstName { get; set; }
        [Required]
        public string TeacherLastName { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Dateofbirth { get; set; }
        public string Gender { get; set; }

        public string TeacherPhoneno { get; set; }
        [Required]
        public string TeacherEmail { get; set; }

        public string SubjectTaught { get; set; }
    }
}
