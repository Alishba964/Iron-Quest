using System;
using System.Text;
using System.Windows.Forms;

namespace IronQuestOOPS
{
    public partial class formDiagnosis : Form
    {
        private readonly (string Question, string Cause, string Advice)[] questions = new[]
        {
            ("I drink tea or coffee during meals.", "Tannins block iron absorption.", "Wait 1 hour after meals before drinking tea/coffee."),
            ("I eat lots of dairy with my food.", "Calcium competes with iron absorption.", "Eat dairy separately from iron-rich meals."),
            ("I don't eat citrus fruits.", "Vitamin C helps iron absorption.", "Add lemon or orange to your meals."),
            ("I eat unsoaked grains.", "Phytates in grains block iron.", "Soak grains before cooking."),
            ("I smoked today.", "Smoking reduces iron absorption.", "Avoid smoking, especially around mealtimes."),
            ("I drank caffeine today.", "Caffeine inhibits iron absorption.", "Limit caffeine and avoid it during meals.")
        };

        public formDiagnosis()
        {
            InitializeComponent();
        }

        private void formDiagnosis_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            foreach (var q in questions)
                checkedListBox1.Items.Add(q.Question);
        }

        private void btnDiagnose_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one option.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder report = new StringBuilder();
            report.AppendLine("📋 DIAGNOSIS REPORT");
            report.AppendLine("════════════════════════════════");

            foreach (int i in checkedListBox1.CheckedIndices)
            {
                var q = questions[i];
                report.AppendLine();
                report.AppendLine($"⚠️ {q.Question}");
                report.AppendLine($"   Cause:  {q.Cause}");
                report.AppendLine($"   Advice: {q.Advice}");
                report.AppendLine("────────────────────────────────");
            }

            MessageBox.Show(report.ToString(), "Your Diagnosis",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}