using System;

namespace ApplicantDirectory
{
    // Клас для опису спеціальності та умов вступу
    public class Specialty
    {
        public string Title { get; set; }
        public double FullTimeScore { get; set; }
        public double EveningScore { get; set; }
        public double ExtramuralScore { get; set; }
        public decimal TuitionFee { get; set; }

        // Ініціалізація властивостей спеціальності
        public Specialty(string title, double fullTime, double evening, double extramural, decimal fee)
        {
            Title = title;
            FullTimeScore = fullTime;
            EveningScore = evening;
            ExtramuralScore = extramural;
            TuitionFee = fee;
        }
    }
}