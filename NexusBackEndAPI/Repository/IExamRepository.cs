

namespace NexusBackEndAPI
{
    public interface IExamRepository<T> where T : class
    {
        void AddExam(T exam);
        
        List<T> GetAllExamDetails();
       

       

    }
}
