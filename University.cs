using System;
using System.Collections.Generic;

namespace ApplicantDirectory
{
    // Клас, що описує університет (згідно з п. 2.2.2 Пояснювальної записки)
    public class University
    {
        public string Name { get; set; }     // Найменування ЗВО
        public string Address { get; set; }  // Адреса
        public string City { get; set; }     // Місто

        // Список) спеціальностей, які є в цьому університеті
        public List<Specialty> Specialties { get; set; }

        // Конструктор для створення нового університету
        public University(string name, string address, string city)
        {
            Name = name;
            Address = address;
            City = city;
            Specialties = new List<Specialty>(); // Створення порожнього списку при створенні ВНЗ
        }

        // Метод для додавання нової спеціальності до цього університету
        public void AddSpecialty(Specialty specialty)
        {
            Specialties.Add(specialty);
        }
    }
}
