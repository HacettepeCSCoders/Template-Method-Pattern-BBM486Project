using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp.Forms;

namespace WindowsFormsApp
{
    public partial class FormMainMenu : Form
    {
        private Form activeForm;

        //Fields
        private Button currentButton;
        private readonly Random random;
        private int tempIndex;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnMainMenuCross.Visible = false;
            Text = "BBM 486 Design Patterns Project";
        }

        //Methods
        private Color SelectThemeColor()
        {
            var index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index) index = random.Next(ThemeColor.ColorList.Count);

            tempIndex = index;
            var color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
                if (currentButton != (Button) btnSender)
                {
                    DisableButton();
                    var color = SelectThemeColor();
                    currentButton = (Button) btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point,
                        162);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnMainMenuCross.Visible = true;
                }
        }

        private void DisableButton()
        {
            foreach (Control prevBtn in panelMenu.Controls)
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = ColorTranslator.FromHtml("#273c75");
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 162);
                }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAddRecordPage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewEmployeeForm(), sender);
            lblTitle.Text = NewEmployeeForm.Title;
        }

        private void btnUpdateEmployeePage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateEmployeeForm(), sender);
            lblTitle.Text = UpdateEmployeeForm.Title;
        }

        private void btnAddWorkHoursPage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddWorkHoursForm(), sender);
            lblTitle.Text = AddWorkHoursForm.Title;
        }

        private void btnAllRecordsPage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeesForm(), sender);
            lblTitle.Text = EmployeesForm.Title;
        }

        private void btnMainMenuCross_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(25, 42, 86);
            panelLogo.BackColor = Color.FromArgb(24, 28, 60);
            DisableButton();
            btnMainMenuCross.Visible = false;
        }
    }
}