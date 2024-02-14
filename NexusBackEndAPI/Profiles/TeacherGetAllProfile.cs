using AutoMapper;



namespace NexusBackEndAPI.Profiles 
{ 
    public class TeacherGetAllProfile : Profile
    {
        public TeacherGetAllProfile()
        {
            CreateMap<TeacherGetAllDTO, Teacher>();
            CreateMap<Teacher, TeacherGetAllDTO>();
        }
    }
}
