using System;
using System.Windows.Forms;

namespace ЕНГ_Task_Часть_2
{
    public partial class CalculatorLite : Form
    {
        public CalculatorLite()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Calculator frm2 = new Calculator();
            frm2.Show();
            this.Hide();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            Engineering_Calculator frm2 = new Engineering_Calculator();
            frm2.Show();
            this.Hide();
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            Graphics frm2 = new Graphics();
            frm2.Show();
            this.Hide();
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
