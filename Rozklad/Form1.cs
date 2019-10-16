using System;
using System.Windows.Forms;

namespace Rozklad
{
    public partial class Form1 : Form
    {
        readonly IRobitnykRoku robitnyk;
        public Form1()
        {
            InitializeComponent();
            robitnyk = new RobitnykRoku(this);
            robitnyk.ZapovnytyPryVkl();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            robitnyk.NarahuvatyBal();
            robitnyk.PochatyTyjden();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            robitnyk.ZberigtyRozklad();
        }
    }
}
