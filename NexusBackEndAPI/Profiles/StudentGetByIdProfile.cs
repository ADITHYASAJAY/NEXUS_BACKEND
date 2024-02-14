using AutoMapper;

using System.Runtime.InteropServices;
namespace NexusBackEndAPI.Profiles
{
    public class StudentGetByIdProfile : Profile
    {
        public StudentGetByIdProfile()
        {
            CreateMap<StudentGetByIdDTO, Student>();
            CreateMap<Student, StudentGetByIdDTO>();
        }
    }
}
