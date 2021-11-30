using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DataAccess.Concrete.EntityFramework;
using Service.Concrete.Managers;

namespace WindowsFormsApp.Forms
{
    public partial class AddWorkHoursForm : Form
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

        public AddWorkHoursForm()
        {
            InitializeComponent();
        }

        public static string Title { get; set; } = "WORK HOURS";


        private void comboBoxSelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectRole.Text.Equals("Intern"))
            {
                var arr1 = new ArrayList();

                foreach (var var1 in _internManager.GetAll())
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);

                comboBoxAddWorkHoursSelectEmployee.DataSource = arr1;
            }
            else if (comboBoxSelectRole.Text.Equals("Junior Software Developer"))
            {
                var arr1 = new ArrayList();

                foreach (var var1 in _juniorSoftwareDeveloperManager.GetAll())
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);

                comboBoxAddWorkHoursSelectEmployee.DataSource = arr1;
            }
            else if (comboBoxSelectRole.Text.Equals("Software Developer"))
            {
                var arr1 = new ArrayList();

                foreach (var var1 in _softwareDeveloperManager.GetAll())
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);

                comboBoxAddWorkHoursSelectEmployee.DataSource = arr1;
            }
            else if (comboBoxSelectRole.Text.Equals("Senior Software Developer"))
            {
                var arr1 = new ArrayList();

                foreach (var var1 in _seniorSoftwareDeveloperManager.GetAll())
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);

                comboBoxAddWorkHoursSelectEmployee.DataSource = arr1;
            }
            else if (comboBoxSelectRole.Text.Equals("QA Engineer"))
            {
                var arr1 = new ArrayList();

                foreach (var var1 in _qaEngineerManager.GetAll())
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);

                comboBoxAddWorkHoursSelectEmployee.DataSource = arr1;
            }
            else if (comboBoxSelectRole.Text.Equals("Test Engineer"))
            {
                var arr1 = new ArrayList();

                foreach (var var1 in _testEngineerManager.GetAll())
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);

                comboBoxAddWorkHoursSelectEmployee.DataSource = arr1;
            }
            else if (comboBoxSelectRole.Text.Equals("System Analyst"))
            {
                var arr1 = new ArrayList();

                foreach (var var1 in _systemAnalystManager.GetAll())
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);

                comboBoxAddWorkHoursSelectEmployee.DataSource = arr1;
            }
            else if (comboBoxSelectRole.Text.Equals("Project Manager"))
            {
                var arr1 = new ArrayList();

                foreach (var var1 in _projectManagerManager.GetAll())
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);

                comboBoxAddWorkHoursSelectEmployee.DataSource = arr1;
            }
            else if (comboBoxSelectRole.Text.Equals("UI Designer"))
            {
                var arr1 = new ArrayList();

                foreach (var var1 in _uiDesignerManager.GetAll())
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);

                comboBoxAddWorkHoursSelectEmployee.DataSource = arr1;
            }
            else
            {
                comboBoxAddWorkHoursSelectEmployee.Text = "NOT FOUND";
            }
        }

        private void AddWorkHoursForm_Load(object sender, EventArgs e)
        {
            comboBoxSelectRole.SelectedIndex = -1;
            var arr1 = new ArrayList();
            foreach (var var1 in _efPositionDal.GetAll()) arr1.Add(var1.PositionName);

            comboBoxSelectRole.DataSource = arr1;
        }


        private void btnAddWorkHoursSubmit_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers!");
                textBox1.Text = string.Empty;
            }

            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a number!");
            }
            else
            {
                if (comboBoxSelectRole.Text.Equals("Intern"))
                {
                    var intern1 =
                        _internManager.GetById(Convert.ToInt32(comboBoxAddWorkHoursSelectEmployee.Text.Split('-')[0]));
                    _internManager.UpdateWage(intern1, Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Intern : " + intern1.FirstName + " " + intern1.LastName + "'s new wage : " +
                                    intern1.Wage);
                }
                else if (comboBoxSelectRole.Text.Equals("Junior Software Developer"))
                {
                    var intern1 =
                        _juniorSoftwareDeveloperManager.GetById(
                            Convert.ToInt32(comboBoxAddWorkHoursSelectEmployee.Text.Split('-')[0]));
                    _juniorSoftwareDeveloperManager.UpdateWage(intern1, Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Junior Software Developer : " + intern1.FirstName + " " + intern1.LastName +
                                    "'s new wage : " + intern1.Wage);
                }
                else if (comboBoxSelectRole.Text.Equals("Software Developer"))
                {
                    var intern1 =
                        _softwareDeveloperManager.GetById(
                            Convert.ToInt32(comboBoxAddWorkHoursSelectEmployee.Text.Split('-')[0]));
                    _softwareDeveloperManager.UpdateWage(intern1, Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Software Developer : " + intern1.FirstName + " " + intern1.LastName +
                                    "'s new wage : " + intern1.Wage);
                }
                else if (comboBoxSelectRole.Text.Equals("Senior Software Developer"))
                {
                    var intern1 =
                        _seniorSoftwareDeveloperManager.GetById(
                            Convert.ToInt32(comboBoxAddWorkHoursSelectEmployee.Text.Split('-')[0]));
                    _seniorSoftwareDeveloperManager.UpdateWage(intern1, Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Senior Software Developer : " + intern1.FirstName + " " + intern1.LastName +
                                    "'s new wage : " + intern1.Wage);
                }
                else if (comboBoxSelectRole.Text.Equals("QA Engineer"))
                {
                    var intern1 =
                        _qaEngineerManager.GetById(
                            Convert.ToInt32(comboBoxAddWorkHoursSelectEmployee.Text.Split('-')[0]));
                    _qaEngineerManager.UpdateWage(intern1, Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("QA Engineer : " + intern1.FirstName + " " + intern1.LastName + "'s new wage : " +
                                    intern1.Wage);
                }
                else if (comboBoxSelectRole.Text.Equals("Test Engineer"))
                {
                    var intern1 =
                        _testEngineerManager.GetById(
                            Convert.ToInt32(comboBoxAddWorkHoursSelectEmployee.Text.Split('-')[0]));
                    _testEngineerManager.UpdateWage(intern1, Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Test Engineer : " + intern1.FirstName + " " + intern1.LastName + "'s new wage : " +
                                    intern1.Wage);
                }
                else if (comboBoxSelectRole.Text.Equals("System Analyst"))
                {
                    var intern1 =
                        _systemAnalystManager.GetById(
                            Convert.ToInt32(comboBoxAddWorkHoursSelectEmployee.Text.Split('-')[0]));
                    _systemAnalystManager.UpdateWage(intern1, Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("System Analyst : " + intern1.FirstName + " " + intern1.LastName +
                                    "'s new wage : " + intern1.Wage);
                }
                else if (comboBoxSelectRole.Text.Equals("Project Manager"))
                {
                    var intern1 =
                        _projectManagerManager.GetById(
                            Convert.ToInt32(comboBoxAddWorkHoursSelectEmployee.Text.Split('-')[0]));
                    _projectManagerManager.UpdateWage(intern1, Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Project Manager : " + intern1.FirstName + " " + intern1.LastName +
                                    "'s new wage : " + intern1.Wage);
                }
                else if (comboBoxSelectRole.Text.Equals("UI Designer"))
                {
                    var intern1 =
                        _uiDesignerManager.GetById(
                            Convert.ToInt32(comboBoxAddWorkHoursSelectEmployee.Text.Split('-')[0]));
                    _uiDesignerManager.UpdateWage(intern1, Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("UI Designer : " + intern1.FirstName + " " + intern1.LastName + "'s new wage : " +
                                    intern1.Wage);
                }

                textBox1.Text = string.Empty;
            }
        }
    }
}