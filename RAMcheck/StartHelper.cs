using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RAMdetect
{
    static class StartHelper
    {
        public static void AddAllProcessToComboBox(Form1 form1)
        {
            form1.comboBox1.Items.Clear();
            ShowProcessCounter(form1);
            HashSet<string> allProcessNames = new HashSet<string>();
            foreach (Process process in Process.GetProcesses())
            {
                allProcessNames.Add(process.ProcessName);
            }

            foreach (string processName in allProcessNames)
            {
                form1.comboBox1.Items.Add(processName);
            }
        }

        private static void ShowProcessCounter(Form1 form1)
        {
            form1.label1.Text = $"Processes: {Process.GetProcesses().Count()}";
        }
    }
}
