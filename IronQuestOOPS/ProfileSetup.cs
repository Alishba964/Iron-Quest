
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace IronQuestOOPS
{
    public partial class ProfileSetup : Form
    {
        
        private string GetConnectionString()
        {
            string dbPath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                "Database2.accdb"
            );
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath;
        }

        public ProfileSetup()
        {
            InitializeComponent();
        }

        private void ProfileSetup_Load(object sender, EventArgs e)
        {

        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SpringGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumSeaGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string weightText = txtWeight.Text.Trim();
            string heightText = txtHeight.Text.Trim();
            string gender = cmbGender.SelectedItem?.ToString();

           //Empty check
            if (string.IsNullOrEmpty(fname) ||
                string.IsNullOrEmpty(lname) ||
                string.IsNullOrEmpty(ageText) ||
                string.IsNullOrEmpty(weightText) ||
                string.IsNullOrEmpty(heightText) ||
                string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please fill all fields properly");
                return;
            }

            // Numeric validation
            if (!int.TryParse(ageText, out int age) || age <= 0 || age > 120)     // return true/false (check if age enters is converted into int or not , if true then store it in age variable)
            {
                MessageBox.Show("Enter a valid age (1–120)");
                return;
            }

            if (!double.TryParse(weightText, out double weight) || weight <= 0)
            {
                MessageBox.Show("Enter a valid weight");
                return;
            }

            if (!double.TryParse(heightText, out double height) || height <= 0)
            {
                MessageBox.Show("Enter a valid height");
                return;
            }
            // Name validation
            if (!Regex.IsMatch(fname, @"^[a-zA-Z]+$") ||     //pattern checker (Regex.IsMatch(text, pattern))  returns true or false , if pattern matches then return true , (^[a-zA-Z]+$) check if uppper and lower case letters only 
                !Regex.IsMatch(lname, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Names should contain only letters");
                return;
            }
            string fullName = fname + " " + lname;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();

                    string query = @"INSERT INTO [Users table] 
                                    ([USER NAME], [Weight (kg)], [Height], [Gender], [Age]) 
                                    VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {  // cmd.Parameters.AddWithValue("?",value)
                        cmd.Parameters.AddWithValue("?", fullName);  
                        cmd.Parameters.AddWithValue("?", weight);
                        cmd.Parameters.AddWithValue("?", height);
                        cmd.Parameters.AddWithValue("?", gender);
                        cmd.Parameters.AddWithValue("?", age);

                        cmd.ExecuteNonQuery();  //does not return any row , just made chnages in the database, actual SQL query that made changes
                        // After ExecuteNonQuery(), fetch the new user's ID
                        OleDbCommand getIdCmd = new OleDbCommand(
                            "SELECT TOP 1 [USER ID] FROM [Users table] ORDER BY [USER ID] DESC", conn);
                        //TOP 1 (means select only one row)
                        int newUserId = Convert.ToInt32(getIdCmd.ExecuteScalar());
                        MessageBox.Show("Profile Created & Saved Successfully");

                        Main mainForm = new Main(fullName, age, weight, height, gender, newUserId);
                        mainForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
    }
}