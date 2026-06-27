using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace IronQuestOOPS
{
    public partial class formDashboard : Form
    {
        string userName;
        int userId;
        int userAge;
        string userGender;

        List<string> tips = new List<string>()
        {
            "Vitamin C boosts iron absorption!",
            "Avoid tea/coffee right after meals.",
            "Spinach is good, but pair it with lemon!",
            "Red meat is a rich source of iron.",
            "Cooking in iron utensils can increase iron intake."
        };

        public formDashboard(string name, int id, int age, string gender)
        {
            InitializeComponent();
            userName = name;
            userId = id;
            userAge = age;
            userGender = gender;
        }
        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            formDiagnosis diagnosis = new formDiagnosis();
            diagnosis.ShowDialog();
        }
        private string GetConnectionString()
        {
            string dbPath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                "Database2.accdb"
            );
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath;
        }

        // Calculate daily iron goal based on age and gender
        private double GetIronGoal()
        {
            string g = userGender?.ToLower() ?? "";
            //in simple words
            //string g;
            //if (userGender != null)
            //{
            //    g = userGender.ToLower();
            //}
            //else
            //{
            //    g = "";
            //}
            if (userAge < 14) return 10;
            if (g == "male") return 8;
            if (g == "female")
            {
                if (userAge >= 14 && userAge <= 18) return 15;
                if (userAge >= 19 && userAge <= 50) return 18;
                return 8;
            }
            return 18;
        }

        // Get total iron consumed today
        private double GetIronToday()
        { double total = 0;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT SUM(dm.[QUANTITY] * fi.[IRON  (mg / 100 g)] / 100) " +
                                   "FROM [Daily meals] dm " +
                                   "INNER JOIN [Food items] fi ON dm.[FOOD ID] = fi.[FOOD ID] " +
                                   "WHERE dm.[USER ID] = " + userId +
                                   " AND dm.[DATE] = #" + DateTime.Today.ToString("M/d/yyyy") + "#";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        total = Convert.ToDouble(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading iron: " + ex.Message);
            }
            return Math.Round(total, 2);
        }
        // Get number of meals logged today
        private int GetMealsToday()
        {
            int count = 0;
            try
            {    using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {conn.Open();
                    string query = "SELECT COUNT(*) FROM [Daily meals] WHERE [USER ID] = " + userId +
                                   " AND [DATE] = #" + DateTime.Today.ToString("M/d/yyyy") + "#";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading meals: " + ex.Message);
            }
            return count;
        }

        // Calculate current streak
        private int GetCurrentStreak()
        {
            int streak = 0;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    DateTime checkDate = DateTime.Today;
                    while (true)
                    {
                        string query = "SELECT COUNT(*) FROM [Daily meals] WHERE [USER ID] = " + userId +
                                       " AND [DATE] = #" + checkDate.ToString("M/d/yyyy") + "#";
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            streak++;
                            checkDate = checkDate.AddDays(-1);
                        }
                        else break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating streak: " + ex.Message);
            }
            return streak;
        }
        // Calculate best streak ever
        private int GetBestStreak()
        {
            int bestStreak = 0;
            int currentStreak = 0;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT [DATE] FROM [Daily meals] WHERE [USER ID] = " + userId +
                                   " ORDER BY [DATE] ASC";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    DateTime? prevDate = null;
                    while (reader.Read())
                    {
                        DateTime logDate = Convert.ToDateTime(reader[0]).Date;
                        if (prevDate == null || logDate == prevDate.Value.AddDays(1))
                            currentStreak++;
                        else
                            currentStreak = 1;
                        if (currentStreak > bestStreak)
                            bestStreak = currentStreak;
                        prevDate = logDate;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating best streak: " + ex.Message);
            }
            return bestStreak;
        }

        // Public method so Main.cs can call this to refresh dashboard anytime
        public void RefreshDashboard()
        {
            double ironGoal = GetIronGoal();
            double ironToday = GetIronToday();
            int meals = GetMealsToday();
            int currentStreak = GetCurrentStreak();
            int bestStreak = GetBestStreak();

            int percent = ironGoal > 0 ? (int)Math.Min(100, (ironToday / ironGoal * 100)) : 0;
            // Progress panel
            lblIronToday.Text = $"{ironToday}mg from {ironGoal}mg";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = percent;
            progressBar1.Refresh();
            // Summary panel
            lblIronToday.Text = $"Consumed: {ironToday}mg / {ironGoal}mg";
            lblMeals.Text = $"Meals today: {meals}";
            lblGoalCompletion.Text = $"Iron Goal: {ironGoal}mg | {percent}% done";
            lblLastLog.Text = meals > 0 ? $"Last log: {DateTime.Now:HH:mm}" : "No meals logged yet";

            // Remaining vs Excess
            if (ironToday <= ironGoal)
            {
                double remaining = Math.Round(ironGoal - ironToday, 2);
                lblIronRemaining.Text = $"Iron Remaining: {remaining} mg";
                lblIronRemaining.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                double excess = Math.Round(ironToday - ironGoal, 2);
                lblIronRemaining.Text = $"Excess Iron: +{excess} mg ⚠️";
                lblIronRemaining.ForeColor = System.Drawing.Color.Red;
            }
            // Streak panel
            lblCurrentStreak.Text = $"Current: {currentStreak} {(currentStreak == 1 ? "day" : "days")}";
            lblBestStreak.Text = $"Best: {bestStreak} {(bestStreak == 1 ? "day" : "days")}";
        }


        private void formDashboard_Load(object sender, EventArgs e)
        {
            lblwelcome.Text = "Welcome, " + userName;
            lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            Random rand = new Random();
            lblTip.Text = tips[rand.Next(tips.Count)];
            RefreshDashboard();
        }

        private void lblTip_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
}