using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex08
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

        private void inputDataText_TextChanged(object sender, EventArgs e)
        {

        }

        private void form1NextButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(inputDataText.text);
            form2.ShowDialog();
        }
    }
}
