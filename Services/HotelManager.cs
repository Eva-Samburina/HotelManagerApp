using HotelManagerApp.Models;


using System.Collections.Generic;
using System.Linq;
using HotelManagerApp.Models;

namespace HotelManagerApp.Services
{
    // Головний клас-менеджер, що містить колекції даних та реалізує бізнес-логіку готелю
    public class HotelManager
    {
        // Колекція всіх номерів готельного фонду
        public List<Room> Rooms { get; set; }

        // Колекція всіх зареєстрованих клієнтів (гостей)
        public List<Guest> Guests { get; set; }

        // Колекція поточних та минулих бронювань (поселень)
        public List<Stay> Stays { get; set; }

        // Конструктор класу, який створює порожні списки та додає тестові дані
        public HotelManager()
        {
            Rooms = new List<Room>();
            Guests = new List<Guest>();
            Stays = new List<Stay>();

            Rooms.Add(new StandardRoom { ID = 101, Category = "Standard", Capacity = 2, BasePrice = 1000m, Status = "Вільний" });
            Rooms.Add(new SuiteRoom { ID = 201, Category = "Suite", Capacity = 2, BasePrice = 2500m, Status = "Вільний" });
        }

        // Метод для пошуку вільних номерів за заданими критеріями за допомогою LINQ
        public List<Room> GetAvailableRooms(string category, int capacity)
        {
            return Rooms.Where(r => r.Category == category && r.Capacity >= capacity && r.Status == "Вільний").ToList();
        }

        // Метод для динамічного розрахунку фінальної вартості проживання
        public decimal CalculateTotalCost(Room room, DateTime arrivalDate, DateTime departureDate)
        {
            int days = (departureDate - arrivalDate).Days;
            if (days <= 0) days = 1;

            return days * room.BasePrice;
        }

        // Метод для поселення гостя у номер та створення запису про бронювання
        public void RegisterGuest(Guest guest, Room room, DateTime arrivalDate, DateTime departureDate)
        {
            room.Status = "Зайнятий";
            Guests.Add(guest);

            Stay newStay = new Stay
            {
                Guest = guest,
                Room = room,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
                TotalCost = CalculateTotalCost(room, arrivalDate, departureDate),
                IsPaid = false,
                HasDelay = false
            };

            Stays.Add(newStay);
        }

        // Метод для оформлення від'їзду клієнта, фіксації затримок та звільнення номера
        public void ProcessCheckOut(Stay stay, DateTime actualDeparture)
        {
            if (actualDeparture > stay.DepartureDate)
            {
                stay.HasDelay = true;
            }
            stay.Room.Status = "На прибиранні";
        }

        // Метод для гнучкого пошуку бронювань за прізвищем гостя або його паспортом
        public List<Stay> Search(string keyword)
        {
            string lowerKeyword = keyword.ToLower();

            return Stays.Where(s =>
                (s.Guest.FullName != null && s.Guest.FullName.ToLower().Contains(lowerKeyword)) ||
                (s.Guest.PassportData != null && s.Guest.PassportData.ToLower().Contains(lowerKeyword))
            ).ToList();
        }
    }
}