using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Guna.UI.WinForms;

namespace EISProject
{
    public partial class LoginUi : Form
    {
        InputValidator validator;
        public LoginUi()
        {
            validator = new InputValidator();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GunaDragControl dragControl = new GunaDragControl();
            dragControl.TargetControl = this;
            new GunaElipse().TargetControl = this;
            gunaAnimateWindow1.Start();
            
        }

        private void usernameTxtbox_Leave(object sender, EventArgs e)
        {
            validator.ValidateIntegerInput(usernameTxtbox.Text,usernameTxtbox,usernameLblError);
        }

        private void passwordTxtbox_Leave(object sender, EventArgs e)
        {
            validator.ValidateCustomInput(passwordTxtbox.Text, passwordTxtbox, passwordLblError, false, true, true, 10);
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (validator.AreAllNotValid())
            {
                MessageBox.Show("please check your all inputs");
            }
            else
            {
                using(var model = new EISDbEntities())
                {
                    var account = model.Accounts_Tbl.Where(c => usernameTxtbox.Text == c.employee_id.ToString() && passwordTxtbox.Text == c.password).FirstOrDefault();

                    if (account != null)
                    {
                        this.Hide();
                        new Modals.LoadingForm().Show();
                    }
                    else MessageBox.Show("no data found!");
                }

            }
        }
    }
}
