namespace Ex07._02
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.loanPeriodTextBox = new System.Windows.Forms.TextBox();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.monthlyPaymentTextBox = new System.Windows.Forms.TextBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Annual Interest Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loan Period (Months):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loan Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monthly Payment:";
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(151, 25);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.interestRateTextBox.TabIndex = 4;
            this.interestRateTextBox.TextChanged += new System.EventHandler(this.interestRateTextBox_TextChanged);
            // 
            // loanPeriodTextBox
            // 
            this.loanPeriodTextBox.Location = new System.Drawing.Point(151, 55);
            this.loanPeriodTextBox.Name = "loanPeriodTextBox";
            this.loanPeriodTextBox.Size = new System.Drawing.Size(100, 20);
            this.loanPeriodTextBox.TabIndex = 5;
            this.loanPeriodTextBox.TextChanged += new System.EventHandler(this.loanPeriodTextBox_TextChanged);
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(151, 85);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.loanAmountTextBox.TabIndex = 6;
            this.loanAmountTextBox.TextChanged += new System.EventHandler(this.loanAmountTextBox_TextChanged);
            // 
            // monthlyPaymentTextBox
            // 
            this.monthlyPaymentTextBox.Enabled = false;
            this.monthlyPaymentTextBox.Location = new System.Drawing.Point(151, 117);
            this.monthlyPaymentTextBox.Name = "monthlyPaymentTextBox";
            this.monthlyPaymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthlyPaymentTextBox.TabIndex = 7;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(151, 154);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 8;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 201);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.monthlyPaymentTextBox);
            this.Controls.Add(this.loanAmountTextBox);
            this.Controls.Add(this.loanPeriodTextBox);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mortgage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox loanPeriodTextBox;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.TextBox monthlyPaymentTextBox;
        private System.Windows.Forms.Button cmdExit;
    }
}

