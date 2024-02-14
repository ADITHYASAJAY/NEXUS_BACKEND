using AutoMapper;


namespace NexusBackEndAPI.Profiles
{
    public class MarkProfile:Profile
    {
        public MarkProfile() 
        {
            CreateMap<MarksofStudentDto, Marks>();
            CreateMap<Marks, MarksofStudentDto>();

            CreateMap<MarksofClassDto, Marks>();
            CreateMap<Marks, MarksofClassDto>();
        }    
    }
}
