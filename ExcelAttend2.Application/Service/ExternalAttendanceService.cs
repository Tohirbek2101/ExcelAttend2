using ExcelAttend2.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAttend2.Application.Service
{
    public class ExternalAttendanceService
    {
        public FileContext myExcelFile { get; set; }
        public ExternalAttendanceService()
        {
            this.myExcelFile = new FileContext();
        }
        public void EkrangaChiqar()
        {
            Console.WriteLine("EXCEL ro'yxati");
            foreach(var item in myExcelFile.ExternalAttendances)
            {
                Console.WriteLine($"FullNAmeWithId: {item.FullNameWithId}, Email: {item.Email}, EnterDate = {item.EnterDate}, ExitDate = {item.ExitDate}, Duration = {item.Duration}, IsHost = {item.IsHost}, IsWainting = {item.IsWaiting}");
            }
        }
            
    }
}
