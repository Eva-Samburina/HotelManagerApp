using System;

namespace HotelManagerApp.Models
{
    // Клас, що зберігає персональні дані клієнта (гостя)
    public class Guest
    {
        // Повне ім'я гостя
        public string FullName { get; set; }

        // Паспортні дані для реєстрації
        public string PassportData { get; set; }

        // Контактний номер телефону
        public string PhoneNumber { get; set; }

        // Рівень лояльності клієнта для розрахунку знижок
        public string LoyaltyLevel { get; set; }
    }
}