using System;
using System.IO;
using System.Windows.Forms;
using HotelManagerApp.Services;
using HotelManagerApp.Data;

namespace HotelManagerApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            DataManager dataManager = new DataManager();
            HotelManager originalManager = new HotelManager();

            string filePath = "data.json";

            dataManager.SaveData(originalManager, filePath);

         
            if (File.Exists(filePath))
            {
               
                HotelManager loadedManager = dataManager.LoadData(filePath);

                string testMessage = "Тест Комміту 4 пройшов успішно!\n\n" +
                                     "Файл data.json створено та успішно прочитано.\n\n" +
                                     "Збережено кімнат: " + originalManager.Rooms.Count + "\n" +
                                     "Завантажено кімнат: " + loadedManager.Rooms.Count + "\n\n" +
                                     "Шлях до файлу:\n" + Path.GetFullPath(filePath);

                MessageBox.Show(testMessage, "Результат збереження");
            }
            else
            {
                MessageBox.Show("Помилка: файл data.json не знайдено!", "Помилка");
            }
        }
    }
}