using System;
using System.Collections;
using System.Windows.Forms;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Service.Concrete.Managers;

namespace WindowsFormsApp.Forms
{
    public partial class NewEmployeeForm : Form
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

        public NewEmployeeForm()
        {
            InitializeComponent();
        }

        public static string Title { get; set; } = "NEW EMPLOYEE";

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            var arr1 = new ArrayList();
            foreach (var var1 in _efPositionDal.GetAll()) arr1.Add(var1.PositionName);
            comboBox1.DataSource = arr1;
        }

        private void btnNewEmployeeSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)
                || string.IsNullOrEmpty(textBox2.Text)
                || string.IsNullOrEmpty(textBox3.Text)
                || string.IsNullOrEmpty(textBox4.Text)
                || string.IsNullOrEmpty(textBox5.Text)
                || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("YOU MUST FILL ALL THE FIELDS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (comboBox1.Text.Equals("Intern"))
                {
                    var intern = new Intern
                    {
                        FirstName = textBox1.Text, LastName = textBox2.Text, EmailAddress = textBox3.Text,
                        Phone = Convert.ToInt64(textBox4.Text), Address = textBox5.Text, WorkSituation = textBox6.Text,
                        StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(1)
                    };
                    _internManager.Add(intern);
                }
                else if (comboBox1.Text.Equals("Junior Software Developer"))
                {
                    var intern = new JuniorSoftwareDeveloper
                    {
                        FirstName = textBox1.Text, LastName = textBox2.Text, EmailAddress = textBox3.Text,
                        Phone = Convert.ToInt64(textBox4.Text), Address = textBox5.Text, WorkSituation = textBox6.Text,
                        StartDate = DateTime.Now
                    };
                    _juniorSoftwareDeveloperManager.Add(intern);
                }
                else if (comboBox1.Text.Equals("Software Developer"))
                {
                    var intern = new SoftwareDeveloper
                    {
                        FirstName = textBox1.Text, LastName = textBox2.Text, EmailAddress = textBox3.Text,
                        Phone = Convert.ToInt64(textBox4.Text), Address = textBox5.Text, WorkSituation = textBox6.Text,
                        StartDate = DateTime.Now
                    };
                    _softwareDeveloperManager.Add(intern);
                }
                else if (comboBox1.Text.Equals("Senior Software Developer"))
                {
                    var intern = new SeniorSoftwareDeveloper
                    {
                        FirstName = textBox1.Text, LastName = textBox2.Text, EmailAddress = textBox3.Text,
                        Phone = Convert.ToInt64(textBox4.Text), Address = textBox5.Text, WorkSituation = textBox6.Text,
                        StartDate = DateTime.Now
                    };
                    _seniorSoftwareDeveloperManager.Add(intern);
                }
                else if (comboBox1.Text.Equals("QA Engineer"))
                {
                    var intern = new QAEngineer
                    {
                        FirstName = textBox1.Text, LastName = textBox2.Text, EmailAddress = textBox3.Text,
                        Phone = Convert.ToInt64(textBox4.Text), Address = textBox5.Text, WorkSituation = textBox6.Text,
                        StartDate = DateTime.Now
                    };
                    _qaEngineerManager.Add(intern);
                }
                else if (comboBox1.Text.Equals("Test Engineer"))
                {
                    var intern = new TestEngineer
                    {
                        FirstName = textBox1.Text, LastName = textBox2.Text, EmailAddress = textBox3.Text,
                        Phone = Convert.ToInt64(textBox4.Text), Address = textBox5.Text, WorkSituation = textBox6.Text,
                        StartDate = DateTime.Now
                    };
                    _testEngineerManager.Add(intern);
                }
                else if (comboBox1.Text.Equals("System Analyst"))
                {
                    var intern = new SystemAnalyst
                    {
                        FirstName = textBox1.Text, LastName = textBox2.Text, EmailAddress = textBox3.Text,
                        Phone = Convert.ToInt64(textBox4.Text), Address = textBox5.Text, WorkSituation = textBox6.Text,
                        StartDate = DateTime.Now
                    };
                    _systemAnalystManager.Add(intern);
                }
                else if (comboBox1.Text.Equals("Project Manager"))
                {
                    var intern = new ProjectManager
                    {
                        FirstName = textBox1.Text, LastName = textBox2.Text, EmailAddress = textBox3.Text,
                        Phone = Convert.ToInt64(textBox4.Text), Address = textBox5.Text, WorkSituation = textBox6.Text,
                        StartDate = DateTime.Now
                    };
                    _projectManagerManager.Add(intern);
                }
                else if (comboBox1.Text.Equals("UI Designer"))
                {
                    var intern = new UIDesigner
                    {
                        FirstName = textBox1.Text, LastName = textBox2.Text, EmailAddress = textBox3.Text,
                        Phone = Convert.ToInt64(textBox4.Text), Address = textBox5.Text, WorkSituation = textBox6.Text,
                        StartDate = DateTime.Now
                    };
                    _uiDesignerManager.Add(intern);
                }

                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
                comboBox1.SelectedIndex = -1;
                MessageBox.Show("EMPLOYEE ADDED !", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}