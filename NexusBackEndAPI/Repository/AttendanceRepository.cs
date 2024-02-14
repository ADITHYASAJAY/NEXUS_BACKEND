using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;


using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NexusBackEndAPI
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly ContextClass _contextClass;
        private readonly IMapper _mapper;
        public AttendanceRepository(ContextClass contextClass, IMapper mapper) 
        {
        _contextClass = contextClass;
            _mapper = mapper;
        }

        public void AddStudentAttendence(AttendanceDTO data)
        {
            try
            {
                var item = _mapper.Map<Attendance>(data);
                item.AttendaceDate = DateTime.Now;
                _contextClass.Attendances.Add(item);
                _contextClass.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public List<Attendance> GetAll()
        {
            try
            {
                return _contextClass.Attendances.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Report GetStudAttendenceById(string StudId)
        {
            try
            {
                Report report = new Report();
                var getids = _contextClass.Attendances.Where(x => x.StudentId == StudId);
                List<Attendance> ta = _contextClass.Attendances.Where(t => t.StudentId == StudId).ToList();
                var dates = getids.ToList();
                report.TotalWorkDays = ta.Count();
                report.Present = ta.Where(t => t.isStudentPresent == "P").Count();
                report.Absent = ta.Where(t => t.isStudentPresent == "A").Count();
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

        public Report GetStudentAttendencebyMonth(DateTime month)
        {
            try
            {
                Report sar = new Report();

                List<Attendance> ta = _contextClass.Attendances.Where(t => t.AttendaceDate.Month == month.Month).ToList();
                sar.TotalWorkDays = ta.Count();
                sar.Absent = ta.Where(t => t.isStudentPresent != "P").Count();
                sar.Present = sar.TotalWorkDays - sar.Absent;
                sar.AttendancePercentage = (sar.Present / sar.TotalWorkDays) * 100;




                return sar;
            }
            catch (Exception)
            {

                throw;
            }
        }

       

       
    }
}
