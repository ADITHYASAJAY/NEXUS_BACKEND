

namespace NexusBackEndAPI
{
    public class MarkRepository : IMarkRepository<Marks>
    {
        private readonly ContextClass _contextClass;
        public MarkRepository(ContextClass contextClass) 
        {
            this._contextClass = contextClass;
        }
        public void AddResult(List<Marks> marksInExam)
        {
            try
            {
                foreach (Marks mark in marksInExam) 
                {
                    _contextClass.Marks.Add(mark);
                    _contextClass.SaveChanges();
                }
                  
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Marks> GetExamResultofClass(string examId)
        {
            try
            {

                var marks = _contextClass.Marks.Where(x => x.ExamId == examId).ToList();
                return marks;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Marks> GetExamResultofStudent(string studentId)
        {
            try
            {
                var marks = _contextClass.Marks.Where(x => x.StudentId == studentId);
               
                return marks.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        } 
        
        public string GetExamName(string examId) 
        {
            var exam = _contextClass.Exams.Find(examId);
            return (exam.ExamName);
        }
        public string GetFullNameofStudent(string studentId) 
        {
            var student= _contextClass.Students.Find(studentId);
            return (student.GetFullName());
        }
    }
}
