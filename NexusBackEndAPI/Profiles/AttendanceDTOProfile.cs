using AutoMapper;


namespace NexusBackEndAPI
{
    public class AttendanceDTOProfile:Profile
    {
        public AttendanceDTOProfile() 
        {
            CreateMap<AttendanceDTO, Attendance>();
            CreateMap<Attendance, AttendanceDTO>();
        }
    }
}
