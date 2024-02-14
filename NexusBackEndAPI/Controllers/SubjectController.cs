using AutoMapper;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NexusBackEndAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly SubjectRepository _repository;

        public SubjectController(IMapper mapper, SubjectRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet,Route("GetAllSubject")]
        public IActionResult Get() 
        {
            try 
            {
                var subjects =_repository.GetSubjects();
                return Ok(subjects);
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
