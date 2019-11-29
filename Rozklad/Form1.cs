using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Rozklad
{
    public partial class Form1 : Form
    {
        private ILaunchHelper LaunchHelper { get; }
        private ITimetableHelper TimetableHelper { get; }
        private IGradesHelper GradesHelper { get; }
        public Form1()
        {
            InitializeComponent();
            LaunchHelper = new ClassMonitor(this);
            TimetableHelper = LaunchHelper as ITimetableHelper;
            GradesHelper = LaunchHelper as IGradesHelper;
            LaunchHelper.SetValuesOnStart();
        }
        private void StartNewWeek_button_Click(object sender, EventArgs e)
        {
            GradesHelper.ShowWeeklyAndMonthlyGrades();
            TimetableHelper.StartNewWeek();
        }
        private void SaveTimetable_button_Click(object sender, EventArgs e) => TimetableHelper.SaveTimetable();
        private void CloseProgram_button_Click(object sender, EventArgs e)
        {
            LaunchHelper.SaveValuesBeforeClosing();
            Process.GetCurrentProcess().Kill();
        }
    }
}
