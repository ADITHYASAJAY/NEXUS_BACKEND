
using Microsoft.EntityFrameworkCore;

namespace NexusBackEndAPI
{
    public class ClassScheduleRepository : IClassScheduleRespository<ClassSchedule>
    {
        private readonly ContextClass _contextClass;

        public ClassScheduleRepository(ContextClass contextClass) 
        {
            this._contextClass = contextClass;
        }

        public void AssignTeacher(ClassSchedule t)
        {
            try
            {
                var v = _contextClass.ClassSchedules.Find(t.ClassScheduleId);
                if (v != null) 
                {
                    v.TeacherId = t.TeacherId;
                    _contextClass.ClassSchedules.Update(v);
                    _contextClass.SaveChanges();

                }
                else 
                {
                    throw new Exception("Cannot assign teacher");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void DeleteClassSchedule(string Id)
        {
            try
            {
                var classschedule = _contextClass.ClassSchedules.Find(Id);
                if (classschedule != null) 
                {
                    _contextClass.ClassSchedules.Remove(classschedule);
                    _contextClass.SaveChanges ();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ClassSchedule> DisplayClassScheduleBYClass(string id)
        {

            try
            {
                var classscheduleofClass = _contextClass.ClassSchedules.Where(x => x.ClassId.Equals(id)).ToList();
                if (classscheduleofClass != null) 
                {
                    return classscheduleofClass;
                }
                else 
                {
                    throw new Exception("no schedule present");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<ClassSchedule> DisplayClassScheduleBYTeacher(string id)
        {

            try
            {
                var classcheduleofClass = _contextClass.ClassSchedules.Where(x => x.TeacherId.Equals(id)).ToList();
                if (classcheduleofClass != null) 
                {
                    return classcheduleofClass; 
                }
                else 
                {
                    throw new Exception("no schedule present");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<ClassSchedule> GetAllSchedules()
        {
            try
            {
                return _contextClass.ClassSchedules.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void ScheduleClass(ClassSchedule t)
        {

            try
            {
                var v = _contextClass.ClassSchedules.FirstOrDefault(x=>(x.TimeSlot == t.TimeSlot && x.TeacherId == t.TeacherId));
                if (v==null) 
                {
                    _contextClass.ClassSchedules.Add(t);
                    _contextClass.SaveChanges();
                }
                else 
                {
                    throw new Exception("Cannot assign teacher. Already assigned!!");
                    
                }
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
        public void UpdateSchedule(ClassSchedule t)
        {
            try
            {
                var updateschedule = _contextClass.ClassSchedules.FirstOrDefault(x => x.ClassScheduleId.Equals(t.ClassScheduleId));
                if (updateschedule != null) 
                {
                    _contextClass.ClassSchedules.Update(updateschedule);
                    _contextClass.SaveChanges();
                }
                else 
                {
                    throw new Exception("No records to update");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Class> GetAllClass() 
        {

            try
            {
                var classes = _contextClass.Classes.ToList();
                return classes;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Subject> AllSubjects() 
        {
            try
            {
                var subjects=_contextClass.Subjects.ToList();
                return subjects;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        
    }
}
