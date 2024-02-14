using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusBackEndAPI
{
    public class Marks
    {
        [Key]
        public string? MarkId { get; set; }

        private Exam? Exam { get; set; }

        [ForeignKey("Exam")]
        public string ExamId { get; set; }

        Student? Student { get; set; }

        [ForeignKey("Student")]
        public string? StudentId { get; set; }
        public int Mark { get; set; }
    }
}
