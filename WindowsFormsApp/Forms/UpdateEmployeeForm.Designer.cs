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
            this.lblUpdateHeader = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new WindowsFormsApp.CustomButton.CustomButton();
            this.comboBoxUpdateSelectRole = new System.Windows.Forms.ComboBox();
            this.lblUpdateSelectRole = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lblUpdateFirstName.Location = new System.Drawing.Point(190, 128);
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
            this.lblUpdateLastName.Location = new System.Drawing.Point(368, 128);
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
            this.lblUpdateEmail.Location = new System.Drawing.Point(191, 252);
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
            this.lblUpdatePhone.Location = new System.Drawing.Point(365, 252);
            this.lblUpdatePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdatePhone.Name = "lblUpdatePhone";
            this.lblUpdatePhone.Size = new System.Drawing.Size(121, 18);
            this.lblUpdatePhone.TabIndex = 4;
            this.lblUpdatePhone.Text = "Phone:";
            // 
            // lblUpdateHeader
            // 
            this.lblUpdateHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateHeader.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateHeader.Location = new System.Drawing.Point(191, 64);
            this.lblUpdateHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateHeader.Name = "lblUpdateHeader";
            this.lblUpdateHeader.Size = new System.Drawing.Size(325, 18);
            this.lblUpdateHeader.TabIndex = 13;
            this.lblUpdateHeader.Text = "Please select the employee:\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 91);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 21);
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
            this.comboBoxUpdateSelectRole.Location = new System.Drawing.Point(190, 31);
            this.comboBoxUpdateSelectRole.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUpdateSelectRole.Name = "comboBoxUpdateSelectRole";
            this.comboBoxUpdateSelectRole.Size = new System.Drawing.Size(320, 21);
            this.comboBoxUpdateSelectRole.TabIndex = 17;
            this.comboBoxUpdateSelectRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateSelectRole_SelectedIndexChanged);
            // 
            // lblUpdateSelectRole
            // 
            this.lblUpdateSelectRole.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateSelectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateSelectRole.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateSelectRole.Location = new System.Drawing.Point(191, 2);
            this.lblUpdateSelectRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateSelectRole.Name = "lblUpdateSelectRole";
            this.lblUpdateSelectRole.Size = new System.Drawing.Size(325, 18);
            this.lblUpdateSelectRole.TabIndex = 16;
            this.lblUpdateSelectRole.Text = "Please select the role of employee:\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(368, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(365, 282);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.label1.Location = new System.Drawing.Point(191, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Work Situation:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(191, 220);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 20);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(13, 282);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 20);
            this.textBox6.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.label2.Location = new System.Drawing.Point(13, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mentor/Senior/Manager ID:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(365, 220);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(144, 20);
            this.textBox7.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.label3.Location = new System.Drawing.Point(365, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Address:";
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxUpdateSelectRole);
            this.Controls.Add(this.lblUpdateSelectRole);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUpdateHeader);
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

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;

        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;

        private System.Windows.Forms.ComboBox comboBoxUpdateSelectRole;
        private System.Windows.Forms.Label lblUpdateSelectRole;

        private System.Windows.Forms.Label lblUpdateHeader;
        private WindowsFormsApp.CustomButton.CustomButton btnUpdate;

        private System.Windows.Forms.ComboBox comboBox1;

        private WindowsFormsApp.CustomTextBox customTextBox2;
        private WindowsFormsApp.CustomTextBox customTextBox3;
        private WindowsFormsApp.CustomTextBox customTextBox4;

        private WindowsFormsApp.CustomTextBox customTextBox1;

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