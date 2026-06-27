using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace IronQuestOOPS
{
    public partial class WelcomeForm : Form
    {
        private string GetConnectionString()
        {
            string dbPath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                "Database2.accdb"
            );
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath;
        }

        public class UserItem
        {
            public int Id;
            public string Name;
        }

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            cmbUsers.Items.Clear();
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT [USER ID], [USER NAME] FROM [Users table]", conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbUsers.Items.Add(new UserItem
                        {
                            Id = Convert.ToInt32(reader["USER ID"]),
                            Name = reader["USER NAME"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }

            cmbUsers.Items.Add("Demo");
            cmbUsers.DisplayMember = "Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem == null)
            {
                MessageBox.Show("Please select a user first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbUsers.SelectedItem.ToString() == "Demo")
            {
                ProfileSetup setup = new ProfileSetup();
                setup.Show();
                this.Hide();
                return;
            }

            UserItem selected = (UserItem)cmbUsers.SelectedItem;   //typecasting UserItem
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(
                        "SELECT * FROM [Users table] WHERE [USER ID] = " + selected.Id, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string name = reader["USER NAME"].ToString();
                        int age = Convert.ToInt32(reader["Age"]);
                        double weight = Convert.ToDouble(reader["Weight (kg)"]);
                        double height = Convert.ToDouble(reader["Height"]);
                        string gender = reader["Gender"].ToString();
                        int id = Convert.ToInt32(reader["USER ID"]);

                        Main mainForm = new Main(name, age, weight, height, gender, id);
                        mainForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

   
}