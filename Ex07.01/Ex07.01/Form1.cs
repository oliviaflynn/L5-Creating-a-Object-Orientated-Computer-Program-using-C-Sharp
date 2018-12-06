using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex07._01
{
    public partial class helloWorldForm : Form
    {
        public helloWorldForm()
        {
            InitializeComponent();
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            helloWorldTextBox.Text = "Hello World!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            helloWorldTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
