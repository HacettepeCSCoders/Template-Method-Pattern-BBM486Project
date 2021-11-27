using System;
using System.Windows.Forms;

namespace WindowsFormsApp.Forms
{
    public partial class UpdateEmployeeForm : Form
    {
        private static string _title = "UPDATE EMPLOYEE";
        public UpdateEmployeeForm()
        {
            InitializeComponent();
        }

        public static string Title
        {
            get => _title;
            set => _title = value;
        }
    }
}