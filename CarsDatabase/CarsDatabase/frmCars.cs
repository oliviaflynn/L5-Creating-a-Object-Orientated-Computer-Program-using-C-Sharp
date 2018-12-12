/**
 * Author:    Olivia Flynn
 * Created:   14/12/2018
 *            City & Guilds Task A frmCars.cs
 **/
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
        private string originalValueOfEngineSize;
        private string originalValueRentalPerDay;
        private bool originalValueAvailable;
        private bool updateCheck = false;

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
            loadCars();
        }

        private void loadCars()
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
            //disable textbox for primary key to secure form from data loss
            VRNumberTextBox.Enabled = false;
           
        }

        private void UpdatePageNumberBox()
        {
            pageNumberBox.Text = (displayedRecord + 1) + " of " + records.Count;

            Currency();
        }

        private string Currency()
        {
            //parsing to get the curency sign for local curency
            double stringToBeFormated = Double.Parse(rentalPerDayTextBox.Text);
            rentalPerDayTextBox.Text = stringToBeFormated.ToString("C", CultureInfo.CurrentCulture);
            return rentalPerDayTextBox.Text;
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

            //disable primary key box
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

        private void disableButtons()
        {
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            searchButton.Enabled = false;
            firstButton.Enabled = false;
            previousButton.Enabled = false;
            nextButton.Enabled = false;
            lastButton.Enabled = false;

        }

        private void enableButtons()
        {
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            searchButton.Enabled = true;
            firstButton.Enabled = true;
            previousButton.Enabled = true;
            nextButton.Enabled = true;
            lastButton.Enabled = true;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            disableButtons();

            //If Add button clicked again then add new vehicle to database if all the fields contain valid input
            if (addbuttonClickedToAddData
                && VRNumberTextBox.Text != ""
                && makeTextBox.Text != ""
                && engineSizeTextBox.Text != ""
                && dateRegisteredTextBox.Text != ""
                && rentalPerDayTextBox.Text != "")
            {

                //Adds new car to list
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

                    DisplayRecord(records.Count - 1);
                    UpdatePageNumberBox();
                    lockTextBox(); // if new car is added to database then close all input fields
                    enableButtons();
                    //change bool to false when add new car
                    addbuttonClickedToAddData = false;

                    // at the end display message that new car has been added
                    MessageBox.Show("A new car has been added to database.");
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
            else
            {
                MessageBox.Show("Please fill in all fields with valid data to register a new car to the Database.");
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
            enableButtons();            
            //disable primary key box again
            lockTextBox();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataRecord datarecord = new DataRecord()
            {
                VehicleRegNo = VRNumberTextBox.Text,
                Make = makeTextBox.Text,
                EngineSize = engineSizeTextBox.Text,
                DateRegistered = dateRegisteredTextBox.Text,
                RentalPerDay = rentalPerDayTextBox.Text,
                Available = availableCheckBox.Checked


            };

            records.Remove(datarecord);

            // delete car from database

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Android\\Documents\\OF\\DatabaseFiles\\Hire.accdb";

            try
            {
                connection.Open();
                string deleteSQL = "DELETE FROM tblCar WHERE VehicleRegNo = ?";

                OleDbCommand cmd = new OleDbCommand(deleteSQL, connection);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new OleDbParameter("VehicleRegNo", OleDbType.VarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VehicleRegNo", DataRowVersion.Original, false, VRNumberTextBox.Text));
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
            // display message to confirm record was deleted

            MessageBox.Show("Car record has been deleted from Database.");
            displayedRecord = 0;
            loadCars();
            lockTextBox();

            }

        private void updateButton_Click(object sender, EventArgs e)
            {
            if (!updateCheck)
            {
                engineSizeTextBox.Enabled = true;
                rentalPerDayTextBox.Enabled = true;
                availableCheckBox.Enabled = true;
                originalValueOfEngineSize = engineSizeTextBox.Text;
                originalValueRentalPerDay = rentalPerDayTextBox.Text;
                originalValueAvailable = availableCheckBox.Checked;
                updateCheck = true;
            }
            else
            {
                string tempString1 = (string)rentalPerDayTextBox.Text.ToString().Substring(0, 1);
                string tempString2 = string.Empty;
                if (tempString1.ToLower() == "-")
                {
                    tempString2 = tempString1 + (string)rentalPerDayTextBox.Text.ToString().Substring(2);
                }
                else
                {
                    tempString2 = (string)rentalPerDayTextBox.Text.ToString().Substring(1);
                }

                if (makeTextBox.Modified || engineSizeTextBox.Modified || rentalPerDayTextBox.Modified || originalValueAvailable != availableCheckBox.Checked) // If values of make, engineSize, rentalPerDay price or availabilty has changed then update the car details
                {
                    OleDbConnection connection = new OleDbConnection();
                    connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Android\\Documents\\OF\\DatabaseFiles\\Hire.accdb";

                    try
                    {
                        connection.Open();
                        string updateSQL = "UPDATE tblCar SET Make = ?, EngineSize = ?, DateRegistered = ?, RentalPerDay = ?, Available = ? WHERE VehicleRegNo = ?";
                        OleDbCommand cmd = new OleDbCommand(updateSQL, connection);
                        cmd.Parameters.Add(new OleDbParameter("Make", OleDbType.VarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Make", DataRowVersion.Current, false, makeTextBox.Text));
                        cmd.Parameters.Add(new OleDbParameter("EngineSize", OleDbType.VarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EngineSize", DataRowVersion.Current, false, engineSizeTextBox.Text));
                        cmd.Parameters.Add(new OleDbParameter("DateRegistered", OleDbType.Date, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateRegistered", DataRowVersion.Current, false, dateRegisteredTextBox.Text));
                        cmd.Parameters.Add(new OleDbParameter("RentalPerDay", OleDbType.Currency, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RentalPerDay", DataRowVersion.Current, false, tempString2));
                        cmd.Parameters.Add(new OleDbParameter("Available", OleDbType.Boolean, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Available", DataRowVersion.Current, false, availableCheckBox.Checked));
                        cmd.Parameters.Add(new OleDbParameter("VehicleRegNo", OleDbType.VarWChar, 0, ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VehicleRegNo", DataRowVersion.Current, false, VRNumberTextBox.Text));
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

                    //Once car is updated, bool goes to false
                    updateCheck = false;

                    // Message box to confirm Car has been updated
                    MessageBox.Show("Car was sucessfully updated.");
                    records[displayedRecord].Make = makeTextBox.Text;
                    records[displayedRecord].EngineSize = engineSizeTextBox.Text;
                    records[displayedRecord].RentalPerDay = tempString2;
                    records[displayedRecord].Available = availableCheckBox.Checked;
                    DisplayRecord(displayedRecord);
                    UpdatePageNumberBox();
                    lockTextBox(); // After update, Lock fields again.
                }

                else
                {
                    MessageBox.Show("No new changes found to update record.");
                }
            }
           
            }

        private void dateRegisteredTextBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }
    }
    }
