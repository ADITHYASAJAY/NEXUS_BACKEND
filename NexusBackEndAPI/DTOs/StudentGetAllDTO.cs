namespace NexusBackEndAPI
{
    public class StudentGetAllDTO
    {
        public string? StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string ClassId { get; set; }
        public string Section { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string StudentEmail { get; set; }
    }
}
