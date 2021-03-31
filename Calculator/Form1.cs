using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string _tmp = "";
        char act = ' ';

        public Form1()
        {
            InitializeComponent();
        }
   
        private void NumericButton_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                textBox1.Text += button.Text;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {
            int answer = 0;
            switch (act)
            {
                case '+':
                    answer = Convert.ToInt32(_tmp) + Convert.ToInt32(textBox1.Text);
                    break;
                case '-':
                    answer = Convert.ToInt32(_tmp) - Convert.ToInt32(textBox1.Text);
                    break;
                case '/':
                    answer = Convert.ToInt32(_tmp) / Convert.ToInt32(textBox1.Text);
                    break;
                case '*':
                    answer = Convert.ToInt32(_tmp) * Convert.ToInt32(textBox1.Text);
                    break;
            }
            textBox1.Text = answer + "";
        }
        private void PlusButton(object sender, EventArgs e)
        {
            _tmp = textBox1.Text;
            textBox1.Text = "";
            act = '+';
        }

        private void MinuseButton(object sender, EventArgs e)
        {
            _tmp = textBox1.Text;
            textBox1.Text = "";
            act = '-';
        }
        private void DivideButton(object sender, EventArgs e)
        {
            _tmp = textBox1.Text;
            textBox1.Text = "";
            act = '/';
        }
        private void MultiplicationButton(object sender, EventArgs e)
        {
            _tmp = textBox1.Text;
            textBox1.Text = "";
            act = '*';
        }
        private void CEButton(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void CButton(object sender, EventArgs e)
        {
            _tmp = "";
            textBox1.Text = "";
        }
        private void DeleteElementButton(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "");
            }
        }

        private void Inversion(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > 0)
            {
                _tmp = '-' + textBox1.Text;
                textBox1.Text = _tmp;
            }
            else 
            {
                _tmp = textBox1.Text;
                _tmp = _tmp.Substring(1);
                textBox1.Text = _tmp;
            }
        }

        private void ConverterToDouble(object sender, EventArgs e)
        {
            _tmp = textBox1.Text;
            if (_tmp.IndexOf('.') == -1)
            {
                textBox1.Text += '.';
            }
        }
    }
}
