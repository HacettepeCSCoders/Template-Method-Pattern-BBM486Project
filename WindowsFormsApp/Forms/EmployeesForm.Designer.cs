using System.ComponentModel;

namespace WindowsFormsApp.Forms
{
    partial class EmployeesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.lblTotalEmployees = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.AllowUserToOrderColumns = true;
            this.dataGridEmployees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmployees.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataGridEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridEmployees.Size = new System.Drawing.Size(1124, 390);
            this.dataGridEmployees.TabIndex = 0;
            this.dataGridEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployees_CellContentClick);
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblTotalEmployees.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblTotalEmployees.Location = new System.Drawing.Point(0, 390);
            this.lblTotalEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            this.lblTotalEmployees.Size = new System.Drawing.Size(1124, 57);
            this.lblTotalEmployees.TabIndex = 1;
            this.lblTotalEmployees.Text = "Total Number of Employees: ";
            this.lblTotalEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 606);
            this.Controls.Add(this.lblTotalEmployees);
            this.Controls.Add(this.dataGridEmployees);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridEmployees)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTotalEmployees;
        
        private System.Windows.Forms.DataGridView dataGridEmployees;
        
        #endregion
    }
}