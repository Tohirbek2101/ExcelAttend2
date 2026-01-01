using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAttend2.Domain.Models
{
    public class ExternalAttendance
    {
        public string FullNameWithId {  get; set; }
        public string Email {  get; set; }
        public DateTime EnterDate {  get; set; }
        public DateTime ExitDate {  get; set; }
        public int Duration {  get; set; }
        public string IsHost {  get; set; }
        public string IsWaiting {  get; set; }

    }
}
