![Console App Demo](Assets/ZOOMExcel.gif)
# ExcelAttend2

**ExcelAttend2** — bu C# tilida yozilgan modul bo‘lib, **Excel fayllar orqali talaba va xodimlar davomatini boshqarish tizimi**. Loyiha qatlamli arxitektura asosida tuzilgan: **Domain**, **Infrastructure**, **Application** va **Client** qatlamlari mavjud.

Ushbu loyiha orqali siz:
- Excel faylni o‘qish va attendans ma’lumotlarini konsolga chiqarish,
- Talabalar va xodimlar davomatini boshqarish,
- Hisobotlar yaratish va qatlamli arxitektura orqali yangi funksiyalar qo‘shish imkoniyatiga ega bo‘lasiz.

---

## 🧱 Loyihaning Tuzilishi

ExcelAttend2/
├── ExcelAttend2.sln
├── ExcelAttend2/ # Asosiy loyiha
├── ExcelAttend2.Application/ # Biznes mantiq va servislar
│ ├── ExternalAttendanceService.cs
│ └── StudentAttendService.cs
├── ExcelAttend2.Client/ # Konsol interfeysi
│ └── Program.cs
├── ExcelAttend2.Domain/ # Modellar
│ ├── ExternalAttendance.cs
│ └── StudentAttend.cs
├── ExcelAttend2.Infrastructure/ # Ma’lumotlar qatlamlari
│ ├── DbContext.cs
│ └── FileContext.cs
├── .gitignore
└── README.md

yaml
Copy code

---

## 🚀 Xususiyatlar (Features)

- 📥 **Excel bilan ishlash**: Excel faylni o‘qib, attendans ma’lumotlarini konsolga chiqarish.
- 🧠 **Qatlamli arxitektura**: Domain‑First yondashuv, modulga asoslangan tuzilma.
- 🔌 **Talabalar boshqaruvi**: Management servisi orqali CRUD imkoniyatlari.
- 💡 **Hisobot yaratish**: Talabalar va xodimlar qatnashuv vaqtlarini ko‘rish.

---

## 🛠️ Texnologiyalar

| Texnologiya | Maqsad |
|-------------|--------|
| C# | Asosiy dasturlash tili |
| .NET 6+ | Framework |
| EPPlus | Excel fayllarni o‘qish va yozish |
| Visual Studio 2022 | IDE |

---

## 📦 O‘rnatish

1. Repo’nni klonlash:
```bash
git clone https://github.com/Tohirbek2101/ExcelAttend2.git
Visual Studio orqali ochish:

text
Copy code
ExcelAttend2.sln
Zarur NuGet paketlarini o‘rnatish:

EPPlus (Excel bilan ishlash uchun)

▶️ Ishga tushirish
ExcelAttend2.Client loyihasini StartUp Project sifatida tanlang.

Run (F5) tugmasini bosing.

Konsolda parolni kiriting:

nginx
Copy code
admin123
Asosiy menyuda tanlov qiling:

1️⃣ Talabalar boshqaruvi

2️⃣ EXCEL ro'yxatni ko'rish

3️⃣ Davomat hisobotini ko'rish

0️⃣ Chiqish

📝 Foydalanish Misoli
EXCEL ro'yxatni ko'rish
text
Copy code
EXCEL ro'yxati
FullNAmeWithId: John Doe 123, Email: john@example.com, EnterDate = 10.01.2026 08:00, ExitDate = 10.01.2026 09:30, Duration = 90, IsHost = Yes, IsWaiting = No
Talabalar davomati
text
Copy code
YANGI JADVAL KO'RINISHI
Id = 123, FirstName = John, LastName = Doe, Email = john@example.com, FirstEntryTime = 10.01.2026 08:00, LastExitTime = 10.01.2026 09:30, ParticipationMinutes = 90
