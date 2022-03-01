using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static ЕНГ_Task_Часть_2.RPN;

namespace ЕНГ_Task_Часть_2
{
    public partial class Engineering_Calculator : Form
    {

        public Engineering_Calculator()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox1.Text = String.Empty;
        }

        public static string ans = String.Empty;

        // 1
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        // 2
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        // 3
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        // 4
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        // 5
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        // 6
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        // 7
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        // 8
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        // 9
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        // 0
        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += button21.Text;
        }

        // =
        private void button20_Click(object sender, EventArgs e)
        {
            try { textBox1.Text = RPN.Calculate(textBox1.Text).ToString(); }
            catch (MyException ex) { textBox1.Text = ex.type; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += " * ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
        }

        // результат последнего вычисления
        private void button16_Click(object sender, EventArgs e)
        {
            if (ans.Length > 0)
                textBox1.Text += ans;
            else
            {
                ans = textBox1.Text;
                textBox1.Text = String.Empty;
            }
        }

        // x^2
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ^2 ";
        }

        // x^3
        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ^3 ";
        }

        // квадратный корень
        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text += "sqrt(";
        }

        // x^y
        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ^ ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = ans = String.Empty;
        }

        // ПИ
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += " \u03C0 ";
        }

        // синус
        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "sin(";
        }

        // косинус
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "cos(";
        }

        // тангенс
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "tg(";
        }

        // 1/х
        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(1/";
        }

        // x! - факториал
        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += "!";
        }

        // логаритм х
        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text += "lg(";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = (textBox1.Text.Substring(0, textBox1.Text.Length - 1));
        }

        // Процент
        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text += " % ";
        }

        // e
        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += " e ";
        }

        // синус - 1
        private void button29_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "asin(";
        }

        // косинус - 1
        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "acos(";
        }

        // тангенс - 1
        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "atg(";
        }

        // Вычисление перестановки элемента
        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "P";
        }

        // Выбор элемента из группы или набора, где порядок элементов не имеет значения.
        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += "C";
        }

        // натуральный логарифм
        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text += "ln(";
        }

        // . точка
        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text += button33.Text;
        }

        // скобка (
        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Text += button39.Text;
        }

        // скобка )
        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text += button41.Text;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            CalculatorLite frm2 = new CalculatorLite();
            frm2.Show();
            this.Hide();
        }
    }
}