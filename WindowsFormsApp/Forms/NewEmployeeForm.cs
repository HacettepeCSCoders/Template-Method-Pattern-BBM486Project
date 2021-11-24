using System;
using System.Windows.Forms;

namespace WindowsFormsApp.Forms
{
    public partial class NewEmployeeForm : Form
    {
        private static string _title = "New Employee";

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