using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NexusBackEndAPI
{
    public class ClassSchedule
    {
        [Key]
        public string ClassScheduleId { get; set; }
        
        private Class? Class { get; set; }
        [ForeignKey("Class")]
        public string ClassId {  get; set; }
        
        private Subject? Subject { get; set; }
        [ForeignKey("Subject")]
        public string SubjectId {  get; set; }
        
        private Teacher? Teacher { get; set; }
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; } 
        public int TimeSlot { get; set; }
    }
}
