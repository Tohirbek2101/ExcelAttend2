using ExcelAttend2.Application.Service;
using Management.Application.Services; // Management servisini qo'shamiz
using Managment.Client;
namespace ExcelAttend2.Client
{
    internal class Program
    {
        public ExternalAttendanceService myExternalAttendance { get; set; }
        public StudentAttendService myStudentAttend { get; set; }
        public StudentService myStudentManagement { get; set; } // Yangi servis

        private const string PASSWORD = "admin123";

        public Program()
        {
            this.myExternalAttendance = new ExternalAttendanceService();
            this.myStudentAttend = new StudentAttendService();
            this.myStudentManagement = new StudentService(); // Init
        }

        static void Main(string[] args)
        {
            if (!Authenticate()) return; // Avval login

            Console.WriteLine("           XUSH KELIBSIZ                    ");
            var program = new Program();
            program.Run();
        }

        // Management'dan olingan login mantiqi
        static bool Authenticate()
        {
            int attempts = 0;
            while (attempts < 3)
            {
                Console.Write("Parolingizni kiriting: ");
                if (Console.ReadLine() == PASSWORD) return true;
                attempts++;
                Console.WriteLine($"Xato! {3 - attempts} urinish qoldi.");
            }
            return false;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n--- ASOSIY MENYU ---");
                Console.WriteLine("1. Talabalar boshqaruvi (Management)");
                Console.WriteLine("2. EXCEL ro'yxatni ko'rish");
                Console.WriteLine("3. Davomat hisobotini ko'rish");
                Console.WriteLine("0. Chiqish");

                Console.Write("Tanlov: ");
                var input = Console.ReadLine();

                if (input == "0") break;

                switch (input)
                {
                    case "1":
                        Managment.Client.Program.ShowStudengMenu();// ManagementSubMenu();
                        break;
                    case "2":
                        myExternalAttendance.EkrangaChiqar();
                        break;
                    case "3":
                        myStudentAttend.YangiJadvalniKorish();
                        break;
                }
            }
        }
    }
}