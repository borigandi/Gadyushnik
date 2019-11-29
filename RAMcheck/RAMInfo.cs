using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace RAMdetect
{
    class RAMInfo
    {
        private Form1 Form1Ref { get; }

        public RAMInfo(Form1 form1)
        {
            Form1Ref = form1;
        }

        public void GetRAMInfoSelectedProcess(string selectedProcess)
        {
            long ram = default;
            IEnumerable<Process> processList = Process
                              .GetProcesses()
                              .Where(x => x.ProcessName == selectedProcess)
                              .Select(x => x);

            foreach (var process in processList)
            {
                ram += process.WorkingSet64;
            }

            ShowRAMInfo(ram);
            //PerformanceCounter ramCounter = new PerformanceCounter("Process", "Working Set", p.ProcessName);
            //PerformanceCounter cpuCounter = new PerformanceCounter("Process", "% Processor Time", p.ProcessName);
        }
        public void GetRAMInfoAllProcesses()
        {
            long ram = default;
            var processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                ram += process.WorkingSet64;
            }

            ShowRAMInfo(ram);
        }

        private void ShowRAMInfo(long ram)
        {
            double usedMemory = Math.Round(ram / Math.Pow(1024, 2), 0);
            double freeMemory = Math.Round(new ComputerInfo().AvailablePhysicalMemory / Math.Pow(1024, 2), 0);
            double totalMemory = Math.Round(new ComputerInfo().TotalPhysicalMemory / Math.Pow(1024, 2), 0);
            Form1Ref.listBox1.Items.Clear();
            Form1Ref.listBox1.Items.Add($"TOTAL: {totalMemory} MB");
            Form1Ref.listBox1.Items.Add($"USED: {usedMemory} MB");
            Form1Ref.listBox1.Items.Add($"FREE: {freeMemory} MB");
        }
    }
}
