using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAMdetect
{
    public partial class Form1 : Form
    {
        private RAMInfo RamInfo { get; }
        private ProcessKiller ProcessKiller { get; }

        public Form1()
        {
            InitializeComponent();
            RamInfo = new RAMInfo(this);
            ProcessKiller = new ProcessKiller();
            StartHelper.AddAllProcessToComboBox(this);
        }

        private void CheckSelectedProcessRAM_Button_Click(object sender, EventArgs e)
        {
            RamInfo.GetRAMInfoSelectedProcess(comboBox1.SelectedItem.ToString());
        }

        private void CheckAllProcessesRAM_Button_Click(object sender, EventArgs e)
        {
            RamInfo.GetRAMInfoAllProcesses();
        }

        private void KillSelectedProcess_Button_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessKiller.KillThisProcess(comboBox1.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ви не обрали процес!", "УВАГА");
            }
        }

        private void RefreshProcessesList_Button_Click(object sender, EventArgs e)
        {
            StartHelper.AddAllProcessToComboBox(this);
        }
    }
}
