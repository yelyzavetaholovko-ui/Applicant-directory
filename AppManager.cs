using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace ApplicantDirectory
{
    public class AppManager
    {
        public List<University> Universities { get; set; }
        private string filePath = "database.json"; 

        public AppManager()
        {
            Universities = new List<University>();
        }

        // Пошук та сортування ЗВО за спеціальністю
        public List<University> FindMinScore(string specialtyTitle)
        {
            return Universities
                .Where(u => u.Specialties.Any(s => s.Title.Contains(specialtyTitle, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(u => u.Specialties.First(s => s.Title.Contains(specialtyTitle, StringComparison.OrdinalIgnoreCase)).FullTimeScore)
                .ToList();
        }

        // Метод збереження даних у файл
        public void SaveToFile()
        {
            string json = JsonSerializer.Serialize(Universities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // Метод завантаження даних із файлу при запуску
        public void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Universities = JsonSerializer.Deserialize<List<University>>(json) ?? new List<University>();
            }
        }
    }
}