using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Service.Concrete;
using Service.Concrete.Managers;

namespace WindowsFormsApp.Forms
{
    public partial class EmployeesForm : Form
    {

        InternManager _internManager = new InternManager(new EfInternDal());

        JuniorSoftwareDeveloperManager _juniorSoftwareDeveloperManager =
            new JuniorSoftwareDeveloperManager(new EfJuniorSoftwareDeveloperDal());

        ProjectManagerManager _projectManagerManager = new ProjectManagerManager(new EfProjectManagerDal());
        QAEngineerManager _qaEngineerManager = new QAEngineerManager(new EfQAEngineerDal());

        SeniorSoftwareDeveloperManager _seniorSoftwareDeveloperManager =
            new SeniorSoftwareDeveloperManager(new EfSeniorSoftwareDeveloperDal());

        SoftwareDeveloperManager _softwareDeveloperManager = new SoftwareDeveloperManager(new EfSoftwareDeveloperDal());
        SystemAnalystManager _systemAnalystManager = new SystemAnalystManager(new EfSystemAnalystDal());
        TestEngineerManager _testEngineerManager = new TestEngineerManager(new EfTestEngineerDal());
        UIDesignerManager _uiDesignerManager = new UIDesignerManager(new EfUIDesignerDal());
        private EfPositionDal _efPositionDal = new EfPositionDal();


        private static string _title = "SHOW / DELETE EMPLOYEES";

        public EmployeesForm()
        {
            InitializeComponent();
        }

        ArrayList arr1 = new ArrayList();

        public static string Title
        {
            get => _title;
            set => _title = value;
        }


        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            ArrayList arr2 = new ArrayList();
            foreach (var var1 in _efPositionDal.GetAll())
            {
                arr2.Add(var1.PositionName);
            }

            comboBox1.DataSource = arr2;

            var height = 40;
            foreach (DataGridViewRow row in dataGridEmployees.Rows)
            {
                if (row.Visible)
                    height += row.Height;
            }

            if (height > 317)
                height = 317;
            dataGridEmployees.Height = height;
            lblTotalEmployees.Text = $"Total Number of Employees: {dataGridEmployees.RowCount}";
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Intern"))
            {                
                ArrayList arr1 = new ArrayList();

                foreach (Intern var1 in _internManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Junior Software Developer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (JuniorSoftwareDeveloper var1 in _juniorSoftwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Software Developer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (SoftwareDeveloper var1 in _softwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Senior Software Developer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (SeniorSoftwareDeveloper var1 in _seniorSoftwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("QA Engineer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (QAEngineer var1 in _qaEngineerManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Test Engineer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (TestEngineer var1 in _testEngineerManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("System Analyst"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (SystemAnalyst var1 in _systemAnalystManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Project Manager"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (ProjectManager var1 in _projectManagerManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("UI Designer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (UIDesigner var1 in _uiDesignerManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else
            {
                dataGridEmployees.Text = "NOT FOUND";
            }
            lblTotalEmployees.Text = $"Total Number of Employees: {dataGridEmployees.RowCount}";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("ENTER A VALID ID!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                 int id = Convert.ToInt32(textBox1.Text);
            
            try
            {
                if (comboBox1.Text.Equals("Intern"))
                {
                    var internToDelete = _internManager.GetById(id);
                    _internManager.Delete(internToDelete);
                }
                else if (comboBox1.Text.Equals("Junior Software Developer"))
                {
                    var internToDelete = _juniorSoftwareDeveloperManager.GetById(id);
                    _juniorSoftwareDeveloperManager.Delete(internToDelete);
                }
                else if (comboBox1.Text.Equals("Software Developer"))
                {
                    var internToDelete = _softwareDeveloperManager.GetById(id);
                    _softwareDeveloperManager.Delete(internToDelete);
                }
                else if (comboBox1.Text.Equals("Senior Software Developer"))
                {
                    var internToDelete = _seniorSoftwareDeveloperManager.GetById(id);
                    _seniorSoftwareDeveloperManager.Delete(internToDelete);
                }
                else if (comboBox1.Text.Equals("Project Manager"))
                {
                    var internToDelete = _projectManagerManager.GetById(id);
                    _projectManagerManager.Delete(internToDelete);
                }
                else if (comboBox1.Text.Equals("Test Engineer"))
                {
                    var internToDelete = _testEngineerManager.GetById(id);
                    _testEngineerManager.Delete(internToDelete);
                }
                else if (comboBox1.Text.Equals("QA Engineer"))
                {
                    var internToDelete = _qaEngineerManager.GetById(id);
                    _qaEngineerManager.Delete(internToDelete);
                }
                else if (comboBox1.Text.Equals("System Analyst"))
                {
                    var internToDelete = _systemAnalystManager.GetById(id);
                    _systemAnalystManager.Delete(internToDelete);
                }
                else if (comboBox1.Text.Equals("UI Designer"))
                {
                    var internToDelete = _uiDesignerManager.GetById(id);
                    _uiDesignerManager.Delete(internToDelete);
                }

                MessageBox.Show("Employee DELETED !");
                textBox1.Text = String.Empty;
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERROR","DELETION ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                 if (comboBox1.Text.Equals("Intern"))
            {                
                ArrayList arr1 = new ArrayList();

                foreach (Intern var1 in _internManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Junior Software Developer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (JuniorSoftwareDeveloper var1 in _juniorSoftwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Software Developer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (SoftwareDeveloper var1 in _softwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Senior Software Developer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (SeniorSoftwareDeveloper var1 in _seniorSoftwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("QA Engineer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (QAEngineer var1 in _qaEngineerManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Test Engineer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (TestEngineer var1 in _testEngineerManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("System Analyst"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (SystemAnalyst var1 in _systemAnalystManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Project Manager"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (ProjectManager var1 in _projectManagerManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("UI Designer"))
            {
                ArrayList arr1 = new ArrayList();
                foreach (UIDesigner var1 in _uiDesignerManager.GetAll())
                {
                    arr1.Add(var1);
                }

                dataGridEmployees.DataSource = arr1;
            }
            else
            {
                dataGridEmployees.Text = "NOT FOUND";
            }
            lblTotalEmployees.Text = $"Total Number of Employees: {dataGridEmployees.RowCount}";
            }
            }
        }
    }
}

