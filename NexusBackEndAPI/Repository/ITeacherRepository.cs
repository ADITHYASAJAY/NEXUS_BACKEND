namespace NexusBackEndAPI
{
    public interface ITeacherRepository<T> where T : class
    {
        public void AddTeacher(T entity);

        List<T> GetTeacherbySubject(string Subject);
        public List<T> GetAll();
        T GetTeacherBYId(string id);
        void UpdateTeacher(T entity);
        void DeleteTeacher(string id);
        List<T> GetTeacherByClassId(string id);

    }
}
