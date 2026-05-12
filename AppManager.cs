using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicantDirectory
{
    // Головний клас (згідно з п. 2.2.3 Пояснювальної записки)
    public class AppManager
    {
        // Список усіх університетів у базі даних
        public List<University> Universities { get; set; }

        public AppManager()
        {
            Universities = new List<University>();
        }

        // Метод для пошуку спеціальності з найменшим балом (Сценарій 1.1.1)
        public List<University> FindMinScore(string specialtyTitle)
        {
            // Пошук ВНЗ, де є така спеціальність + сортування за зростанням балу на денну ф. 
            return Universities
                .Where(u => u.Specialties.Any(s => s.Title.Contains(specialtyTitle, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(u => u.Specialties.First(s => s.Title.Contains(specialtyTitle, StringComparison.OrdinalIgnoreCase)).FullTimeScore)
                .ToList();
        }

        // Метод для видалення університету (Сценарій 1.1.4)
        public void RemoveUniversity(string name)
        {
            Universities.RemoveAll(u => u.Name == name);
        }

        // Юудуть методи SaveToFile() та LoadFromFile() для роботи з JSON/CSV
    }
}