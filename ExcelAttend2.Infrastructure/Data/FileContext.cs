using ExcelAttend2.Domain.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAttend2.Infrastructure.Data
{
    public class FileContext
    {
        public List<ExternalAttendance> ExternalAttendances { get; set; }
        public FileContext()
        {
            this.ExternalAttendances=new List<ExternalAttendance>();
            using var package = new ExcelPackage(new FileInfo(@"C:\Users\User\Desktop\Yangi\fixed_attendance.xlsx"));
            var worksheet = package.Workbook.Worksheets[0];
            var rowCount=worksheet.Dimension.Rows;
            for (int row = 2; row <= rowCount; row++)
            {
                // Bo'sh qatorni tekshirish (agar birinchi ustun bo'sh bo'lsa, tashlab o'tadi)
                if (string.IsNullOrWhiteSpace(worksheet.Cells[row, 1].Text)) continue;

                // Exceldagi tekst ko'rinishidagi sanalarni olish
                string enterDateRaw = worksheet.Cells[row, 3].Text;
                string exitDateRaw = worksheet.Cells[row, 4].Text;

                // Sana formatini belgilash (Rasmda: 20.12.2025 07:03:42 AM)
                string dateFormat = "dd.MM.yyyy hh:mm:ss tt";

                ExternalAttendances.Add(new ExternalAttendance
                {
                    FullNameWithId = worksheet.Cells[row, 1].Text,
                    Email = worksheet.Cells[row, 2].Text,

                    // Sanani tekstdan DateTime ob'ektiga o'girish
                    EnterDate = DateTime.ParseExact(enterDateRaw, dateFormat, System.Globalization.CultureInfo.InvariantCulture),
                    ExitDate = DateTime.ParseExact(exitDateRaw, dateFormat, System.Globalization.CultureInfo.InvariantCulture),

                    // Duration ustuni uchun xavfsiz o'girish (xato chiqmasligi uchun)
                    Duration = int.TryParse(worksheet.Cells[row, 5].Text, out int d) ? d : 0,

                    IsHost = worksheet.Cells[row, 6].Text,
                    IsWaiting = worksheet.Cells[row, 7].Text
                });
            }
            /*for(int row=2; row<=rowCount; row++)
            {
                ExternalAttendances.Add(new ExternalAttendance
                {
                    FullNameWithId = worksheet.Cells[row,1].Text,
                    Email=worksheet.Cells[row,2].Text,
                    //EnterDate = worksheet.Cells[row, 3].GetValue<DateTime>(),
                    //ExitDate = worksheet.Cells[row,4].GetValue<DateTime>(),
                    Duration = int.Parse(worksheet.Cells[row,5].Text),
                    IsHost=worksheet.Cells[row,6].Text,
                    IsWaiting=worksheet.Cells[row,7].Text
                });
            }*/
        }
    }
}
