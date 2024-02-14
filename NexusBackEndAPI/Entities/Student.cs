using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NexusBackEndAPI
{
    
    public class Student
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //disable the identity
        public string? StudentId { get; set; }
        [Column("First Name")]
        public string? StudentFirstName { get; set; }
        [Column("Last Name")]
        public string? StudentLastName { get; set; }

        private Class? Class { get; set; }
        [ForeignKey("Class")]
        public string ClassId { get; set; }

        public string Section { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string StudentEmail { get; set; }
        public string GetFullName()
        {
            return $"{this.StudentFirstName}, {this.StudentLastName}";
        }
    }
}
