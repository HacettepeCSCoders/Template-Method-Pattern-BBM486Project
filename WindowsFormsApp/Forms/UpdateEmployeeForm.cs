using System;
using System.Collections;
using System.Windows.Forms;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Service.Concrete;
using Service.Concrete.Managers;

namespace WindowsFormsApp.Forms
{
    public partial class UpdateEmployeeForm : Form
    {
        private static string _title = "UPDATE EMPLOYEE";

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

        public UpdateEmployeeForm()
        {
            InitializeComponent();
        }

        public static string Title
        {
            get => _title;
            set => _title = value;
        }

        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {
            comboBoxUpdateSelectRole.SelectedIndex = -1;
            ArrayList arr1 = new ArrayList();
            foreach (var var1 in _efPositionDal.GetAll())
            {
                arr1.Add(var1.PositionName);
            }
            comboBoxUpdateSelectRole.DataSource = arr1; 

        }

        private void comboBoxUpdateSelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdateSelectRole.Text.Equals("Intern"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _internManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Junior Software Developer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _juniorSoftwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Software Developer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _softwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Senior Software Developer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _seniorSoftwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("QA Engineer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _qaEngineerManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Test Engineer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _testEngineerManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("System Analyst"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _systemAnalystManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Project Manager"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _projectManagerManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("UI Designer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _uiDesignerManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else
            {
                comboBox1.Text = "NOT FOUND";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxUpdateSelectRole.Text.Equals("Intern"))
            {

                Intern intern1 = _internManager.GetById(Convert.ToInt32(comboBox1.Text.Split('-')[0]));
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    intern1.FirstName = textBox1.Text;
                }

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    intern1.LastName = textBox3.Text;
                }

                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    intern1.EmailAddress = textBox2.Text;
                }

                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    intern1.Phone = Convert.ToInt64(textBox4.Text);
                }
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    intern1.Address = textBox7.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    intern1.WorkSituation = textBox4.Text;
                }
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    intern1.MentorId = Convert.ToInt32(textBox6.Text);
                }
                
                _internManager.Update(intern1);
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Junior Software Developer"))
            {
                JuniorSoftwareDeveloper intern1 =
                    _juniorSoftwareDeveloperManager.GetById(Convert.ToInt32(comboBox1.Text.Split('-')[0]));
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    intern1.FirstName = textBox1.Text;
                }

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    intern1.LastName = textBox3.Text;
                }

                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    intern1.EmailAddress = textBox2.Text;
                }

                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    intern1.Phone = Convert.ToInt64(textBox4.Text);
                }
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    intern1.Address = textBox7.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    intern1.WorkSituation = textBox4.Text;
                }
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    intern1.SeniorId = Convert.ToInt32(textBox6.Text);
                }
                _juniorSoftwareDeveloperManager.Update(intern1);
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Software Developer"))
            {
                SoftwareDeveloper intern1 =
                    _softwareDeveloperManager.GetById(Convert.ToInt32(comboBox1.Text.Split('-')[0]));
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    intern1.FirstName = textBox1.Text;
                }

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    intern1.LastName = textBox3.Text;
                }

                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    intern1.EmailAddress = textBox2.Text;
                }

                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    intern1.Phone = Convert.ToInt64(textBox4.Text);
                }
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    intern1.Address = textBox7.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    intern1.WorkSituation = textBox4.Text;
                }
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    intern1.SeniorId = Convert.ToInt32(textBox6.Text);
                }

                _softwareDeveloperManager.Update(intern1);
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Senior Software Developer"))
            {
                SeniorSoftwareDeveloper intern1 = _seniorSoftwareDeveloperManager.GetById(Convert.ToInt32(comboBox1.Text.Split('-')[0]));
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    intern1.FirstName = textBox1.Text;
                }

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    intern1.LastName = textBox3.Text;
                }

                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    intern1.EmailAddress = textBox2.Text;
                }

                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    intern1.Phone = Convert.ToInt64(textBox4.Text);
                }
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    intern1.Address = textBox7.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    intern1.WorkSituation = textBox4.Text;
                }
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    intern1.ManagerId = Convert.ToInt32(textBox6.Text);
                }
                _seniorSoftwareDeveloperManager.Update(intern1);
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("QA Engineer"))
            {
                QAEngineer intern1 = _qaEngineerManager.GetById(Convert.ToInt32(comboBox1.Text.Split('-')[0]));
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    intern1.FirstName = textBox1.Text;
                }

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    intern1.LastName = textBox3.Text;
                }

                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    intern1.EmailAddress = textBox2.Text;
                }

                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    intern1.Phone = Convert.ToInt64(textBox4.Text);
                }
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    intern1.Address = textBox7.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    intern1.WorkSituation = textBox4.Text;
                }
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    intern1.ManagerId = Convert.ToInt32(textBox6.Text);
                }
                _qaEngineerManager.Update(intern1);
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Test Engineer"))
            {
                TestEngineer intern1 = _testEngineerManager.GetById(Convert.ToInt32(comboBox1.Text.Split('-')[0]));
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    intern1.FirstName = textBox1.Text;
                }

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    intern1.LastName = textBox3.Text;
                }

                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    intern1.EmailAddress = textBox2.Text;
                }

                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    intern1.Phone = Convert.ToInt64(textBox4.Text);
                }
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    intern1.Address = textBox7.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    intern1.WorkSituation = textBox4.Text;
                }
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    intern1.ManagerId = Convert.ToInt32(textBox6.Text);
                }

                _testEngineerManager.Update(intern1);
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("System Analyst"))
            {
                SystemAnalyst intern1 = _systemAnalystManager.GetById(Convert.ToInt32(comboBox1.Text.Split('-')[0]));
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    intern1.FirstName = textBox1.Text;
                }

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    intern1.LastName = textBox3.Text;
                }

                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    intern1.EmailAddress = textBox2.Text;
                }

                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    intern1.Phone = Convert.ToInt64(textBox4.Text);
                }
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    intern1.Address = textBox7.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    intern1.WorkSituation = textBox4.Text;
                }
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    intern1.ManagerId = Convert.ToInt32(textBox6.Text);
                }
                _systemAnalystManager.Update(intern1);
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Project Manager"))
            {
                ProjectManager intern1 = _projectManagerManager.GetById(Convert.ToInt32(comboBox1.Text.Split('-')[0]));
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    intern1.FirstName = textBox1.Text;
                }

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    intern1.LastName = textBox3.Text;
                }

                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    intern1.EmailAddress = textBox2.Text;
                }

                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    intern1.Phone = Convert.ToInt64(textBox4.Text);
                }
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    intern1.Address = textBox7.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    intern1.WorkSituation = textBox4.Text;
                }

                _projectManagerManager.Update(intern1);
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("UI Designer"))
            {
                UIDesigner intern1 = _uiDesignerManager.GetById(Convert.ToInt32(comboBox1.Text.Split('-')[0]));
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    intern1.FirstName = textBox1.Text;
                }

                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    intern1.LastName = textBox3.Text;
                }

                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    intern1.EmailAddress = textBox2.Text;
                }

                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    intern1.Phone = Convert.ToInt64(textBox4.Text);
                }
                if (!string.IsNullOrEmpty(textBox7.Text))
                {
                    intern1.Address = textBox7.Text;
                }
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    intern1.WorkSituation = textBox4.Text;
                }
                if (!string.IsNullOrEmpty(textBox6.Text))
                {
                    intern1.ManagerId = Convert.ToInt32(textBox6.Text);
                }
                _uiDesignerManager.Update(intern1);
            }
            else
            {
                comboBox1.Text = "NOT FOUND";
            }
            if (comboBoxUpdateSelectRole.Text.Equals("Intern"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _internManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Junior Software Developer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _juniorSoftwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Software Developer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _softwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Senior Software Developer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _seniorSoftwareDeveloperManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("QA Engineer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _qaEngineerManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Test Engineer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _testEngineerManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("System Analyst"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _systemAnalystManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("Project Manager"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _projectManagerManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else if (comboBoxUpdateSelectRole.Text.Equals("UI Designer"))
            {
                ArrayList arr1 = new ArrayList();

                foreach (var var1 in _uiDesignerManager.GetAll())
                {
                    arr1.Add(var1.Id + "- " + var1.FirstName + " " + var1.LastName);
                }

                comboBox1.DataSource = arr1;
            }
            else
            {
                comboBox1.Text = "NOT FOUND";
            }
            MessageBox.Show("Employee UPDATED !");
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }
    }
}
