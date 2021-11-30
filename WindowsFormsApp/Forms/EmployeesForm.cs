using System;
using System.Collections;
using System.Windows.Forms;
using DataAccess.Concrete.EntityFramework;
using Service.Concrete.Managers;

namespace WindowsFormsApp.Forms
{
    public partial class EmployeesForm : Form
    {
        private readonly EfPositionDal _efPositionDal = new EfPositionDal();

        private readonly InternManager _internManager = new InternManager(new EfInternDal());

        private readonly JuniorSoftwareDeveloperManager _juniorSoftwareDeveloperManager =
            new JuniorSoftwareDeveloperManager(new EfJuniorSoftwareDeveloperDal());

        private readonly ProjectManagerManager _projectManagerManager =
            new ProjectManagerManager(new EfProjectManagerDal());

        private readonly QAEngineerManager _qaEngineerManager = new QAEngineerManager(new EfQAEngineerDal());

        private readonly SeniorSoftwareDeveloperManager _seniorSoftwareDeveloperManager =
            new SeniorSoftwareDeveloperManager(new EfSeniorSoftwareDeveloperDal());

        private readonly SoftwareDeveloperManager _softwareDeveloperManager =
            new SoftwareDeveloperManager(new EfSoftwareDeveloperDal());

        private readonly SystemAnalystManager
            _systemAnalystManager = new SystemAnalystManager(new EfSystemAnalystDal());

        private readonly TestEngineerManager _testEngineerManager = new TestEngineerManager(new EfTestEngineerDal());
        private readonly UIDesignerManager _uiDesignerManager = new UIDesignerManager(new EfUIDesignerDal());

        private ArrayList arr1 = new ArrayList();

        public EmployeesForm()
        {
            InitializeComponent();
        }

        public static string Title { get; set; } = "SHOW / DELETE EMPLOYEES";


        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            var arr2 = new ArrayList();
            foreach (var var1 in _efPositionDal.GetAll()) arr2.Add(var1.PositionName);

            comboBox1.DataSource = arr2;

            var height = 40;
            foreach (DataGridViewRow row in dataGridEmployees.Rows)
                if (row.Visible)
                    height += row.Height;

            if (height > 317)
                height = 317;
            dataGridEmployees.Height = height;
            lblTotalEmployees.Text = $"Total Number of Employees: {dataGridEmployees.RowCount}";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Intern"))
            {
                var arr1 = new ArrayList();

                foreach (var var1 in _internManager.GetAll()) arr1.Add(var1);

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Junior Software Developer"))
            {
                var arr1 = new ArrayList();
                foreach (var var1 in _juniorSoftwareDeveloperManager.GetAll()) arr1.Add(var1);

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Software Developer"))
            {
                var arr1 = new ArrayList();
                foreach (var var1 in _softwareDeveloperManager.GetAll()) arr1.Add(var1);

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Senior Software Developer"))
            {
                var arr1 = new ArrayList();
                foreach (var var1 in _seniorSoftwareDeveloperManager.GetAll()) arr1.Add(var1);

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("QA Engineer"))
            {
                var arr1 = new ArrayList();
                foreach (var var1 in _qaEngineerManager.GetAll()) arr1.Add(var1);

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Test Engineer"))
            {
                var arr1 = new ArrayList();
                foreach (var var1 in _testEngineerManager.GetAll()) arr1.Add(var1);

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("System Analyst"))
            {
                var arr1 = new ArrayList();
                foreach (var var1 in _systemAnalystManager.GetAll()) arr1.Add(var1);

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("Project Manager"))
            {
                var arr1 = new ArrayList();
                foreach (var var1 in _projectManagerManager.GetAll()) arr1.Add(var1);

                dataGridEmployees.DataSource = arr1;
            }
            else if (comboBox1.Text.Equals("UI Designer"))
            {
                var arr1 = new ArrayList();
                foreach (var var1 in _uiDesignerManager.GetAll()) arr1.Add(var1);

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
                MessageBox.Show("ENTER A VALID ID!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var id = Convert.ToInt32(textBox1.Text);

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
                    textBox1.Text = string.Empty;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR", "DELETION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (comboBox1.Text.Equals("Intern"))
                    {
                        var arr1 = new ArrayList();

                        foreach (var var1 in _internManager.GetAll()) arr1.Add(var1);

                        dataGridEmployees.DataSource = arr1;
                    }
                    else if (comboBox1.Text.Equals("Junior Software Developer"))
                    {
                        var arr1 = new ArrayList();
                        foreach (var var1 in _juniorSoftwareDeveloperManager.GetAll()) arr1.Add(var1);

                        dataGridEmployees.DataSource = arr1;
                    }
                    else if (comboBox1.Text.Equals("Software Developer"))
                    {
                        var arr1 = new ArrayList();
                        foreach (var var1 in _softwareDeveloperManager.GetAll()) arr1.Add(var1);

                        dataGridEmployees.DataSource = arr1;
                    }
                    else if (comboBox1.Text.Equals("Senior Software Developer"))
                    {
                        var arr1 = new ArrayList();
                        foreach (var var1 in _seniorSoftwareDeveloperManager.GetAll()) arr1.Add(var1);

                        dataGridEmployees.DataSource = arr1;
                    }
                    else if (comboBox1.Text.Equals("QA Engineer"))
                    {
                        var arr1 = new ArrayList();
                        foreach (var var1 in _qaEngineerManager.GetAll()) arr1.Add(var1);

                        dataGridEmployees.DataSource = arr1;
                    }
                    else if (comboBox1.Text.Equals("Test Engineer"))
                    {
                        var arr1 = new ArrayList();
                        foreach (var var1 in _testEngineerManager.GetAll()) arr1.Add(var1);

                        dataGridEmployees.DataSource = arr1;
                    }
                    else if (comboBox1.Text.Equals("System Analyst"))
                    {
                        var arr1 = new ArrayList();
                        foreach (var var1 in _systemAnalystManager.GetAll()) arr1.Add(var1);

                        dataGridEmployees.DataSource = arr1;
                    }
                    else if (comboBox1.Text.Equals("Project Manager"))
                    {
                        var arr1 = new ArrayList();
                        foreach (var var1 in _projectManagerManager.GetAll()) arr1.Add(var1);

                        dataGridEmployees.DataSource = arr1;
                    }
                    else if (comboBox1.Text.Equals("UI Designer"))
                    {
                        var arr1 = new ArrayList();
                        foreach (var var1 in _uiDesignerManager.GetAll()) arr1.Add(var1);

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