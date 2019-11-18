using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Rozklad
{
    public partial class Form1 : Form
    {
        readonly IEmployeeOfTheYear employeeOfTheYear;
        readonly IKiller processKiller;
        public Form1()
        {
            InitializeComponent();
            employeeOfTheYear = new EmployeeOfTheYear(this);
            processKiller = employeeOfTheYear as IKiller;
            employeeOfTheYear.SetValuesOnStart();
        }

        private void StartNewWeek_button_Click(object sender, EventArgs e)
        {
            employeeOfTheYear.DisplayWeeklyAndMonthlyGrades();
            employeeOfTheYear.StartNewWeek();
        }
        private void SaveTimetable_button_Click(object sender, EventArgs e) => employeeOfTheYear.SaveTimetable();
        private void CloseProgram_button_Click(object sender, EventArgs e) => processKiller.CloseProgram();
    }
}
