using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAttend2.Domain.Models
{
    public class StudentAttend
    {
        public string Id { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public DateTime FirstEntryTime {  get; set; }
        public DateTime LastExitTime {  get; set; }
        public int ParticipationMinutes { get; set; }

    }
}
