using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace NexusBackEndAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public readonly TeacherRepository obj;

        private readonly IMapper _mapper;

        public TeacherController(TeacherRepository obj, IMapper mapper)
        {
            this.obj = obj;
            _mapper = mapper;
        }
        [HttpPost, Route("AddTeacher")]
        public IActionResult Add([FromBody] Teacher teacher)
        {
            try
            {
                obj.AddTeacher(teacher);
                return Ok(teacher);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        [HttpGet, Route("GetTeacherById/{id}")]
        public IActionResult GetTeacherbyId(string id)
        {
            try
            {
                return Ok(obj.GetTeacherBYId(id));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpGet, Route("GetTeacherBySubject/{Subject}")]
        public IActionResult getTeacherbySubject(string Subject)
        {
            try
            {
                List<Teacher> teachers = obj.GetTeacherbySubject(Subject);
                List<TeacherGetBySubjectDTO> teacherDTOs = _mapper.Map<List<TeacherGetBySubjectDTO>>(teachers);
                return Ok(teacherDTOs);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpGet, Route("GetTeacherByClassid/{id}")]
        public IActionResult GetTeacherByClassId(string id)
        {
            List<Teacher> teachers = obj.GetTeacherByClassId(id);
            List<TeacherClassDTO> teacherDTOs = _mapper.Map<List<TeacherClassDTO>>(teachers);
            return Ok(teacherDTOs);
        }
        [HttpGet, Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                List<Teacher> teachers = obj.GetAll();
                List<TeacherGetAllDTO> teacherDTOs = _mapper.Map<List<TeacherGetAllDTO>>(teachers);
                return Ok(teacherDTOs);
                //return Ok(obj.GetAll());
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpPut, Route("UpdateTeacher")]
        public IActionResult Update(Teacher teacher)
        {
            try
            {
                obj.UpdateTeacher(teacher);
                return Ok(teacher);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpDelete, Route("DeleteTeacher")]
        public IActionResult Delete(string id)
        {
            try
            {
                obj.DeleteTeacher(id);
                return Ok("Teacher Deleted");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
