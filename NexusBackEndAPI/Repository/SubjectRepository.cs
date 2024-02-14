

namespace NexusBackEndAPI
{
    public class SubjectRepository : ISubjectRepository<Subject>
    {
        private readonly ContextClass _contextClass;
        public SubjectRepository(ContextClass contextClass) 
        {
            this._contextClass = contextClass;
        }
        public List<Subject> GetSubjects()
        {            
			 try
			{
				return _contextClass.Subjects.ToList();
			}
			catch (Exception ex)
			{

				throw new Exception (ex.Message);
			}
        }
    }
}
