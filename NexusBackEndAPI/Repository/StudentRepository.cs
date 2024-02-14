
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

using System;
using System.Security.Cryptography;

namespace NexusBackEndAPI
{
    public class StudentRepository : IStudentRepository<Student>
    {
        public readonly ContextClass contextClass;
        public StudentRepository(ContextClass contextClass)
        {
            this.contextClass = contextClass;
        }

        public void Add(Student entity)
        {
            try
            {
                contextClass.Students.Add(entity);
                contextClass.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(string StudentId)
        {
            try
            {
                Student student = contextClass.Students.Find(StudentId);
                contextClass.Students.Remove(student);
                contextClass.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Student> GetAll()
        {
            try
            {
                return contextClass.Students.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Student> GetStudentByClassSection(string ClassId, string Section)
        {
            try
            {
                List<Student> student = contextClass.Students.Where(x => x.ClassId == ClassId && x.Section == Section).ToList();
                return student;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Student> GetStudentsByClass(string ClassId)
        {
            try
            {
                List<Student> student = contextClass.Students.Where(x => x.ClassId == ClassId).ToList();
                return student;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Student GetStudentById(string StudentId)
        {
            try
            {
                Student student = contextClass.Students.Find(StudentId);
                return student;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Student entity)
        {
            try
            {
                contextClass.Students.Update(entity);
                contextClass.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}





//public class StudentRepository : IStudentRepository
//{
//    private readonly MyContext _context;

//    public StudentRepository(MyContext context)
//    {
//        _context = context;
//    }

//    public void AddStudent(Student student)
//    {
//        try
//        {
//            _context.Students.Add(student);
//            _context.SaveChanges();
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//    }

//    public void DeleteStudent(string id)
//    {
//        try
//        {
//            Student student = _context.Students.Find(id);
//            _context.Students.Remove(student);
//            _context.SaveChanges();
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//    }
//    public void UpdateStudent(Student student)
//    {
//        try
//        {
//            _context.Students.Update(student);
//            _context.SaveChanges();
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//    }
//    public List<Student> GetAllStudent(Student student)
//    {
//        try
//        {
//            return _context.Students.ToList();
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//    }
//    public Student GetAllStudentByRollno(string id)
//    {
//        try
//        {
//            return _context.Students.Find(id);
//        }
//        catch (Exception)
//        {
//            throw;
//        }
//    }

//    public List<Student> GetAllStudentByClass(string std)
//    {

//    }

//    public List<Student> GetAllStudentByClassSection(string std, string section)
//    {
//        throw new NotImplementedException();
//    }





