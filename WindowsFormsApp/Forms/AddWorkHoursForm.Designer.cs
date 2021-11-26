using System.ComponentModel;

namespace WindowsFormsApp.Forms
{
    partial class AddWorkHoursForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkHoursForm));
            this.pictureBoxWorkHours = new System.Windows.Forms.PictureBox();
            this.lblAddWorkHoursSelectEmployee = new System.Windows.Forms.Label();
            this.comboBoxAddWorkHoursSelectEmployee = new System.Windows.Forms.ComboBox();
            this.customTextBoxAddWorkHoursEnterWorkHours = new WindowsFormsApp.CustomTextBox();
            this.lblAddWorkHoursEnterWorkHours = new System.Windows.Forms.Label();
            this.btnAddWorkHoursSubmit = new WindowsFormsApp.CustomButton.CustomButton();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxWorkHours)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWorkHours
            // 
            this.pictureBoxWorkHours.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxWorkHours.Image")));
            this.pictureBoxWorkHours.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxWorkHours.Name = "pictureBoxWorkHours";
            this.pictureBoxWorkHours.Size = new System.Drawing.Size(138, 133);
            this.pictureBoxWorkHours.TabIndex = 0;
            this.pictureBoxWorkHours.TabStop = false;
            // 
            // lblAddWorkHoursSelectEmployee
            // 
            this.lblAddWorkHoursSelectEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblAddWorkHoursSelectEmployee.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblAddWorkHoursSelectEmployee.Location = new System.Drawing.Point(174, 20);
            this.lblAddWorkHoursSelectEmployee.Name = "lblAddWorkHoursSelectEmployee";
            this.lblAddWorkHoursSelectEmployee.Size = new System.Drawing.Size(257, 28);
            this.lblAddWorkHoursSelectEmployee.TabIndex = 1;
            this.lblAddWorkHoursSelectEmployee.Text = "Please select the employee:";
            // 
            // comboBoxAddWorkHoursSelectEmployee
            // 
            this.comboBoxAddWorkHoursSelectEmployee.FormattingEnabled = true;
            this.comboBoxAddWorkHoursSelectEmployee.Location = new System.Drawing.Point(174, 63);
            this.comboBoxAddWorkHoursSelectEmployee.Name = "comboBoxAddWorkHoursSelectEmployee";
            this.comboBoxAddWorkHoursSelectEmployee.Size = new System.Drawing.Size(405, 24);
            this.comboBoxAddWorkHoursSelectEmployee.TabIndex = 2;
            // 
            // customTextBoxAddWorkHoursEnterWorkHours
            // 
            this.customTextBoxAddWorkHoursEnterWorkHours.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.customTextBoxAddWorkHoursEnterWorkHours.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.customTextBoxAddWorkHoursEnterWorkHours.BorderSize = 2;
            this.customTextBoxAddWorkHoursEnterWorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.customTextBoxAddWorkHoursEnterWorkHours.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxAddWorkHoursEnterWorkHours.Location = new System.Drawing.Point(174, 149);
            this.customTextBoxAddWorkHoursEnterWorkHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customTextBoxAddWorkHoursEnterWorkHours.Name = "customTextBoxAddWorkHoursEnterWorkHours";
            this.customTextBoxAddWorkHoursEnterWorkHours.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.customTextBoxAddWorkHoursEnterWorkHours.Size = new System.Drawing.Size(405, 31);
            this.customTextBoxAddWorkHoursEnterWorkHours.TabIndex = 3;
            this.customTextBoxAddWorkHoursEnterWorkHours.UnderlinedStyle = true;
            // 
            // lblAddWorkHoursEnterWorkHours
            // 
            this.lblAddWorkHoursEnterWorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblAddWorkHoursEnterWorkHours.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblAddWorkHoursEnterWorkHours.Location = new System.Drawing.Point(174, 126);
            this.lblAddWorkHoursEnterWorkHours.Name = "lblAddWorkHoursEnterWorkHours";
            this.lblAddWorkHoursEnterWorkHours.Size = new System.Drawing.Size(257, 28);
            this.lblAddWorkHoursEnterWorkHours.TabIndex = 4;
            this.lblAddWorkHoursEnterWorkHours.Text = "Please enter the work hours:";
            // 
            // btnAddWorkHoursSubmit
            // 
            this.btnAddWorkHoursSubmit.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.btnAddWorkHoursSubmit.FlatAppearance.BorderSize = 0;
            this.btnAddWorkHoursSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkHoursSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.btnAddWorkHoursSubmit.ForeColor = System.Drawing.Color.White;
            this.btnAddWorkHoursSubmit.Location = new System.Drawing.Point(174, 242);
            this.btnAddWorkHoursSubmit.Name = "btnAddWorkHoursSubmit";
            this.btnAddWorkHoursSubmit.Size = new System.Drawing.Size(405, 39);
            this.btnAddWorkHoursSubmit.TabIndex = 5;
            this.btnAddWorkHoursSubmit.Text = "Submit";
            this.btnAddWorkHoursSubmit.UseVisualStyleBackColor = false;
            // 
            // AddWorkHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddWorkHoursSubmit);
            this.Controls.Add(this.lblAddWorkHoursEnterWorkHours);
            this.Controls.Add(this.customTextBoxAddWorkHoursEnterWorkHours);
            this.Controls.Add(this.comboBoxAddWorkHoursSelectEmployee);
            this.Controls.Add(this.lblAddWorkHoursSelectEmployee);
            this.Controls.Add(this.pictureBoxWorkHours);
            this.Name = "AddWorkHoursForm";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxWorkHours)).EndInit();
            this.ResumeLayout(false);
        }

        private WindowsFormsApp.CustomButton.CustomButton btnAddWorkHoursSubmit;

        private System.Windows.Forms.ComboBox comboBoxAddWorkHoursSelectEmployee;
        private WindowsFormsApp.CustomTextBox customTextBoxAddWorkHoursEnterWorkHours;
        private System.Windows.Forms.Label lblAddWorkHoursEnterWorkHours;

        private System.Windows.Forms.Label lblAddWorkHoursSelectEmployee;

        private System.Windows.Forms.PictureBox pictureBoxWorkHours;

        #endregion
    }
}