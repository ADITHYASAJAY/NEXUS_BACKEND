using AutoMapper;

namespace NexusBackEndAPI.Profiles
{
    public class TeacherGetBYClassDTOProfile:Profile
    {
        public TeacherGetBYClassDTOProfile()
        {
            CreateMap<TeacherClassDTO, Teacher>();
            CreateMap<Teacher, TeacherClassDTO>();
        }
    }
}
