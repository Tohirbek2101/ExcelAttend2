using ExcelAttend2.Application.Service;

namespace ExcelAttend2.Client
{
    internal class Program
    {
        public ExternalAttendanceService myExternalAttendance { get; set; }
        public StudentAttendService myStudentAttend { get; set; }
        public Program()
        {
            this.myExternalAttendance = new ExternalAttendanceService();
            this.myStudentAttend = new StudentAttendService();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("          XUSH KELIBSIZ                    ");
            var program = new Program();
            program.Run();
        }
        public void Run()
        {
            bool choose = false;
            while (!choose)
            {
                Console.WriteLine("1. EXCEL fayldagi ro'yxatni ko'rish");
                Console.WriteLine("2. Yangi jadvalni ko'rish");
                Console.WriteLine("0. Dasturdan chiqish");
                Console.Write("Tanlovingizni kiriting: ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        myExternalAttendance.EkrangaChiqar();
                        break;
                    case "2":
                        myStudentAttend.YangiJadvalniKorish();
                        break;
                    case "0":
                        choose = true;
                        Console.WriteLine("Dasturdan chiqilyapti...");
                        break;
                    default:
                        Console.WriteLine("Noto'g'ri tanlov, qayta urinib ko'ring.");
                        break;
                }
            }
        }
    }
}
