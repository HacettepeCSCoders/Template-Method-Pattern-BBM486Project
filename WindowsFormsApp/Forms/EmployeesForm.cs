using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Service.Concrete;

namespace WindowsFormsApp.Forms
{
    public partial class EmployeesForm : Form
    {
        
        InternManager _internManager = new InternManager(new EfInternDal());
        JuniorSoftwareDeveloperManager _juniorSoftwareDeveloperManager = new JuniorSoftwareDeveloperManager(new EfJuniorSoftwareDeveloperDal());
        ProjectManagerManager _projectManager = new ProjectManagerManager(new EfProjectManagerDal());
        QAEngineerManager _qaEngineerManager = new QAEngineerManager(new EfQAEngineerDal());
        SeniorSoftwareDeveloperManager _seniorSoftwareDeveloperManager = new SeniorSoftwareDeveloperManager(new EfSeniorSoftwareDeveloperDal());
        SoftwareDeveloperManager _softwareDeveloperManager = new SoftwareDeveloperManager(new EfSoftwareDeveloperDal());
        SystemAnalystManager _systemAnalystManager = new SystemAnalystManager(new EfSystemAnalystDal());
        TestEngineerManager _testEngineerManager = new TestEngineerManager(new EfTestEngineerDal());
        UIDesignerManager _uiDesignerManager = new UIDesignerManager(new EfUIDesignerDal());
        
        
        private static string _title = "EMPLOYEES";


        public ArrayList getAllEmployee()
        {
            ArrayList arrEmp = new ArrayList();
            ArrayList emps = new ArrayList();

            arrEmp.AddRange(_projectManager.GetAll());
            // arrEmp.AddRange(_qaEngineerManager.GetAll());
            // arrEmp.AddRange(_uiDesignerManager.GetAll());
            // arrEmp.AddRange(_testEngineerManager.GetAll());
            // arrEmp.AddRange(_systemAnalystManager.GetAll());
            // arrEmp.AddRange(_seniorSoftwareDeveloperManager.GetAll());
            // arrEmp.AddRange(_seniorSoftwareDeveloperManager.GetAll());
            // arrEmp.AddRange(_softwareDeveloperManager.GetAll());
            // arrEmp.AddRange(_juniorSoftwareDeveloperManager.GetAll());
            // arrEmp.AddRange(_internManager.GetAll());
            return arrEmp;
        }
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
            {
                //if click is on new row or header row
                if( e.RowIndex == dataGridEmployees.NewRowIndex || e.RowIndex < 0)
                    return;

                //Check if click is on specific column 
                if( e.ColumnIndex  == dataGridEmployees.Columns["dataGridViewDeleteButton"].Index)
                {
                    if (DialogResult.OK == MessageBox.Show("Are You Sure?","delete",MessageBoxButtons.OKCancel))
                    {
                        getAllEmployee().RemoveAt(e.RowIndex);
                        dataGridEmployees.DataSource = null;
                        dataGridEmployees.Columns.Clear();
                        dataGridEmployees.DataSource = getAllEmployee();
                        dataGridEmployees.Columns.Add(deleteButtonCreator());
                        
                        lblTotalEmployees.Text = $"Total Number of Employees: {dataGridEmployees.RowCount}";
                    }
                }
            }
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            
            dataGridEmployees.DataSource = getAllEmployee();
            
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