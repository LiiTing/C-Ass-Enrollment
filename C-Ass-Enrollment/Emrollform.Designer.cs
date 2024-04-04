
namespace C_Ass_Enrollment
{
    partial class Emrollform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emrollform));
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MAJOR = new System.Windows.Forms.Button();
            this.STUDENT = new System.Windows.Forms.Button();
            this.EMPLOYEE = new System.Windows.Forms.Button();
            this.REPORT = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.Button();
            this.emroll = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Yellow;
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Location = new System.Drawing.Point(1, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1030, 162);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblwelcome, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1030, 162);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBox2, 3);
            this.pictureBox2.Size = new System.Drawing.Size(294, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblwelcome, 2);
            this.lblwelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblwelcome.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(303, 54);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(294, 54);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "Welcome !!!";
            this.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Controls.Add(this.MAJOR);
            this.panel7.Controls.Add(this.STUDENT);
            this.panel7.Controls.Add(this.EMPLOYEE);
            this.panel7.Controls.Add(this.REPORT);
            this.panel7.Controls.Add(this.button5);
            this.panel7.Controls.Add(this.payment);
            this.panel7.Controls.Add(this.emroll);
            this.panel7.Controls.Add(this.dashboard);
            this.panel7.Location = new System.Drawing.Point(1, 161);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(177, 425);
            this.panel7.TabIndex = 1;
            // 
            // MAJOR
            // 
            this.MAJOR.Image = ((System.Drawing.Image)(resources.GetObject("MAJOR.Image")));
            this.MAJOR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MAJOR.Location = new System.Drawing.Point(10, 180);
            this.MAJOR.Name = "MAJOR";
            this.MAJOR.Size = new System.Drawing.Size(163, 44);
            this.MAJOR.TabIndex = 7;
            this.MAJOR.Text = "MAJOR";
            this.MAJOR.UseVisualStyleBackColor = true;
            // 
            // STUDENT
            // 
            this.STUDENT.Image = ((System.Drawing.Image)(resources.GetObject("STUDENT.Image")));
            this.STUDENT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.STUDENT.Location = new System.Drawing.Point(10, 238);
            this.STUDENT.Name = "STUDENT";
            this.STUDENT.Size = new System.Drawing.Size(163, 44);
            this.STUDENT.TabIndex = 6;
            this.STUDENT.Text = "STUDENT";
            this.STUDENT.UseVisualStyleBackColor = true;
            this.STUDENT.Click += new System.EventHandler(this.button8_Click);
            // 
            // EMPLOYEE
            // 
            this.EMPLOYEE.Image = ((System.Drawing.Image)(resources.GetObject("EMPLOYEE.Image")));
            this.EMPLOYEE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EMPLOYEE.Location = new System.Drawing.Point(10, 296);
            this.EMPLOYEE.Name = "EMPLOYEE";
            this.EMPLOYEE.Size = new System.Drawing.Size(163, 44);
            this.EMPLOYEE.TabIndex = 5;
            this.EMPLOYEE.Text = "EMPLOYEE";
            this.EMPLOYEE.UseVisualStyleBackColor = true;
            // 
            // REPORT
            // 
            this.REPORT.Image = ((System.Drawing.Image)(resources.GetObject("REPORT.Image")));
            this.REPORT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.REPORT.Location = new System.Drawing.Point(10, 375);
            this.REPORT.Name = "REPORT";
            this.REPORT.Size = new System.Drawing.Size(163, 44);
            this.REPORT.TabIndex = 4;
            this.REPORT.Text = "REPORT";
            this.REPORT.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 451);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // payment
            // 
            this.payment.Image = ((System.Drawing.Image)(resources.GetObject("payment.Image")));
            this.payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payment.Location = new System.Drawing.Point(10, 122);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(163, 44);
            this.payment.TabIndex = 2;
            this.payment.Text = "PAYMENT";
            this.payment.UseVisualStyleBackColor = true;
            // 
            // emroll
            // 
            this.emroll.Image = ((System.Drawing.Image)(resources.GetObject("emroll.Image")));
            this.emroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emroll.Location = new System.Drawing.Point(10, 64);
            this.emroll.Name = "emroll";
            this.emroll.Size = new System.Drawing.Size(163, 44);
            this.emroll.TabIndex = 1;
            this.emroll.Text = "ENROLL";
            this.emroll.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            this.dashboard.Image = ((System.Drawing.Image)(resources.GetObject("dashboard.Image")));
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(10, 6);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(163, 44);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "DASHBOARD";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel8.Location = new System.Drawing.Point(1, 586);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1030, 70);
            this.panel8.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel11.Location = new System.Drawing.Point(983, 161);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(48, 425);
            this.panel11.TabIndex = 3;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // Emrollform
            // 
            this.ClientSize = new System.Drawing.Size(1031, 653);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Name = "Emrollform";
            this.Load += new System.EventHandler(this.Emrollform_Load_1);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btreport;
        private System.Windows.Forms.Button btstudent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btdashboard;
        private System.Windows.Forms.Button btEnroll;
        private System.Windows.Forms.Button BtEmployee;
        private System.Windows.Forms.LinkLabel linklogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmajor;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button STUDENT;
        private System.Windows.Forms.Button EMPLOYEE;
        private System.Windows.Forms.Button REPORT;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button emroll;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button MAJOR;
        private System.Windows.Forms.Label lblwelcome;
    }
}