using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NexusBackEndAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassScheduleController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly ClassScheduleRepository _repository;

        public ClassScheduleController(ClassScheduleRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet,Route("GetTeacherSchedule/{teacherId}")]
        public IActionResult GetTeacherScheDule(string teacherId) 
        {
            try
            {
                var teacherSchedule = _repository.DisplayClassScheduleBYTeacher(teacherId);
               
                if (teacherSchedule != null)
                {
                    List<ClassTeacherScheduleDto> teacherSchedules = [];
                    foreach (var v in teacherSchedule) 
                    {
                        var s = _mapper.Map<ClassTeacherScheduleDto>(v);
                        teacherSchedules.Add(s);
                    }
                    return Ok(teacherSchedules);
                   
                }
                else { return BadRequest(); }

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        [HttpGet, Route("GetClassSchedule/{classId}")]
        public IActionResult GetClassScheDule(string classId)
        {
            try
            {
                var classSchedule = _repository.DisplayClassScheduleBYClass(classId);
                if (classSchedule != null)
                {
                    List<ClassScheduleStudentDto> scheduleByClassid = [];
                    foreach (var v in classSchedule)
                    {
                        var s = _mapper.Map<ClassScheduleStudentDto>(v);
                        scheduleByClassid.Add(s);
                    }
                    return Ok(scheduleByClassid);

                }
                else { return BadRequest(); }
                

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost,Route("AddClassSchedule")]
        public IActionResult AddClassSchedule(ClassSchedule schedule) 
        {
            try
            {
              
                _repository.ScheduleClass(schedule);
                return Ok(schedule);

            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }

        [HttpPut,Route("AssignTeachers")]
        public IActionResult AssignTeacher(TeacherScheduleDto teacherSchedule) 
        {
            try
            {
                var teacherSchuled = _mapper.Map<ClassSchedule>(teacherSchedule);
                _repository.AssignTeacher(teacherSchuled);

                return Ok("Success");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        
        }

        [HttpGet,Route("GetAllSchedule")]
        public IActionResult GetAll() 
        {
            try
            {
                var v = _repository.GetAllSchedules();
                return Ok(v);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("Delete/{classScheduleId}")]
        public IActionResult Delete(string classScheduleId) 
        {
            try 
            {
                _repository.DeleteClassSchedule(classScheduleId);
                return Ok("Deleted Successfully");
            
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);    
            }
        
        }
        [HttpGet,Route("GetAllClass")]
        public IActionResult AllClass() 
        {
            try
            {
                var result = _repository.GetAllClass();
                return Ok(result);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetAllSubjects")]

        public IActionResult AllSubjects() 
        {
            try
            {
                var subjects=_repository.AllSubjects();
                return Ok(subjects);
            }
            catch (Exception)
            {

                throw;
            }
        }

       

    }
}
