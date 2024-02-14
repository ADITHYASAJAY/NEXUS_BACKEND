using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NexusBackEndAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly ExamRepository _repository;

        public ExamController(IMapper mapper, ExamRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpPost,Route("AddExam")]
        public IActionResult AddExam(Exam exam) 
        {
            try
            {
                _repository.AddExam(exam);
                return Ok(exam);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        
        }

        [HttpGet, Route("GetExamDetailsforaClass/{classid}")]
        public IActionResult GetExam(string classid)
        {
            try
            {
                var result = _repository.GetExamsofaClass(classid);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }



        [HttpGet,Route("GetAllExamDetails")]
        public IActionResult GetExamDetails() 
        {
            try
            {
                var result = _repository.GetAllExamDetails();
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

       
    }
}
