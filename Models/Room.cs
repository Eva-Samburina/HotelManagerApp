using System;

namespace HotelManagerApp.Models
{
    // Клас, що описує базові характеристики готельного номера
    public class Room
    {
        // Унікальний ідентифікатор номера
        public int ID { get; set; }

        // Категорія комфортності номера (Standard, Suite, Deluxe)
        public string Category { get; set; }

        // Кількість спальних місць у номері
        public int Capacity { get; set; }

        // Базова вартість номера за одну добу (для 1 людини)
        public decimal BasePrice { get; set; }

        // Доплата за кожне додаткове спальне місце в номері
        public decimal ExtraPersonPrice { get; set; }

        // Поточний статус номера (Вільний, Зайнятий, На прибиранні)
        public string Status { get; set; }
    }

    // Клас, що представляє номер стандартної категорії
    public class StandardRoom : Room
    {
        // Конструктор, який ініціалізує стандартний номер базовими цінами та категорією
        public StandardRoom()
        {
            Category = "Standard";
            BasePrice = 1000m;
            ExtraPersonPrice = 250m;
        }
    }

    // Клас, що представляє номер категорії люкс
    public class SuiteRoom : Room
    {
        // Конструктор, який ініціалізує номер люкс базовими цінами та категорією
        public SuiteRoom()
        {
            Category = "Suite";
            BasePrice = 2500m;
            ExtraPersonPrice = 500m;
        }
    }

    // Клас, що представляє номер категорії делюкс
    public class DeluxeRoom : Room
    {
        // Конструктор, який ініціалізує номер делюкс базовими цінами та категорією
        public DeluxeRoom()
        {
            Category = "Deluxe";
            BasePrice = 4000m;
            ExtraPersonPrice = 1000m;
        }
    }
}