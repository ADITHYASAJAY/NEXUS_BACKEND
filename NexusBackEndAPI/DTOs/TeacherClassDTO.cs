using System.ComponentModel.DataAnnotations;

namespace NexusBackEndAPI
{
    public class TeacherClassDTO
    {
       
        public string TeacherId { get; set; }
        public string  TeacherFirstName { get; set; }
       
        public string TeacherLastName { get; set; }
        public string SubjectTaught { get; set; }
    }
}
