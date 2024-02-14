using AutoMapper;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NexusBackEndAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly MarkRepository _repository;

        public MarkController (IMapper mapper, MarkRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        
        [HttpPost, Route("AddMarks")]
        public IActionResult AddMarks(List<Marks> marks)
        {
            try
            {
                _repository.AddResult(marks);
                return Ok(marks);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        [HttpGet, Route("GetExamDetailsofClass/{examid}")]
        public IActionResult GetClassExamResultDetails(string examid)
        {
            try
            {
                var result = _repository.GetExamResultofClass(examid);
                if(result != null) 
                {
                    List<MarksofClassDto> marksofClasses = [];

                    foreach(var v in result) 
                    {
                        var s =_mapper.Map<MarksofClassDto>(v);
                        s.StudentFullName=_repository.GetFullNameofStudent(v.StudentId);
                        marksofClasses.Add(s);
                    }
                    return Ok(marksofClasses);
                }
                else { return BadRequest(); }
                

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpGet, Route("GetExamResult/{studentId}")]
        public IActionResult GetStudentResult(string studentId)
        {
            try
            {
                var result = _repository.GetExamResultofStudent(studentId);
                if (result != null) 
                {
                    List<MarksofStudentDto> marks = [];

                    foreach (var v in result)
                    {
                        var s = _mapper.Map<MarksofStudentDto>(v);
                        s.ExamName = _repository.GetExamName(v.ExamId); 
                        marks.Add(s);
                    }
                    return Ok(marks);
                }
                else 
                {
                    return BadRequest();
                }
               
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
