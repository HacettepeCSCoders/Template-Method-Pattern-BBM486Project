using System;
using System.Windows.Forms;

namespace WindowsFormsApp.Forms
{
    public partial class AddWorkHoursForm : Form
    { 
        private static string _title = "WORK HOURS";

        public static string Title
        {
            get => _title;
            set => _title = value;
        }

        public AddWorkHoursForm()
        {
            InitializeComponent();
        }

        private void lblAddWorkHours_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}