
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace IronQuestOOPS
{
    public partial class formMealLog : Form
    {
        public class FoodItem
        {
            public int Id;
            public string Name;
            public double IronPer100g;
        }

        List<FoodItem> foods = new List<FoodItem>();
        int currentUserId;
        formDashboard dashboard;
        private int selectedMealId = -1;

        public formMealLog(int userId, formDashboard dash)
        {
            InitializeComponent();
            currentUserId = userId;
            dashboard = dash;
        }

        private string GetConnectionString()
        {
            string dbPath = Path.Combine(
                Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName,
                "Database2.accdb"
            );
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath;
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void LoadFoods()
        {
            foods.Clear();
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Food items]", conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        foods.Add(new FoodItem
                        {
                            Id = Convert.ToInt32(reader[0]),
                            Name = reader[1].ToString(),
                            IronPer100g = Convert.ToDouble(reader[2])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading foods: " + ex.Message);
            }
        }

        private void LoadMealLog()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT dm.[MEAL ID], fi.[FOOD NAME], dm.[QUANTITY], dm.[DATE] " +
                                   "FROM [Daily meals] dm " +
                                   "INNER JOIN [Food items] fi ON dm.[FOOD ID] = fi.[FOOD ID] " +
                                   "WHERE dm.[DATE] = #" + DateTime.Today.ToString("M/d/yyyy") + "# " +
                                   "AND dm.[USER ID] = " + currentUserId;

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.RowHeadersVisible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading meal log: " + ex.Message);
            }
        }

        private int GetNextMealIdForUser()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT MAX([MEAL ID]) FROM [Daily meals]";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                        return 1;
                    return Convert.ToInt32(result) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting next Meal ID: " + ex.Message);
                return 1;
            }
        }

        private void formMealLog_Load(object sender, EventArgs e)
        {
            LoadFoods();
            LoadMealLog();
            comboBox1.DataSource = foods;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            if (comboBox1.SelectedItem is FoodItem first)  //FoodItem first =(FoodItem)comboBox1.SelectedItem;
            {
                textBox2.Text = first.IronPer100g.ToString("F2") + " mg";
            }

            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is FoodItem selected)   //FoodItem first =(FoodItem)comboBox1.SelectedItem;
            {
                if (double.TryParse(textBox1.Text, out double grams))
                {
                    double iron = (selected.IronPer100g * grams) / 100;
                    textBox2.Text = iron.ToString("F2") + " mg"; //ToString("F2") decimal ke baad 2 values return karta hai
                }
                else
                {
                    textBox2.Text = selected.IronPer100g.ToString("F2") + " mg";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is FoodItem selected)
            {
                if (double.TryParse(textBox1.Text, out double grams))
                {
                    double iron = (selected.IronPer100g * grams) / 100;
                    textBox2.Text = iron.ToString("F2") + " mg";
                }
                else
                {
                    textBox2.Text = selected.IronPer100g.ToString("F2") + " mg";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            selectedMealId = Convert.ToInt32(row.Cells[0].Value);

            string foodName = row.Cells[1].Value.ToString();
            foreach (FoodItem item in foods)
            {
                if (item.Name == foodName)
                {
                    comboBox1.SelectedItem = item;
                    break;
                }
            }

            textBox1.Text = row.Cells[2].Value.ToString();
        }

        // ADD
        private void button2_Click(object sender, EventArgs e)
        {
            FoodItem selected = comboBox1.SelectedItem as FoodItem;
            if (selected == null)
            {
                MessageBox.Show("Please select a food.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textBox1.Text, out double grams))
            {
                MessageBox.Show("Please enter a valid quantity in grams.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                    try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    int nextMealId = GetNextMealIdForUser();
                    OleDbTransaction transaction = conn.BeginTransaction();

                    string query = "INSERT INTO [Daily meals] ([MEAL ID], [USER ID], [FOOD ID], [QUANTITY], [DATE]) " +
                                   "VALUES (@mealId, @userId, @foodId, @qty, @date)";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddWithValue("@mealId", nextMealId);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.Parameters.AddWithValue("@foodId", selected.Id);
                    cmd.Parameters.AddWithValue("@qty", grams);
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);
                    int rows = cmd.ExecuteNonQuery();
                    transaction.Commit();
                    if (rows > 0)
                    {
                        MessageBox.Show($"Meal added!\n\nFood: {selected.Name}\nQuantity: {grams}g",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedMealId = -1;
                        textBox1.Text = "";
                        LoadMealLog();
                        dashboard?.RefreshDashboard(); // ✅ Refresh dashboard
                    }
                    else
                    {
                        MessageBox.Show("Failed to add meal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EDIT
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedMealId == -1)
            {
                MessageBox.Show("Please click on a row first, then press Edit.",
                    "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FoodItem selected = comboBox1.SelectedItem as FoodItem;

            if (selected == null)
            {
                MessageBox.Show("Please select a food.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textBox1.Text, out double grams))
            {
                MessageBox.Show("Please enter a valid quantity in grams.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Update Meal ID {selectedMealId}?\n\nFood: {selected.Name}\nQuantity: {grams}g",
                "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = "UPDATE [Daily meals] SET [FOOD ID] = @foodId, [QUANTITY] = @qty WHERE [MEAL ID] = @mealId AND [USER ID] " +
                        "= @userId";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@foodId", selected.Id);
                    cmd.Parameters.AddWithValue("@qty", grams);
                    cmd.Parameters.AddWithValue("@mealId", selectedMealId);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show($"Meal updated\n\nFood: {selected.Name}\nQuantity: {grams}g",
                            "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedMealId = -1;
                        textBox1.Text = "";
                        LoadMealLog();
                        dashboard?.RefreshDashboard(); 
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Meal ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMealId == -1)
            {
                MessageBox.Show("Please click on a row first, then press Delete.",
                    "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedFoodName = "";
            if (dataGridView1.CurrentRow != null)
                selectedFoodName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Delete '{selectedFoodName}' (Meal ID: {selectedMealId})?\n\nThis cannot be undone!",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = "DELETE FROM [Daily meals] WHERE [MEAL ID] = @mealId AND [USER ID] = @userId";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mealId", selectedMealId);
                    cmd.Parameters.AddWithValue("@userId", currentUserId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show($"'{selectedFoodName}' deleted successfully!",
                            "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedMealId = -1;
                        textBox1.Text = "";
                        LoadMealLog();
                        dashboard?.RefreshDashboard(); // ✅ Refresh dashboard

                        if (comboBox1.SelectedItem is FoodItem first)
                            textBox2.Text = first.IronPer100g.ToString("F2") + " mg";
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Meal ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}