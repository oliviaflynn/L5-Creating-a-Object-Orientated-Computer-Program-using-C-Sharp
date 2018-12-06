using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex07._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool isDouble(String text)
        {
            double dummyDouble;
            return Double.TryParse(text, out dummyDouble);

        }

        private bool isInt32(String text)
        {
            int dummyInt;
            return Int32.TryParse(text, out dummyInt);
        }


        private void calculate()
        {
            double answer;
            double rate;
            double months;
            double amount;
            if (isDouble(interestRateTextBox.Text))
            {
                if (isInt32(loanPeriodTextBox.Text))
                {
                    if (isDouble(loanAmountTextBox.Text))
                    {
                        rate =
                        Convert.ToDouble(interestRateTextBox.Text) / 12;
                        months =
                        Convert.ToDouble(loanPeriodTextBox.Text);
                        amount =
                        Convert.ToDouble(loanAmountTextBox.Text);
                        answer =
                        (amount * rate) /
                        (1 - Math.Pow((1 + rate), -months));
                        monthlyPaymentTextBox.Text =
                        answer.ToString("0.00");
                    }
                }
            }
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void interestRateTextBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void loanPeriodTextBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void loanAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
