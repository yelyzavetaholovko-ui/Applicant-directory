using System;
using System.Collections.Generic;

namespace ApplicantDirectory
{
    // Клас опису закладу вищої освіти
    public class University
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        // Колекція спеціальностей, що належать університету
        public List<Specialty> Specialties { get; set; }

        // Ініціалізація властивостей об'єкта
        public University(string name, string address, string city)
        {
            Name = name;
            Address = address;
            City = city;
            Specialties = new List<Specialty>();
        }

        // Метод додавання освітньої програми
        public void AddSpecialty(Specialty specialty)
        {
            Specialties.Add(specialty);
        }
    }
}