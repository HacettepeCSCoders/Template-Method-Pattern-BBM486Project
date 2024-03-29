﻿namespace WindowsFormsApp
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAllRecordsPage = new System.Windows.Forms.Button();
            this.btnAddWorkHoursPage = new System.Windows.Forms.Button();
            this.btnUpdateEmployeePage = new System.Windows.Forms.Button();
            this.btnAddRecordPage = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMainMenuCross = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMainMenuFillRightBottom = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.panelMainMenuFillRightBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (39)))), ((int) (((byte) (60)))), ((int) (((byte) (117)))));
            this.panelMenu.Controls.Add(this.btnAllRecordsPage);
            this.panelMenu.Controls.Add(this.btnAddWorkHoursPage);
            this.panelMenu.Controls.Add(this.btnUpdateEmployeePage);
            this.panelMenu.Controls.Add(this.btnAddRecordPage);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(176, 435);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAllRecordsPage
            // 
            this.btnAllRecordsPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllRecordsPage.FlatAppearance.BorderSize = 0;
            this.btnAllRecordsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRecordsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.btnAllRecordsPage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAllRecordsPage.Image = ((System.Drawing.Image) (resources.GetObject("btnAllRecordsPage.Image")));
            this.btnAllRecordsPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllRecordsPage.Location = new System.Drawing.Point(0, 163);
            this.btnAllRecordsPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllRecordsPage.Name = "btnAllRecordsPage";
            this.btnAllRecordsPage.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAllRecordsPage.Size = new System.Drawing.Size(176, 49);
            this.btnAllRecordsPage.TabIndex = 3;
            this.btnAllRecordsPage.Text = "Show/Delete Employees";
            this.btnAllRecordsPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllRecordsPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllRecordsPage.UseVisualStyleBackColor = true;
            this.btnAllRecordsPage.Click += new System.EventHandler(this.btnAllRecordsPage_Click);
            // 
            // btnAddWorkHoursPage
            // 
            this.btnAddWorkHoursPage.FlatAppearance.BorderSize = 0;
            this.btnAddWorkHoursPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkHoursPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.btnAddWorkHoursPage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddWorkHoursPage.Image = ((System.Drawing.Image) (resources.GetObject("btnAddWorkHoursPage.Image")));
            this.btnAddWorkHoursPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWorkHoursPage.Location = new System.Drawing.Point(0, 216);
            this.btnAddWorkHoursPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddWorkHoursPage.Name = "btnAddWorkHoursPage";
            this.btnAddWorkHoursPage.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAddWorkHoursPage.Size = new System.Drawing.Size(176, 49);
            this.btnAddWorkHoursPage.TabIndex = 4;
            this.btnAddWorkHoursPage.Text = " Work Hours";
            this.btnAddWorkHoursPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWorkHoursPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddWorkHoursPage.UseVisualStyleBackColor = true;
            this.btnAddWorkHoursPage.Click += new System.EventHandler(this.btnAddWorkHoursPage_Click);
            // 
            // btnUpdateEmployeePage
            // 
            this.btnUpdateEmployeePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateEmployeePage.FlatAppearance.BorderSize = 0;
            this.btnUpdateEmployeePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmployeePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.btnUpdateEmployeePage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateEmployeePage.Image = ((System.Drawing.Image) (resources.GetObject("btnUpdateEmployeePage.Image")));
            this.btnUpdateEmployeePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployeePage.Location = new System.Drawing.Point(0, 114);
            this.btnUpdateEmployeePage.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateEmployeePage.Name = "btnUpdateEmployeePage";
            this.btnUpdateEmployeePage.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnUpdateEmployeePage.Size = new System.Drawing.Size(176, 49);
            this.btnUpdateEmployeePage.TabIndex = 2;
            this.btnUpdateEmployeePage.Text = " Update Employee";
            this.btnUpdateEmployeePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployeePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateEmployeePage.UseVisualStyleBackColor = true;
            this.btnUpdateEmployeePage.Click += new System.EventHandler(this.btnUpdateEmployeePage_Click);
            // 
            // btnAddRecordPage
            // 
            this.btnAddRecordPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRecordPage.FlatAppearance.BorderSize = 0;
            this.btnAddRecordPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecordPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.btnAddRecordPage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddRecordPage.Image = ((System.Drawing.Image) (resources.GetObject("btnAddRecordPage.Image")));
            this.btnAddRecordPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRecordPage.Location = new System.Drawing.Point(0, 65);
            this.btnAddRecordPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRecordPage.Name = "btnAddRecordPage";
            this.btnAddRecordPage.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAddRecordPage.Size = new System.Drawing.Size(176, 49);
            this.btnAddRecordPage.TabIndex = 1;
            this.btnAddRecordPage.Text = " New Employee";
            this.btnAddRecordPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRecordPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRecordPage.UseVisualStyleBackColor = true;
            this.btnAddRecordPage.Click += new System.EventHandler(this.btnAddRecordPage_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (24)))), ((int) (((byte) (28)))), ((int) (((byte) (60)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(176, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (24)))), ((int) (((byte) (28)))), ((int) (((byte) (60)))));
            this.lblLogo.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogo.Location = new System.Drawing.Point(30, 24);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(123, 31);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Payroll Project";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.panelTitleBar.Controls.Add(this.btnMainMenuCross);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(176, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(678, 65);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnMainMenuCross
            // 
            this.btnMainMenuCross.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMainMenuCross.FlatAppearance.BorderSize = 0;
            this.btnMainMenuCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenuCross.Image = ((System.Drawing.Image) (resources.GetObject("btnMainMenuCross.Image")));
            this.btnMainMenuCross.Location = new System.Drawing.Point(0, 0);
            this.btnMainMenuCross.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenuCross.Name = "btnMainMenuCross";
            this.btnMainMenuCross.Size = new System.Drawing.Size(64, 65);
            this.btnMainMenuCross.TabIndex = 1;
            this.btnMainMenuCross.UseVisualStyleBackColor = true;
            this.btnMainMenuCross.Click += new System.EventHandler(this.btnMainMenuCross_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (42)))), ((int) (((byte) (86)))));
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(64, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(551, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.panelMainMenuFillRightBottom);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(176, 65);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(678, 370);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // panelMainMenuFillRightBottom
            // 
            this.panelMainMenuFillRightBottom.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (17)))), ((int) (((byte) (17)))), ((int) (((byte) (45)))));
            this.panelMainMenuFillRightBottom.Controls.Add(this.pictureBox1);
            this.panelMainMenuFillRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenuFillRightBottom.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenuFillRightBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelMainMenuFillRightBottom.Name = "panelMainMenuFillRightBottom";
            this.panelMainMenuFillRightBottom.Size = new System.Drawing.Size(678, 370);
            this.panelMainMenuFillRightBottom.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 299);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 435);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.panelMainMenuFillRightBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAllRecordsPage;

        private System.Windows.Forms.Button btnAddWorkHoursPage;

        private System.Windows.Forms.Button btnUpdateEmployeePage;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.PictureBox pictureBox1;
        
        private System.Windows.Forms.Panel panelMainMenuFillRightBottom;

        private System.Windows.Forms.Button btnMainMenuCross;

        private System.Windows.Forms.Panel panelDesktopPane;

        private System.Windows.Forms.Label lblLogo;

        private System.Windows.Forms.Label lblTitle;
        
        private System.Windows.Forms.Panel panelTitleBar;

        private System.Windows.Forms.Button btnAddRecordPage;
        
        private System.Windows.Forms.Panel panelLogo;

        private System.Windows.Forms.Panel panelMenu;

        #endregion
    }
}