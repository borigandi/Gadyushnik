using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad
{
    static class SuchAGoodDay
    {
        static Dictionary<DayOfWeek, string> daysOfWeek = new Dictionary<DayOfWeek, string>();

        static SuchAGoodDay()
        {
            InitializeDictionary();
        }

        static void InitializeDictionary()
        {
            daysOfWeek.Add(DayOfWeek.Monday, "Понеділок");
            daysOfWeek.Add(DayOfWeek.Tuesday, "Вівторок");
            daysOfWeek.Add(DayOfWeek.Wednesday, "Середа");
            daysOfWeek.Add(DayOfWeek.Thursday, "Четвер");
            daysOfWeek.Add(DayOfWeek.Friday, "П'ятниця");
            daysOfWeek.Add(DayOfWeek.Saturday, "Субота");
        }
        public static string GetDayName(DayOfWeek day)
        {
            return daysOfWeek.ContainsKey(day) ? daysOfWeek[day] : "Неділя - вихідний";
        }
    }
}
