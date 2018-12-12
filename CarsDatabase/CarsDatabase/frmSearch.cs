/**
 * Author:    Olivia Flynn
 * Created:   14/12/2018
 *            City & Guilds Task A frmSearch.cs        
 **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet2.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter2.Fill(this.hireDataSet2.tblCar);
            // TODO: This line of code loads data into the 'hireDataSet1.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter1.Fill(this.hireDataSet1.tblCar);
            // TODO: This line of code loads data into the 'hireDataSet2.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);


            //Load Values into the Field and Operator Combo Boxes
            var fields = new List<string>();
            fields.Add(""); //Start with empty string
            fields.Add("Make");
            fields.Add("EngineSize");
            fields.Add("RentalPerDay");
            fields.Add("Available");
            cboField.DataSource = fields;

            var operators = new List<string>();
            operators.Add(""); //Start with empty string
            operators.Add("=");
            operators.Add("<");
            operators.Add(">");
            operators.Add("<=");
            operators.Add(">=");
            cboOperator.DataSource = operators;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
            frmCars formCars = new frmCars();
            formCars.Show();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Android\\Documents\\OF\\DatabaseFiles\\Hire.accdb";

            // assemble the values
            string field = cboField.Text;
            if (String.IsNullOrEmpty(field))
            {
                MessageBox.Show("Please select a field of the Database to search.");
                return;
            }
            string op = cboOperator.Text;
            if (String.IsNullOrEmpty(op))
            {
                MessageBox.Show("Please select an operator to filter the data with.");
                return;
            }
            string value = DataEntryTextBox.Text;
            if (String.IsNullOrEmpty(value))
            {
                MessageBox.Show("Please enter a value to search by.");
                return;
            }
            if (field == "Make" || field == "EngineSize")
            {
                value = "\"" + value + "\"";    


            }

            try
            {
                connection.Open();
                DataTable dataTable = new DataTable();
                dataTable.Load(Car.search(field, op, value));
                dgView.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally

            {
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
