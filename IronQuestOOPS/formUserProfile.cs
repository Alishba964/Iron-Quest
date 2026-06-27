using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace IronQuestOOPS
{
    public partial class formUserProfile : Form
    {
        string userName;
        int userAge;
        double userWeight;
        double userHeight;
        string userGender;
        int userId;

        public formUserProfile(string name, int age, double weight, double height, string gender, int id)
        {
            InitializeComponent();
            userName = name;
            userAge = age;
            userWeight = weight;
            userHeight = height;
            userGender = gender;
            userId = id;

            lblName.Text = userName;
            lblAge.Text = userAge.ToString();
            lblGender.Text = userGender;
            lblHeight.Text = userHeight.ToString();
            lblWeight.Text = userWeight.ToString();
        }

        private string GetConnectionString()
        {
            string dbPath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                "Database2.accdb"
            );
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath;
        }

        // EDIT INFORMATION BUTTON — Gender is fixed and cannot be changed
        private void button1_Click_1(object sender, EventArgs e)
        {
            //New form dynamically
            Form editForm = new Form();
            editForm.Text = "Edit Profile";
            editForm.Size = new System.Drawing.Size(400, 360);
            editForm.StartPosition = FormStartPosition.CenterParent;
            editForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            editForm.MaximizeBox = false;
            editForm.MinimizeBox = false;

            // Name
            Label lName = new Label() { Text = "Full Name:", Location = new System.Drawing.Point(20, 20), AutoSize = true };
            TextBox tName = new TextBox() { Location = new System.Drawing.Point(130, 17), Width = 220, Text = userName };

            // Age
            Label lAge = new Label() { Text = "Age:", Location = new System.Drawing.Point(20, 65), AutoSize = true };
            TextBox tAge = new TextBox() { Location = new System.Drawing.Point(130, 62), Width = 220, Text = userAge.ToString() };

            // Height
            Label lHeight = new Label() { Text = "Height (cm):", Location = new System.Drawing.Point(20, 110), AutoSize = true };
            TextBox tHeight = new TextBox() { Location = new System.Drawing.Point(130, 107), Width = 220, Text = userHeight.ToString() };

            // Weight
            Label lWeight = new Label() { Text = "Weight (kg):", Location = new System.Drawing.Point(20, 155), AutoSize = true };
            TextBox tWeight = new TextBox() { Location = new System.Drawing.Point(130, 152), Width = 220, Text = userWeight.ToString() };

            // Save button
            Button btnSave = new Button()
            {
                Text = "Save Changes",
                Location = new System.Drawing.Point(130, 220),
                Width = 150,
                Height = 40,
                BackColor = System.Drawing.Color.MediumSeaGreen,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };

            // Cancel button
            Button btnCancel = new Button()
            {
                Text = "Cancel",
                Location = new System.Drawing.Point(290, 220),
                Width = 80,
                Height = 40
            };
       
            private void BtnCancel_Click(object sender, EventArgs e)
             {
            editForm.Close();
              }
             btnCancel.Click += BtnCancel_Click;
        
            
            // Save button logic
              btnSave.Click += (s, ev) =>
                {
                string newName = tName.Text.Trim();

                if (string.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("Name cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tAge.Text, out int newAge) || newAge <= 0 || newAge > 120)
                {
                    MessageBox.Show("Enter a valid age (1-120).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(tHeight.Text, out double newHeight) || newHeight <= 0)
                {
                    MessageBox.Show("Enter a valid height.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(tWeight.Text, out double newWeight) || newWeight <= 0)
                {
                    MessageBox.Show("Enter a valid weight.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                    {conn.Open();
                        // Gender is NOT updated , it stays fixed as originally set
                        string query = @"UPDATE [Users table] 
                                         SET [USER NAME] = ?, [Age] = ?, [Height] = ?, [Weight (kg)] = ?
                                         WHERE [USER ID] = ?";
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", newName);
                            cmd.Parameters.AddWithValue("?", newAge);
                            cmd.Parameters.AddWithValue("?", newHeight);
                            cmd.Parameters.AddWithValue("?", newWeight);
                            cmd.Parameters.AddWithValue("?", userId);

                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                // Update local variables
                                userName = newName;
                                userAge = newAge;
                                userHeight = newHeight;
                                userWeight = newWeight;
                                // userGender stays unchanged

                                // Refresh labels on screen
                                lblName.Text = userName;
                                lblAge.Text = userAge.ToString();
                                lblHeight.Text = userHeight.ToString();
                                lblWeight.Text = userWeight.ToString();
                                // lblGender stays unchanged
                                MessageBox.Show("Profile updated successfully!",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                editForm.Close();
                            }
                            else
                            {
                                MessageBox.Show("Update failed. User not found.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            editForm.Controls.AddRange(new Control[]
            {
                lName, tName, lAge, tAge,
                lHeight, tHeight, lWeight, tWeight,
                btnSave, btnCancel
            });

            editForm.ShowDialog(this);
        }
    }
}