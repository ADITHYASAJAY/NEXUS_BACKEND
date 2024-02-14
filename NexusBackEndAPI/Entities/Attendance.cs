using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace NexusBackEndAPI
{
    public class Attendance
    {
        [Key]
        
        public int StudentAttendanceId { get; set; }


        private Student Student { get; set; }

        [ForeignKey("Student")]
        public string StudentId { get; set; }
      
        [Required]
        [Column(TypeName = "Date")]
        public DateTime AttendaceDate { get; set; }

        public string isStudentPresent { get; set; }
        
    }
}
