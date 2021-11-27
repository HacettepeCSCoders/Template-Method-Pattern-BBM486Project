using System.Collections;
using System.ComponentModel;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Win32;

namespace WindowsFormsApp.Forms
{
    partial class UpdateEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeeForm));
            this.pictureBoxUpdatePage = new System.Windows.Forms.PictureBox();
            this.lblUpdateFirstName = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.lblUpdatePhone = new System.Windows.Forms.Label();
            this.lblUpdateRole = new System.Windows.Forms.Label();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.dateTimePickerUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUpdateRole = new System.Windows.Forms.ComboBox();
            this.lblUpdateHeader = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new WindowsFormsApp.CustomButton.CustomButton();
            this.comboBoxUpdateSelectRole = new System.Windows.Forms.ComboBox();
            this.lblUpdateSelectRole = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxUpdatePage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUpdatePage
            // 
            this.pictureBoxUpdatePage.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxUpdatePage.Image")));
            this.pictureBoxUpdatePage.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxUpdatePage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUpdatePage.Name = "pictureBoxUpdatePage";
            this.pictureBoxUpdatePage.Size = new System.Drawing.Size(103, 110);
            this.pictureBoxUpdatePage.TabIndex = 0;
            this.pictureBoxUpdatePage.TabStop = false;
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateFirstName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateFirstName.Location = new System.Drawing.Point(161, 122);
            this.lblUpdateFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(121, 18);
            this.lblUpdateFirstName.TabIndex = 1;
            this.lblUpdateFirstName.Text = "First Name:";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateLastName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateLastName.Location = new System.Drawing.Point(365, 122);
            this.lblUpdateLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(121, 18);
            this.lblUpdateLastName.TabIndex = 2;
            this.lblUpdateLastName.Text = "Last Name:";
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateEmail.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateEmail.Location = new System.Drawing.Point(161, 190);
            this.lblUpdateEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(121, 18);
            this.lblUpdateEmail.TabIndex = 3;
            this.lblUpdateEmail.Text = "E-Mail:";
            // 
            // lblUpdatePhone
            // 
            this.lblUpdatePhone.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdatePhone.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdatePhone.Location = new System.Drawing.Point(365, 190);
            this.lblUpdatePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatePhone.Name = "lblUpdatePhone";
            this.lblUpdatePhone.Size = new System.Drawing.Size(121, 18);
            this.lblUpdatePhone.TabIndex = 4;
            this.lblUpdatePhone.Text = "Phone:";
            // 
            // lblUpdateRole
            // 
            this.lblUpdateRole.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateRole.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateRole.Location = new System.Drawing.Point(161, 263);
            this.lblUpdateRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateRole.Name = "lblUpdateRole";
            this.lblUpdateRole.Size = new System.Drawing.Size(121, 18);
            this.lblUpdateRole.TabIndex = 5;
            this.lblUpdateRole.Text = "Role:";
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateDate.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateDate.Location = new System.Drawing.Point(365, 263);
            this.lblUpdateDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(121, 18);
            this.lblUpdateDate.TabIndex = 6;
            this.lblUpdateDate.Text = "Date:";
            // 
            // dateTimePickerUpdateDate
            // 
            this.dateTimePickerUpdateDate.Location = new System.Drawing.Point(365, 288);
            this.dateTimePickerUpdateDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerUpdateDate.Name = "dateTimePickerUpdateDate";
            this.dateTimePickerUpdateDate.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerUpdateDate.TabIndex = 11;
            // 
            // comboBoxUpdateRole
            // 
            this.comboBoxUpdateRole.FormattingEnabled = true;
            this.comboBoxUpdateRole.Location = new System.Drawing.Point(161, 287);
            this.comboBoxUpdateRole.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUpdateRole.Name = "comboBoxUpdateRole";
            this.comboBoxUpdateRole.Size = new System.Drawing.Size(145, 21);
            this.comboBoxUpdateRole.TabIndex = 12;
            // 
            // lblUpdateHeader
            // 
            this.lblUpdateHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateHeader.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateHeader.Location = new System.Drawing.Point(161, 61);
            this.lblUpdateHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateHeader.Name = "lblUpdateHeader";
            this.lblUpdateHeader.Size = new System.Drawing.Size(325, 18);
            this.lblUpdateHeader.TabIndex = 13;
            this.lblUpdateHeader.Text = "Please select the employee:\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 90);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(161, 329);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(348, 31);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBoxUpdateSelectRole
            // 
            this.comboBoxUpdateSelectRole.FormattingEnabled = true;
            this.comboBoxUpdateSelectRole.Location = new System.Drawing.Point(161, 31);
            this.comboBoxUpdateSelectRole.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUpdateSelectRole.Name = "comboBoxUpdateSelectRole";
            this.comboBoxUpdateSelectRole.Size = new System.Drawing.Size(349, 21);
            this.comboBoxUpdateSelectRole.TabIndex = 17;
            this.comboBoxUpdateSelectRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateSelectRole_SelectedIndexChanged);
            // 
            // lblUpdateSelectRole
            // 
            this.lblUpdateSelectRole.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateSelectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateSelectRole.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateSelectRole.Location = new System.Drawing.Point(161, 2);
            this.lblUpdateSelectRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateSelectRole.Name = "lblUpdateSelectRole";
            this.lblUpdateSelectRole.Size = new System.Drawing.Size(325, 18);
            this.lblUpdateSelectRole.TabIndex = 16;
            this.lblUpdateSelectRole.Text = "Please select the role of employee:\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(365, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(365, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 21;
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxUpdateSelectRole);
            this.Controls.Add(this.lblUpdateSelectRole);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUpdateHeader);
            this.Controls.Add(this.comboBoxUpdateRole);
            this.Controls.Add(this.dateTimePickerUpdateDate);
            this.Controls.Add(this.lblUpdateDate);
            this.Controls.Add(this.lblUpdateRole);
            this.Controls.Add(this.lblUpdatePhone);
            this.Controls.Add(this.lblUpdateEmail);
            this.Controls.Add(this.lblUpdateLastName);
            this.Controls.Add(this.lblUpdateFirstName);
            this.Controls.Add(this.pictureBoxUpdatePage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateEmployeeForm";
            this.Text = "UpdateEmployeeForm";
            this.Load += new System.EventHandler(this.UpdateEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxUpdatePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.ComboBox comboBoxUpdateSelectRole;
        private System.Windows.Forms.Label lblUpdateSelectRole;

        private System.Windows.Forms.ComboBox comboBoxUpdateRole;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdateDate;
        private System.Windows.Forms.Label lblUpdateHeader;
        private WindowsFormsApp.CustomButton.CustomButton btnUpdate;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        private WindowsFormsApp.CustomTextBox customTextBox2;
        private WindowsFormsApp.CustomTextBox customTextBox3;
        private WindowsFormsApp.CustomTextBox customTextBox4;

        private System.Windows.Forms.Label lblUpdateDate;
        private WindowsFormsApp.CustomTextBox customTextBox1;

        private System.Windows.Forms.Label lblUpdateRole;

        private System.Windows.Forms.Label lblUpdatePhone;

        private System.Windows.Forms.Label lblUpdateEmail;

        private System.Windows.Forms.Label lblUpdateLastName;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label lblUpdateFirstName;

        private System.Windows.Forms.PictureBox pictureBoxUpdatePage;

        #endregion
    }
}