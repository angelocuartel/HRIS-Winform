namespace EISProject.Modals
{
    partial class AddAllowanceUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAllowanceUi));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.allowanceTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amountTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.addAttendanceButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.allowanceTextBox);
            this.gunaLinePanel1.Controls.Add(this.label2);
            this.gunaLinePanel1.Controls.Add(this.amountTextBox);
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.label5);
            this.gunaLinePanel1.Controls.Add(this.cancelButton);
            this.gunaLinePanel1.Controls.Add(this.addAttendanceButton);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Silver;
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 1;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(453, 381);
            this.gunaLinePanel1.TabIndex = 138;
            // 
            // allowanceTextBox
            // 
            this.allowanceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.allowanceTextBox.BaseColor = System.Drawing.Color.White;
            this.allowanceTextBox.BorderColor = System.Drawing.Color.Gray;
            this.allowanceTextBox.BorderSize = 1;
            this.allowanceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.allowanceTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.allowanceTextBox.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.allowanceTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.allowanceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.allowanceTextBox.Location = new System.Drawing.Point(12, 134);
            this.allowanceTextBox.Name = "allowanceTextBox";
            this.allowanceTextBox.PasswordChar = '\0';
            this.allowanceTextBox.Radius = 3;
            this.allowanceTextBox.SelectedText = "";
            this.allowanceTextBox.Size = new System.Drawing.Size(425, 41);
            this.allowanceTextBox.TabIndex = 145;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 144;
            this.label2.Text = "Allowance Name";
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.Color.Transparent;
            this.amountTextBox.BaseColor = System.Drawing.Color.White;
            this.amountTextBox.BorderColor = System.Drawing.Color.Gray;
            this.amountTextBox.BorderSize = 1;
            this.amountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.amountTextBox.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.amountTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.amountTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.amountTextBox.Location = new System.Drawing.Point(12, 224);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.PasswordChar = '\0';
            this.amountTextBox.Radius = 3;
            this.amountTextBox.SelectedText = "";
            this.amountTextBox.Size = new System.Drawing.Size(425, 41);
            this.amountTextBox.TabIndex = 143;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ratePerHourTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 142;
            this.label1.Text = "Amount";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(405, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 130;
            this.label5.Text = "Allowance";
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.cancelButton.CustomizableEdges = borderEdges3;
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
            this.cancelButton.Location = new System.Drawing.Point(331, 330);
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
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addAttendanceButton
            // 
            this.addAttendanceButton.AllowAnimations = true;
            this.addAttendanceButton.AllowMouseEffects = true;
            this.addAttendanceButton.AllowToggling = false;
            this.addAttendanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAttendanceButton.AnimationSpeed = 200;
            this.addAttendanceButton.AutoGenerateColors = false;
            this.addAttendanceButton.AutoRoundBorders = false;
            this.addAttendanceButton.AutoSizeLeftIcon = true;
            this.addAttendanceButton.AutoSizeRightIcon = true;
            this.addAttendanceButton.BackColor = System.Drawing.Color.Transparent;
            this.addAttendanceButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addAttendanceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addAttendanceButton.BackgroundImage")));
            this.addAttendanceButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addAttendanceButton.ButtonText = "Add";
            this.addAttendanceButton.ButtonTextMarginLeft = 0;
            this.addAttendanceButton.ColorContrastOnClick = 45;
            this.addAttendanceButton.ColorContrastOnHover = 45;
            this.addAttendanceButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.addAttendanceButton.CustomizableEdges = borderEdges4;
            this.addAttendanceButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addAttendanceButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addAttendanceButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addAttendanceButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addAttendanceButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.addAttendanceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.addAttendanceButton.ForeColor = System.Drawing.Color.White;
            this.addAttendanceButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAttendanceButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addAttendanceButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.addAttendanceButton.IconMarginLeft = 11;
            this.addAttendanceButton.IconPadding = 10;
            this.addAttendanceButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addAttendanceButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addAttendanceButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.addAttendanceButton.IconSize = 25;
            this.addAttendanceButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addAttendanceButton.IdleBorderRadius = 5;
            this.addAttendanceButton.IdleBorderThickness = 1;
            this.addAttendanceButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addAttendanceButton.IdleIconLeftImage = null;
            this.addAttendanceButton.IdleIconRightImage = null;
            this.addAttendanceButton.IndicateFocus = true;
            this.addAttendanceButton.Location = new System.Drawing.Point(242, 330);
            this.addAttendanceButton.Name = "addAttendanceButton";
            this.addAttendanceButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addAttendanceButton.OnDisabledState.BorderRadius = 5;
            this.addAttendanceButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addAttendanceButton.OnDisabledState.BorderThickness = 1;
            this.addAttendanceButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addAttendanceButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addAttendanceButton.OnDisabledState.IconLeftImage = null;
            this.addAttendanceButton.OnDisabledState.IconRightImage = null;
            this.addAttendanceButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addAttendanceButton.onHoverState.BorderRadius = 5;
            this.addAttendanceButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addAttendanceButton.onHoverState.BorderThickness = 1;
            this.addAttendanceButton.onHoverState.FillColor = System.Drawing.Color.White;
            this.addAttendanceButton.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addAttendanceButton.onHoverState.IconLeftImage = null;
            this.addAttendanceButton.onHoverState.IconRightImage = null;
            this.addAttendanceButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addAttendanceButton.OnIdleState.BorderRadius = 5;
            this.addAttendanceButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addAttendanceButton.OnIdleState.BorderThickness = 1;
            this.addAttendanceButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addAttendanceButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.addAttendanceButton.OnIdleState.IconLeftImage = null;
            this.addAttendanceButton.OnIdleState.IconRightImage = null;
            this.addAttendanceButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addAttendanceButton.OnPressedState.BorderRadius = 5;
            this.addAttendanceButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addAttendanceButton.OnPressedState.BorderThickness = 1;
            this.addAttendanceButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addAttendanceButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.addAttendanceButton.OnPressedState.IconLeftImage = null;
            this.addAttendanceButton.OnPressedState.IconRightImage = null;
            this.addAttendanceButton.Size = new System.Drawing.Size(83, 39);
            this.addAttendanceButton.TabIndex = 35;
            this.addAttendanceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addAttendanceButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addAttendanceButton.TextMarginLeft = 0;
            this.addAttendanceButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.addAttendanceButton.UseDefaultRadiusAndThickness = true;
            this.addAttendanceButton.Click += new System.EventHandler(this.addAttendanceButton_Click);
            // 
            // AddAllowanceUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 381);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAllowanceUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAllowanceUi";
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton cancelButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addAttendanceButton;
        private Guna.UI.WinForms.GunaTextBox allowanceTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox amountTextBox;
        private System.Windows.Forms.Label label1;
    }
}