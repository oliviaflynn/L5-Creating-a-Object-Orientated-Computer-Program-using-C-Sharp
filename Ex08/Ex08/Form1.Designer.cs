namespace Ex08
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
            System.Windows.Forms.TextBox inputDataText;
            this.form1NextButton = new System.Windows.Forms.Button();
            this.inputDataLabel = new System.Windows.Forms.Label();
            this.dataFromForm2Label = new System.Windows.Forms.Label();
            this.dataFromForm2TextBox = new System.Windows.Forms.TextBox();
            inputDataText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // form1NextButton
            // 
            this.form1NextButton.Location = new System.Drawing.Point(167, 148);
            this.form1NextButton.Name = "form1NextButton";
            this.form1NextButton.Size = new System.Drawing.Size(88, 38);
            this.form1NextButton.TabIndex = 4;
            this.form1NextButton.Text = "Next ->";
            this.form1NextButton.UseVisualStyleBackColor = true;
            this.form1NextButton.Click += new System.EventHandler(this.form1NextButton_Click);
            // 
            // inputDataText
            // 
            inputDataText.Location = new System.Drawing.Point(105, 34);
            inputDataText.Name = "inputDataText";
            inputDataText.Size = new System.Drawing.Size(150, 20);
            inputDataText.TabIndex = 1;
            inputDataText.TextChanged += new System.EventHandler(this.inputDataText_TextChanged);
            // 
            // inputDataLabel
            // 
            this.inputDataLabel.AutoSize = true;
            this.inputDataLabel.Location = new System.Drawing.Point(39, 41);
            this.inputDataLabel.Name = "inputDataLabel";
            this.inputDataLabel.Size = new System.Drawing.Size(60, 13);
            this.inputDataLabel.TabIndex = 0;
            this.inputDataLabel.Text = "Input Data:";
            // 
            // dataFromForm2Label
            // 
            this.dataFromForm2Label.AutoSize = true;
            this.dataFromForm2Label.Location = new System.Drawing.Point(8, 83);
            this.dataFromForm2Label.Name = "dataFromForm2Label";
            this.dataFromForm2Label.Size = new System.Drawing.Size(91, 13);
            this.dataFromForm2Label.TabIndex = 2;
            this.dataFromForm2Label.Text = "Data from Form 2:";
            // 
            // dataFromForm2TextBox
            // 
            this.dataFromForm2TextBox.Location = new System.Drawing.Point(105, 76);
            this.dataFromForm2TextBox.Name = "dataFromForm2TextBox";
            this.dataFromForm2TextBox.Size = new System.Drawing.Size(150, 20);
            this.dataFromForm2TextBox.TabIndex = 3;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 198);
            this.Controls.Add(this.dataFromForm2Label);
            this.Controls.Add(this.dataFromForm2TextBox);
            this.Controls.Add(this.inputDataLabel);
            this.Controls.Add(inputDataText);
            this.Controls.Add(this.form1NextButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button form1NextButton;
        private System.Windows.Forms.Label inputDataLabel;
        private System.Windows.Forms.Label dataFromForm2Label;
        private System.Windows.Forms.TextBox dataFromForm2TextBox;
    }
}

