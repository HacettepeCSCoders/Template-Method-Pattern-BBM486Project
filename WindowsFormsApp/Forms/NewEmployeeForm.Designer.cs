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
            this.lblNewEmployeeRole = new System.Windows.Forms.Label();
            this.lblNewEmployeeLastName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBoxNewEmployee = new System.Windows.Forms.PictureBox();
            this.btnNewEmployeeSubmit = new WindowsFormsApp.CustomButton.CustomButton();
            this.lblPhoneNumberNewEmployee = new System.Windows.Forms.Label();
            this.lblEMailNewEmployee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxNewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewEmployeeName
            // 
            this.lblNewEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblNewEmployeeName.Location = new System.Drawing.Point(166, 14);
            this.lblNewEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewEmployeeName.Name = "lblNewEmployeeName";
            this.lblNewEmployeeName.Size = new System.Drawing.Size(117, 21);
            this.lblNewEmployeeName.TabIndex = 4;
            this.lblNewEmployeeName.Text = "First Name:";
            // 
            // lblNewEmployeeRole
            // 
            this.lblNewEmployeeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblNewEmployeeRole.Location = new System.Drawing.Point(321, 258);
            this.lblNewEmployeeRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewEmployeeRole.Name = "lblNewEmployeeRole";
            this.lblNewEmployeeRole.Size = new System.Drawing.Size(51, 21);
            this.lblNewEmployeeRole.TabIndex = 7;
            this.lblNewEmployeeRole.Text = "Role:";
            // 
            // lblNewEmployeeLastName
            // 
            this.lblNewEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblNewEmployeeLastName.Location = new System.Drawing.Point(370, 14);
            this.lblNewEmployeeLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewEmployeeLastName.Name = "lblNewEmployeeLastName";
            this.lblNewEmployeeLastName.Size = new System.Drawing.Size(117, 21);
            this.lblNewEmployeeLastName.TabIndex = 8;
            this.lblNewEmployeeLastName.Text = "Last Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 281);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // pictureBoxNewEmployee
            // 
            this.pictureBoxNewEmployee.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxNewEmployee.Image")));
            this.pictureBoxNewEmployee.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxNewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNewEmployee.Name = "pictureBoxNewEmployee";
            this.pictureBoxNewEmployee.Size = new System.Drawing.Size(112, 110);
            this.pictureBoxNewEmployee.TabIndex = 11;
            this.pictureBoxNewEmployee.TabStop = false;
            // 
            // btnNewEmployeeSubmit
            // 
            this.btnNewEmployeeSubmit.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.btnNewEmployeeSubmit.FlatAppearance.BorderSize = 0;
            this.btnNewEmployeeSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEmployeeSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.btnNewEmployeeSubmit.ForeColor = System.Drawing.Color.White;
            this.btnNewEmployeeSubmit.Location = new System.Drawing.Point(166, 321);
            this.btnNewEmployeeSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewEmployeeSubmit.Name = "btnNewEmployeeSubmit";
            this.btnNewEmployeeSubmit.Size = new System.Drawing.Size(348, 32);
            this.btnNewEmployeeSubmit.TabIndex = 14;
            this.btnNewEmployeeSubmit.Text = "Submit";
            this.btnNewEmployeeSubmit.UseVisualStyleBackColor = false;
            this.btnNewEmployeeSubmit.Click += new System.EventHandler(this.btnNewEmployeeSubmit_Click);
            // 
            // lblPhoneNumberNewEmployee
            // 
            this.lblPhoneNumberNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblPhoneNumberNewEmployee.Location = new System.Drawing.Point(370, 98);
            this.lblPhoneNumberNewEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumberNewEmployee.Name = "lblPhoneNumberNewEmployee";
            this.lblPhoneNumberNewEmployee.Size = new System.Drawing.Size(117, 21);
            this.lblPhoneNumberNewEmployee.TabIndex = 16;
            this.lblPhoneNumberNewEmployee.Text = "Phone:";
            // 
            // lblEMailNewEmployee
            // 
            this.lblEMailNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblEMailNewEmployee.Location = new System.Drawing.Point(166, 98);
            this.lblEMailNewEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEMailNewEmployee.Name = "lblEMailNewEmployee";
            this.lblEMailNewEmployee.Size = new System.Drawing.Size(117, 21);
            this.lblEMailNewEmployee.TabIndex = 15;
            this.lblEMailNewEmployee.Text = "E-Mail:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label1.Location = new System.Drawing.Point(166, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Address:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label2.Location = new System.Drawing.Point(370, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Work Situation:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(370, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(370, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 217);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 20);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(370, 217);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 20);
            this.textBox6.TabIndex = 24;
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 379);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhoneNumberNewEmployee);
            this.Controls.Add(this.lblEMailNewEmployee);
            this.Controls.Add(this.btnNewEmployeeSubmit);
            this.Controls.Add(this.pictureBoxNewEmployee);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNewEmployeeLastName);
            this.Controls.Add(this.lblNewEmployeeRole);
            this.Controls.Add(this.lblNewEmployeeName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewEmployeeForm";
            this.Text = "NewEmployeeForm";
            this.Load += new System.EventHandler(this.NewEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxNewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lblPhoneNumberNewEmployee;
        private System.Windows.Forms.Label lblEMailNewEmployee;

        private WindowsFormsApp.CustomButton.CustomButton btnNewEmployeeSubmit;

        private WindowsFormsApp.CustomButton.CustomButton customButton1;

        private System.Windows.Forms.PictureBox pictureBoxNewEmployee;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblNewEmployeeLastName;
        private System.Windows.Forms.Label lblNewEmployeeRole;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label lblNewEmployeeName;

        #endregion
    }
}