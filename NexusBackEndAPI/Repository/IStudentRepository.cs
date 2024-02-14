
namespace NexusBackEndAPI
{
   
        public interface IStudentRepository<T> where T : class
        {
            T GetStudentById(string StudentId);
            List<T> GetStudentsByClass(string ClassId);
            List<T> GetStudentByClassSection(string ClassId, string Section);
            List<T> GetAll();
            void Add(T entity);
            void Update(T entity);
            void Delete(string StudentId);

        }

    
}


//public void AddStudent(Student student);
//public void UpdateStudent(Student student);
//public void DeleteStudent(string id);
//public List<Student> GetAllStudent(Student student);
//public Student GetAllStudentByRollno(string id);
//public List<Student> GetAllStudentByClass(string std);
//public List<Student> GetAllStudentByClassSection(string std, string section);
