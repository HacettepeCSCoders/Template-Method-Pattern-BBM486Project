using System;
using System.Collections;
using System.Linq;
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
        ArrayList arrEmp = new ArrayList()
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
            {
                //if click is on new row or header row
                if( e.RowIndex == dataGridEmployees.NewRowIndex || e.RowIndex < 0)
                    return;

                //Check if click is on specific column 
                if( e.ColumnIndex  == dataGridEmployees.Columns["dataGridViewDeleteButton"].Index)
                {
                    if (DialogResult.OK == MessageBox.Show("Are You Sure?","delete",MessageBoxButtons.OKCancel))
                    {
                        arrEmp.RemoveAt(e.RowIndex);
                        dataGridEmployees.DataSource = null;
                        dataGridEmployees.Columns.Clear();
                        dataGridEmployees.DataSource = arrEmp;
                        dataGridEmployees.Columns.Add(deleteButtonCreator());
                        
                        lblTotalEmployees.Text = $"Total Number of Employees: {dataGridEmployees.RowCount}";
                    }
                }
            }
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            
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
            
            dataGridEmployees.Columns.Add(deleteButtonCreator());
            lblTotalEmployees.Text = $"Total Number of Employees: {dataGridEmployees.RowCount}";
        }

        private DataGridViewButtonColumn deleteButtonCreator()
        {
            var deleteButton=new DataGridViewButtonColumn();
            deleteButton.Name="dataGridViewDeleteButton";
            deleteButton.HeaderText="Delete";
            deleteButton.Text="Delete";
            deleteButton.UseColumnTextForButtonValue=true;
            return deleteButton;
        } 
    }
}