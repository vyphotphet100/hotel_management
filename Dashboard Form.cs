using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hotel_Manager
{
    public partial class FormDashBoard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse,
               int x = 10
         );

        public FormDashBoard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = buttonDashboard.Height;
            pnlNav.Top = buttonDashboard.Top;
            pnlNav.Left = buttonDashboard.Left;
            buttonDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }
        public void showControl(Control control)
        {
            panelContent.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panelContent.Controls.Add(control);
        }
        private void btnDashbord_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonDashboard.Height;
            pnlNav.Top = buttonDashboard.Top;
            pnlNav.Left = buttonDashboard.Left;
            buttonDashboard.BackColor = Color.FromArgb(46, 51, 73);
            Dashboard dashboard = new Dashboard();
            showControl(dashboard);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonAnalytics.Height;
            pnlNav.Top = buttonAnalytics.Top;
            buttonAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            EmployeeList employeeList = new EmployeeList();
            showControl(employeeList);
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonSchedule.Height;
            pnlNav.Top = buttonSchedule.Top;
            buttonSchedule.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonEmployee.Height;
            pnlNav.Top = buttonEmployee.Top;
            buttonEmployee.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = buttonSettings.Height;
            pnlNav.Top = buttonSettings.Top;
            buttonSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            buttonDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            buttonAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            buttonSchedule.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            buttonEmployee.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {
            buttonSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            showControl(dashboard);
        }
    }
}
