using System.ComponentModel.DataAnnotations.Schema;

namespace NexusBackEndAPI.Entities
{
    public class ClassSchedule
    {
        public string ClassScheduleId { get; set; }

        public Class? Class { get; set; }
        [ForeignKey("Class")]
        public string ClassId { get; set; }




        public Subject? Subject { get; set; }
        [ForeignKey("Subject")]
        public string SubjectId { get; set; }

        private Teacher? Teacher { get; set; }
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }
        public int TimeSlot { get; set; }
    }
}
