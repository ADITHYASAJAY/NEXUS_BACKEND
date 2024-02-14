using AutoMapper;

namespace NexusBackEndAPI.Profiles
{
    public class StudentGetAllProfile : Profile
    {
        public StudentGetAllProfile()
        {
            CreateMap<StudentGetAllDTO, Student>();
            CreateMap<Student, StudentGetAllDTO>();
        }
    }
}
