using AutoMapper;

namespace NexusBackEndAPI.Profiles
{
    public class teacherGetSubjectProfile : Profile
    {
        public teacherGetSubjectProfile()
        {
            CreateMap<TeacherGetBySubjectDTO, Teacher>();
            CreateMap<Teacher, TeacherGetBySubjectDTO>();
        }
    }
}
