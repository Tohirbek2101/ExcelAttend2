using ExcelAttend2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAttend2.Infrastructure.Data
{
    public class DbContext:FileContext
    {
        public List<StudentAttend> StudentAttendances { get; set; }
        public DbContext()
        {
            this.StudentAttendances = new List<StudentAttend>();
            foreach(var item in ExternalAttendances)
            {
                var value = item.FullNameWithId.Split(' ');
                var firstName=value[0];
                var lastName=value[1];
                var id=value[2];
                var myNewStudent = StudentAttendances.FirstOrDefault(x => x.Id == id);
                if (myNewStudent != null)
                {
                    myNewStudent.ParticipationMinutes += item.Duration;

                    if (myNewStudent.FirstEntryTime > item.EnterDate)
                    {
                        myNewStudent.FirstEntryTime = item.EnterDate;
                    }

                    if (myNewStudent.LastExitTime < item.ExitDate)
                    {
                        myNewStudent.LastExitTime = item.ExitDate;
                    }
                }
                else
                {
                    StudentAttendances.Add(new StudentAttend
                    {
                        Id = id,
                        FirstName = firstName,
                        LastName = lastName,
                        Email = item.Email,
                        FirstEntryTime = item.EnterDate,
                        LastExitTime = item.ExitDate,
                        ParticipationMinutes = item.Duration,
                    });
                }
            }
        }
    }
}
