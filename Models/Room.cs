using System;

namespace HotelManagerApp.Models
{
    // Абстрактний базовий клас, що містить інформацію про готельний фонд
    public abstract class Room
    {
        // Унікальний ідентифікатор номера
        public int ID { get; set; }

        // Категорія кімнати (наприклад, Standard, Suite, Deluxe)
        public string Category { get; set; }

        // Кількість спальних місць у номері
        public int Capacity { get; set; }

        // Базова ціна проживання за одну добу
        public decimal BasePrice { get; set; }

        // Поточний статус (Вільний, Зайнятий, На прибиранні, Ремонт)
        public string Status { get; set; }
    }

    // Клас, що представляє стандартний номер
    public class StandardRoom : Room { }

    // Клас, що представляє номер покращеного планування (люкс)
    public class SuiteRoom : Room { }

    // Клас, що представляє номер найвищого комфорту (делюкс)
    public class DeluxeRoom : Room { }
}