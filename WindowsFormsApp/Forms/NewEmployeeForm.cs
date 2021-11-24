using System;
using System.Windows.Forms;

namespace WindowsFormsApp.Forms
{
    public partial class NewEmployeeForm : Form
    {
        private static string _title = "NEW EMPLOYEE";

        public NewEmployeeForm()
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