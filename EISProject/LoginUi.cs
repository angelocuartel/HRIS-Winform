using System;
using System.Windows.Forms;
using SharpValidation;
using Guna.UI.WinForms;
using EISProject.DataBaseFunctions;
using System.Linq;
using System.Threading;
using System.Drawing;

namespace EISProject
{
    public partial class LoginUi : Form
    {
        Validator validator;

        bool isDeactivated = false;
        bool isNull = false;
        Modals.LoggingINUi loadingForm = new Modals.LoggingINUi();
        public LoginUi()
        {
            InitializeComponent();


            new Settings(logoPictureBox, titleTextLabel).InitializeSystemSettings();


            validator = new Validator(new System.Collections.Generic.Dictionary<Control, Label>() { {usernameTxtbox,usernameLblError } });
            validator.ValidTextBoxCustomColor = Color.SeaGreen;
            gunaAnimateWindow1.Start();
        }
       private void LoadScreen()
        {
            Application.Run(new Modals.LoggingINUi());
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (validator.AreAllNotValid())
            {
                bunifuSnackbar1.Show(this, "Please check all your Input", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

                ValidatePassword();
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();

                loadingForm.ShowDialog();
                
              

            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2CheckBox1.Checked == true)
                passwordTxtbox.UseSystemPasswordChar = false;
            else
                passwordTxtbox.UseSystemPasswordChar = true;
        }

      
    


        private void gunaLineTextBox2_Enter(object sender, EventArgs e)
        {
            passwordTxtbox.Focus();
        }

        private void usernameTxtbox_TextChanged(object sender, EventArgs e)
        {
            validator.ValidateCustomInput(usernameTxtbox, false, true, true, 0, 16);
        }

        private void passwordTxtbox_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
        }

        private bool HasSymbols()
        {
            foreach (var let in passwordTxtbox.Text)
            {
                if (char.IsSymbol(let))
                {
                    return true;
                }
               

            }

            return false;
        }


        private void ValidatePassword()
        {
            if (passwordTxtbox.Text == string.Empty)
            {
                gunaLineTextBox2.LineColor = System.Drawing.Color.Red;
                passwordLblError.Text = "This field should not be empty";
                passwordLblError.ForeColor = System.Drawing.Color.Red;

            }
            else if (HasSymbols())
            {
                gunaLineTextBox2.LineColor =Color.Red;
                passwordLblError.Text = "This field should not contain symbols";
                passwordLblError.ForeColor = Color.Red;
            }
            else
            {
                gunaLineTextBox2.LineColor = System.Drawing.Color.SeaGreen;
                passwordLblError.Text = "valid";
                passwordLblError.ForeColor = System.Drawing.Color.SeaGreen;

            }

            passwordLblError.Visible = true;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {


            var account = SystemAccount();

            if (account != null && account.account_status == "ACTIVE")
            {
                SystemUser.LogInDate = DateTime.Today;
                SystemUser.LoginTime = DateTime.Now.ToLongTimeString();
                SystemUser.UserAccount = account;

                isNull = false;
                

            }
            else if (account != null && account.account_status == "DEACTIVATED")
            {
                isDeactivated = true;
            }
            else if (account == null)
            {
                isNull = true;
            }




        }

        private HRIS_Account_Table SystemAccount()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                return dbModel.HRIS_Account_Table.Where(i => i.username == usernameTxtbox.Text.Trim() && i.password == passwordTxtbox.Text).SingleOrDefault();
            }
        }       


        private void ValidateUserNamePassword()
        {
            if (isDeactivated)
            {
                loadingForm.Close();
                isDeactivated = false;
                bunifuSnackbar1.Show(this, "Cannot login account is deactivated, please contact the administrator Thank you", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            else if (isNull)
            {
                loadingForm.Close();
                isNull = false;
                bunifuSnackbar1.Show(this, "Invalid Username or Password", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }

            else if (!isNull)
            {
                loadingForm.Dispose();
                bunifuSnackbar1.CloseAll();
                this.Hide();
                new EISMainForm().Show();
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

           
            ValidateUserNamePassword();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DtrUi().Show();
        }

        private async void LoginUi_Load(object sender, EventArgs e)
        {
            await EmployeeEntity.CheckSuspendedEmployee();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
