using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB160223
{
    struct Birthday
    {
        private DateTime _birthdayDate;

        public Birthday(DateTime birthdayDate)
        {
            _birthdayDate = new DateTime(birthdayDate.Year, birthdayDate.Month, birthdayDate.Day);
        }

        public void SetDate(DateTime birthdayDate)
        {
            _birthdayDate = new DateTime(birthdayDate.Year, birthdayDate.Month, birthdayDate.Day);
        }

        public DayOfWeek GetDayOfWeek()
        {
            return _birthdayDate.DayOfWeek;
        }

        public DayOfWeek GetDayOfWeekInYear(int year)
        {
            return new DateTime(year, _birthdayDate.Month, _birthdayDate.Day).DayOfWeek;
        }

        public int GetDaysUntilNextBirthday()
        {
            DateTime nextBirthday = new DateTime(DateTime.Now.Year, _birthdayDate.Month, _birthdayDate.Day);
            if (nextBirthday < DateTime.Now)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            return (nextBirthday - DateTime.Now).Days;
        }
    }
}
