using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusBackEndAPI
{
    public class Exam
    {
        [Key]
        public string ExamId { get; set; }
        public string? ExamName { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ExamDate { get; set; }
        private Class? Class { get; set; }
        [ForeignKey("Class")]
        public string? ClassId { get; set; }
    }
}
