namespace EISProject.Modals
{
    partial class AddDepartmentUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartmentUi));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.personnelTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depCodeErrorLabel = new System.Windows.Forms.Label();
            this.departmentNameErrorLabel = new System.Windows.Forms.Label();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.depHeadErrorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.departmentCodeTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.depHeadTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.departmentTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.addDepartmentButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personnelTextBox
            // 
            this.personnelTextBox.AutoSize = true;
            this.personnelTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personnelTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.personnelTextBox.Location = new System.Drawing.Point(19, 245);
            this.personnelTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personnelTextBox.Name = "personnelTextBox";
            this.personnelTextBox.Size = new System.Drawing.Size(116, 17);
            this.personnelTextBox.TabIndex = 116;
            this.personnelTextBox.Text = "Department Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 114;
            this.label1.Text = "Department Name";
            // 
            // depCodeErrorLabel
            // 
            this.depCodeErrorLabel.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depCodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.depCodeErrorLabel.Location = new System.Drawing.Point(177, 309);
            this.depCodeErrorLabel.Name = "depCodeErrorLabel";
            this.depCodeErrorLabel.Size = new System.Drawing.Size(186, 15);
            this.depCodeErrorLabel.TabIndex = 123;
            this.depCodeErrorLabel.Text = "error";
            this.depCodeErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.depCodeErrorLabel.Visible = false;
            // 
            // departmentNameErrorLabel
            // 
            this.departmentNameErrorLabel.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.departmentNameErrorLabel.Location = new System.Drawing.Point(177, 132);
            this.departmentNameErrorLabel.Name = "departmentNameErrorLabel";
            this.departmentNameErrorLabel.Size = new System.Drawing.Size(186, 15);
            this.departmentNameErrorLabel.TabIndex = 124;
            this.departmentNameErrorLabel.Text = "error";
            this.departmentNameErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.departmentNameErrorLabel.Visible = false;
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
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
            this.bunifuSnackbar1.FadeCloseIcon = true;
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
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 125;
            this.label3.Text = "Department Head";
            // 
            // depHeadErrorLabel
            // 
            this.depHeadErrorLabel.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depHeadErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.depHeadErrorLabel.Location = new System.Drawing.Point(177, 216);
            this.depHeadErrorLabel.Name = "depHeadErrorLabel";
            this.depHeadErrorLabel.Size = new System.Drawing.Size(186, 15);
            this.depHeadErrorLabel.TabIndex = 127;
            this.depHeadErrorLabel.Text = "error";
            this.depHeadErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.depHeadErrorLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 25);
            this.label5.TabIndex = 130;
            this.label5.Text = "Add Department";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(495, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.personnelTextBox);
            this.gunaLinePanel1.Controls.Add(this.departmentCodeTextBox);
            this.gunaLinePanel1.Controls.Add(this.depHeadTextBox);
            this.gunaLinePanel1.Controls.Add(this.departmentTextBox);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.label5);
            this.gunaLinePanel1.Controls.Add(this.depHeadErrorLabel);
            this.gunaLinePanel1.Controls.Add(this.cancelButton);
            this.gunaLinePanel1.Controls.Add(this.addDepartmentButton);
            this.gunaLinePanel1.Controls.Add(this.depCodeErrorLabel);
            this.gunaLinePanel1.Controls.Add(this.departmentNameErrorLabel);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Silver;
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(543, 403);
            this.gunaLinePanel1.TabIndex = 136;
            // 
            // departmentCodeTextBox
            // 
            this.departmentCodeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.departmentCodeTextBox.BaseColor = System.Drawing.Color.White;
            this.departmentCodeTextBox.BorderColor = System.Drawing.Color.Gray;
            this.departmentCodeTextBox.BorderSize = 1;
            this.departmentCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.departmentCodeTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.departmentCodeTextBox.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.departmentCodeTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.departmentCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.departmentCodeTextBox.Location = new System.Drawing.Point(22, 265);
            this.departmentCodeTextBox.Name = "departmentCodeTextBox";
            this.departmentCodeTextBox.PasswordChar = '\0';
            this.departmentCodeTextBox.Radius = 3;
            this.departmentCodeTextBox.SelectedText = "";
            this.departmentCodeTextBox.Size = new System.Drawing.Size(492, 41);
            this.departmentCodeTextBox.TabIndex = 134;
            this.departmentCodeTextBox.TextChanged += new System.EventHandler(this.departmentCodeTextBox_TextChanged);
            // 
            // depHeadTextBox
            // 
            this.depHeadTextBox.BackColor = System.Drawing.Color.Transparent;
            this.depHeadTextBox.BaseColor = System.Drawing.Color.White;
            this.depHeadTextBox.BorderColor = System.Drawing.Color.Gray;
            this.depHeadTextBox.BorderSize = 1;
            this.depHeadTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.depHeadTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.depHeadTextBox.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.depHeadTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.depHeadTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.depHeadTextBox.Location = new System.Drawing.Point(22, 172);
            this.depHeadTextBox.Name = "depHeadTextBox";
            this.depHeadTextBox.PasswordChar = '\0';
            this.depHeadTextBox.Radius = 3;
            this.depHeadTextBox.SelectedText = "";
            this.depHeadTextBox.Size = new System.Drawing.Size(492, 41);
            this.depHeadTextBox.TabIndex = 132;
            this.depHeadTextBox.TextChanged += new System.EventHandler(this.depHeadTextBox_TextChanged);
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.BackColor = System.Drawing.Color.Transparent;
            this.departmentTextBox.BaseColor = System.Drawing.Color.White;
            this.departmentTextBox.BorderColor = System.Drawing.Color.Gray;
            this.departmentTextBox.BorderSize = 1;
            this.departmentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.departmentTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.departmentTextBox.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.departmentTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.departmentTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.departmentTextBox.Location = new System.Drawing.Point(22, 88);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.PasswordChar = '\0';
            this.departmentTextBox.Radius = 3;
            this.departmentTextBox.SelectedText = "";
            this.departmentTextBox.Size = new System.Drawing.Size(492, 41);
            this.departmentTextBox.TabIndex = 131;
            this.departmentTextBox.TextChanged += new System.EventHandler(this.departmentTextBox_TextChanged_1);
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.cancelButton.CustomizableEdges = borderEdges1;
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
            this.cancelButton.Location = new System.Drawing.Point(404, 352);
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
            this.cancelButton.TabIndex = 36;
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelButton.TextMarginLeft = 0;
            this.cancelButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.cancelButton.UseDefaultRadiusAndThickness = true;
            this.cancelButton.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.AllowAnimations = true;
            this.addDepartmentButton.AllowMouseEffects = true;
            this.addDepartmentButton.AllowToggling = false;
            this.addDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDepartmentButton.AnimationSpeed = 200;
            this.addDepartmentButton.AutoGenerateColors = false;
            this.addDepartmentButton.AutoRoundBorders = false;
            this.addDepartmentButton.AutoSizeLeftIcon = true;
            this.addDepartmentButton.AutoSizeRightIcon = true;
            this.addDepartmentButton.BackColor = System.Drawing.Color.Transparent;
            this.addDepartmentButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addDepartmentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addDepartmentButton.BackgroundImage")));
            this.addDepartmentButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addDepartmentButton.ButtonText = "Add";
            this.addDepartmentButton.ButtonTextMarginLeft = 0;
            this.addDepartmentButton.ColorContrastOnClick = 45;
            this.addDepartmentButton.ColorContrastOnHover = 45;
            this.addDepartmentButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.addDepartmentButton.CustomizableEdges = borderEdges2;
            this.addDepartmentButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addDepartmentButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addDepartmentButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addDepartmentButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addDepartmentButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.addDepartmentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.addDepartmentButton.ForeColor = System.Drawing.Color.White;
            this.addDepartmentButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDepartmentButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addDepartmentButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.addDepartmentButton.IconMarginLeft = 11;
            this.addDepartmentButton.IconPadding = 10;
            this.addDepartmentButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addDepartmentButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addDepartmentButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.addDepartmentButton.IconSize = 25;
            this.addDepartmentButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addDepartmentButton.IdleBorderRadius = 5;
            this.addDepartmentButton.IdleBorderThickness = 1;
            this.addDepartmentButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addDepartmentButton.IdleIconLeftImage = null;
            this.addDepartmentButton.IdleIconRightImage = null;
            this.addDepartmentButton.IndicateFocus = true;
            this.addDepartmentButton.Location = new System.Drawing.Point(315, 352);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addDepartmentButton.OnDisabledState.BorderRadius = 5;
            this.addDepartmentButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addDepartmentButton.OnDisabledState.BorderThickness = 1;
            this.addDepartmentButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addDepartmentButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addDepartmentButton.OnDisabledState.IconLeftImage = null;
            this.addDepartmentButton.OnDisabledState.IconRightImage = null;
            this.addDepartmentButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addDepartmentButton.onHoverState.BorderRadius = 5;
            this.addDepartmentButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addDepartmentButton.onHoverState.BorderThickness = 1;
            this.addDepartmentButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.addDepartmentButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addDepartmentButton.onHoverState.IconLeftImage = null;
            this.addDepartmentButton.onHoverState.IconRightImage = null;
            this.addDepartmentButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addDepartmentButton.OnIdleState.BorderRadius = 5;
            this.addDepartmentButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addDepartmentButton.OnIdleState.BorderThickness = 1;
            this.addDepartmentButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addDepartmentButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.addDepartmentButton.OnIdleState.IconLeftImage = null;
            this.addDepartmentButton.OnIdleState.IconRightImage = null;
            this.addDepartmentButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addDepartmentButton.OnPressedState.BorderRadius = 5;
            this.addDepartmentButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addDepartmentButton.OnPressedState.BorderThickness = 1;
            this.addDepartmentButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addDepartmentButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.addDepartmentButton.OnPressedState.IconLeftImage = null;
            this.addDepartmentButton.OnPressedState.IconRightImage = null;
            this.addDepartmentButton.Size = new System.Drawing.Size(83, 39);
            this.addDepartmentButton.TabIndex = 35;
            this.addDepartmentButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addDepartmentButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addDepartmentButton.TextMarginLeft = 0;
            this.addDepartmentButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.addDepartmentButton.UseDefaultRadiusAndThickness = true;
            this.addDepartmentButton.Click += new System.EventHandler(this.addDepartmentButton_Click);
            // 
            // AddDepartmentUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 403);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDepartmentUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDepartmentUi";
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label personnelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label depCodeErrorLabel;
        private System.Windows.Forms.Label departmentNameErrorLabel;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label depHeadErrorLabel;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton cancelButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addDepartmentButton;
        private Guna.UI.WinForms.GunaTextBox departmentTextBox;
        private Guna.UI.WinForms.GunaTextBox departmentCodeTextBox;
        private Guna.UI.WinForms.GunaTextBox depHeadTextBox;
    }
}