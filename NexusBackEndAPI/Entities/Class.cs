using System.ComponentModel.DataAnnotations;

namespace NexusBackEndAPI
{
    public class Class
    {
        [Key]
        public string Class_Id { get; set; }
        public string ClassName { get; set; }

        public string Section {  get; set; }
    }
}
