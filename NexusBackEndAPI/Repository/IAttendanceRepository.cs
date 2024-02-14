
namespace NexusBackEndAPI
{
    public interface IAttendanceRepository
    {
        void AddStudentAttendence(AttendanceDTO data);
        List<Attendance> GetAll();

        Report GetStudAttendenceById(string StudId);

        Report GetStudentAttendencebyMonth(DateTime month);
        
    }
}
