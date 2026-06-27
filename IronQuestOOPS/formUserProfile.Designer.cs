namespace IronQuestOOPS
{
    partial class formUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUserProfile));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblStat = new Label();
            lblMessage = new Label();
            lblName = new Label();
            lblAge = new Label();
            lblGender = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 55);
            label1.Name = "label1";
            label1.Size = new Size(281, 46);
            label1.TabIndex = 3;
            label1.Text = "Account Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 182);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 250);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 5;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 331);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 6;
            label4.Text = "Gender: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 411);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 7;
            label5.Text = "Height:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(49, 485);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 8;
            label6.Text = "Weight:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(79, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SYSTEM : DORMANT";
            // 
            // lblStat
            // 
            lblStat.AutoSize = true;
            lblStat.BackColor = Color.Transparent;
            lblStat.Location = new Point(151, 93);
            lblStat.Name = "lblStat";
            lblStat.Size = new Size(39, 20);
            lblStat.TabIndex = 1;
            lblStat.Text = "0mg";
            lblStat.Click += lblMessage_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Location = new Point(104, 208);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(148, 20);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Initialize iron intake...";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(183, 189);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 16;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(183, 258);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(21, 20);
            lblAge.TabIndex = 17;
            lblAge.Text = "....";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(183, 331);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(21, 20);
            lblGender.TabIndex = 18;
            lblGender.Text = "....";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(183, 411);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(21, 20);
            lblHeight.TabIndex = 19;
            lblHeight.Text = "....";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(183, 489);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(21, 20);
            lblWeight.TabIndex = 20;
            lblWeight.Text = "....";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(601, 60);
            button1.Name = "button1";
            button1.Size = new Size(182, 45);
            button1.TabIndex = 21;
            button1.Text = "Edit Information";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // formUserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(900, 600);
            Controls.Add(button1);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formUserProfile";
            Text = "formUserProfile";
            Load += formUserProfile_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblStat;
        private Label lblMessage;
        private Label lblName;
        private Label lblAge;
        private Label lblGender;
        private Label lblHeight;
        private Label lblWeight;
        private Button button1;
    }
}