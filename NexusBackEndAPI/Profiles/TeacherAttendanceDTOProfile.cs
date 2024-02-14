using AutoMapper;


namespace NexusBackEndAPI 
{ 
    public class TeacherAttendanceDTOProfile:Profile
    {
        public TeacherAttendanceDTOProfile() 
        {
            CreateMap<TeacherAttendanceDTO, TeacherAttendance>();
            CreateMap<TeacherAttendance, TeacherAttendanceDTO>();
        }
    }
}
