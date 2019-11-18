using System;
using System.Windows.Forms;
using Rozklad.Properties;
using System.Drawing;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;

namespace Rozklad
{
    class EmployeeOfTheYear : IEmployeeOfTheYear, IKiller
    {
        static Form1 form;
        static int currentWeekNumber; // кожний жмак по кнопці DONE - це +1 до counter 

        public EmployeeOfTheYear(Form1 formRef)
        {
            form = formRef;
            currentWeekNumber = Settings.Default.currentWeekNumberParam;
            Helper.PickOutDay();
        }

        #region Реалізація IEmployeeOfTheYear
        public void DisplayWeeklyAndMonthlyGrades()
        {
            int count = form.checkedListBox1.CheckedItems.Count;
            Settings.Default.week = count;
            Settings.Default.month += count;
            Settings.Default.Save();
            form.weeklyGradesTextBox.Text = Settings.Default.week.ToString();
            form.monthlyGradesTextBox.Text = Settings.Default.month.ToString();
        }
        public void StartNewWeek()
        {
            foreach (int index in form.checkedListBox1.CheckedIndices)
            {
                form.checkedListBox1.SetItemChecked(index, false);
            }
            currentWeekNumber++;

            if(currentWeekNumber >= 4) { Helper.StartNewMonth(); }

            form.currentWeekNumberLabel.Text = (currentWeekNumber + 1).ToString();
            Settings.Default.currentWeekNumberParam = currentWeekNumber;
            Settings.Default.Save();
        }
        public void SetValuesOnStart()
        {
            CheckBoxHelper.SetItemChecked();
            form.mondayTimetable.Text = Settings.Default.monday.ToString();
            form.tuesdayTimetable.Text = Settings.Default.tuesday.ToString();
            form.wednesdayTimetable.Text = Settings.Default.wednesday.ToString();
            form.thursdayTimetable.Text = Settings.Default.thursday.ToString();
            form.fridayTimetable.Text = Settings.Default.friday.ToString();
            form.saturdayTimetable.Text = Settings.Default.saturday.ToString();
            form.weeklyGradesTextBox.Text = Settings.Default.week.ToString();
            form.monthlyGradesTextBox.Text = Settings.Default.month.ToString();
            form.currentWeekNumberLabel.Text = (currentWeekNumber + 1).ToString();
        }
        public void SaveTimetable()
        {
            Helper.SaveTimetableToFile();
            Settings.Default.monday = form.mondayTimetable.Text;
            Settings.Default.tuesday = form.tuesdayTimetable.Text;
            Settings.Default.wednesday = form.wednesdayTimetable.Text;
            Settings.Default.thursday = form.thursdayTimetable.Text;
            Settings.Default.friday = form.fridayTimetable.Text;
            Settings.Default.saturday = form.saturdayTimetable.Text;
            Settings.Default.Save();
            MessageBox.Show("Розклад збережено", "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
        }
        #endregion
        #region Реалізація IKiller
        public void CloseProgram()
        {
            CheckBoxHelper.SaveCheckedIndices();
            Process.GetCurrentProcess().Kill();
        }
        #endregion

        static class Helper
        {
            public static void SaveTimetableToFile()
            {
                // Зберігає розклад в окремий txt файл
                FileInfo saveFile = new FileInfo(@"C:\Games\StudContra Beta Release\RozkladSave.txt");
                StreamWriter writer = saveFile.CreateText();
                foreach (string dayTimetable in GetWeeklyTimetableText())
                {
                    writer.WriteLine(dayTimetable);
                    writer.WriteLine(new string('-', 20));
                }
                writer.Close();
            }
            public static void StartNewMonth()
            {
                // Викликається у методі StartNewWeek() якщо змінна counter >= 4. 
                // Змінна зануляється та починаються нові 4 тижні, новий місяць.
                // Кількість балів за вже минувший місяць переносяться до лічильника нижче у вікні контролю.
                // Бали за почавшийся місяць зануляються
                currentWeekNumber = 0;
                form.finalMonthlyGradesLabel.Text = form.monthlyGradesTextBox.Text;
                form.monthlyGradesTextBox.Text = "0";
                Settings.Default.month = 0;
                Settings.Default.Save();
            }
            public static void PickOutDay()
            {
                switch (SuchAGoodDay.GetDayName(DateTime.Today.DayOfWeek))
                {
                    case "Понеділок": form.label1.ForeColor = Color.Red; break;
                    case "Вівторок": form.label2.ForeColor = Color.Red; break;
                    case "Середа": form.label3.ForeColor = Color.Red; break;
                    case "Четвер": form.label4.ForeColor = Color.Red; break;
                    case "П'ятниця": form.label5.ForeColor = Color.Red; break;
                    case "Субота": form.label6.ForeColor = Color.Red; break;
                    default: break;
                }
            }
            static List<string> GetWeeklyTimetableText()
            {
                return new List<string> { form.mondayTimetable.Text,
                                          form.tuesdayTimetable.Text,
                                          form.wednesdayTimetable.Text,
                                          form.thursdayTimetable.Text,
                                          form.fridayTimetable.Text,
                                          form.saturdayTimetable.Text};
            }
        }
        static class CheckBoxHelper
        {
            public static void SaveCheckedIndices()
            {
                Settings.Default.checkboxes = new ArrayList();
                foreach (int index in form.checkedListBox1.CheckedIndices)
                {
                    Settings.Default.checkboxes.Add(index);
                }
                Settings.Default.Save();
            }
            public static void SetItemChecked()
            {
                if (Settings.Default.checkboxes == null)
                    return;

                foreach (int index in Settings.Default.checkboxes)
                {
                    form.checkedListBox1.SetItemChecked(index, true);
                }
            }
        }
    }
}
