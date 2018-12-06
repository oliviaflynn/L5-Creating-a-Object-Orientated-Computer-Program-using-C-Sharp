namespace Ex06._02
{
    partial class PersonalInformation
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.Label();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ppsNumberTextBox = new System.Windows.Forms.TextBox();
            this.ppsNumberLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.maritalStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.divorcedRadioButton = new System.Windows.Forms.RadioButton();
            this.seperatedRadioButton = new System.Windows.Forms.RadioButton();
            this.marriedRadioButton = new System.Windows.Forms.RadioButton();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.maritalStatusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(31, 31);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(97, 24);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(129, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.AutoSize = true;
            this.lastNameTextBox.Location = new System.Drawing.Point(232, 31);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(61, 13);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Text = "Last Name:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(111, 63);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(64, 20);
            this.genderTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender (M/F):";
            // 
            // ppsNumberTextBox
            // 
            this.ppsNumberTextBox.Location = new System.Drawing.Point(108, 111);
            this.ppsNumberTextBox.Name = "ppsNumberTextBox";
            this.ppsNumberTextBox.Size = new System.Drawing.Size(151, 20);
            this.ppsNumberTextBox.TabIndex = 12;
            // 
            // ppsNumberLabel
            // 
            this.ppsNumberLabel.AutoSize = true;
            this.ppsNumberLabel.Location = new System.Drawing.Point(31, 114);
            this.ppsNumberLabel.Name = "ppsNumberLabel";
            this.ppsNumberLabel.Size = new System.Drawing.Size(71, 13);
            this.ppsNumberLabel.TabIndex = 11;
            this.ppsNumberLabel.Text = "PPS Number:";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(111, 157);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 13;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // maritalStatusGroupBox
            // 
            this.maritalStatusGroupBox.Controls.Add(this.divorcedRadioButton);
            this.maritalStatusGroupBox.Controls.Add(this.seperatedRadioButton);
            this.maritalStatusGroupBox.Controls.Add(this.marriedRadioButton);
            this.maritalStatusGroupBox.Controls.Add(this.singleRadioButton);
            this.maritalStatusGroupBox.Location = new System.Drawing.Point(299, 63);
            this.maritalStatusGroupBox.Name = "maritalStatusGroupBox";
            this.maritalStatusGroupBox.Size = new System.Drawing.Size(142, 117);
            this.maritalStatusGroupBox.TabIndex = 6;
            this.maritalStatusGroupBox.TabStop = false;
            this.maritalStatusGroupBox.Text = "Marital Status";
            this.maritalStatusGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // divorcedRadioButton
            // 
            this.divorcedRadioButton.AutoSize = true;
            this.divorcedRadioButton.Location = new System.Drawing.Point(6, 90);
            this.divorcedRadioButton.Name = "divorcedRadioButton";
            this.divorcedRadioButton.Size = new System.Drawing.Size(68, 17);
            this.divorcedRadioButton.TabIndex = 10;
            this.divorcedRadioButton.TabStop = true;
            this.divorcedRadioButton.Text = "Divorced";
            this.divorcedRadioButton.UseVisualStyleBackColor = true;
            // 
            // seperatedRadioButton
            // 
            this.seperatedRadioButton.AutoSize = true;
            this.seperatedRadioButton.Location = new System.Drawing.Point(6, 67);
            this.seperatedRadioButton.Name = "seperatedRadioButton";
            this.seperatedRadioButton.Size = new System.Drawing.Size(74, 17);
            this.seperatedRadioButton.TabIndex = 9;
            this.seperatedRadioButton.TabStop = true;
            this.seperatedRadioButton.Text = "Seperated";
            this.seperatedRadioButton.UseVisualStyleBackColor = true;
            // 
            // marriedRadioButton
            // 
            this.marriedRadioButton.AutoSize = true;
            this.marriedRadioButton.Location = new System.Drawing.Point(6, 44);
            this.marriedRadioButton.Name = "marriedRadioButton";
            this.marriedRadioButton.Size = new System.Drawing.Size(60, 17);
            this.marriedRadioButton.TabIndex = 8;
            this.marriedRadioButton.TabStop = true;
            this.marriedRadioButton.Text = "Married";
            this.marriedRadioButton.UseVisualStyleBackColor = true;
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Location = new System.Drawing.Point(6, 21);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(54, 17);
            this.singleRadioButton.TabIndex = 7;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "Single";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            // 
            // PersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 195);
            this.Controls.Add(this.maritalStatusGroupBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.ppsNumberTextBox);
            this.Controls.Add(this.ppsNumberLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "PersonalInformation";
            this.Text = "Personal Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.maritalStatusGroupBox.ResumeLayout(false);
            this.maritalStatusGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lastNameTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ppsNumberTextBox;
        private System.Windows.Forms.Label ppsNumberLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.GroupBox maritalStatusGroupBox;
        private System.Windows.Forms.RadioButton divorcedRadioButton;
        private System.Windows.Forms.RadioButton seperatedRadioButton;
        private System.Windows.Forms.RadioButton marriedRadioButton;
        private System.Windows.Forms.RadioButton singleRadioButton;
    }
}

