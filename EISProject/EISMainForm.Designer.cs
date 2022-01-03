namespace EISProject
{
    partial class EISMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EISMainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.companyLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.systemuserPictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.accessLevelLabel = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.systemUserBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.settingBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.reportBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.allowanceBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.departmentBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.positionBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.holidayBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dtrBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pendingLeaveBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.leaveTypeBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.LeaveBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deductionBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cashAdvanceBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.genPayslipBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.payrollBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.empFilesBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.archiveEmpBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.activeEmpBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.mainEmpBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.systemDashboardBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SystemProccess = new System.ComponentModel.BackgroundWorker();
            this.onlineIndicator = new Bunifu.UI.WinForms.BunifuShapes();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemuserPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.companyNameLabel.Location = new System.Drawing.Point(20, 163);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(228, 59);
            this.companyNameLabel.TabIndex = 3;
            this.companyNameLabel.Text = "Human Resource Information System";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.companyLogoPictureBox);
            this.panel3.Controls.Add(this.companyNameLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 264);
            this.panel3.TabIndex = 5;
            // 
            // companyLogoPictureBox
            // 
            this.companyLogoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("companyLogoPictureBox.Image")));
            this.companyLogoPictureBox.Location = new System.Drawing.Point(54, 18);
            this.companyLogoPictureBox.Name = "companyLogoPictureBox";
            this.companyLogoPictureBox.Size = new System.Drawing.Size(169, 131);
            this.companyLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companyLogoPictureBox.TabIndex = 15;
            this.companyLogoPictureBox.TabStop = false;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(277, 54);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1071, 689);
            this.mainPanel.TabIndex = 7;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateLabel.Location = new System.Drawing.Point(5, 14);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(43, 17);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "label2";
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeLabel.Location = new System.Drawing.Point(170, 14);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(183, 17);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.onlineIndicator);
            this.panel1.Controls.Add(this.systemuserPictureBox);
            this.panel1.Controls.Add(this.gunaVSeparator1);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.accessLevelLabel);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Location = new System.Drawing.Point(270, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 48);
            this.panel1.TabIndex = 13;
            // 
            // systemuserPictureBox
            // 
            this.systemuserPictureBox.AllowFocused = false;
            this.systemuserPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.systemuserPictureBox.AutoSizeHeight = true;
            this.systemuserPictureBox.BackColor = System.Drawing.Color.Silver;
            this.systemuserPictureBox.BorderRadius = 19;
            this.systemuserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("systemuserPictureBox.Image")));
            this.systemuserPictureBox.IsCircle = true;
            this.systemuserPictureBox.Location = new System.Drawing.Point(896, 7);
            this.systemuserPictureBox.Name = "systemuserPictureBox";
            this.systemuserPictureBox.Size = new System.Drawing.Size(38, 38);
            this.systemuserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.systemuserPictureBox.TabIndex = 0;
            this.systemuserPictureBox.TabStop = false;
            this.systemuserPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Gray;
            this.gunaVSeparator1.Location = new System.Drawing.Point(940, 7);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 36);
            this.gunaVSeparator1.TabIndex = 19;
            this.gunaVSeparator1.Thickness = 3;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameLabel.Location = new System.Drawing.Point(670, 7);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameLabel.Size = new System.Drawing.Size(220, 23);
            this.userNameLabel.TabIndex = 16;
            this.userNameLabel.Text = "934743289";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(1039, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(45, 41);
            this.guna2Button2.TabIndex = 18;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // accessLevelLabel
            // 
            this.accessLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accessLevelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessLevelLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.accessLevelLabel.Location = new System.Drawing.Point(708, 27);
            this.accessLevelLabel.Name = "accessLevelLabel";
            this.accessLevelLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accessLevelLabel.Size = new System.Drawing.Size(168, 16);
            this.accessLevelLabel.TabIndex = 17;
            this.accessLevelLabel.Text = "Administrator";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2Button1.Location = new System.Drawing.Point(996, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(45, 41);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(947, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 41);
            this.guna2ControlBox2.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 748);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.systemUserBtn);
            this.panel2.Controls.Add(this.settingBtn);
            this.panel2.Controls.Add(this.reportBtn);
            this.panel2.Controls.Add(this.allowanceBtn);
            this.panel2.Controls.Add(this.departmentBtn);
            this.panel2.Controls.Add(this.positionBtn);
            this.panel2.Controls.Add(this.holidayBtn);
            this.panel2.Controls.Add(this.dtrBtn);
            this.panel2.Controls.Add(this.pendingLeaveBtn);
            this.panel2.Controls.Add(this.leaveTypeBtn);
            this.panel2.Controls.Add(this.LeaveBtn);
            this.panel2.Controls.Add(this.deductionBtn);
            this.panel2.Controls.Add(this.cashAdvanceBtn);
            this.panel2.Controls.Add(this.genPayslipBtn);
            this.panel2.Controls.Add(this.payrollBtn);
            this.panel2.Controls.Add(this.empFilesBtn);
            this.panel2.Controls.Add(this.archiveEmpBtn);
            this.panel2.Controls.Add(this.activeEmpBtn);
            this.panel2.Controls.Add(this.mainEmpBtn);
            this.panel2.Controls.Add(this.systemDashboardBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 472);
            this.panel2.TabIndex = 6;
            // 
            // systemUserBtn
            // 
            this.systemUserBtn.Animated = true;
            this.systemUserBtn.AnimationHoverSpeed = 0.07F;
            this.systemUserBtn.AnimationSpeed = 0.03F;
            this.systemUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.systemUserBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.systemUserBtn.BorderColor = System.Drawing.Color.Black;
            this.systemUserBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.systemUserBtn.CheckedBaseColor = System.Drawing.Color.Empty;
            this.systemUserBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.systemUserBtn.CheckedForeColor = System.Drawing.Color.White;
            this.systemUserBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_admin_settings_male_16;
            this.systemUserBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.systemUserBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.systemUserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.systemUserBtn.FocusedColor = System.Drawing.Color.Empty;
            this.systemUserBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemUserBtn.ForeColor = System.Drawing.Color.White;
            this.systemUserBtn.Image = global::EISProject.Properties.Resources.icons8_admin_settings_male_16;
            this.systemUserBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.systemUserBtn.LineColor = System.Drawing.Color.Transparent;
            this.systemUserBtn.LineLeft = 5;
            this.systemUserBtn.Location = new System.Drawing.Point(0, 1053);
            this.systemUserBtn.Name = "systemUserBtn";
            this.systemUserBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.systemUserBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.systemUserBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.systemUserBtn.OnHoverImage = null;
            this.systemUserBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.systemUserBtn.OnPressedColor = System.Drawing.Color.Black;
            this.systemUserBtn.Size = new System.Drawing.Size(248, 55);
            this.systemUserBtn.TabIndex = 31;
            this.systemUserBtn.Text = "System User";
            this.systemUserBtn.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.Animated = true;
            this.settingBtn.AnimationHoverSpeed = 0.07F;
            this.settingBtn.AnimationSpeed = 0.03F;
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.settingBtn.BackgroundImage = global::EISProject.Properties.Resources.white_settings_16;
            this.settingBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.settingBtn.BorderColor = System.Drawing.Color.Black;
            this.settingBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.settingBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.settingBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.settingBtn.CheckedForeColor = System.Drawing.Color.White;
            this.settingBtn.CheckedImage = global::EISProject.Properties.Resources.white_settings_16;
            this.settingBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.settingBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingBtn.FocusedColor = System.Drawing.Color.Empty;
            this.settingBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBtn.ForeColor = System.Drawing.Color.White;
            this.settingBtn.Image = global::EISProject.Properties.Resources.white_settings_16;
            this.settingBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.settingBtn.LineColor = System.Drawing.Color.Transparent;
            this.settingBtn.LineLeft = 5;
            this.settingBtn.Location = new System.Drawing.Point(0, 990);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.settingBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.settingBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.settingBtn.OnHoverImage = null;
            this.settingBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.settingBtn.OnPressedColor = System.Drawing.Color.Black;
            this.settingBtn.Size = new System.Drawing.Size(248, 63);
            this.settingBtn.TabIndex = 30;
            this.settingBtn.Text = "System Settings";
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Animated = true;
            this.reportBtn.AnimationHoverSpeed = 0.07F;
            this.reportBtn.AnimationSpeed = 0.03F;
            this.reportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.reportBtn.BackgroundImage = global::EISProject.Properties.Resources.icons8_download_graph_report_16;
            this.reportBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.reportBtn.BorderColor = System.Drawing.Color.Black;
            this.reportBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.reportBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.reportBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.reportBtn.CheckedForeColor = System.Drawing.Color.White;
            this.reportBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_download_graph_report_16;
            this.reportBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.reportBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reportBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportBtn.FocusedColor = System.Drawing.Color.Empty;
            this.reportBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.White;
            this.reportBtn.Image = global::EISProject.Properties.Resources.icons8_download_graph_report_16;
            this.reportBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.reportBtn.LineColor = System.Drawing.Color.Transparent;
            this.reportBtn.LineLeft = 5;
            this.reportBtn.Location = new System.Drawing.Point(0, 935);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.reportBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.reportBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.reportBtn.OnHoverImage = null;
            this.reportBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.reportBtn.OnPressedColor = System.Drawing.Color.Black;
            this.reportBtn.Size = new System.Drawing.Size(248, 55);
            this.reportBtn.TabIndex = 29;
            this.reportBtn.Text = "Reports";
            this.reportBtn.Visible = false;
            // 
            // allowanceBtn
            // 
            this.allowanceBtn.Animated = true;
            this.allowanceBtn.AnimationHoverSpeed = 0.07F;
            this.allowanceBtn.AnimationSpeed = 0.03F;
            this.allowanceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.allowanceBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.allowanceBtn.BorderColor = System.Drawing.Color.Black;
            this.allowanceBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.allowanceBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.allowanceBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.allowanceBtn.CheckedForeColor = System.Drawing.Color.White;
            this.allowanceBtn.CheckedImage = global::EISProject.Properties.Resources.money_16;
            this.allowanceBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.allowanceBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.allowanceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.allowanceBtn.FocusedColor = System.Drawing.Color.Empty;
            this.allowanceBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowanceBtn.ForeColor = System.Drawing.Color.White;
            this.allowanceBtn.Image = global::EISProject.Properties.Resources.money_16;
            this.allowanceBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.allowanceBtn.LineColor = System.Drawing.Color.Transparent;
            this.allowanceBtn.LineLeft = 5;
            this.allowanceBtn.Location = new System.Drawing.Point(0, 880);
            this.allowanceBtn.Name = "allowanceBtn";
            this.allowanceBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.allowanceBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.allowanceBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.allowanceBtn.OnHoverImage = null;
            this.allowanceBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.allowanceBtn.OnPressedColor = System.Drawing.Color.Black;
            this.allowanceBtn.Size = new System.Drawing.Size(248, 55);
            this.allowanceBtn.TabIndex = 24;
            this.allowanceBtn.Text = "Allowance";
            this.allowanceBtn.Click += new System.EventHandler(this.allowanceBtn_Click);
            // 
            // departmentBtn
            // 
            this.departmentBtn.Animated = true;
            this.departmentBtn.AnimationHoverSpeed = 0.07F;
            this.departmentBtn.AnimationSpeed = 0.03F;
            this.departmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.departmentBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.departmentBtn.BorderColor = System.Drawing.Color.Black;
            this.departmentBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.departmentBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.departmentBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.departmentBtn.CheckedForeColor = System.Drawing.Color.White;
            this.departmentBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_department_16;
            this.departmentBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.departmentBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.departmentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.departmentBtn.FocusedColor = System.Drawing.Color.Empty;
            this.departmentBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentBtn.ForeColor = System.Drawing.Color.White;
            this.departmentBtn.Image = global::EISProject.Properties.Resources.icons8_department_16;
            this.departmentBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.departmentBtn.LineColor = System.Drawing.Color.Transparent;
            this.departmentBtn.LineLeft = 5;
            this.departmentBtn.Location = new System.Drawing.Point(0, 825);
            this.departmentBtn.Name = "departmentBtn";
            this.departmentBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.departmentBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.departmentBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.departmentBtn.OnHoverImage = null;
            this.departmentBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.departmentBtn.OnPressedColor = System.Drawing.Color.Black;
            this.departmentBtn.Size = new System.Drawing.Size(248, 55);
            this.departmentBtn.TabIndex = 0;
            this.departmentBtn.Text = "Departments";
            this.departmentBtn.Click += new System.EventHandler(this.departmentBtn_Click);
            // 
            // positionBtn
            // 
            this.positionBtn.Animated = true;
            this.positionBtn.AnimationHoverSpeed = 0.07F;
            this.positionBtn.AnimationSpeed = 0.03F;
            this.positionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.positionBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.positionBtn.BorderColor = System.Drawing.Color.Black;
            this.positionBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.positionBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.positionBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.positionBtn.CheckedForeColor = System.Drawing.Color.White;
            this.positionBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_new_job_16;
            this.positionBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.positionBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.positionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.positionBtn.FocusedColor = System.Drawing.Color.Empty;
            this.positionBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionBtn.ForeColor = System.Drawing.Color.White;
            this.positionBtn.Image = global::EISProject.Properties.Resources.icons8_new_job_16;
            this.positionBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.positionBtn.LineColor = System.Drawing.Color.Transparent;
            this.positionBtn.LineLeft = 5;
            this.positionBtn.Location = new System.Drawing.Point(0, 770);
            this.positionBtn.Name = "positionBtn";
            this.positionBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.positionBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.positionBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.positionBtn.OnHoverImage = null;
            this.positionBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.positionBtn.OnPressedColor = System.Drawing.Color.Black;
            this.positionBtn.Size = new System.Drawing.Size(248, 55);
            this.positionBtn.TabIndex = 25;
            this.positionBtn.Text = "Position";
            this.positionBtn.Click += new System.EventHandler(this.positionBtn_Click);
            // 
            // holidayBtn
            // 
            this.holidayBtn.Animated = true;
            this.holidayBtn.AnimationHoverSpeed = 0.07F;
            this.holidayBtn.AnimationSpeed = 0.03F;
            this.holidayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.holidayBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.holidayBtn.BorderColor = System.Drawing.Color.Black;
            this.holidayBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.holidayBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.holidayBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.holidayBtn.CheckedForeColor = System.Drawing.Color.White;
            this.holidayBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_calendar_16;
            this.holidayBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.holidayBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.holidayBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.holidayBtn.FocusedColor = System.Drawing.Color.Empty;
            this.holidayBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayBtn.ForeColor = System.Drawing.Color.White;
            this.holidayBtn.Image = global::EISProject.Properties.Resources.icons8_calendar_16;
            this.holidayBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.holidayBtn.LineColor = System.Drawing.Color.Transparent;
            this.holidayBtn.LineLeft = 5;
            this.holidayBtn.Location = new System.Drawing.Point(0, 715);
            this.holidayBtn.Name = "holidayBtn";
            this.holidayBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.holidayBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.holidayBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.holidayBtn.OnHoverImage = null;
            this.holidayBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.holidayBtn.OnPressedColor = System.Drawing.Color.Black;
            this.holidayBtn.Size = new System.Drawing.Size(248, 55);
            this.holidayBtn.TabIndex = 32;
            this.holidayBtn.Text = "Holidays";
            this.holidayBtn.Click += new System.EventHandler(this.gunaAdvenceButton1_Click_1);
            // 
            // dtrBtn
            // 
            this.dtrBtn.Animated = true;
            this.dtrBtn.AnimationHoverSpeed = 0.07F;
            this.dtrBtn.AnimationSpeed = 0.03F;
            this.dtrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.dtrBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.dtrBtn.BorderColor = System.Drawing.Color.Black;
            this.dtrBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.dtrBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.dtrBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.dtrBtn.CheckedForeColor = System.Drawing.Color.White;
            this.dtrBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_time_16;
            this.dtrBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.dtrBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.dtrBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtrBtn.FocusedColor = System.Drawing.Color.Empty;
            this.dtrBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtrBtn.ForeColor = System.Drawing.Color.White;
            this.dtrBtn.Image = global::EISProject.Properties.Resources.icons8_time_16;
            this.dtrBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.dtrBtn.LineColor = System.Drawing.Color.Transparent;
            this.dtrBtn.LineLeft = 5;
            this.dtrBtn.Location = new System.Drawing.Point(0, 660);
            this.dtrBtn.Name = "dtrBtn";
            this.dtrBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.dtrBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.dtrBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.dtrBtn.OnHoverImage = null;
            this.dtrBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.dtrBtn.OnPressedColor = System.Drawing.Color.Black;
            this.dtrBtn.Size = new System.Drawing.Size(248, 55);
            this.dtrBtn.TabIndex = 28;
            this.dtrBtn.Text = "Daily Time Record";
            this.dtrBtn.Click += new System.EventHandler(this.dtrBtn_Click);
            // 
            // pendingLeaveBtn
            // 
            this.pendingLeaveBtn.Animated = true;
            this.pendingLeaveBtn.AnimationHoverSpeed = 0.07F;
            this.pendingLeaveBtn.AnimationSpeed = 0.03F;
            this.pendingLeaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.pendingLeaveBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.pendingLeaveBtn.BorderColor = System.Drawing.Color.Black;
            this.pendingLeaveBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.pendingLeaveBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.pendingLeaveBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.pendingLeaveBtn.CheckedForeColor = System.Drawing.Color.White;
            this.pendingLeaveBtn.CheckedImage = null;
            this.pendingLeaveBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.pendingLeaveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pendingLeaveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pendingLeaveBtn.FocusedColor = System.Drawing.Color.Empty;
            this.pendingLeaveBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingLeaveBtn.ForeColor = System.Drawing.Color.White;
            this.pendingLeaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("pendingLeaveBtn.Image")));
            this.pendingLeaveBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.pendingLeaveBtn.LineColor = System.Drawing.Color.Transparent;
            this.pendingLeaveBtn.LineLeft = 5;
            this.pendingLeaveBtn.Location = new System.Drawing.Point(0, 605);
            this.pendingLeaveBtn.Name = "pendingLeaveBtn";
            this.pendingLeaveBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.pendingLeaveBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.pendingLeaveBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.pendingLeaveBtn.OnHoverImage = null;
            this.pendingLeaveBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.pendingLeaveBtn.OnPressedColor = System.Drawing.Color.Black;
            this.pendingLeaveBtn.Size = new System.Drawing.Size(248, 55);
            this.pendingLeaveBtn.TabIndex = 18;
            this.pendingLeaveBtn.Text = "Pending Leaves";
            this.pendingLeaveBtn.Visible = false;
            // 
            // leaveTypeBtn
            // 
            this.leaveTypeBtn.Animated = true;
            this.leaveTypeBtn.AnimationHoverSpeed = 0.07F;
            this.leaveTypeBtn.AnimationSpeed = 0.03F;
            this.leaveTypeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.leaveTypeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.leaveTypeBtn.BorderColor = System.Drawing.Color.Black;
            this.leaveTypeBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.leaveTypeBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.leaveTypeBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.leaveTypeBtn.CheckedForeColor = System.Drawing.Color.White;
            this.leaveTypeBtn.CheckedImage = null;
            this.leaveTypeBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.leaveTypeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.leaveTypeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.leaveTypeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.leaveTypeBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveTypeBtn.ForeColor = System.Drawing.Color.White;
            this.leaveTypeBtn.Image = ((System.Drawing.Image)(resources.GetObject("leaveTypeBtn.Image")));
            this.leaveTypeBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.leaveTypeBtn.LineColor = System.Drawing.Color.Transparent;
            this.leaveTypeBtn.LineLeft = 5;
            this.leaveTypeBtn.Location = new System.Drawing.Point(0, 550);
            this.leaveTypeBtn.Name = "leaveTypeBtn";
            this.leaveTypeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.leaveTypeBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.leaveTypeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.leaveTypeBtn.OnHoverImage = null;
            this.leaveTypeBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.leaveTypeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.leaveTypeBtn.Size = new System.Drawing.Size(248, 55);
            this.leaveTypeBtn.TabIndex = 1;
            this.leaveTypeBtn.Text = "Leave Type";
            this.leaveTypeBtn.Visible = false;
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.Animated = true;
            this.LeaveBtn.AnimationHoverSpeed = 0.07F;
            this.LeaveBtn.AnimationSpeed = 0.03F;
            this.LeaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.LeaveBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.LeaveBtn.BorderColor = System.Drawing.Color.Black;
            this.LeaveBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.LeaveBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.LeaveBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.LeaveBtn.CheckedForeColor = System.Drawing.Color.White;
            this.LeaveBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_expand_arrow_16;
            this.LeaveBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.LeaveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LeaveBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeaveBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LeaveBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveBtn.ForeColor = System.Drawing.Color.White;
            this.LeaveBtn.Image = global::EISProject.Properties.Resources.icons8_expand_arrow_16;
            this.LeaveBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.LeaveBtn.LineColor = System.Drawing.Color.Transparent;
            this.LeaveBtn.LineLeft = 5;
            this.LeaveBtn.Location = new System.Drawing.Point(0, 495);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.LeaveBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.LeaveBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LeaveBtn.OnHoverImage = null;
            this.LeaveBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.LeaveBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LeaveBtn.Size = new System.Drawing.Size(248, 55);
            this.LeaveBtn.TabIndex = 24;
            this.LeaveBtn.Text = "Leaves";
            this.LeaveBtn.Visible = false;
            this.LeaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // deductionBtn
            // 
            this.deductionBtn.Animated = true;
            this.deductionBtn.AnimationHoverSpeed = 0.07F;
            this.deductionBtn.AnimationSpeed = 0.03F;
            this.deductionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.deductionBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.deductionBtn.BorderColor = System.Drawing.Color.Black;
            this.deductionBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.deductionBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.deductionBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.deductionBtn.CheckedForeColor = System.Drawing.Color.White;
            this.deductionBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_minus_16;
            this.deductionBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.deductionBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deductionBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deductionBtn.FocusedColor = System.Drawing.Color.Empty;
            this.deductionBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deductionBtn.ForeColor = System.Drawing.Color.White;
            this.deductionBtn.Image = global::EISProject.Properties.Resources.icons8_minus_16;
            this.deductionBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.deductionBtn.LineColor = System.Drawing.Color.Transparent;
            this.deductionBtn.LineLeft = 5;
            this.deductionBtn.Location = new System.Drawing.Point(0, 440);
            this.deductionBtn.Name = "deductionBtn";
            this.deductionBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.deductionBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.deductionBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deductionBtn.OnHoverImage = null;
            this.deductionBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.deductionBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deductionBtn.Size = new System.Drawing.Size(248, 55);
            this.deductionBtn.TabIndex = 19;
            this.deductionBtn.Text = "Deductions";
            this.deductionBtn.Visible = false;
            this.deductionBtn.Click += new System.EventHandler(this.deductionBtn_Click);
            // 
            // cashAdvanceBtn
            // 
            this.cashAdvanceBtn.Animated = true;
            this.cashAdvanceBtn.AnimationHoverSpeed = 0.07F;
            this.cashAdvanceBtn.AnimationSpeed = 0.03F;
            this.cashAdvanceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.cashAdvanceBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.cashAdvanceBtn.BorderColor = System.Drawing.Color.Black;
            this.cashAdvanceBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.cashAdvanceBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.cashAdvanceBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.cashAdvanceBtn.CheckedForeColor = System.Drawing.Color.White;
            this.cashAdvanceBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_cash_in_hand_16;
            this.cashAdvanceBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.cashAdvanceBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cashAdvanceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cashAdvanceBtn.FocusedColor = System.Drawing.Color.Empty;
            this.cashAdvanceBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashAdvanceBtn.ForeColor = System.Drawing.Color.White;
            this.cashAdvanceBtn.Image = global::EISProject.Properties.Resources.icons8_cash_in_hand_16;
            this.cashAdvanceBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.cashAdvanceBtn.LineColor = System.Drawing.Color.Transparent;
            this.cashAdvanceBtn.LineLeft = 5;
            this.cashAdvanceBtn.Location = new System.Drawing.Point(0, 385);
            this.cashAdvanceBtn.Name = "cashAdvanceBtn";
            this.cashAdvanceBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.cashAdvanceBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.cashAdvanceBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cashAdvanceBtn.OnHoverImage = null;
            this.cashAdvanceBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.cashAdvanceBtn.OnPressedColor = System.Drawing.Color.Black;
            this.cashAdvanceBtn.Size = new System.Drawing.Size(248, 55);
            this.cashAdvanceBtn.TabIndex = 22;
            this.cashAdvanceBtn.Text = "Cash Advance";
            this.cashAdvanceBtn.Visible = false;
            this.cashAdvanceBtn.Click += new System.EventHandler(this.cashAdvanceBtn_Click);
            // 
            // genPayslipBtn
            // 
            this.genPayslipBtn.Animated = true;
            this.genPayslipBtn.AnimationHoverSpeed = 0.07F;
            this.genPayslipBtn.AnimationSpeed = 0.03F;
            this.genPayslipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.genPayslipBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.genPayslipBtn.BorderColor = System.Drawing.Color.Black;
            this.genPayslipBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.genPayslipBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.genPayslipBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.genPayslipBtn.CheckedForeColor = System.Drawing.Color.White;
            this.genPayslipBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_purchase_order_16;
            this.genPayslipBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.genPayslipBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.genPayslipBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.genPayslipBtn.FocusedColor = System.Drawing.Color.Empty;
            this.genPayslipBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genPayslipBtn.ForeColor = System.Drawing.Color.White;
            this.genPayslipBtn.Image = global::EISProject.Properties.Resources.icons8_purchase_order_16;
            this.genPayslipBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.genPayslipBtn.LineColor = System.Drawing.Color.Transparent;
            this.genPayslipBtn.LineLeft = 5;
            this.genPayslipBtn.Location = new System.Drawing.Point(0, 330);
            this.genPayslipBtn.Name = "genPayslipBtn";
            this.genPayslipBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.genPayslipBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.genPayslipBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.genPayslipBtn.OnHoverImage = null;
            this.genPayslipBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.genPayslipBtn.OnPressedColor = System.Drawing.Color.Black;
            this.genPayslipBtn.Size = new System.Drawing.Size(248, 55);
            this.genPayslipBtn.TabIndex = 3;
            this.genPayslipBtn.Text = "Generate Payslip";
            this.genPayslipBtn.Visible = false;
            this.genPayslipBtn.Click += new System.EventHandler(this.genPayslipBtn_Click);
            // 
            // payrollBtn
            // 
            this.payrollBtn.Animated = true;
            this.payrollBtn.AnimationHoverSpeed = 0.07F;
            this.payrollBtn.AnimationSpeed = 0.03F;
            this.payrollBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.payrollBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.payrollBtn.BorderColor = System.Drawing.Color.Black;
            this.payrollBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.payrollBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.payrollBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.payrollBtn.CheckedForeColor = System.Drawing.Color.White;
            this.payrollBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_expand_arrow_16;
            this.payrollBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.payrollBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.payrollBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.payrollBtn.FocusedColor = System.Drawing.Color.Empty;
            this.payrollBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollBtn.ForeColor = System.Drawing.Color.White;
            this.payrollBtn.Image = global::EISProject.Properties.Resources.icons8_expand_arrow_16;
            this.payrollBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.payrollBtn.LineColor = System.Drawing.Color.Transparent;
            this.payrollBtn.LineLeft = 5;
            this.payrollBtn.Location = new System.Drawing.Point(0, 275);
            this.payrollBtn.Name = "payrollBtn";
            this.payrollBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.payrollBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.payrollBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.payrollBtn.OnHoverImage = null;
            this.payrollBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.payrollBtn.OnPressedColor = System.Drawing.Color.Black;
            this.payrollBtn.Size = new System.Drawing.Size(248, 55);
            this.payrollBtn.TabIndex = 21;
            this.payrollBtn.Text = "Payroll";
            this.payrollBtn.Click += new System.EventHandler(this.payrollBtn_Click);
            // 
            // empFilesBtn
            // 
            this.empFilesBtn.Animated = true;
            this.empFilesBtn.AnimationHoverSpeed = 0.07F;
            this.empFilesBtn.AnimationSpeed = 0.03F;
            this.empFilesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.empFilesBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.empFilesBtn.BorderColor = System.Drawing.Color.Black;
            this.empFilesBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.empFilesBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.empFilesBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.empFilesBtn.CheckedForeColor = System.Drawing.Color.White;
            this.empFilesBtn.CheckedImage = global::EISProject.Properties.Resources.employeefiles_16;
            this.empFilesBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.empFilesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.empFilesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.empFilesBtn.FocusedColor = System.Drawing.Color.Empty;
            this.empFilesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empFilesBtn.ForeColor = System.Drawing.Color.White;
            this.empFilesBtn.Image = global::EISProject.Properties.Resources.employeefiles_16;
            this.empFilesBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.empFilesBtn.LineColor = System.Drawing.Color.Transparent;
            this.empFilesBtn.LineLeft = 5;
            this.empFilesBtn.Location = new System.Drawing.Point(0, 220);
            this.empFilesBtn.Name = "empFilesBtn";
            this.empFilesBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.empFilesBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.empFilesBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.empFilesBtn.OnHoverImage = null;
            this.empFilesBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.empFilesBtn.OnPressedColor = System.Drawing.Color.Black;
            this.empFilesBtn.Size = new System.Drawing.Size(248, 55);
            this.empFilesBtn.TabIndex = 23;
            this.empFilesBtn.Text = "Employee Files";
            this.empFilesBtn.Visible = false;
            this.empFilesBtn.Click += new System.EventHandler(this.empFilesBtn_Click);
            // 
            // archiveEmpBtn
            // 
            this.archiveEmpBtn.Animated = true;
            this.archiveEmpBtn.AnimationHoverSpeed = 0.07F;
            this.archiveEmpBtn.AnimationSpeed = 0.03F;
            this.archiveEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.archiveEmpBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.archiveEmpBtn.BorderColor = System.Drawing.Color.Black;
            this.archiveEmpBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.archiveEmpBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.archiveEmpBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.archiveEmpBtn.CheckedForeColor = System.Drawing.Color.White;
            this.archiveEmpBtn.CheckedImage = global::EISProject.Properties.Resources.employeearchived_16;
            this.archiveEmpBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.archiveEmpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.archiveEmpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.archiveEmpBtn.FocusedColor = System.Drawing.Color.Empty;
            this.archiveEmpBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiveEmpBtn.ForeColor = System.Drawing.Color.White;
            this.archiveEmpBtn.Image = global::EISProject.Properties.Resources.employeearchived_16;
            this.archiveEmpBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.archiveEmpBtn.LineColor = System.Drawing.Color.Transparent;
            this.archiveEmpBtn.LineLeft = 5;
            this.archiveEmpBtn.Location = new System.Drawing.Point(0, 165);
            this.archiveEmpBtn.Name = "archiveEmpBtn";
            this.archiveEmpBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.archiveEmpBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.archiveEmpBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.archiveEmpBtn.OnHoverImage = null;
            this.archiveEmpBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.archiveEmpBtn.OnPressedColor = System.Drawing.Color.Black;
            this.archiveEmpBtn.Size = new System.Drawing.Size(248, 55);
            this.archiveEmpBtn.TabIndex = 20;
            this.archiveEmpBtn.Text = "Archive Employees";
            this.archiveEmpBtn.Visible = false;
            this.archiveEmpBtn.Click += new System.EventHandler(this.archiveEmpBtn_Click);
            // 
            // activeEmpBtn
            // 
            this.activeEmpBtn.Animated = true;
            this.activeEmpBtn.AnimationHoverSpeed = 0.07F;
            this.activeEmpBtn.AnimationSpeed = 0.03F;
            this.activeEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.activeEmpBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.activeEmpBtn.BorderColor = System.Drawing.Color.Black;
            this.activeEmpBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.activeEmpBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.activeEmpBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.activeEmpBtn.CheckedForeColor = System.Drawing.Color.White;
            this.activeEmpBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("activeEmpBtn.CheckedImage")));
            this.activeEmpBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.activeEmpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.activeEmpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.activeEmpBtn.FocusedColor = System.Drawing.Color.Empty;
            this.activeEmpBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeEmpBtn.ForeColor = System.Drawing.Color.White;
            this.activeEmpBtn.Image = ((System.Drawing.Image)(resources.GetObject("activeEmpBtn.Image")));
            this.activeEmpBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.activeEmpBtn.LineColor = System.Drawing.Color.Transparent;
            this.activeEmpBtn.LineLeft = 5;
            this.activeEmpBtn.Location = new System.Drawing.Point(0, 110);
            this.activeEmpBtn.Name = "activeEmpBtn";
            this.activeEmpBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(31)))));
            this.activeEmpBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.activeEmpBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.activeEmpBtn.OnHoverImage = null;
            this.activeEmpBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.activeEmpBtn.OnPressedColor = System.Drawing.Color.Black;
            this.activeEmpBtn.Size = new System.Drawing.Size(248, 55);
            this.activeEmpBtn.TabIndex = 1;
            this.activeEmpBtn.Text = "Active Employees";
            this.activeEmpBtn.Visible = false;
            this.activeEmpBtn.Click += new System.EventHandler(this.activeEmpBtn_Click);
            // 
            // mainEmpBtn
            // 
            this.mainEmpBtn.Animated = true;
            this.mainEmpBtn.AnimationHoverSpeed = 0.07F;
            this.mainEmpBtn.AnimationSpeed = 0.03F;
            this.mainEmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.mainEmpBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.mainEmpBtn.BorderColor = System.Drawing.Color.Black;
            this.mainEmpBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.mainEmpBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.mainEmpBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.mainEmpBtn.CheckedForeColor = System.Drawing.Color.White;
            this.mainEmpBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("mainEmpBtn.CheckedImage")));
            this.mainEmpBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.mainEmpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.mainEmpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainEmpBtn.FocusedColor = System.Drawing.Color.Empty;
            this.mainEmpBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainEmpBtn.ForeColor = System.Drawing.Color.White;
            this.mainEmpBtn.Image = global::EISProject.Properties.Resources.icons8_expand_arrow_16;
            this.mainEmpBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.mainEmpBtn.LineColor = System.Drawing.Color.Transparent;
            this.mainEmpBtn.LineLeft = 5;
            this.mainEmpBtn.Location = new System.Drawing.Point(0, 55);
            this.mainEmpBtn.Name = "mainEmpBtn";
            this.mainEmpBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.mainEmpBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.mainEmpBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.mainEmpBtn.OnHoverImage = null;
            this.mainEmpBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.mainEmpBtn.OnPressedColor = System.Drawing.Color.Black;
            this.mainEmpBtn.Size = new System.Drawing.Size(248, 55);
            this.mainEmpBtn.TabIndex = 26;
            this.mainEmpBtn.Text = "Employees";
            this.mainEmpBtn.Click += new System.EventHandler(this.mainEmpBtn_Click);
            // 
            // systemDashboardBtn
            // 
            this.systemDashboardBtn.Animated = true;
            this.systemDashboardBtn.AnimationHoverSpeed = 0.07F;
            this.systemDashboardBtn.AnimationSpeed = 0.03F;
            this.systemDashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.systemDashboardBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.systemDashboardBtn.BorderColor = System.Drawing.Color.Black;
            this.systemDashboardBtn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.systemDashboardBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.systemDashboardBtn.CheckedBorderColor = System.Drawing.Color.Empty;
            this.systemDashboardBtn.CheckedForeColor = System.Drawing.Color.White;
            this.systemDashboardBtn.CheckedImage = global::EISProject.Properties.Resources.icons8_combo_chart_16;
            this.systemDashboardBtn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.systemDashboardBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.systemDashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.systemDashboardBtn.FocusedColor = System.Drawing.Color.Empty;
            this.systemDashboardBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemDashboardBtn.ForeColor = System.Drawing.Color.White;
            this.systemDashboardBtn.Image = global::EISProject.Properties.Resources.icons8_combo_chart_16;
            this.systemDashboardBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.systemDashboardBtn.LineColor = System.Drawing.Color.Transparent;
            this.systemDashboardBtn.LineLeft = 5;
            this.systemDashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.systemDashboardBtn.Name = "systemDashboardBtn";
            this.systemDashboardBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.systemDashboardBtn.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.systemDashboardBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.systemDashboardBtn.OnHoverImage = null;
            this.systemDashboardBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.systemDashboardBtn.OnPressedColor = System.Drawing.Color.Black;
            this.systemDashboardBtn.Size = new System.Drawing.Size(248, 55);
            this.systemDashboardBtn.TabIndex = 2;
            this.systemDashboardBtn.Text = "Dashboard";
            this.systemDashboardBtn.Click += new System.EventHandler(this.systemDashboardBtn_Click);
            // 
            // SystemProccess
            // 
            this.SystemProccess.WorkerSupportsCancellation = true;
            // 
            // onlineIndicator
            // 
            this.onlineIndicator.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.onlineIndicator.Angle = 0F;
            this.onlineIndicator.BackColor = System.Drawing.Color.Transparent;
            this.onlineIndicator.BorderColor = System.Drawing.Color.SeaGreen;
            this.onlineIndicator.BorderThickness = 2;
            this.onlineIndicator.FillColor = System.Drawing.Color.SeaGreen;
            this.onlineIndicator.FillShape = true;
            this.onlineIndicator.Location = new System.Drawing.Point(876, 29);
            this.onlineIndicator.Name = "onlineIndicator";
            this.onlineIndicator.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.onlineIndicator.Sides = 5;
            this.onlineIndicator.Size = new System.Drawing.Size(14, 14);
            this.onlineIndicator.TabIndex = 0;
            this.onlineIndicator.Text = "bunifuShapes1";
            // 
            // EISMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1356, 748);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1356, 737);
            this.Name = "EISMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EISMainForm";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemuserPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label companyNameLabel;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton departmentBtn;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI.WinForms.GunaAdvenceButton pendingLeaveBtn;
        private Guna.UI.WinForms.GunaAdvenceButton activeEmpBtn;
        private Guna.UI.WinForms.GunaAdvenceButton genPayslipBtn;
        private Guna.UI.WinForms.GunaAdvenceButton systemDashboardBtn;
        private Guna.UI.WinForms.GunaAdvenceButton leaveTypeBtn;
        private Guna.UI.WinForms.GunaAdvenceButton deductionBtn;
        private Guna.UI.WinForms.GunaAdvenceButton cashAdvanceBtn;
        private Guna.UI.WinForms.GunaAdvenceButton payrollBtn;
        private Guna.UI.WinForms.GunaAdvenceButton archiveEmpBtn;
        private Guna.UI.WinForms.GunaAdvenceButton LeaveBtn;
        private Guna.UI.WinForms.GunaAdvenceButton empFilesBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox companyLogoPictureBox;
        private System.Windows.Forms.Label accessLevelLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.ComponentModel.BackgroundWorker SystemProccess;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Bunifu.UI.WinForms.BunifuPictureBox systemuserPictureBox;
        private Guna.UI.WinForms.GunaAdvenceButton positionBtn;
        private Guna.UI.WinForms.GunaAdvenceButton mainEmpBtn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton allowanceBtn;
        private Guna.UI.WinForms.GunaAdvenceButton dtrBtn;
        private Guna.UI.WinForms.GunaAdvenceButton settingBtn;
        private Guna.UI.WinForms.GunaAdvenceButton reportBtn;
        private Guna.UI.WinForms.GunaAdvenceButton systemUserBtn;
        private Guna.UI.WinForms.GunaAdvenceButton holidayBtn;
        private Bunifu.UI.WinForms.BunifuShapes onlineIndicator;
    }
}