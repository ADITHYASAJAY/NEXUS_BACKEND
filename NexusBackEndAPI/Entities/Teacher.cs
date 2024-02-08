using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusBackEndAPI.Entities
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

        public int TeacherPhoneno { get; set; }
        [Required]
        public string TeacherEmail { get; set; }

        public string SubjectTaught { get; set; }
    }
}
