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
        static Dictionary<DayOfWeek, string> goodDay = new Dictionary<DayOfWeek, string>();

        static SuchAGoodDay()
        {
            DictionaryIni();
        }

        static void DictionaryIni()
        {
            goodDay.Add(DayOfWeek.Monday, "Понеділок");
            goodDay.Add(DayOfWeek.Tuesday, "Вівторок");
            goodDay.Add(DayOfWeek.Wednesday, "Середа");
            goodDay.Add(DayOfWeek.Thursday, "Четвер");
            goodDay.Add(DayOfWeek.Friday, "П'ятниця");
            goodDay.Add(DayOfWeek.Saturday, "Субота");
        }
        public static string GetDayName(DayOfWeek day)
        {
            return goodDay.ContainsKey(day) ? goodDay[day] : "no";
        }
    }
}
