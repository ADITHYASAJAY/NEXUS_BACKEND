namespace NexusBackEndAPI
{
    public interface ISubjectRepository<T> where T : class
    {
        List<T> GetSubjects();
    }
}
