using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentPractice
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void name_Popup(object sender, PopupEventArgs e)
        {

        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();

            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Android\\Documents\\Hire.accdb";
                        
            try
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblCar", connection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    VRNumberTextBox.Text = reader.GetValue(0).ToString();
                    makeTextBox.Text = reader.GetValue(1).ToString();
                    engineSizeTextBox.Text = reader.GetValue(2).ToString();
                    dateRegisteredTextBox.Text = reader.GetValue(3).ToString();
                    rentalPerDayTextBox.Text = reader.GetValue(4).ToString();

                    CheckState checkState = CheckState.Unchecked;
                    if (reader.GetBoolean(5))
                    {
                        checkState = CheckState.Checked;
                    }

                    availableCheckBox.CheckState = checkState;



                        //Debug.WriteLine(reader.GetValue(0));
                        // Insert code to process data.                    
                }
                reader.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Failed to connect to data source");
            }

            finally
            {
                connection.Close();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pageNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Hide();
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();


        }

        private void VRNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
