using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; //add oledb for database
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        private bool addbuttonClickedToAddData = false;

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

            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                            "Data Source=C:\\Users\\Android\\Documents\\OF\\DatabaseFiles\\Hire.accdb";

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
            lockTextBox();
        }
        // method for locking fields
        private void lockTextBox()
        {
            //disable textboxes for input can be used to secure form from data loss
            VRNumberTextBox.Enabled = false;
            makeTextBox.Enabled = false;
            engineSizeTextBox.Enabled = false;
            dateRegisteredTextBox.Enabled = false;
        }

        private void UpdatePageNumberBox()
        {
            pageNumberBox.Text = (displayedRecord + 1) + " of " + records.Count;

            //parsing to get the curency sign for local curency
            double stringToBeFormated = Double.Parse(rentalPerDayTextBox.Text);
            rentalPerDayTextBox.Text = stringToBeFormated.ToString("C", CultureInfo.CurrentCulture);
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
            if (displayedRecord + 1 < records.Count)
            {
                DisplayRecord(++displayedRecord);
                UpdatePageNumberBox();
            }

            //disable primary key box and other fields
            lockTextBox();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (displayedRecord > 0)
            {
                DisplayRecord(--displayedRecord);
                UpdatePageNumberBox();
            }

            //disable primary key box again
            lockTextBox();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            displayedRecord = records.Count - 1;
            DisplayRecord(displayedRecord);
            UpdatePageNumberBox();

            //disable primary key box again
            lockTextBox();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            displayedRecord = 0;
            DisplayRecord(displayedRecord);
            UpdatePageNumberBox();

            //disable primary key box again
            lockTextBox();
        }

        private void dateRegisteredTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rentalPerDayTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void addButton_Click(object sender, EventArgs e)
        {
              //if Add button clicked again then add new vehicle to database if all the fields are added correctly
            if (addbuttonClickedToAddData
                && VRNumberTextBox.Text != ""
                && makeTextBox.Text != ""
                && engineSizeTextBox.Text != ""
                && dateRegisteredTextBox.Text != ""
                && rentalPerDayTextBox.Text != "")
            {

                //adding to list new car
                DataRecord databaseRecords = new DataRecord()
                {
                    VehicleRegNo = VRNumberTextBox.Text,
                    Make = makeTextBox.Text,
                    EngineSize = engineSizeTextBox.Text,
                    DateRegistered = dateRegisteredTextBox.Text,
                    RentalPerDay = rentalPerDayTextBox.Text,
                    Available = availableCheckBox.Checked
                };
                records.Add(databaseRecords);              

                //add new vehicle to database
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Android\\Documents\\OF\\DatabaseFiles\\Hire.accdb";

                try
                {
                    connection.Open();
                    string insertSQL = "INSERT INTO tblCar (VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) VALUES (?, ?, ?, ?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(insertSQL, connection);
                    cmd.Parameters.Add(new OleDbParameter("VehicleRegNo", OleDbType.VarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VehicleRegNo", DataRowVersion.Current, false, VRNumberTextBox.Text));
                    cmd.Parameters.Add(new OleDbParameter("Make", OleDbType.VarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Make", DataRowVersion.Current, false, makeTextBox.Text));
                    cmd.Parameters.Add(new OleDbParameter("EngineSize", OleDbType.VarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EngineSize", DataRowVersion.Current, false, engineSizeTextBox.Text));
                    cmd.Parameters.Add(new OleDbParameter("DateRegistered", OleDbType.Date, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateRegistered", DataRowVersion.Current, false, dateRegisteredTextBox.Text));
                    cmd.Parameters.Add(new OleDbParameter("RentalPerDay", OleDbType.Currency, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RentalPerDay", DataRowVersion.Current, false, rentalPerDayTextBox.Text));
                    cmd.Parameters.Add(new OleDbParameter("Available", OleDbType.Boolean, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Available", DataRowVersion.Current, false, availableCheckBox.Checked));
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }

                DisplayRecord(records.Count -1);
                UpdatePageNumberBox();
                lockTextBox(); // if new car is added to database then close all input fields

                //change bool to false when add new car
                addbuttonClickedToAddData = false;

                // at the end display message that new car has been added
                MessageBox.Show("A new car has been added to database.");
            }
            else
            {
                MessageBox.Show("Please fill in all fields to register a new car to the Database.");
                addbuttonClickedToAddData = true; //set to true
                //enable reg number textbox
                VRNumberTextBox.Enabled = true;
                makeTextBox.Enabled = true;
                engineSizeTextBox.Enabled = true;
                dateRegisteredTextBox.Enabled = true;
                //empty all the texboxes values for new input
                VRNumberTextBox.Text = "";
                makeTextBox.Text = "";
                engineSizeTextBox.Text = "";
                dateRegisteredTextBox.Text = "";
                rentalPerDayTextBox.Text = "";
                availableCheckBox.Checked = false;
            }
        }
    

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //reverts back to orignal record
            DisplayRecord(displayedRecord);       

            //parsing to get the curency sign for local curency
            double stringToBeFormated = Double.Parse(rentalPerDayTextBox.Text);
            rentalPerDayTextBox.Text = stringToBeFormated.ToString("C", CultureInfo.CurrentCulture);
            //disable primary key box again
            lockTextBox();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            lockTextBox();
        }
    }
}
