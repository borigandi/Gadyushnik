using System;
using System.Collections.Generic;

namespace Rozklad
{
    [Serializable]
    public class ForSerialization
    {
        public string monday, tuesday, wednesday, thursday, friday, saturday, finalMonthlyGrades;
        public int weeklyGrades, monthlyGrades, currentWeekNumber;
        public List<int> CheckedIndices { get; set; }
    }
}
