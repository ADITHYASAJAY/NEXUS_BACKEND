using AutoMapper;


namespace NexusBackEndAPI
{
    public class ClassScheduleProfile:Profile
    {
        public ClassScheduleProfile()
        {
            CreateMap<ClassScheduleStudentDto, ClassSchedule>();
            CreateMap<ClassSchedule, ClassScheduleStudentDto>();

            CreateMap<ClassTeacherScheduleDto, ClassSchedule>();
            CreateMap<ClassSchedule, ClassTeacherScheduleDto>();

            CreateMap<TeacherScheduleDto, ClassSchedule>();
            CreateMap<ClassSchedule, TeacherScheduleDto>();
        }
    }
}
