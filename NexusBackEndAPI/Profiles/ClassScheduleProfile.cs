using AutoMapper;
using NexusBackEndAPI.DTOs;
using NexusBackEndAPI.Entities;

namespace NexusBackEndAPI.Profiles
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
