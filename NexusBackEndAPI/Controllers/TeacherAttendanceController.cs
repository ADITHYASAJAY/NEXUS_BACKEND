using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace NexusBackEndAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherAttendanceController : ControllerBase
    {
        private readonly TeacherAttendanceRepo obj;
        public TeacherAttendanceController(TeacherAttendanceRepo obj)
        {
            this.obj = obj;
        }
        [HttpPost, Route("AddTeachAttendence")]
        public IActionResult AddTeachAttendence(TeacherAttendanceDTO data)
        {
            try
            {
                obj.AddTeacherAttendence(data);
                return Ok("Teacher Attendence added Succesfully");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet, Route("GetAllAttendance")]
        public IActionResult GetAllTeacherAttendances()
        {
            try
            {
                return Ok(obj.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet, Route("GetTeachAttendenceById/{id}")]
        public IActionResult GetTeachAttendenceById(string id)
        {
            try
            {
                return Ok(obj.GetteacherAttendenceById(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetTeachersAttendenceByMonth/{date}")]
        public IActionResult GetTeachersAttendencebyDate(DateTime date)
        {
            try
            {
                return Ok(obj.GetTeacherAttendencebyMonth(date));

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
