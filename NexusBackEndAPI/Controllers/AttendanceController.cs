using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NexusBackEndAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly AttendanceRepository obj;
        public AttendanceController(AttendanceRepository obj) 
        {
        this.obj = obj;
        }
        [HttpPost, Route("AddStudAttendence")]
        public IActionResult AddStudAttendence(AttendanceDTO data)
        {
            try
            {
                obj.AddStudentAttendence(data);
                return Ok("Student Attendence Added Succesfully");
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        [HttpGet, Route("GetAllAttendance")]
        public IActionResult GetAllStudAttendances()
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

        [HttpGet, Route("GetStudentAttendenceById/{StudId}")]
        public IActionResult GetStudentAttendenceById(string StudId)
        {
            try
            {
                return Ok(obj.GetStudAttendenceById(StudId));
            }
            catch (Exception)
            {

                throw;
            }
        }

       
        [HttpGet, Route("GetStudentsAttendenceByMonth/{date}")]
        public IActionResult GetStudentsAttendencebyDate(DateTime date)
        {
            try
            {
                return Ok(obj.GetStudentAttendencebyMonth(date));

            }
            catch (Exception)
            {

                throw;
            }
        }
   
        


    }
}
