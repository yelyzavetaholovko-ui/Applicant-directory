using System;

namespace ApplicantDirectory
{
    // Клас, що описує спеціальність (згідно з п. 2.2.1 Пояснювальної записки)
    public class Specialty
    {
        public string Title { get; set; }           // Назва спеціальності
        public double FullTimeScore { get; set; }   // Прохідний бал (денна форма)
        public double EveningScore { get; set; }    // Прохідний бал (вечірня форма)
        public double ExtramuralScore { get; set; } // Прохідний бал (заочна форма)
        public decimal TuitionFee { get; set; }     // Вартість контракту

        // Конструктор класу для зручного створення нових спеціальностей
        public Specialty(string title, double fullTimeScore, double eveningScore, double extramuralScore, decimal tuitionFee)
        {
            Title = title;
            FullTimeScore = fullTimeScore;
            EveningScore = eveningScore;
            ExtramuralScore = extramuralScore;
            TuitionFee = tuitionFee;
        }
    }
}