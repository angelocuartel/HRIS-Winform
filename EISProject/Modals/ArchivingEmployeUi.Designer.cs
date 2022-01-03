namespace EISProject.Modals
{
    partial class ArchivingEmployeUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivingEmployeUi));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.reasonComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.othersTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.suspensionDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.archiveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reasonComboBox
            // 
            this.reasonComboBox.Animated = true;
            this.reasonComboBox.BackColor = System.Drawing.Color.Transparent;
            this.reasonComboBox.BorderColor = System.Drawing.Color.Gray;
            this.reasonComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.reasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reasonComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.reasonComboBox.FocusedState.Parent = this.reasonComboBox;
            this.reasonComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reasonComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.reasonComboBox.FormattingEnabled = true;
            this.reasonComboBox.HoverState.Parent = this.reasonComboBox;
            this.reasonComboBox.ItemHeight = 30;
            this.reasonComboBox.Items.AddRange(new object[] {
            "Resign",
            "Suspended",
            "Retired",
            "Deceased",
            "Awol",
            "Others"});
            this.reasonComboBox.ItemsAppearance.Parent = this.reasonComboBox;
            this.reasonComboBox.Location = new System.Drawing.Point(17, 111);
            this.reasonComboBox.Name = "reasonComboBox";
            this.reasonComboBox.ShadowDecoration.Depth = 10;
            this.reasonComboBox.ShadowDecoration.Parent = this.reasonComboBox;
            this.reasonComboBox.Size = new System.Drawing.Size(255, 36);
            this.reasonComboBox.StartIndex = 0;
            this.reasonComboBox.TabIndex = 121;
            this.reasonComboBox.SelectedIndexChanged += new System.EventHandler(this.reasonComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 122;
            this.label2.Text = "Others";
            // 
            // othersTextBox
            // 
            this.othersTextBox.Animated = true;
            this.othersTextBox.BorderColor = System.Drawing.Color.Gray;
            this.othersTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.othersTextBox.DefaultText = "";
            this.othersTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.othersTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.othersTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.othersTextBox.DisabledState.Parent = this.othersTextBox;
            this.othersTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.othersTextBox.Enabled = false;
            this.othersTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.othersTextBox.FocusedState.Parent = this.othersTextBox;
            this.othersTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.othersTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.othersTextBox.HoverState.Parent = this.othersTextBox;
            this.othersTextBox.Location = new System.Drawing.Point(17, 256);
            this.othersTextBox.Multiline = true;
            this.othersTextBox.Name = "othersTextBox";
            this.othersTextBox.PasswordChar = '\0';
            this.othersTextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.othersTextBox.PlaceholderText = "";
            this.othersTextBox.SelectedText = "";
            this.othersTextBox.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.othersTextBox.ShadowDecoration.Depth = 10;
            this.othersTextBox.ShadowDecoration.Parent = this.othersTextBox;
            this.othersTextBox.Size = new System.Drawing.Size(492, 89);
            this.othersTextBox.TabIndex = 0;
            // 
            // suspensionDateTimePicker
            // 
            this.suspensionDateTimePicker.Animated = true;
            this.suspensionDateTimePicker.AutoRoundedCorners = true;
            this.suspensionDateTimePicker.BackColor = System.Drawing.Color.White;
            this.suspensionDateTimePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suspensionDateTimePicker.BorderRadius = 17;
            this.suspensionDateTimePicker.CheckedState.Parent = this.suspensionDateTimePicker;
            this.suspensionDateTimePicker.Enabled = false;
            this.suspensionDateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.suspensionDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspensionDateTimePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suspensionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.suspensionDateTimePicker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suspensionDateTimePicker.HoverState.Parent = this.suspensionDateTimePicker;
            this.suspensionDateTimePicker.Location = new System.Drawing.Point(16, 182);
            this.suspensionDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.suspensionDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.suspensionDateTimePicker.Name = "suspensionDateTimePicker";
            this.suspensionDateTimePicker.ShadowDecoration.Parent = this.suspensionDateTimePicker;
            this.suspensionDateTimePicker.Size = new System.Drawing.Size(256, 36);
            this.suspensionDateTimePicker.TabIndex = 124;
            this.suspensionDateTimePicker.Value = new System.DateTime(2021, 2, 14, 23, 55, 39, 255);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 130;
            this.label5.Text = "Archiving Employee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(17, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 128;
            this.label4.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(13, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 127;
            this.label3.Text = "Suspension lift after :";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(489, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = false;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.archiveButton);
            this.gunaLinePanel1.Controls.Add(this.cancelButton);
            this.gunaLinePanel1.Controls.Add(this.employeeNameLabel);
            this.gunaLinePanel1.Controls.Add(this.label4);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Silver;
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(535, 404);
            this.gunaLinePanel1.TabIndex = 134;
            // 
            // archiveButton
            // 
            this.archiveButton.AllowAnimations = true;
            this.archiveButton.AllowMouseEffects = true;
            this.archiveButton.AllowToggling = false;
            this.archiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.archiveButton.AnimationSpeed = 200;
            this.archiveButton.AutoGenerateColors = false;
            this.archiveButton.AutoRoundBorders = false;
            this.archiveButton.AutoSizeLeftIcon = true;
            this.archiveButton.AutoSizeRightIcon = true;
            this.archiveButton.BackColor = System.Drawing.Color.Transparent;
            this.archiveButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.archiveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("archiveButton.BackgroundImage")));
            this.archiveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.archiveButton.ButtonText = "Archive";
            this.archiveButton.ButtonTextMarginLeft = 0;
            this.archiveButton.ColorContrastOnClick = 45;
            this.archiveButton.ColorContrastOnHover = 45;
            this.archiveButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.archiveButton.CustomizableEdges = borderEdges1;
            this.archiveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.archiveButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.archiveButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.archiveButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.archiveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.archiveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.archiveButton.ForeColor = System.Drawing.Color.White;
            this.archiveButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.archiveButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.archiveButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.archiveButton.IconMarginLeft = 11;
            this.archiveButton.IconPadding = 10;
            this.archiveButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.archiveButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.archiveButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.archiveButton.IconSize = 25;
            this.archiveButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.archiveButton.IdleBorderRadius = 5;
            this.archiveButton.IdleBorderThickness = 1;
            this.archiveButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.archiveButton.IdleIconLeftImage = null;
            this.archiveButton.IdleIconRightImage = null;
            this.archiveButton.IndicateFocus = true;
            this.archiveButton.Location = new System.Drawing.Point(310, 353);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.archiveButton.OnDisabledState.BorderRadius = 5;
            this.archiveButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.archiveButton.OnDisabledState.BorderThickness = 1;
            this.archiveButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.archiveButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.archiveButton.OnDisabledState.IconLeftImage = null;
            this.archiveButton.OnDisabledState.IconRightImage = null;
            this.archiveButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.archiveButton.onHoverState.BorderRadius = 5;
            this.archiveButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.archiveButton.onHoverState.BorderThickness = 1;
            this.archiveButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.archiveButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.archiveButton.onHoverState.IconLeftImage = null;
            this.archiveButton.onHoverState.IconRightImage = null;
            this.archiveButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.archiveButton.OnIdleState.BorderRadius = 5;
            this.archiveButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.archiveButton.OnIdleState.BorderThickness = 1;
            this.archiveButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.archiveButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.archiveButton.OnIdleState.IconLeftImage = null;
            this.archiveButton.OnIdleState.IconRightImage = null;
            this.archiveButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.archiveButton.OnPressedState.BorderRadius = 5;
            this.archiveButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.archiveButton.OnPressedState.BorderThickness = 1;
            this.archiveButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.archiveButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.archiveButton.OnPressedState.IconLeftImage = null;
            this.archiveButton.OnPressedState.IconRightImage = null;
            this.archiveButton.Size = new System.Drawing.Size(83, 39);
            this.archiveButton.TabIndex = 135;
            this.archiveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.archiveButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.archiveButton.TextMarginLeft = 0;
            this.archiveButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.archiveButton.UseDefaultRadiusAndThickness = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AllowAnimations = true;
            this.cancelButton.AllowMouseEffects = true;
            this.cancelButton.AllowToggling = false;
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.AnimationSpeed = 200;
            this.cancelButton.AutoGenerateColors = false;
            this.cancelButton.AutoRoundBorders = false;
            this.cancelButton.AutoSizeLeftIcon = true;
            this.cancelButton.AutoSizeRightIcon = true;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.cancelButton.ButtonText = "Cancel";
            this.cancelButton.ButtonTextMarginLeft = 0;
            this.cancelButton.ColorContrastOnClick = 45;
            this.cancelButton.ColorContrastOnHover = 45;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.cancelButton.CustomizableEdges = borderEdges2;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.cancelButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cancelButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.cancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.cancelButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.cancelButton.IconMarginLeft = 11;
            this.cancelButton.IconPadding = 10;
            this.cancelButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.cancelButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.cancelButton.IconSize = 25;
            this.cancelButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.IdleBorderRadius = 5;
            this.cancelButton.IdleBorderThickness = 1;
            this.cancelButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.IdleIconLeftImage = null;
            this.cancelButton.IdleIconRightImage = null;
            this.cancelButton.IndicateFocus = true;
            this.cancelButton.Location = new System.Drawing.Point(399, 353);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.cancelButton.OnDisabledState.BorderRadius = 5;
            this.cancelButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.cancelButton.OnDisabledState.BorderThickness = 1;
            this.cancelButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cancelButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.cancelButton.OnDisabledState.IconLeftImage = null;
            this.cancelButton.OnDisabledState.IconRightImage = null;
            this.cancelButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.onHoverState.BorderRadius = 5;
            this.cancelButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.cancelButton.onHoverState.BorderThickness = 1;
            this.cancelButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.cancelButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.onHoverState.IconLeftImage = null;
            this.cancelButton.onHoverState.IconRightImage = null;
            this.cancelButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.OnIdleState.BorderRadius = 5;
            this.cancelButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.cancelButton.OnIdleState.BorderThickness = 1;
            this.cancelButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.cancelButton.OnIdleState.IconLeftImage = null;
            this.cancelButton.OnIdleState.IconRightImage = null;
            this.cancelButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.OnPressedState.BorderRadius = 5;
            this.cancelButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.cancelButton.OnPressedState.BorderThickness = 1;
            this.cancelButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.cancelButton.OnPressedState.IconLeftImage = null;
            this.cancelButton.OnPressedState.IconRightImage = null;
            this.cancelButton.Size = new System.Drawing.Size(110, 39);
            this.cancelButton.TabIndex = 136;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelButton.TextMarginLeft = 0;
            this.cancelButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.cancelButton.UseDefaultRadiusAndThickness = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.employeeNameLabel.Location = new System.Drawing.Point(7, 35);
            this.employeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(446, 25);
            this.employeeNameLabel.TabIndex = 135;
            this.employeeNameLabel.Text = "Archiving Employee";
            // 
            // ArchivingEmployeUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 404);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.othersTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reasonComboBox);
            this.Controls.Add(this.suspensionDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArchivingEmployeUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchiveEmployeeUi";
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox reasonComboBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox othersTextBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker suspensionDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label employeeNameLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton cancelButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton archiveButton;
    }
}