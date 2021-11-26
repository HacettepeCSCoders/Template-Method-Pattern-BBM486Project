using System;
using System.Windows.Forms;

public class emp
{
    public string name { get; set; }
    public string surname { get; set; }
    public string mail { get; set; }
    public string phone { get; set; }
    public string role { get; set; }
    public emp(string name, string surname, string mail, string phone, string role)
    {
        this.name = name;
        this.surname = surname;
        this.mail = mail;
        this.phone = phone;
        this.role = role;
    }
}
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            var arrEmp = new[]
            {
                new emp("burak","daglar","burak@gmail.com","5555555555","junior"),
                new emp("uqi", "erdo*an", "uqi@outlook.com", "7777777777", "cleaner"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("alpic", "ısıldak", "alperensudagezen@gmail.com", "2222222222", "proj manager :D"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master"),
                new emp("furquark", "wolf", "furquark@gmail.com", "1111111111", "frontend master")
                
                
            };
            dataGridEmployees.DataSource = arrEmp;
            
            var height = 40;
            foreach (DataGridViewRow row in dataGridEmployees.Rows)
            {
                if(row.Visible)
                    height += row.Height;
            }
            if (height > 317)
                height = 317;
            dataGridEmployees.Height = height;
            
            
            lblTotalEmployees.Text = $"Total Number of Employees: {dataGridEmployees.RowCount}";
        }
    }
}