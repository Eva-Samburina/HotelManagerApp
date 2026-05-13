using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelManagerApp.Models;
using HotelManagerApp.Services;

namespace HotelManagerApp
{ 
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            HotelManager manager = new HotelManager();
            List<Room> freeRooms = manager.GetAvailableRooms("Standard", 2);

            string testMessage = "Тест пройшов успішно.\n" +
                                 "Знайдено вільних номерів: " + freeRooms.Count + "\n";

            if (freeRooms.Count > 0)
            {
                testMessage += "ID першого номера: " + freeRooms[0].ID;
            }
            else
            {
                testMessage += "На жаль, вільних номерів не знайдено.";
            }

            MessageBox.Show(testMessage, "Результат");
        }
    }
}