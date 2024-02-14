
using AutoMapper;

using static System.Runtime.InteropServices.JavaScript.JSType;


namespace NexusBackEndAPI
{
    public class TeacherAttendanceRepo : ITeacherAttendance
    {

        private readonly ContextClass _contextClass;
        private readonly IMapper _mapper;
        public TeacherAttendanceRepo(ContextClass contextClass, IMapper mapper)
        {
            _contextClass = contextClass;
            _mapper = mapper;
        }
        public void AddTeacherAttendence(TeacherAttendanceDTO data)
        {
            try
            {
                var item = _mapper.Map<TeacherAttendance>(data);
                item.AttendaceDate = DateTime.Now;
                _contextClass.TeacherAttendances.Add(item);
                _contextClass.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TeacherAttendance> GetAll()
        {
            try
            {
                return _contextClass.TeacherAttendances.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Report GetteacherAttendenceById(string Teachid)
        {
            try
            {
                Report report = new Report();
                var getids = _contextClass.TeacherAttendances.Where(x => x.TeacherId == Teachid);
                List<TeacherAttendance> ta=_contextClass.TeacherAttendances.Where(t=>t.TeacherId==Teachid).ToList();
                var dates = getids.ToList();
                report.TotalWorkDays = ta.Count();
                report.Present = ta.Where(t => t.isTeacherPresent == "P").Count();
                report.Absent = ta.Where(t => t.isTeacherPresent == "A").Count();
                report.AttendancePercentage = (report.Present / report.TotalWorkDays) * 100;
                //report.Present = Present;
                //report.Absent = Absent;
                //report.AttendancePercentage = AttendancePercentage;
                return report;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Report GetTeacherAttendencebyMonth(DateTime month)
        {
            try
            {
               
                Report tar= new Report();

                List<TeacherAttendance> ta= _contextClass.TeacherAttendances.Where(t=>t.AttendaceDate.Month==month.Month).ToList();
                tar.TotalWorkDays = ta.Count();
                tar.Absent=ta.Where(t=>t.isTeacherPresent!="P").Count();
                tar.Present = tar.TotalWorkDays - tar.Absent;
                tar.AttendancePercentage = (tar.Present / tar.TotalWorkDays) * 100;

                
                
               
                return tar;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
