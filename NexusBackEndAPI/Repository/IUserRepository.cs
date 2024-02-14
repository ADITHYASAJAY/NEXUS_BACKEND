using NexusUserBackend.DTO;


namespace NexusUserBackend.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(string id);
        void Update(T entity);
        void Delete(string id);
        bool Add(UserDto entity);
    }


}

