namespace EISProject
{
    partial class LoginUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUi));
            this.Loginbtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.usernameLblError = new System.Windows.Forms.Label();
            this.passwordLblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTxtbox = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordTxtbox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginbtn
            // 
            this.Loginbtn.Animated = true;
            this.Loginbtn.AnimationHoverSpeed = 0.07F;
            this.Loginbtn.AnimationSpeed = 0.03F;
            this.Loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.Loginbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.Loginbtn.BorderColor = System.Drawing.Color.Black;
            this.Loginbtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Loginbtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.Loginbtn.CheckedForeColor = System.Drawing.Color.White;
            this.Loginbtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Loginbtn.CheckedImage")));
            this.Loginbtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Loginbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Loginbtn.FocusedColor = System.Drawing.Color.Empty;
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Image = null;
            this.Loginbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.Loginbtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.Loginbtn.Location = new System.Drawing.Point(443, 388);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.Loginbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Loginbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.Loginbtn.OnHoverImage = null;
            this.Loginbtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.Loginbtn.OnPressedColor = System.Drawing.Color.Black;
            this.Loginbtn.Radius = 15;
            this.Loginbtn.Size = new System.Drawing.Size(203, 36);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // usernameLblError
            // 
            this.usernameLblError.BackColor = System.Drawing.SystemColors.Control;
            this.usernameLblError.ForeColor = System.Drawing.Color.Red;
            this.usernameLblError.Location = new System.Drawing.Point(431, 240);
            this.usernameLblError.Name = "usernameLblError";
            this.usernameLblError.Size = new System.Drawing.Size(301, 19);
            this.usernameLblError.TabIndex = 6;
            this.usernameLblError.Text = "Error";
            this.usernameLblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameLblError.Visible = false;
            // 
            // passwordLblError
            // 
            this.passwordLblError.BackColor = System.Drawing.SystemColors.Control;
            this.passwordLblError.ForeColor = System.Drawing.Color.Red;
            this.passwordLblError.Location = new System.Drawing.Point(432, 338);
            this.passwordLblError.Name = "passwordLblError";
            this.passwordLblError.Size = new System.Drawing.Size(302, 23);
            this.passwordLblError.TabIndex = 7;
            this.passwordLblError.Text = "Error";
            this.passwordLblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordLblError.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 467);
            this.panel1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(132, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "All Rights Reserved 2020";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(26, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "EMPLOYEE INFORMATION SYSTEM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(189, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "TO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(46, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "WELCOME";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(240, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 106);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(429, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login to your Account";
            // 
            // usernameTxtbox
            // 
            this.usernameTxtbox.BackColor = System.Drawing.Color.Transparent;
            this.usernameTxtbox.BaseColor = System.Drawing.Color.White;
            this.usernameTxtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.usernameTxtbox.BorderSize = 1;
            this.usernameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxtbox.FocusedBaseColor = System.Drawing.Color.White;
            this.usernameTxtbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.usernameTxtbox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.usernameTxtbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.usernameTxtbox.Location = new System.Drawing.Point(434, 195);
            this.usernameTxtbox.Name = "usernameTxtbox";
            this.usernameTxtbox.PasswordChar = '\0';
            this.usernameTxtbox.Radius = 15;
            this.usernameTxtbox.SelectedText = "";
            this.usernameTxtbox.Size = new System.Drawing.Size(288, 30);
            this.usernameTxtbox.TabIndex = 12;
            this.usernameTxtbox.Leave += new System.EventHandler(this.usernameTxtbox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label7.Location = new System.Drawing.Point(439, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enter UserName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label8.Location = new System.Drawing.Point(439, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Enter Password";
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTxtbox.BaseColor = System.Drawing.Color.White;
            this.passwordTxtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.passwordTxtbox.BorderSize = 1;
            this.passwordTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxtbox.FocusedBaseColor = System.Drawing.Color.White;
            this.passwordTxtbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.passwordTxtbox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.passwordTxtbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.passwordTxtbox.Location = new System.Drawing.Point(434, 300);
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.PasswordChar = '●';
            this.passwordTxtbox.Radius = 15;
            this.passwordTxtbox.SelectedText = "";
            this.passwordTxtbox.Size = new System.Drawing.Size(288, 30);
            this.passwordTxtbox.TabIndex = 14;
            this.passwordTxtbox.UseSystemPasswordChar = true;
            this.passwordTxtbox.Leave += new System.EventHandler(this.passwordTxtbox_Leave);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(798, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 16;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.gunaAnimateWindow1.Interval = 100;
            this.gunaAnimateWindow1.TargetControl = this;
            // 
            // LoginUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 467);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passwordTxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.usernameTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwordLblError);
            this.Controls.Add(this.usernameLblError);
            this.Controls.Add(this.Loginbtn);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginUi";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton Loginbtn;
        private System.Windows.Forms.Label usernameLblError;
        private System.Windows.Forms.Label passwordLblError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox usernameTxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox passwordTxtbox;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
    }
}

