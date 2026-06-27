namespace IronQuestOOPS
{
    partial class ProfileSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSetup));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtFname = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label6 = new Label();
            txtWeight = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtLname = new TextBox();
            txtHeight = new TextBox();
            cmbGender = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(408, -1);
            label1.Name = "label1";
            label1.Size = new Size(393, 54);
            label1.TabIndex = 0;
            label1.Text = "USER INPUT FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Arial", 25.6F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(106, 92);
            label2.Name = "label2";
            label2.Size = new Size(386, 53);
            label2.TabIndex = 2;
            label2.Text = "Basic Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(46, 180);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 3;
            label3.Text = "First Name";
            //label3.Click += label3_Click;
            // 
            // txtFname
            // 
            txtFname.BorderStyle = BorderStyle.None;
            txtFname.Font = new Font("Segoe UI", 14F);
            txtFname.Location = new Point(46, 233);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(326, 32);
            txtFname.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(46, 310);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 5;
            label4.Text = "Your Age";
            //label4.Click += label4_Click;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Font = new Font("Segoe UI", 14F);
            txtAge.Location = new Point(46, 368);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(334, 32);
            txtAge.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(46, 465);
            label6.Name = "label6";
            label6.Size = new Size(158, 28);
            label6.TabIndex = 8;
            label6.Text = "Your Weight (kg)";
            // 
            // txtWeight
            // 
            txtWeight.BorderStyle = BorderStyle.None;
            txtWeight.Font = new Font("Segoe UI", 14F);
            txtWeight.Location = new Point(46, 537);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(334, 32);
            txtWeight.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(802, 180);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 10;
            label7.Text = "Last Name";
            //label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLight;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.AppWorkspace;
            label8.Location = new Point(802, 310);
            label8.Name = "label8";
            label8.Size = new Size(120, 28);
            label8.TabIndex = 11;
            label8.Text = "Your Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.AppWorkspace;
            label9.Location = new Point(802, 465);
            label9.Name = "label9";
            label9.Size = new Size(149, 28);
            label9.TabIndex = 12;
            label9.Text = "Your Height (m)";
            // 
            // txtLname
            // 
            txtLname.BorderStyle = BorderStyle.None;
            txtLname.Font = new Font("Segoe UI", 14F);
            txtLname.Location = new Point(802, 233);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(326, 32);
            txtLname.TabIndex = 13;
            // 
            // txtHeight
            // 
            txtHeight.BorderStyle = BorderStyle.None;
            txtHeight.Font = new Font("Segoe UI", 14F);
            txtHeight.Location = new Point(804, 537);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(336, 32);
            txtHeight.TabIndex = 15;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 14F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Female", "Male" });
            cmbGender.Location = new Point(802, 355);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(338, 39);
            cmbGender.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(471, 600);
            button1.Name = "button1";
            button1.Size = new Size(314, 41);
            button1.TabIndex = 17;
            button1.Text = "DONE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // ProfileSetup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1182, 653);
            Controls.Add(button1);
            Controls.Add(cmbGender);
            Controls.Add(txtHeight);
            Controls.Add(txtLname);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtWeight);
            Controls.Add(label6);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtFname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileSetup";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileSetup";
            Load += ProfileSetup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtFname;
        private Label label4;
        private TextBox txtAge;
        private Label label6;
        private TextBox txtWeight;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtLname;
        private TextBox txtHeight;
        private ComboBox cmbGender;
        private Button button1;
    }
}