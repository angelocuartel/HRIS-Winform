namespace EISProject.ControlForms
{
    partial class AddedSuccessUi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddedSuccessUi));
            this.successPictureBox = new System.Windows.Forms.PictureBox();
            this.successLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // successPictureBox
            // 
            this.successPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("successPictureBox.Image")));
            this.successPictureBox.Location = new System.Drawing.Point(299, 50);
            this.successPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.successPictureBox.Name = "successPictureBox";
            this.successPictureBox.Size = new System.Drawing.Size(215, 149);
            this.successPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.successPictureBox.TabIndex = 6;
            this.successPictureBox.TabStop = false;
            // 
            // successLbl
            // 
            this.successLbl.AutoSize = true;
            this.successLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.successLbl.Location = new System.Drawing.Point(234, 212);
            this.successLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.successLbl.Name = "successLbl";
            this.successLbl.Size = new System.Drawing.Size(333, 32);
            this.successLbl.TabIndex = 5;
            this.successLbl.Text = "Successfully Added Employee";
            // 
            // AddedSuccessUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.successPictureBox);
            this.Controls.Add(this.successLbl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddedSuccessUi";
            this.Size = new System.Drawing.Size(810, 381);
            this.Load += new System.EventHandler(this.AddedSuccessUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox successPictureBox;
        private System.Windows.Forms.Label successLbl;
    }
}
