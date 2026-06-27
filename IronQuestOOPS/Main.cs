using System;
using System.Windows.Forms;
namespace IronQuestOOPS
{
    public partial class Main : Form
    {
        bool SidebarExpand;
        formDashboard dashboard;
        formMealLog mlog;
        formUserProfile uprofile;

        private void LoadChildForm(Form childForm)
        {
            mainContentPanel.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainContentPanel.Controls.Add(childForm);
            mainContentPanel.Tag = childForm;
            childForm.Show();
        }
        string userName;
        int userAge;
        double userWeight;
        double userHeight;
        string userGender;
        int userId;

        public Main(string name, int age, double weight, double height, string gender, int id)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            userName = name;
            userAge = age;
            userWeight = weight;
            userHeight = height;
            userGender = gender;
            userId = id;

            labelDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            // Pre-create dashboard on load so it will always available for mlog
            dashboard = new formDashboard(userName, userId, userAge, userGender);
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            this.SuspendLayout();
            if (SidebarExpand)
            {
                Sidebar.Width -= 30;
                if (Sidebar.Width <= Sidebar.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 30;
                if (Sidebar.Width >= Sidebar.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
            this.ResumeLayout();
        }
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        //private void label4_Click(object sender, EventArgs e) { }
        //private void panel3_Paint(object sender, EventArgs e) { }
        //private void label2_Click(object sender, EventArgs e) { }
        //private void UserProfile_Load(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            if (uprofile == null || uprofile.IsDisposed)
            {
                uprofile = new formUserProfile(userName, userAge, userWeight, userHeight, userGender, userId);
            }
            LoadChildForm(uprofile);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mlog == null || mlog.IsDisposed)
            {
                //  Pass dashboard reference so meal log can refresh it
                mlog = new formMealLog(userId, dashboard);
            }
            LoadChildForm(mlog);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Reuse the pre-created dashboard (same instance mlog uses)
            LoadChildForm(dashboard);
        }

        private void button4_Click(object sender, EventArgs e) { }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit IronQuest?",
                "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs e) { }
    }
}