namespace Ex08
{
    partial class Form2
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
            this.dataFromForm1Label = new System.Windows.Forms.Label();
            this.dataFromForm1TextBox = new System.Windows.Forms.TextBox();
            this.inputDataForm2Label = new System.Windows.Forms.Label();
            this.inputDataForm2TextBox = new System.Windows.Forms.TextBox();
            this.form2BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataFromForm1Label
            // 
            this.dataFromForm1Label.AutoSize = true;
            this.dataFromForm1Label.Location = new System.Drawing.Point(7, 80);
            this.dataFromForm1Label.Name = "dataFromForm1Label";
            this.dataFromForm1Label.Size = new System.Drawing.Size(91, 13);
            this.dataFromForm1Label.TabIndex = 2;
            this.dataFromForm1Label.Text = "Data from Form 1:";
            // 
            // dataFromForm1TextBox
            // 
            this.dataFromForm1TextBox.Location = new System.Drawing.Point(104, 73);
            this.dataFromForm1TextBox.Name = "dataFromForm1TextBox";
            this.dataFromForm1TextBox.Size = new System.Drawing.Size(150, 20);
            this.dataFromForm1TextBox.TabIndex = 3;
            this.dataFromForm1TextBox.TextChanged += new System.EventHandler(this.dataFromForm1TextBox_TextChanged);
            // 
            // inputDataForm2Label
            // 
            this.inputDataForm2Label.AutoSize = true;
            this.inputDataForm2Label.Location = new System.Drawing.Point(38, 38);
            this.inputDataForm2Label.Name = "inputDataForm2Label";
            this.inputDataForm2Label.Size = new System.Drawing.Size(60, 13);
            this.inputDataForm2Label.TabIndex = 0;
            this.inputDataForm2Label.Text = "Input Data:";
            // 
            // inputDataForm2TextBox
            // 
            this.inputDataForm2TextBox.Location = new System.Drawing.Point(104, 31);
            this.inputDataForm2TextBox.Name = "inputDataForm2TextBox";
            this.inputDataForm2TextBox.Size = new System.Drawing.Size(150, 20);
            this.inputDataForm2TextBox.TabIndex = 1;
            // 
            // form2BackButton
            // 
            this.form2BackButton.Location = new System.Drawing.Point(166, 148);
            this.form2BackButton.Name = "form2BackButton";
            this.form2BackButton.Size = new System.Drawing.Size(88, 38);
            this.form2BackButton.TabIndex = 4;
            this.form2BackButton.Text = "<- Back";
            this.form2BackButton.UseVisualStyleBackColor = true;
            this.form2BackButton.Click += new System.EventHandler(this.form2BackButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 198);
            this.Controls.Add(this.dataFromForm1Label);
            this.Controls.Add(this.dataFromForm1TextBox);
            this.Controls.Add(this.inputDataForm2Label);
            this.Controls.Add(this.inputDataForm2TextBox);
            this.Controls.Add(this.form2BackButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataFromForm1Label;
        private System.Windows.Forms.TextBox dataFromForm1TextBox;
        private System.Windows.Forms.Label inputDataForm2Label;
        private System.Windows.Forms.TextBox inputDataForm2TextBox;
        private System.Windows.Forms.Button form2BackButton;
    }
}