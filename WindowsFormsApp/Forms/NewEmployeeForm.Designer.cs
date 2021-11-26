using System.ComponentModel;

namespace WindowsFormsApp.Forms
{
    partial class NewEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEmployeeForm));
            this.lblNewEmployeeName = new System.Windows.Forms.Label();
            this.lblNewEmployeeDate = new System.Windows.Forms.Label();
            this.lblNewEmployeeRole = new System.Windows.Forms.Label();
            this.lblNewEmployeeLastName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBoxNewEmployee = new System.Windows.Forms.PictureBox();
            this.customTextBox1 = new WindowsFormsApp.CustomTextBox();
            this.customTextBox2 = new WindowsFormsApp.CustomTextBox();
            this.btnNewEmployeeSubmit = new WindowsFormsApp.CustomButton.CustomButton();
            this.customTextBox3 = new WindowsFormsApp.CustomTextBox();
            this.customTextBox4 = new WindowsFormsApp.CustomTextBox();
            this.lblPhoneNumberNewEmployee = new System.Windows.Forms.Label();
            this.lblEMailNewEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxNewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewEmployeeName
            // 
            this.lblNewEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblNewEmployeeName.Location = new System.Drawing.Point(221, 11);
            this.lblNewEmployeeName.Name = "lblNewEmployeeName";
            this.lblNewEmployeeName.Size = new System.Drawing.Size(156, 26);
            this.lblNewEmployeeName.TabIndex = 4;
            this.lblNewEmployeeName.Text = "First Name:";
            // 
            // lblNewEmployeeDate
            // 
            this.lblNewEmployeeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblNewEmployeeDate.Location = new System.Drawing.Point(493, 216);
            this.lblNewEmployeeDate.Name = "lblNewEmployeeDate";
            this.lblNewEmployeeDate.Size = new System.Drawing.Size(75, 26);
            this.lblNewEmployeeDate.TabIndex = 6;
            this.lblNewEmployeeDate.Text = "Date: ";
            // 
            // lblNewEmployeeRole
            // 
            this.lblNewEmployeeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblNewEmployeeRole.Location = new System.Drawing.Point(221, 216);
            this.lblNewEmployeeRole.Name = "lblNewEmployeeRole";
            this.lblNewEmployeeRole.Size = new System.Drawing.Size(68, 26);
            this.lblNewEmployeeRole.TabIndex = 7;
            this.lblNewEmployeeRole.Text = "Role:";
            // 
            // lblNewEmployeeLastName
            // 
            this.lblNewEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblNewEmployeeLastName.Location = new System.Drawing.Point(493, 11);
            this.lblNewEmployeeLastName.Name = "lblNewEmployeeLastName";
            this.lblNewEmployeeLastName.Size = new System.Drawing.Size(156, 26);
            this.lblNewEmployeeLastName.TabIndex = 8;
            this.lblNewEmployeeLastName.Text = "Last Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(493, 247);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 247);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // pictureBoxNewEmployee
            // 
            this.pictureBoxNewEmployee.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxNewEmployee.Image")));
            this.pictureBoxNewEmployee.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxNewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxNewEmployee.Name = "pictureBoxNewEmployee";
            this.pictureBoxNewEmployee.Size = new System.Drawing.Size(149, 135);
            this.pictureBoxNewEmployee.TabIndex = 11;
            this.pictureBoxNewEmployee.TabStop = false;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.customTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(221, 41);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.customTextBox1.Size = new System.Drawing.Size(161, 31);
            this.customTextBox1.TabIndex = 12;
            this.customTextBox1.UnderlinedStyle = true;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.customTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.customTextBox2.BorderSize = 2;
            this.customTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.customTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox2.Location = new System.Drawing.Point(493, 41);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.customTextBox2.Size = new System.Drawing.Size(161, 31);
            this.customTextBox2.TabIndex = 13;
            this.customTextBox2.UnderlinedStyle = true;
            // 
            // btnNewEmployeeSubmit
            // 
            this.btnNewEmployeeSubmit.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.btnNewEmployeeSubmit.FlatAppearance.BorderSize = 0;
            this.btnNewEmployeeSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEmployeeSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.btnNewEmployeeSubmit.ForeColor = System.Drawing.Color.White;
            this.btnNewEmployeeSubmit.Location = new System.Drawing.Point(221, 303);
            this.btnNewEmployeeSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewEmployeeSubmit.Name = "btnNewEmployeeSubmit";
            this.btnNewEmployeeSubmit.Size = new System.Drawing.Size(464, 39);
            this.btnNewEmployeeSubmit.TabIndex = 14;
            this.btnNewEmployeeSubmit.Text = "Submit";
            this.btnNewEmployeeSubmit.UseVisualStyleBackColor = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.customTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.customTextBox3.BorderSize = 2;
            this.customTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.customTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox3.Location = new System.Drawing.Point(493, 151);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.customTextBox3.Size = new System.Drawing.Size(161, 31);
            this.customTextBox3.TabIndex = 18;
            this.customTextBox3.UnderlinedStyle = true;
            // 
            // customTextBox4
            // 
            this.customTextBox4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.customTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.customTextBox4.BorderSize = 2;
            this.customTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.customTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox4.Location = new System.Drawing.Point(221, 151);
            this.customTextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.customTextBox4.Size = new System.Drawing.Size(161, 31);
            this.customTextBox4.TabIndex = 17;
            this.customTextBox4.UnderlinedStyle = true;
            // 
            // lblPhoneNumberNewEmployee
            // 
            this.lblPhoneNumberNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblPhoneNumberNewEmployee.Location = new System.Drawing.Point(493, 121);
            this.lblPhoneNumberNewEmployee.Name = "lblPhoneNumberNewEmployee";
            this.lblPhoneNumberNewEmployee.Size = new System.Drawing.Size(156, 26);
            this.lblPhoneNumberNewEmployee.TabIndex = 16;
            this.lblPhoneNumberNewEmployee.Text = "Phone:";
            // 
            // lblEMailNewEmployee
            // 
            this.lblEMailNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblEMailNewEmployee.Location = new System.Drawing.Point(221, 121);
            this.lblEMailNewEmployee.Name = "lblEMailNewEmployee";
            this.lblEMailNewEmployee.Size = new System.Drawing.Size(156, 26);
            this.lblEMailNewEmployee.TabIndex = 15;
            this.lblEMailNewEmployee.Text = "E-Mail:";
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 466);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox4);
            this.Controls.Add(this.lblPhoneNumberNewEmployee);
            this.Controls.Add(this.lblEMailNewEmployee);
            this.Controls.Add(this.btnNewEmployeeSubmit);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.pictureBoxNewEmployee);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblNewEmployeeLastName);
            this.Controls.Add(this.lblNewEmployeeRole);
            this.Controls.Add(this.lblNewEmployeeDate);
            this.Controls.Add(this.lblNewEmployeeName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewEmployeeForm";
            this.Text = "NewEmployeeForm";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxNewEmployee)).EndInit();
            this.ResumeLayout(false);
        }

        private WindowsFormsApp.CustomTextBox customTextBox3;
        private System.Windows.Forms.Label lblPhoneNumberNewEmployee;
        private System.Windows.Forms.Label lblEMailNewEmployee;

        private WindowsFormsApp.CustomButton.CustomButton btnNewEmployeeSubmit;

        private WindowsFormsApp.CustomButton.CustomButton customButton1;

        private WindowsFormsApp.CustomTextBox customTextBox1;

        private System.Windows.Forms.PictureBox pictureBoxNewEmployee;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNewEmployeeLastName;
        private System.Windows.Forms.Label lblNewEmployeeRole;
        private System.Windows.Forms.Label lblNewEmployeeDate;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private System.Windows.Forms.Label lblNewEmployeeName;

        private WindowsFormsApp.CustomTextBox customTextBox2;
        private WindowsFormsApp.CustomTextBox customTextBox4;

        #endregion
    }
}