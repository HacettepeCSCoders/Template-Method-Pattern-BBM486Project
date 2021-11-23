namespace WindowsFormsApp
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
            this.btnAddRecordPage = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (51)))), ((int) (((byte) (76)))));
            this.panelMenu.Controls.Add(this.btnAllRecordsPage);
            this.panelMenu.Controls.Add(this.btnAddRecordPage);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 535);
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
            this.btnAllRecordsPage.Location = new System.Drawing.Point(0, 140);
            this.btnAllRecordsPage.Name = "btnAllRecordsPage";
            this.btnAllRecordsPage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAllRecordsPage.Size = new System.Drawing.Size(220, 60);
            this.btnAllRecordsPage.TabIndex = 2;
            this.btnAllRecordsPage.Text = " Employees";
            this.btnAllRecordsPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllRecordsPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllRecordsPage.UseVisualStyleBackColor = true;
            this.btnAllRecordsPage.Click += new System.EventHandler(this.btnAllRecordsPage_Click);
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
            this.btnAddRecordPage.Location = new System.Drawing.Point(0, 80);
            this.btnAddRecordPage.Name = "btnAddRecordPage";
            this.btnAddRecordPage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddRecordPage.Size = new System.Drawing.Size(220, 60);
            this.btnAddRecordPage.TabIndex = 1;
            this.btnAddRecordPage.Text = " New Employee";
            this.btnAddRecordPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRecordPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRecordPage.UseVisualStyleBackColor = true;
            this.btnAddRecordPage.Click += new System.EventHandler(this.btnAddRecordPage_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (39)))), ((int) (((byte) (39)))), ((int) (((byte) (58)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogo.Location = new System.Drawing.Point(40, 30);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(164, 38);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Payroll Project";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (150)))), ((int) (((byte) (136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(919, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(92, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(735, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(919, 455);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 535);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelDesktopPane;

        private System.Windows.Forms.Label lblLogo;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panelTitleBar;

        private System.Windows.Forms.Button btnAllRecordsPage;

        private System.Windows.Forms.Button btnAddRecordPage;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Panel panelLogo;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel panelMenu;

        #endregion
    }
}