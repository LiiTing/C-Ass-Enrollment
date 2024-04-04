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
    public partial class LogInForm : Form
    {
        //Global Variable
        public static string username = "";
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Admin")
            {
                if (txtpassword.Text == "AUB123!@#")
                {
                    MessageBox.Show("Successful !");
                    Emrollform main = new Emrollform();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Password is Incorrect !");
                }
            }
            else
            {
                MessageBox.Show("Username is Invalid !");
            }
        }
    }
}

