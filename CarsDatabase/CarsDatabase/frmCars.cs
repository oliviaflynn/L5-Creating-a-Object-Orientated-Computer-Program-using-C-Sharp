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

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        private List<DataRecord> records;
        private int displayedRecord = 0;

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
            //conection to database using suitable parameters below
        {
            records = new List<DataRecord>();
            OleDbConnection connection = new OleDbConnection();

            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Android\\Documents\\OF\\DatabaseFiles\\Hire.accdb";
                        
            try
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblCar", connection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataRecord dataRecord = new DataRecord()
                    {
                        VehicleRegNo = reader.GetValue(0).ToString(),
                        Make = reader.GetValue(1).ToString(),
                        EngineSize = reader.GetValue(2).ToString(),
                        DateRegistered = reader.GetValue(3).ToString(),
                        RentalPerDay = reader.GetValue(4).ToString(),
                        Available = reader.GetBoolean(5)
                    };

                    records.Add(dataRecord);
                    

                                    
                }
                reader.Close();
            }

            // database connection error handling

            catch (Exception)
            {
                MessageBox.Show("Failed to connect to data source");
            }

            finally
            {
                connection.Close();
            }

            DisplayRecord(displayedRecord);
            UpdatePageNumberBox();
        }

        private void UpdatePageNumberBox()
        {
            pageNumberBox.Text = (displayedRecord+1) + " of " + records.Count;
        }

        private void DisplayRecord(int index)
        {
            //assigning data from the database to the textfields on frmCars.
            VRNumberTextBox.Text = records[index].VehicleRegNo;
            makeTextBox.Text = records[index].Make;
            engineSizeTextBox.Text = records[index].EngineSize;
            dateRegisteredTextBox.Text = records[index].DateRegistered;            
            rentalPerDayTextBox.Text = records[index].RentalPerDay;  

            CheckState checkState = CheckState.Unchecked;
            if (records[index].Available)
            {
                checkState = CheckState.Checked;
            }
            availableCheckBox.CheckState = checkState;
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

        //navigation buttons below

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (displayedRecord+1 < records.Count)
            {
                DisplayRecord(++displayedRecord);
                UpdatePageNumberBox();
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (displayedRecord > 0)
            {
                DisplayRecord(--displayedRecord);
                UpdatePageNumberBox();
            }
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            displayedRecord = records.Count - 1;
            DisplayRecord(displayedRecord);
            UpdatePageNumberBox();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            displayedRecord = 0;
            DisplayRecord(displayedRecord);
            UpdatePageNumberBox();
        }

        private void dateRegisteredTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rentalPerDayTextBox_TextChanged(object sender, EventArgs e)
        {

              
     

           
        }
    }
}
