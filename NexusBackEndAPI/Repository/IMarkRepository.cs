

namespace NexusBackEndAPI
{
    public interface IMarkRepository<T> where T : class 
    {
        void AddResult(List<T> t);
        List<Marks> GetExamResultofClass(string examId);
        List<Marks> GetExamResultofStudent(string studentId);

    }
   
}
