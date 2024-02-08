namespace NexusBackEndAPI.Repository
{
    public interface IClassScheduleRespository<T> where T : class
    {
        void ScheduleClass(T t);
        void UpdateSchedule(T t);
        List<T> DisplayClassScheduleBYClass(string id);
        List<T> DisplayClassScheduleBYTeacher(string id);
        void AssignTeacher(T t);
        void DeleteClassSchedule(string Id);
        List<T> GetAllSchedules();
    }
}
