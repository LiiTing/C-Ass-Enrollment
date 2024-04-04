using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Ass_Enrollment
{
    public partial class Emrollform : Form
    {
        //Global variable
        //GLobal variable
        bool btnstatus = true;
        public static Form activeform = null;
        public Emrollform()
        {
            InitializeComponent();
        }
      /* private void OpenForm(Form form)
        {
            if (activeform != null)
                activeform.Close();
            activeform = form;
            activeform.TopLevel = false;
            activeform.Dock = DockStyle.Fill;
            panel5.Controls.Add(activeform);
            panel5.Tag = activeform;
            activeform.BringToFront();//protect form
            activeform.Show();//protect form
        }*/

        private void Emrollform_Load(object sender, EventArgs e)
        {

        }

      /*  private void btdashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm= new DashboardForm();
            dashboard.Show();
        }*/

        private void linklogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new DashboardForm());
        }

        private void Emrollform_Load_1(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
