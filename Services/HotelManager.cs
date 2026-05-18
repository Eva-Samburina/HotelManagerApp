using System;
using System.Collections.Generic;
using System.Linq;
using HotelManagerApp.Models;

namespace HotelManagerApp.Services
{
    // Клас, що реалізує основну бізнес-логіку управління готелем
    public class HotelManager
    {
        // Колекція всіх номерів готельного фонду
        public List<Room> Rooms { get; set; }

        // Колекція всіх зареєстрованих клієнтів
        public List<Guest> Guests { get; set; }

        // Колекція всіх оформлених бронювань та поселень
        public List<Stay> Stays { get; set; }

        // Конструктор, що ініціалізує порожні списки для зберігання даних
        public HotelManager()
        {
            Rooms = new List<Room>();
            Guests = new List<Guest>();
            Stays = new List<Stay>();
        }

        // Метод для початкового наповнення бази номерного фонду (генерує 24 тестових номери)
        public void GenerateDefaultRooms()
        {
            if (Rooms.Count == 0)
            {
                int standardId = 101;
                int suiteId = 201;
                int deluxeId = 301;

                for (int capacity = 1; capacity <= 4; capacity++)
                {
                    for (int count = 0; count < 2; count++)
                    {
                        Rooms.Add(new StandardRoom { ID = standardId++, Capacity = capacity, Status = "Вільний" });
                        Rooms.Add(new SuiteRoom { ID = suiteId++, Capacity = capacity, Status = "Вільний" });
                        Rooms.Add(new DeluxeRoom { ID = deluxeId++, Capacity = capacity, Status = "Вільний" });
                    }
                }
            }
        }

        // Метод для пошуку вільних номерів за категорією та мінімальною кількістю місць
        public List<Room> GetAvailableRooms(string category, int capacity)
        {
            return Rooms.Where(r => r.Category == category && r.Capacity >= capacity && r.Status == "Вільний").ToList();
        }

        // Метод для динамічного розрахунку фінальної вартості проживання з урахуванням доплат та знижок
        public decimal CalculateTotalCost(Room room, Guest guest, DateTime arrivalDate, DateTime departureDate)
        {
            int days = (departureDate - arrivalDate).Days;
            if (days <= 0) days = 1;

            decimal dailyRate = room.BasePrice + (room.Capacity - 1) * room.ExtraPersonPrice;
            decimal total = days * dailyRate;

            if (guest.LoyaltyLevel == "Срібний")
            {
                total = total * 0.95m;
            }
            else if (guest.LoyaltyLevel == "Золотий")
            {
                total = total * 0.90m;
            }

            return total;
        }

        // Метод для реєстрації нового клієнта та оформлення його поселення у номер
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
                TotalCost = CalculateTotalCost(room, guest, arrivalDate, departureDate),
                IsPaid = false,
                HasDelay = false
            };

            Stays.Add(newStay);
        }

        // Метод для оформлення виїзду клієнта та зміни статусу номера
        public void ProcessCheckOut(Stay stay, DateTime actualDeparture)
        {
            if (actualDeparture > stay.DepartureDate)
            {
                stay.HasDelay = true;
            }
            stay.Room.Status = "На прибиранні";
        }
        // Метод для пошуку інформації про поселення за фрагментом ПІБ або паспорта гостя
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