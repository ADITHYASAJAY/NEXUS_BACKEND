

namespace NexusBackEndAPI
{
    public class ExamRepository : IExamRepository<Exam>
    {
        private readonly ContextClass _contextClass;
        public ExamRepository(ContextClass contextClass) 
        {
         this._contextClass = contextClass;
        }

        public void AddExam(Exam exam)
        {
            try
            {
                var e = _contextClass.Exams.Where(x => x.ExamName == exam.ExamName && x.ExamDate==exam.ExamDate && x.ClassId==exam.ClassId);
                if (e.Count()>0) 
                {
                    throw new Exception("Cannot add Exam Schedule");
                }
                else 
                {
                    _contextClass.Exams.Add(exam);
                    _contextClass.SaveChanges();
                }
               
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        

        public List<Exam> GetAllExamDetails()
        {
            try
            {
                var examschedules = _contextClass.Exams.ToList();
                return examschedules;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<Exam> GetExamsofaClass(string id)
        {
            try
            {
                var result = _contextClass.Exams.Where(x => x.ClassId == id);
                return result.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
