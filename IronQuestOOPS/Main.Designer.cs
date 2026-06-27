namespace IronQuestOOPS
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuBtn = new PictureBox();
            pnDashboard = new Panel();
            button1 = new Button();
            pnMealLog = new Panel();
            button3 = new Button();
            pnProfile = new Panel();
            button2 = new Button();
            pnExit = new Panel();
            button4 = new Button();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            labelDate = new Label();
            mainContentPanel = new Panel();
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            pnDashboard.SuspendLayout();
            pnMealLog.SuspendLayout();
            pnProfile.SuspendLayout();
            pnExit.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.IndianRed;
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(pnDashboard);
            Sidebar.Controls.Add(pnMealLog);
            Sidebar.Controls.Add(pnProfile);
            Sidebar.Controls.Add(pnExit);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.ForeColor = SystemColors.ControlLight;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(253, 653);
            Sidebar.MinimumSize = new Size(65, 653);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(253, 653);
            Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 131);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 48);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // MenuBtn
            // 
            MenuBtn.Cursor = Cursors.Hand;
            MenuBtn.Image = Properties.Resources.menu_burger__1_;
            MenuBtn.Location = new Point(9, 48);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(32, 32);
            MenuBtn.SizeMode = PictureBoxSizeMode.AutoSize;
            MenuBtn.TabIndex = 0;
            MenuBtn.TabStop = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(button1);
            pnDashboard.Dock = DockStyle.Top;
            pnDashboard.Location = new Point(3, 140);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(250, 52);
            pnDashboard.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(253, 49);
            button1.TabIndex = 3;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnMealLog
            // 
            pnMealLog.Controls.Add(button3);
            pnMealLog.Dock = DockStyle.Top;
            pnMealLog.Location = new Point(3, 198);
            pnMealLog.Name = "pnMealLog";
            pnMealLog.Size = new Size(247, 53);
            pnMealLog.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 3);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(250, 50);
            button3.TabIndex = 5;
            button3.Text = "Meal Log";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pnProfile
            // 
            pnProfile.Controls.Add(button2);
            pnProfile.Dock = DockStyle.Top;
            pnProfile.Location = new Point(3, 257);
            pnProfile.Name = "pnProfile";
            pnProfile.Size = new Size(250, 53);
            pnProfile.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(252, 50);
            button2.TabIndex = 4;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pnExit
            // 
            pnExit.Controls.Add(button4);
            pnExit.Location = new Point(3, 316);
            pnExit.Name = "pnExit";
            pnExit.Size = new Size(250, 65);
            pnExit.TabIndex = 9;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.exit;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-3, 3);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(252, 50);
            button4.TabIndex = 6;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 20;
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(1005, 62);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(0, 20);
            labelDate.TabIndex = 3;
            labelDate.Click += label4_Click;
            // 
            // mainContentPanel
            // 
            mainContentPanel.Dock = DockStyle.Fill;
            mainContentPanel.Location = new Point(253, 0);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(929, 653);
            mainContentPanel.TabIndex = 4;
            mainContentPanel.Paint += mainContentPanel_Paint;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1182, 653);
            Controls.Add(mainContentPanel);
            Controls.Add(labelDate);
            Controls.Add(Sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserProfile";
            Load += UserProfile_Load;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            pnDashboard.ResumeLayout(false);
            pnMealLog.ResumeLayout(false);
            pnProfile.ResumeLayout(false);
            pnExit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label1;
        private PictureBox MenuBtn;
        private System.Windows.Forms.Timer SidebarTimer;
        private Label labelDate;
        private Panel pnDashboard;
        private Panel pnMealLog;
        private Panel pnProfile;
        private Panel mainContentPanel;
        private Panel pnExit;
        private Button button4;
    }
}