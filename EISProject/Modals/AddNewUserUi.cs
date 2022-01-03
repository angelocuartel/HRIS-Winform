using System;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EISProject.Modals
{
    public partial class AddNewUserUi : Form
    {
        private string imagePath = string.Empty;
       
        public AddNewUserUi()
        {
            InitializeComponent();

            passwordNotMatchLabel.Visible = false;

            accessLevelComboBox.DataSource = DataBaseFunctions.SystemUser.UserAccount.access_level == "Administrator" ? new List<string>() { "HR" } : new List<string>() { "Administrator", "HR" };
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void addAttendanceButton_Click(object sender, EventArgs e)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                if (retypePasswordTextBox.Text != passwordTextBox.Text)
                {
                    bunifuSnackbar1.Show(this, "Password do not match!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                   passwordTextBox.BorderColor =  retypePasswordTextBox.BorderColor = Color.Red;
                }
                else if (yourPasswordTextBox.Text != DataBaseFunctions.SystemUser.UserAccount.password)
                {
                    bunifuSnackbar1.Show(this, "Invalid Administrator password", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else if(dbModel.HRIS_Account_Table.Where(i =>i.username == usernameTextBox.Text).SingleOrDefault() != null)
                {
                    bunifuSnackbar1.Show(this, "username is already taken", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    var imageStoragePath = $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 6)}\accountImages\{usernameTextBox.Text}.png";
                    System.IO.File.Copy(SetProfilePicture(), imageStoragePath);
                    var hrisAccount = new HRIS_Account_Table()
                    {
                        username = usernameTextBox.Text,
                        password = passwordTextBox.Text,
                        date_added = DateTime.Today,
                        profile_picture =SetProfilePicture() == string.Empty ? SetProfilePicture() : imageStoragePath,
                        access_level = accessLevelComboBox.Text,
                        account_status = "ACTIVE"


                    };

                    dbModel.HRIS_Account_Table.Add(hrisAccount);
                    try
                    {
                        dbModel.SaveChanges();
                    }
                       


                      catch (DbEntityValidationException ex)
                    {
                        foreach (var eve in ex.EntityValidationErrors)
                        {
                            MessageBox.Show($"Entity of type \"{  eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:");
                            foreach (var ve in eve.ValidationErrors)
                            {
                                MessageBox.Show($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}");
                            }
                        }
                    }


                    await ControlForms.SystemUserAccountUi.SystemAccountGridObj.PopulateGridView(ControlForms.SystemUserAccountUi.SystemAccountGridObj.fullList = dbModel.HRIS_Account_Table.Where(i => i.hris_account_id != DataBaseFunctions.SystemUser.UserAccount.hris_account_id && (DataBaseFunctions.SystemUser.UserAccount.access_level == "Primary Administrator" ? i.access_level != "Primary Administrator" : i.access_level == "HR")).ToList());
                    new NotificationUi("Successfully add new user", NotificationUi.NotificationType.restore);
                    this.Close();

                }
            }

           
           
            
        }

        private string SetProfilePicture()
        {
            if (this.imagePath == string.Empty)
                return $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 6)}\default-image.png";
            else
                return this.imagePath;
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            using (var openfile = new OpenFileDialog())
            {
                openfile.Filter = "Png Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg";
                if(openfile.ShowDialog() == DialogResult.OK)
                {
                    this.imagePath = openfile.FileName;
                    userPictureBox.Image = new Bitmap(openfile.FileName);
                }
            }
        }

        private void retypePasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (retypePasswordTextBox.BorderColor != Color.Gray)
                retypePasswordTextBox.BorderColor = Color.Gray;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if(passwordTextBox.BorderColor != Color.Gray)
            passwordTextBox.BorderColor = Color.Gray;
        }
    }
}
