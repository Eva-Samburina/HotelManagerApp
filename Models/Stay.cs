using System;

namespace HotelManagerApp.Models
{
    // Клас, що описує факт проживання (бронювання) гостя у номері
    public class Stay
    {
        // Посилання на об'єкт гостя
        public Guest Guest { get; set; }

        // Посилання на об'єкт кімнати
        public Room Room { get; set; }

        // Дата та час заїзду
        public DateTime ArrivalDate { get; set; }

        // Дата та час запланованого виїзду
        public DateTime DepartureDate { get; set; }

        // Фінальна вартість проживання
        public decimal TotalCost { get; set; }

        // Статус оплати
        public bool IsPaid { get; set; }

        // Позначка про наявність затримки при виселенні
        public bool HasDelay { get; set; }
    }
}