namespace IronQuestOOPS
{
    partial class formDiagnosis
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
            lblwelcome = new Label();
            label1 = new Label();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            btnDiagnose = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.Location = new Point(525, 43);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(294, 46);
            lblwelcome.TabIndex = 1;
            lblwelcome.Text = "Diagnosis Report";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 163);
            label1.Name = "label1";
            label1.Size = new Size(305, 25);
            label1.TabIndex = 2;
            label1.Text = "Why might your iron be low today?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(210, 202);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = "Select all that apply";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.ControlLightLight;
            checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(192, 241);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(490, 244);
            checkedListBox1.TabIndex = 4;
            // 
            // btnDiagnose
            // 
            btnDiagnose.BackColor = Color.MediumSeaGreen;
            btnDiagnose.FlatStyle = FlatStyle.Flat;
            btnDiagnose.ForeColor = SystemColors.ButtonHighlight;
            btnDiagnose.Location = new Point(192, 518);
            btnDiagnose.Name = "btnDiagnose";
            btnDiagnose.Size = new Size(169, 40);
            btnDiagnose.TabIndex = 5;
            btnDiagnose.Text = "Get Diagnosis";
            btnDiagnose.UseVisualStyleBackColor = false;
            btnDiagnose.Click += btnDiagnose_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ControlDarkDark;
            btnCancel.Location = new Point(423, 518);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(169, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // formDiagnosis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1164, 606);
            Controls.Add(btnCancel);
            Controls.Add(btnDiagnose);
            Controls.Add(checkedListBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblwelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDiagnosis";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formDiagnosis";
            Load += formDiagnosis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwelcome;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Button btnDiagnose;
        private Button btnCancel;
    }
}