
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace NexusBackEndAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly StudentRepository studentRepository;
        public StudentController(StudentRepository studentRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this.studentRepository = studentRepository;
        }
        [HttpGet("Get_All_Student")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(studentRepository.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("Add_Student")]
        public IActionResult AddStudent(Student student)
        {
            try
            {
                studentRepository.Add(student);
                return Ok("Student Added");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete("Delete_Student/{StudentId}")]
        public IActionResult DeleteStudent(string StudentId)
        {
            try
            {
                studentRepository.Delete(StudentId);
                return Ok("Student Deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut("Edit_Student")]
        public IActionResult EditStudent(Student student)
        {
            try
            {
                studentRepository.Update(student);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get_Student_by_Id/{StudentId}")]
        public IActionResult GetStudentById(string StudentId)
        {
            try
            {
                return Ok(studentRepository.GetStudentById(StudentId));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get_Student_by_Class/{ClassId}")]
        public IActionResult GetStudentByClass(string ClassId)
        {
            try
            {
                return Ok(studentRepository.GetStudentsByClass(ClassId));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get_Student_by_Class_And_Section/{ClassId}/{Section}")]
        public IActionResult GetStudentByClassSection(string ClassId, string Section)
        {
            try
            {
                return Ok(studentRepository.GetStudentByClassSection(ClassId, Section));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
