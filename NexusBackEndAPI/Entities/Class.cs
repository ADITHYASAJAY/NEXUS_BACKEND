using System.ComponentModel.DataAnnotations;

namespace NexusBackEndAPI.Entities
{
    public class Class
    {
        [Key]
        public string Class_Id { get; set; }
        public string ClassName { get; set; }
    }
}
