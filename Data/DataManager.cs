using System;
using System.IO;
using System.Text.Json;
using HotelManagerApp.Services;

namespace HotelManagerApp.Data
{
    // Клас для роботи з файловою системою та збереження даних готелю у форматі JSON
    public class DataManager
    {
       
        private JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        // Метод для перетворення об'єкта менеджера в текст і збереження у файл
        public void SaveData(HotelManager manager, string path)
        {
            
            string json = JsonSerializer.Serialize(manager, _options);
            File.WriteAllText(path, json);
        }

        // Метод для читання файлу та відновлення даних при запуску програми
        public HotelManager LoadData(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    string json = File.ReadAllText(path);
                    HotelManager manager = JsonSerializer.Deserialize<HotelManager>(json, _options);
                    if (manager != null)
                    {
                        return manager;
                    }
                }
                catch
                {
                    
                    return new HotelManager();
                }
            }
            return new HotelManager();
        }
    }
}