using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace NexusBackEndAPI
{
    public class TeacherAttendance
    {
        [Key]
        public int TeacherAttendanceId { get; set; }

        private Teacher Teacher { get; set; }
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime AttendaceDate { get; set; }
        public string isTeacherPresent { get; set; }
    }
}
