using System.Windows.Forms;

namespace WindowsFormsApp.Forms
{
    public partial class EmployeesForm : Form
    {
        private static string _title = "EMPLOYEES";
        
        public EmployeesForm()
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