namespace CarsDatabase
{
    partial class frmCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolTip formToolTip;
            this.titleLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.VRNumberLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.engineSizeLabel = new System.Windows.Forms.Label();
            this.dateRegisteredLabel = new System.Windows.Forms.Label();
            this.rentalPerDayLabel = new System.Windows.Forms.Label();
            this.availableLabel = new System.Windows.Forms.Label();
            this.VRNumberTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.rentalPerDayTextBox = new System.Windows.Forms.TextBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.pageNumberBox = new System.Windows.Forms.TextBox();
            this.VecRegToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MakeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EngineSizeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dateRegisteredTextBox = new System.Windows.Forms.DateTimePicker();
            this.tableAdapterManager1 = new CarsDatabase.HireDataSetTableAdapters.TableAdapterManager();
            formToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // formToolTip
            // 
            formToolTip.ToolTipTitle = "Hire a car today!";
            formToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Agency FB", 50F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(106, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(435, 80);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Bowman Car Hire";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(663, 99);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 60);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(663, 165);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 60);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(663, 231);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(125, 60);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(663, 297);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 60);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(663, 363);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 60);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(663, 33);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 60);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(12, 399);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(102, 39);
            this.firstButton.TabIndex = 19;
            this.firstButton.Text = "First";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(120, 399);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(102, 39);
            this.previousButton.TabIndex = 20;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(436, 399);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(102, 39);
            this.nextButton.TabIndex = 22;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(544, 399);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(102, 39);
            this.lastButton.TabIndex = 23;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // VRNumberLabel
            // 
            this.VRNumberLabel.AutoSize = true;
            this.VRNumberLabel.Location = new System.Drawing.Point(137, 169);
            this.VRNumberLabel.Name = "VRNumberLabel";
            this.VRNumberLabel.Size = new System.Drawing.Size(150, 13);
            this.VRNumberLabel.TabIndex = 1;
            this.VRNumberLabel.Text = "Vechicle Registration Number:";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(252, 195);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(37, 13);
            this.makeLabel.TabIndex = 3;
            this.makeLabel.Text = "Make:";
            // 
            // engineSizeLabel
            // 
            this.engineSizeLabel.AutoSize = true;
            this.engineSizeLabel.Location = new System.Drawing.Point(221, 221);
            this.engineSizeLabel.Name = "engineSizeLabel";
            this.engineSizeLabel.Size = new System.Drawing.Size(66, 13);
            this.engineSizeLabel.TabIndex = 5;
            this.engineSizeLabel.Text = "Engine Size:";
            // 
            // dateRegisteredLabel
            // 
            this.dateRegisteredLabel.AutoSize = true;
            this.dateRegisteredLabel.Location = new System.Drawing.Point(202, 246);
            this.dateRegisteredLabel.Name = "dateRegisteredLabel";
            this.dateRegisteredLabel.Size = new System.Drawing.Size(87, 13);
            this.dateRegisteredLabel.TabIndex = 7;
            this.dateRegisteredLabel.Text = "Date Registered:";
            // 
            // rentalPerDayLabel
            // 
            this.rentalPerDayLabel.AutoSize = true;
            this.rentalPerDayLabel.Location = new System.Drawing.Point(205, 269);
            this.rentalPerDayLabel.Name = "rentalPerDayLabel";
            this.rentalPerDayLabel.Size = new System.Drawing.Size(82, 13);
            this.rentalPerDayLabel.TabIndex = 9;
            this.rentalPerDayLabel.Text = "Rental Per Day:";
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Location = new System.Drawing.Point(234, 300);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(53, 13);
            this.availableLabel.TabIndex = 11;
            this.availableLabel.Text = "Available:";
            // 
            // VRNumberTextBox
            // 
            this.VRNumberTextBox.Enabled = false;
            this.VRNumberTextBox.Location = new System.Drawing.Point(293, 162);
            this.VRNumberTextBox.MaxLength = 10;
            this.VRNumberTextBox.Name = "VRNumberTextBox";
            this.VRNumberTextBox.Size = new System.Drawing.Size(161, 20);
            this.VRNumberTextBox.TabIndex = 2;
            this.VecRegToolTip.SetToolTip(this.VRNumberTextBox, "Please Enter Reg. Number");
            this.VRNumberTextBox.TextChanged += new System.EventHandler(this.VRNumberTextBox_TextChanged);
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(293, 188);
            this.makeTextBox.MaxLength = 50;
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(161, 20);
            this.makeTextBox.TabIndex = 4;
            this.MakeToolTip.SetToolTip(this.makeTextBox, "Please Enter Car Make");
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.Location = new System.Drawing.Point(293, 214);
            this.engineSizeTextBox.MaxLength = 10;
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(161, 20);
            this.engineSizeTextBox.TabIndex = 6;
            this.EngineSizeToolTip.SetToolTip(this.engineSizeTextBox, "Please Enter Engine Size");
            // 
            // rentalPerDayTextBox
            // 
            this.rentalPerDayTextBox.Location = new System.Drawing.Point(293, 266);
            this.rentalPerDayTextBox.Name = "rentalPerDayTextBox";
            this.rentalPerDayTextBox.Size = new System.Drawing.Size(161, 20);
            this.rentalPerDayTextBox.TabIndex = 10;
            this.rentalPerDayTextBox.TextChanged += new System.EventHandler(this.rentalPerDayTextBox_TextChanged);
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.AutoSize = true;
            this.availableCheckBox.Location = new System.Drawing.Point(293, 300);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(15, 14);
            this.availableCheckBox.TabIndex = 12;
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // pageNumberBox
            // 
            this.pageNumberBox.Location = new System.Drawing.Point(247, 409);
            this.pageNumberBox.Name = "pageNumberBox";
            this.pageNumberBox.Size = new System.Drawing.Size(161, 20);
            this.pageNumberBox.TabIndex = 21;
            this.pageNumberBox.Text = "1 of 222";
            this.pageNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageNumberBox.TextChanged += new System.EventHandler(this.pageNumberBox_TextChanged);
            // 
            // dateRegisteredTextBox
            // 
            this.dateRegisteredTextBox.Location = new System.Drawing.Point(295, 240);
            this.dateRegisteredTextBox.Name = "dateRegisteredTextBox";
            this.dateRegisteredTextBox.Size = new System.Drawing.Size(159, 20);
            this.dateRegisteredTextBox.TabIndex = 8;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tblCarTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CarsDatabase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateRegisteredTextBox);
            this.Controls.Add(this.pageNumberBox);
            this.Controls.Add(this.availableCheckBox);
            this.Controls.Add(this.rentalPerDayTextBox);
            this.Controls.Add(this.engineSizeTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.VRNumberTextBox);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.rentalPerDayLabel);
            this.Controls.Add(this.dateRegisteredLabel);
            this.Controls.Add(this.engineSizeLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.VRNumberLabel);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "frmCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task A Olivia Flynn 14/12/2018";
            formToolTip.SetToolTip(this, "\r\n");
            this.Load += new System.EventHandler(this.frmCars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Label VRNumberLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label engineSizeLabel;
        private System.Windows.Forms.Label dateRegisteredLabel;
        private System.Windows.Forms.Label rentalPerDayLabel;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.TextBox VRNumberTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox engineSizeTextBox;
        private System.Windows.Forms.TextBox rentalPerDayTextBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.TextBox pageNumberBox;
        private System.Windows.Forms.ToolTip VecRegToolTip;
        private System.Windows.Forms.ToolTip MakeToolTip;
        private System.Windows.Forms.ToolTip EngineSizeToolTip;
        private System.Windows.Forms.DateTimePicker dateRegisteredTextBox;
        private CarsDatabase.HireDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

