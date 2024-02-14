using System.ComponentModel.DataAnnotations.Schema;

namespace NexusBackEndAPI 
{ 
    public class MarksofStudentDto
    {
        public string? ExamName { get; set; }
        public int Mark { get; set; }
    }
}
