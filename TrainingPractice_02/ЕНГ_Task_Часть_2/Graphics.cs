using System;
using System.Windows.Forms;

namespace ЕНГ_Task_Часть_2
{
    public partial class Graphics : Form
    {
        private double a, b, h;
        private double x, y;


        public Graphics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorLite frm2 = new CalculatorLite();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Выберите хотя бы один график!!!", "Будьте внимательны!!!");
                return;
            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Параметры по умолчанию!!!", "Внимание!!!");
                DefaultParams();
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                h = Convert.ToDouble(textBox3.Text);
            }

            if (checkBox1.Checked)
            {
                x = a;
                this.chart1.Series[0].Points.Clear();
                while (x <= b)
                {
                    y = Math.Cos(x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }

            if (checkBox2.Checked)
            {
                x = a;
                this.chart1.Series[1].Points.Clear();
                while (x <= b)
                {
                    y = Math.Sin(x);
                    this.chart1.Series[1].Points.AddXY(x, y);
                    x += h;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Выберите хотя бы один график!!!", "Будьте внимательны!!!");
                return;
            }

            if (checkBox1.Checked)
            {
                this.chart1.Series[1].Points.Clear();
            }

            if (checkBox2.Checked)
            {
                this.chart1.Series[1].Points.Clear();
            }
        }

        private void DefaultParams()
        {
            a = -10;
            a = 10;
            h = 0.1;
        }
    }
}
