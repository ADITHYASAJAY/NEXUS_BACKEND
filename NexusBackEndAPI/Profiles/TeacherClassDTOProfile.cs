using AutoMapper;


namespace NexusBackEndAPI
{
    public class TeacherClassDTOProfile:Profile
    {
        public TeacherClassDTOProfile()
        {
            CreateMap<TeacherClassDTO, Teacher>();
            CreateMap<Teacher, TeacherClassDTO>();
        }
    }
}
