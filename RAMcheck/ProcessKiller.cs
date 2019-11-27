using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAMdetect
{
    class ProcessKiller
    {
        public void KillThisProcess(string selectedProcess)
        {
            if (GetUserChoice())
            {
                var processList = Process
                                  .GetProcesses()
                                  .Where(x => x.ProcessName == selectedProcess)
                                  .Select(x => x);
                foreach (var process in processList)
                {
                    process.Kill();
                }
            }
        }
        private bool GetUserChoice()
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете завершити цей процес?", "Підтвердіть вибір", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            return result == DialogResult.Yes ? true : false;
        }
    }
}
