

namespace NexusBackEndAPI 
{ 
    public interface ITeacherAttendance
    {

        void AddTeacherAttendence(TeacherAttendanceDTO data);

        Report GetteacherAttendenceById(string Teachid);

        List<TeacherAttendance> GetAll();

        Report GetTeacherAttendencebyMonth(DateTime month);

      
    }
}
