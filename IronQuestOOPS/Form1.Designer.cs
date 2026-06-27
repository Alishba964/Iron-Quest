namespace IronQuestOOPS
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label3;
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbUsers = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 422);
            label3.Name = "label3";
            label3.Size = new Size(287, 17);
            label3.TabIndex = 2;
            label3.Text = "\"Defeat Deficiency, Begin Your Quest\"";
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 658);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 22.1999989F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(81, 245);
            label2.Name = "label2";
            label2.Size = new Size(178, 47);
            label2.TabIndex = 1;
            label2.Text = "QUEST";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(30, 194);
            label1.Name = "label1";
            label1.Size = new Size(160, 51);
            label1.TabIndex = 0;
            label1.Text = "IRON";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Elephant", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(399, 135);
            label4.Name = "label4";
            label4.Size = new Size(741, 60);
            label4.TabIndex = 1;
            label4.Text = "⋆°｡⋆♡ WELCOME BACK♡⋆｡°⋆";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(642, 221);
            label5.Name = "label5";
            label5.Size = new Size(257, 42);
            label5.TabIndex = 2;
            label5.Text = "Select  A  User";
            // 
            // cmbUsers
            // 
            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Items.AddRange(new object[] { "Haya", "Demo" });
            cmbUsers.Location = new Point(544, 333);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(463, 28);
            cmbUsers.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(676, 419);
            button1.Name = "button1";
            button1.Size = new Size(185, 44);
            button1.TabIndex = 4;
            button1.Text = "DONE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1182, 653);
            Controls.Add(button1);
            Controls.Add(cmbUsers);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeForm";
            Load += WelcomeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private ComboBox cmbUsers;
        private Button button1;
    }
}
