using ExcelAttend2.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAttend2.Application.Service
{
    public class StudentAttendService
    {
        public DbContext _DbContext {  get; set; }
        public StudentAttendService()
        {
            this._DbContext = new DbContext();
        }
        public void YangiJadvalniKorish()
        {
            Console.WriteLine("          YANGI JADVAL KO'RINISHI         ");
            foreach(var item in _DbContext.StudentAttendances)
            {
                Console.WriteLine($" Id = {item.Id}, FirstName = {item.FirstName}, LastName = {item.LastName}, Email = {item.Email}, FirstEntryTime = {item.FirstEntryTime}, LastExitTime = {item.LastExitTime}, ParticipationMinutes = {item.ParticipationMinutes} ");
            }
        }
    }
}
