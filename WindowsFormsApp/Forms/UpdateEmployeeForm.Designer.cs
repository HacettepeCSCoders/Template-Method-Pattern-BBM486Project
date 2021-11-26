using System.ComponentModel;

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
            this.customTextBoxUpdateFirstName = new WindowsFormsApp.CustomTextBox();
            this.customTextBoxUpdateLastName = new WindowsFormsApp.CustomTextBox();
            this.customTextBoxUpdateEmail = new WindowsFormsApp.CustomTextBox();
            this.customTextBoxUpdatePhone = new WindowsFormsApp.CustomTextBox();
            this.dateTimePickerUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUpdateRole = new System.Windows.Forms.ComboBox();
            this.lblUpdateHeader = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new WindowsFormsApp.CustomButton.CustomButton();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxUpdatePage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUpdatePage
            // 
            this.pictureBoxUpdatePage.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxUpdatePage.Image")));
            this.pictureBoxUpdatePage.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxUpdatePage.Name = "pictureBoxUpdatePage";
            this.pictureBoxUpdatePage.Size = new System.Drawing.Size(137, 136);
            this.pictureBoxUpdatePage.TabIndex = 0;
            this.pictureBoxUpdatePage.TabStop = false;
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateFirstName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateFirstName.Location = new System.Drawing.Point(212, 85);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(161, 22);
            this.lblUpdateFirstName.TabIndex = 1;
            this.lblUpdateFirstName.Text = "First Name:";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateLastName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateLastName.Location = new System.Drawing.Point(484, 85);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(161, 22);
            this.lblUpdateLastName.TabIndex = 2;
            this.lblUpdateLastName.Text = "Last Name:";
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateEmail.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateEmail.Location = new System.Drawing.Point(212, 169);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(161, 22);
            this.lblUpdateEmail.TabIndex = 3;
            this.lblUpdateEmail.Text = "E-Mail:";
            // 
            // lblUpdatePhone
            // 
            this.lblUpdatePhone.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdatePhone.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdatePhone.Location = new System.Drawing.Point(484, 169);
            this.lblUpdatePhone.Name = "lblUpdatePhone";
            this.lblUpdatePhone.Size = new System.Drawing.Size(161, 22);
            this.lblUpdatePhone.TabIndex = 4;
            this.lblUpdatePhone.Text = "Phone:";
            // 
            // lblUpdateRole
            // 
            this.lblUpdateRole.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateRole.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateRole.Location = new System.Drawing.Point(212, 259);
            this.lblUpdateRole.Name = "lblUpdateRole";
            this.lblUpdateRole.Size = new System.Drawing.Size(161, 22);
            this.lblUpdateRole.TabIndex = 5;
            this.lblUpdateRole.Text = "Role:";
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateDate.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateDate.Location = new System.Drawing.Point(484, 259);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(161, 22);
            this.lblUpdateDate.TabIndex = 6;
            this.lblUpdateDate.Text = "Date:";
            // 
            // customTextBoxUpdateFirstName
            // 
            this.customTextBoxUpdateFirstName.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.customTextBoxUpdateFirstName.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.customTextBoxUpdateFirstName.BorderSize = 2;
            this.customTextBoxUpdateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.customTextBoxUpdateFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxUpdateFirstName.Location = new System.Drawing.Point(212, 111);
            this.customTextBoxUpdateFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBoxUpdateFirstName.Name = "customTextBoxUpdateFirstName";
            this.customTextBoxUpdateFirstName.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.customTextBoxUpdateFirstName.Size = new System.Drawing.Size(161, 31);
            this.customTextBoxUpdateFirstName.TabIndex = 7;
            this.customTextBoxUpdateFirstName.UnderlinedStyle = true;
            // 
            // customTextBoxUpdateLastName
            // 
            this.customTextBoxUpdateLastName.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.customTextBoxUpdateLastName.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.customTextBoxUpdateLastName.BorderSize = 2;
            this.customTextBoxUpdateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.customTextBoxUpdateLastName.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxUpdateLastName.Location = new System.Drawing.Point(484, 111);
            this.customTextBoxUpdateLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBoxUpdateLastName.Name = "customTextBoxUpdateLastName";
            this.customTextBoxUpdateLastName.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.customTextBoxUpdateLastName.Size = new System.Drawing.Size(161, 31);
            this.customTextBoxUpdateLastName.TabIndex = 8;
            this.customTextBoxUpdateLastName.UnderlinedStyle = true;
            // 
            // customTextBoxUpdateEmail
            // 
            this.customTextBoxUpdateEmail.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.customTextBoxUpdateEmail.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.customTextBoxUpdateEmail.BorderSize = 2;
            this.customTextBoxUpdateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.customTextBoxUpdateEmail.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxUpdateEmail.Location = new System.Drawing.Point(212, 195);
            this.customTextBoxUpdateEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBoxUpdateEmail.Name = "customTextBoxUpdateEmail";
            this.customTextBoxUpdateEmail.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.customTextBoxUpdateEmail.Size = new System.Drawing.Size(161, 31);
            this.customTextBoxUpdateEmail.TabIndex = 9;
            this.customTextBoxUpdateEmail.UnderlinedStyle = true;
            // 
            // customTextBoxUpdatePhone
            // 
            this.customTextBoxUpdatePhone.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.customTextBoxUpdatePhone.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.customTextBoxUpdatePhone.BorderSize = 2;
            this.customTextBoxUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.customTextBoxUpdatePhone.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxUpdatePhone.Location = new System.Drawing.Point(484, 195);
            this.customTextBoxUpdatePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBoxUpdatePhone.Name = "customTextBoxUpdatePhone";
            this.customTextBoxUpdatePhone.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.customTextBoxUpdatePhone.Size = new System.Drawing.Size(161, 31);
            this.customTextBoxUpdatePhone.TabIndex = 10;
            this.customTextBoxUpdatePhone.UnderlinedStyle = true;
            // 
            // dateTimePickerUpdateDate
            // 
            this.dateTimePickerUpdateDate.Location = new System.Drawing.Point(484, 290);
            this.dateTimePickerUpdateDate.Name = "dateTimePickerUpdateDate";
            this.dateTimePickerUpdateDate.Size = new System.Drawing.Size(192, 22);
            this.dateTimePickerUpdateDate.TabIndex = 11;
            // 
            // comboBoxUpdateRole
            // 
            this.comboBoxUpdateRole.FormattingEnabled = true;
            this.comboBoxUpdateRole.Location = new System.Drawing.Point(212, 290);
            this.comboBoxUpdateRole.Name = "comboBoxUpdateRole";
            this.comboBoxUpdateRole.Size = new System.Drawing.Size(192, 24);
            this.comboBoxUpdateRole.TabIndex = 12;
            // 
            // lblUpdateHeader
            // 
            this.lblUpdateHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblUpdateHeader.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblUpdateHeader.Location = new System.Drawing.Point(212, 9);
            this.lblUpdateHeader.Name = "lblUpdateHeader";
            this.lblUpdateHeader.Size = new System.Drawing.Size(433, 22);
            this.lblUpdateHeader.TabIndex = 13;
            this.lblUpdateHeader.Text = "Please select the employee:\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(464, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(212, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(464, 38);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUpdateHeader);
            this.Controls.Add(this.comboBoxUpdateRole);
            this.Controls.Add(this.dateTimePickerUpdateDate);
            this.Controls.Add(this.customTextBoxUpdatePhone);
            this.Controls.Add(this.customTextBoxUpdateEmail);
            this.Controls.Add(this.customTextBoxUpdateLastName);
            this.Controls.Add(this.customTextBoxUpdateFirstName);
            this.Controls.Add(this.lblUpdateDate);
            this.Controls.Add(this.lblUpdateRole);
            this.Controls.Add(this.lblUpdatePhone);
            this.Controls.Add(this.lblUpdateEmail);
            this.Controls.Add(this.lblUpdateLastName);
            this.Controls.Add(this.lblUpdateFirstName);
            this.Controls.Add(this.pictureBoxUpdatePage);
            this.Name = "UpdateEmployeeForm";
            this.Text = "UpdateEmployeeForm";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxUpdatePage)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBoxUpdateRole;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdateDate;
        private WindowsFormsApp.CustomTextBox customTextBoxUpdateFirstName;
        private WindowsFormsApp.CustomTextBox customTextBoxUpdateLastName;
        private WindowsFormsApp.CustomTextBox customTextBoxUpdateEmail;
        private WindowsFormsApp.CustomTextBox customTextBoxUpdatePhone;
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