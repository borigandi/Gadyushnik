using System;
using System.Windows.Forms;
using Rozklad.Properties;
using System.Drawing;

namespace Rozklad
{
    class RobitnykRoku : IRobitnykRoku
    {
        readonly Form1 form;
        int counter; // кожний жмак по кнопці DONE - це +1 до counter 

        public RobitnykRoku(Form1 form)
        {
            this.form = form;
            counter = Settings.Default.counter;
            VydilytyDen();
        }

        public void NarahuvatyBal()
        {
            int counter2 = form.checkedListBox1.CheckedItems.Count;
            Settings.Default.tijden = counter2;
            Settings.Default.misyac += counter2;
            Settings.Default.Save();
            form.textBox11.Text = Settings.Default.tijden.ToString();
            form.textBox12.Text = Settings.Default.misyac.ToString();
        }
        public void PochatyTyjden()
        {
            foreach (int item in form.checkedListBox1.CheckedIndices)
            {
                form.checkedListBox1.SetItemChecked(item, false);
            }
            counter++;

            if(counter >= 4) { NarahuvatyBal2(); }

            form.label17.Text = (counter + 1).ToString();
            Settings.Default.counter = counter;
            Settings.Default.Save();
        }
        public void ZapovnytyPryVkl()
        {
            form.richTextBox1.Text = Settings.Default.monday0.ToString();
            form.richTextBox2.Text = Settings.Default.tuesday0.ToString();
            form.richTextBox3.Text = Settings.Default.wednesday0.ToString();
            form.richTextBox4.Text = Settings.Default.thursday0.ToString();
            form.richTextBox5.Text = Settings.Default.friday.ToString();
            form.richTextBox6.Text = Settings.Default.saturday.ToString();
            form.textBox11.Text = Settings.Default.tijden.ToString();
            form.textBox12.Text = Settings.Default.misyac.ToString();
            form.label17.Text = (counter + 1).ToString();
        }
        public void ZberigtyRozklad()
        {
            Settings.Default.monday0 = form.richTextBox1.Text;
            Settings.Default.tuesday0 = form.richTextBox2.Text;
            Settings.Default.wednesday0 = form.richTextBox3.Text;
            Settings.Default.thursday0 = form.richTextBox4.Text;
            Settings.Default.friday = form.richTextBox5.Text;
            Settings.Default.saturday = form.richTextBox6.Text;
            Settings.Default.Save();
            MessageBox.Show("Розклад збережено", "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
        }

        void NarahuvatyBal2()
        {
            // Викликається у методі PochatyTyjden() якщо змінна counter >= 4. 
            // Змінна зануляється та починаються нові 4 тижні, новий місяць.
            // Кількість балів за вже минувший місяць переносяться до лічильника нижче у вікні контролю.
            // Бали за почавшийся місяць зануляються
            counter = 0;
            form.label15.Text = form.textBox12.Text;
            form.textBox12.Text = "0";
            Settings.Default.misyac = 0;
            Settings.Default.Save();
        }
        void VydilytyDen()
        {
            switch(SuchAGoodDay.GetDayName(DateTime.Today.DayOfWeek))
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
    }
}
