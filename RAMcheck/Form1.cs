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
        private bool IsLoop { get; set; }

        public Form1()
        {
            InitializeComponent();
            RamInfo = new RAMInfo(this);
            ProcessKiller = new ProcessKiller();
            LaunchHelper.AddAllProcessToComboBox(this);
            IsLoop = false;
        }

        private void CheckSelectedProcessRAM_Button_Click(object sender, EventArgs e)
        {
            try
            {
                RamInfo.GetRAMInfoSelectedProcess(comboBox1.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ви не обрали процес!", "УВАГА");
            }
        }

        private void CheckAllProcessesRAM_Button_Click(object sender, EventArgs e)
        {
            RamInfo.GetRAMInfoAllProcesses();
        }

        private void KillSelectedProcess_Button_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessKiller.KillSelectedProcess(comboBox1.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ви не обрали процес!", "УВАГА");
            }
        }

        private void RefreshProcessesList_Button_Click(object sender, EventArgs e)
        {
            LaunchHelper.AddAllProcessToComboBox(this);
        }

        private void GetInfoLoop_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (getInfoLoop_CheckBox.CheckState == CheckState.Checked)
                IsLoop = true;
            else
                IsLoop = false;
        }
    }
}
