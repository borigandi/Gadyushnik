using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Rozklad
{
    internal class ClassMonitor : ILaunchHelper, ITimetableHelper, IGradesHelper
    {
        private ForSerialization ForSerial { get; set; }
        private BinaryFormatter Formatter { get; }
        private Form1 Form { get; }
        private int CurrentWeekNumber { get; set; } // кожний жмак по кнопці DONE - це +1 до counter

        public ClassMonitor(Form1 formRef)
        {
            Form = formRef;
            Formatter = new BinaryFormatter();
            ForSerial = new ForSerialization();
            SelectDay();
        }

        #region Реалізація ILaunchHelper
        public void SetValuesOnStart()
        {
            FileStream stream = File.OpenRead("timetable.dat");
            ForSerial = Formatter.Deserialize(stream) as ForSerialization;
            stream.Close();
            SetItemChecked();
            SetTimetable();
            Form.weeklyGradesTextBox.Text = ForSerial.weeklyGrades.ToString();
            Form.monthlyGradesTextBox.Text = ForSerial.monthlyGrades.ToString();
            Form.finalMonthlyGradesLabel.Text = ForSerial.finalMonthlyGrades;
            CurrentWeekNumber = ForSerial.currentWeekNumber;
            Form.currentWeekNumberLabel.Text = (CurrentWeekNumber + 1).ToString();
        }

        public void SaveValuesBeforeClosing()
        {
            SaveCheckedIndices();
            FileStream stream = File.Create("timetable.dat");
            Formatter.Serialize(stream, ForSerial);
            stream.Close();
        }
        #endregion

        #region Реалізація IGradesHelper
        public void ShowWeeklyAndMonthlyGrades()
        {
            // Метод рахує та виводить на екран кількість балів за тиждень та місяць.
            // Викликається після натискання на кнопку Done.
            // Кількість балів за тиждень - кількість галочок у вікні контролю (1 галочка - 1 бал).
            // Кількість балів за місяць - сума балів завершених тижнів.

            int count = Form.checkedListBox1.CheckedItems.Count;
            ForSerial.weeklyGrades = count; // зберігає у спец. клас для серіалізації
            ForSerial.monthlyGrades += count; // зберігає у спец. клас для серіалізації
            Form.weeklyGradesTextBox.Text = ForSerial.weeklyGrades.ToString();
            Form.monthlyGradesTextBox.Text = ForSerial.monthlyGrades.ToString();
        }
        #endregion

        #region Реалізація ITimetableHelper
        public void SaveTimetable()
        {
            ForSerial.monday = Form.mondayTimetable.Text;
            ForSerial.tuesday = Form.tuesdayTimetable.Text;
            ForSerial.wednesday = Form.wednesdayTimetable.Text;
            ForSerial.thursday = Form.thursdayTimetable.Text;
            ForSerial.friday = Form.fridayTimetable.Text;
            ForSerial.saturday = Form.saturdayTimetable.Text;
            MessageBox.Show("Розклад збережено", "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
        }

        public void StartNewWeek()
        {
            // Метод знімає всі галочки з чекбоксів та додає +1 до номеру тижня (тепер це номер нового тижня).
            // Якщо значення currentWeekNumber дорівнює >4, то викликається метод StartNewMonth(),
            // що починає новий місяць.
            // currentWeekNumber > 4 після інкременту значить, що закінчився 4-й тиждень місяця, тож треба
            // почати новий місяць і скинути номер тижня до 1 (перший тиждень нового місяця).
            // В кінці метод StartNewWeek() виводить на екран номер поточного (нового) тижня.

            foreach (int index in Form.checkedListBox1.CheckedIndices)
            {
                Form.checkedListBox1.SetItemChecked(index, false);
            }
            CurrentWeekNumber++;

            if (CurrentWeekNumber >= 4) { StartNewMonth(); }

            Form.currentWeekNumberLabel.Text = (CurrentWeekNumber + 1).ToString();
            ForSerial.currentWeekNumber = CurrentWeekNumber; // Збереження номеру тижня в полі спец. класу для серіалізації
        }
        #endregion

        #region Розширення функціоналу. Для внутрішнього використання
        private void StartNewMonth()
        {
            // Викликається у методі StartNewWeek() якщо змінна currentWeekNumber >= 4. 
            // Змінна зануляється та починаються нові 4 тижні, новий місяць.
            // Кількість балів за вже минувший місяць переносяться до лічильника нижче у вікні контролю.
            // Бали за почавшийся місяць зануляються
            CurrentWeekNumber = 0;
            Form.finalMonthlyGradesLabel.Text = Form.monthlyGradesTextBox.Text;
            ForSerial.finalMonthlyGrades = Form.finalMonthlyGradesLabel.Text;
            Form.monthlyGradesTextBox.Text = "0";
            ForSerial.monthlyGrades = 0;
        } // Викликається у StartNewWeek();
        private void SetTimetable()
        {
            Form.mondayTimetable.Text = ForSerial.monday;
            Form.tuesdayTimetable.Text = ForSerial.tuesday;
            Form.wednesdayTimetable.Text = ForSerial.wednesday;
            Form.thursdayTimetable.Text = ForSerial.thursday;
            Form.fridayTimetable.Text = ForSerial.friday;
            Form.saturdayTimetable.Text = ForSerial.saturday;
        } // Викликається у SetValuesOnStart();
        private void SetItemChecked()
        {
            // Виставляє галочки за збереженними індексами.
            // Викликається при запуску програми, у методі SetValuesOnStart().

            foreach (int index in ForSerial.CheckedIndices)
            {
                Form.checkedListBox1.SetItemChecked(index, true);
            }
        } // Викликається у SetValuesOnStart();
        private void SaveCheckedIndices()
        {
            // Зберігає індекси відміченних чекбоксів у список спец. класу для серіалізації
            // Викликається при закритті програми, у методі CloseProgram(),
            // в рамках фіналізуючого процесу (перед серіалізацією).

            ForSerial.CheckedIndices = new List<int>();
            foreach (int index in Form.checkedListBox1.CheckedIndices)
            {
                ForSerial.CheckedIndices.Add(index);
            }
        } // Викликається у CloseProgram();
        private void SelectDay()
            {
                switch (SuchAGoodDay.GetDayName(DateTime.Today.DayOfWeek))
                {
                    case "Понеділок": Form.label1.ForeColor = Color.Red; break;
                    case "Вівторок": Form.label2.ForeColor = Color.Red; break;
                    case "Середа": Form.label3.ForeColor = Color.Red; break;
                    case "Четвер": Form.label4.ForeColor = Color.Red; break;
                    case "П'ятниця": Form.label5.ForeColor = Color.Red; break;
                    case "Субота": Form.label6.ForeColor = Color.Red; break;
                    default: break;
                }
            } // Викликається у конструкторі
        #endregion
    }
}
