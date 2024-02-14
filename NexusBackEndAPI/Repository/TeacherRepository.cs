using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace NexusBackEndAPI
{
    public class TeacherRepository : ITeacherRepository<Teacher>
    {
        private readonly ContextClass contextClass;



        public TeacherRepository(ContextClass contextClass)
        {
            this.contextClass = contextClass;

        }
        public void AddTeacher(Teacher entity)
        {
            try
            {
                contextClass.Teachers.Add(entity);
                contextClass.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public List<Teacher> GetTeacherbySubject(string Subject)
        {
            try
            {

                List<Teacher> teachersBySubject = contextClass.Teachers.Where(t => t.SubjectTaught == Subject).ToList();
                if (teachersBySubject.Count > 0)
                {
                    return teachersBySubject;
                }
                else
                {
                    throw new Exception("No teachers present");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public List<Teacher> GetAll()
        {
            try
            {
                var teachers = contextClass.Teachers.ToList();
                if (teachers != null)
                {
                    return teachers;
                }
                else
                {
                    throw new Exception("No teacher records present");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }




        public Teacher GetTeacherBYId(string id)
        {
            try
            {
                var teacher = contextClass.Teachers.SingleOrDefault(c => c.TeacherId == id);
                if (teacher != null)
                {
                    return teacher;
                }
                else
                {
                    throw new Exception("No Teacher by this Id");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void UpdateTeacher(Teacher entity)
        {
            try
            {
                contextClass.Teachers.Update(entity);
                contextClass.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void DeleteTeacher(string id)
        {
            try
            {
                Teacher teacher = contextClass.Teachers.Find(id);
                if (teacher != null)
                {
                    contextClass.Teachers.Remove(teacher);
                    contextClass.SaveChanges();
                }
                else
                {
                    throw new Exception("NO teacher to delete");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Teacher> GetTeacherByClassId(string id)
        {
            var teachers = from teacher in contextClass.Teachers
                           join cls in contextClass.ClassSchedules
                           on teacher.TeacherId equals cls.TeacherId
                           where id == cls.ClassId
                           select teacher;
            return teachers.ToList();
        }

    }
}
