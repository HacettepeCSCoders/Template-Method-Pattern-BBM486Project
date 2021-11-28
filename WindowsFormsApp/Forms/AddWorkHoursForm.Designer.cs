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
            this.lblAddWorkHoursEnterWorkHours = new System.Windows.Forms.Label();
            this.btnAddWorkHoursSubmit = new WindowsFormsApp.CustomButton.CustomButton();
            this.comboBoxSelectRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxWorkHours)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWorkHours
            // 
            this.pictureBoxWorkHours.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxWorkHours.Image")));
            this.pictureBoxWorkHours.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxWorkHours.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxWorkHours.Name = "pictureBoxWorkHours";
            this.pictureBoxWorkHours.Size = new System.Drawing.Size(104, 108);
            this.pictureBoxWorkHours.TabIndex = 0;
            this.pictureBoxWorkHours.TabStop = false;
            // 
            // lblAddWorkHoursSelectEmployee
            // 
            this.lblAddWorkHoursSelectEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblAddWorkHoursSelectEmployee.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblAddWorkHoursSelectEmployee.Location = new System.Drawing.Point(160, 123);
            this.lblAddWorkHoursSelectEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddWorkHoursSelectEmployee.Name = "lblAddWorkHoursSelectEmployee";
            this.lblAddWorkHoursSelectEmployee.Size = new System.Drawing.Size(193, 23);
            this.lblAddWorkHoursSelectEmployee.TabIndex = 1;
            this.lblAddWorkHoursSelectEmployee.Text = "Please select the employee:";
            // 
            // comboBoxAddWorkHoursSelectEmployee
            // 
            this.comboBoxAddWorkHoursSelectEmployee.FormattingEnabled = true;
            this.comboBoxAddWorkHoursSelectEmployee.Location = new System.Drawing.Point(160, 148);
            this.comboBoxAddWorkHoursSelectEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAddWorkHoursSelectEmployee.Name = "comboBoxAddWorkHoursSelectEmployee";
            this.comboBoxAddWorkHoursSelectEmployee.Size = new System.Drawing.Size(305, 21);
            this.comboBoxAddWorkHoursSelectEmployee.TabIndex = 2;
            // 
            // lblAddWorkHoursEnterWorkHours
            // 
            this.lblAddWorkHoursEnterWorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblAddWorkHoursEnterWorkHours.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblAddWorkHoursEnterWorkHours.Location = new System.Drawing.Point(161, 221);
            this.lblAddWorkHoursEnterWorkHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddWorkHoursEnterWorkHours.Name = "lblAddWorkHoursEnterWorkHours";
            this.lblAddWorkHoursEnterWorkHours.Size = new System.Drawing.Size(193, 23);
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
            this.btnAddWorkHoursSubmit.Location = new System.Drawing.Point(160, 263);
            this.btnAddWorkHoursSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddWorkHoursSubmit.Name = "btnAddWorkHoursSubmit";
            this.btnAddWorkHoursSubmit.Size = new System.Drawing.Size(305, 32);
            this.btnAddWorkHoursSubmit.TabIndex = 5;
            this.btnAddWorkHoursSubmit.Text = "Submit";
            this.btnAddWorkHoursSubmit.UseVisualStyleBackColor = false;
            this.btnAddWorkHoursSubmit.Click += new System.EventHandler(this.btnAddWorkHoursSubmit_Click);
            // 
            // comboBoxSelectRole
            // 
            this.comboBoxSelectRole.FormattingEnabled = true;
            this.comboBoxSelectRole.Location = new System.Drawing.Point(160, 72);
            this.comboBoxSelectRole.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSelectRole.Name = "comboBoxSelectRole";
            this.comboBoxSelectRole.Size = new System.Drawing.Size(305, 21);
            this.comboBoxSelectRole.TabIndex = 7;
            this.comboBoxSelectRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.label1.Location = new System.Drawing.Point(160, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please select the role of employee:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(359, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 8;
            // 
            // AddWorkHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxSelectRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddWorkHoursSubmit);
            this.Controls.Add(this.lblAddWorkHoursEnterWorkHours);
            this.Controls.Add(this.comboBoxAddWorkHoursSelectEmployee);
            this.Controls.Add(this.lblAddWorkHoursSelectEmployee);
            this.Controls.Add(this.pictureBoxWorkHours);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddWorkHoursForm";
            this.Load += new System.EventHandler(this.AddWorkHoursForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxWorkHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ComboBox comboBoxSelectRole;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;

        private WindowsFormsApp.CustomButton.CustomButton btnAddWorkHoursSubmit;

        private System.Windows.Forms.ComboBox comboBoxAddWorkHoursSelectEmployee;
        private System.Windows.Forms.Label lblAddWorkHoursEnterWorkHours;

        private System.Windows.Forms.Label lblAddWorkHoursSelectEmployee;

        private System.Windows.Forms.PictureBox pictureBoxWorkHours;

        #endregion
    }
}