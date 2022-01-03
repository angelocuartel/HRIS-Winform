using EISProject.DataBaseFunctions;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EISProject.Modals
{
    public partial class ViewEditUser : Form
    {
        private HRIS_Account_Table accountUser;
        private static DataGridAction<Log_History_Table> historyGridObj ;
        private string selectedImagePath = string.Empty;
        private Bunifu.UI.WinForms.BunifuPictureBox picture;

        public ViewEditUser(HRIS_Account_Table user, Bunifu.UI.WinForms.BunifuPictureBox picture)
        {
            InitializeComponent();
            this.accountUser = user;
            this.picture = picture;

            hrisAccountIdLabel.Text = user.hris_account_id.ToString();
            accountStatusLabel.Text = user.account_status;
            userTextbox.Text = user.username;
            passwordTextBox.Text = user.password;
            accessLevelComboTextBox.Text = user.access_level;
            userAccountPictureBox.Image = new Bitmap(user.profile_picture);

            SetStatusAccount();


            saveBtn.Visible = false;

            if (picture == null)
            {
                SetAccessLevelControl(true);
                
                
            }
            else 
            {
                statusBtn.Visible = false;
                SetAccessLevelControl(false);
            }

        }

        private void SetAccessLevelControl(bool isShow)
        {
             EditAccessLevelPictureBox.Visible = accessLevelLabel.Visible = accessLevelComboTextBox.Visible = isShow;
        }

   

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
              if(!passwordTextBox.ReadOnly && retypePasswordTextBox.Text != passwordTextBox.Text)
                {
                    bunifuSnackbar1.Show(this, "Password do not match!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
              else if(!userTextbox.ReadOnly && dbModel.HRIS_Account_Table.Where(i =>i.username == userTextbox.Text).SingleOrDefault() != null)
                {
                    bunifuSnackbar1.Show(this, "Username is already taken!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
              else if(adminPasswordTextBox.Text != SystemUser.UserAccount.password)
                {
                    bunifuSnackbar1.Show(this, "Administrator password is invalid", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
              else
                {
                    this.accountUser.username = userTextbox.Text;
                    this.accountUser.password = passwordTextBox.Text;
                    this.accountUser.access_level = accessLevelComboTextBox.Enabled ? accessLevelComboTextBox.Text : this.accountUser.access_level;

                    if (this.selectedImagePath != string.Empty)
                    {
                        this.accountUser.profile_picture = UpdateProfile();
                    }

                    
                       

                    dbModel.Entry(this.accountUser).State = System.Data.Entity.EntityState.Modified;
                    dbModel.SaveChanges();

                    if(this.picture != null)
                    SystemUser.UserAccount = this.accountUser;
                    else
                    UpdateSystemUserList(dbModel);

                    bunifuSnackbar1.Show(this, "Successfully Updated UserAccount", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    userTextbox.ReadOnly = passwordTextBox.ReadOnly = true;
                   saveBtn.Visible = adminPassLabel.Visible = adminPasswordTextBox.Visible = retypePassLabel.Visible = retypePasswordTextBox.Visible = false;

                    await ControlForms.SystemUserAccountUi.SystemAccountGridObj.PopulateGridView(ControlForms.SystemUserAccountUi.SystemAccountGridObj.fullList = dbModel.HRIS_Account_Table.Where(i => i.hris_account_id != DataBaseFunctions.SystemUser.UserAccount.hris_account_id && (DataBaseFunctions.SystemUser.UserAccount.access_level == "Primary Administrator" ? i.access_level != "Primary Administrator" : i.access_level == "HR")).ToList());

                }
            }
        }



        private void editPasswordPictureBox_Click_1(object sender, EventArgs e)
        {
            saveBtn.Visible = adminPassLabel.Visible = adminPasswordTextBox.Visible = retypePassLabel.Visible = retypePasswordTextBox.Visible = true;
            passwordTextBox.ReadOnly = false;
            passwordTextBox.Focus();
        }

        private void EditAccessLevelPictureBox_Click_1(object sender, EventArgs e)
        {
            accessLevelComboTextBox.Enabled = true;
            saveBtn.Visible = adminPassLabel.Visible = adminPasswordTextBox.Visible = true;
        }

        private void editUserPictureBox_Click_1(object sender, EventArgs e)
        {
            userTextbox.ReadOnly = false;
            userTextbox.Focus();
            saveBtn.Visible = adminPassLabel.Visible = adminPasswordTextBox.Visible = true;
        }

        private void SetStatusAccount()
        {
            statusBtn.Text = this.accountUser.account_status == "DEACTIVATED" ? "Activate" : "Deactivate";
        }

        private void userAccountPictureBox_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            if(statusBtn.Text == "Activate")
            {
                UpdateAccountStatus("ACTIVE");
                statusBtn.Text = "Deactivate";
            }
            else
            {
                UpdateAccountStatus("DEACTIVATED");
                statusBtn.Text = "Activate";
            }

            bunifuSnackbar1.Show(this, "Account Status Updated",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
        }

        private void UpdateAccountStatus(string status)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                this.accountUser.account_status = status;
                dbModel.Entry(this.accountUser).State = System.Data.Entity.EntityState.Modified;
                dbModel.SaveChanges();

                UpdateSystemUserList(dbModel);
            }
        }

        private void UpdateSystemUserList(EmployeeInformationSystemDataBaseEntities dbModel)
        {
            ControlForms.SystemUserAccountUi.SystemAccountGridObj
                  .PopulateGridView(ControlForms.SystemUserAccountUi
                  .SystemAccountGridObj.fullList = dbModel.HRIS_Account_Table
                  .Where(i => i.hris_account_id != SystemUser.UserAccount.hris_account_id)
                  .ToList());
        }

        private void userAccountPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void uploadPictureBtn_Click(object sender, EventArgs e)
        {
            using (var openfile = new OpenFileDialog())
            {
                openfile.Filter ="Png Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg"; 

                if(openfile.ShowDialog() == DialogResult.OK)
                {
                    this.selectedImagePath = openfile.FileName;
                    userAccountPictureBox.Image.Dispose();
                    saveBtn.Visible = true;
                    userAccountPictureBox.Image = new Bitmap(this.selectedImagePath);
                    adminPassLabel.Visible = adminPasswordTextBox.Visible = true;
                }
            }
        }


        private string UpdateProfile()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.IO.File.Delete(this.accountUser.profile_picture);
            System.IO.File.Copy(this.selectedImagePath, this.accountUser.profile_picture);

            return this.accountUser.profile_picture;
           
   
        }

        private async void ViewEditUser_Load(object sender, EventArgs e)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                historyGridObj = new DataGridAction<Log_History_Table>(historyLabel, totalRecordsLabel, logHistoryDataGridView, dbModel.Log_History_Table.Where(i => i.employee_id == this.accountUser.hris_account_id).ToList());
                await historyGridObj.PopulateGridView(historyGridObj.fullList);
            }
           
        }

        private async void logHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (logHistoryDataGridView.Columns[e.ColumnIndex].Name == "Delete" && logHistoryDataGridView.Rows.Count > 0)
            {
                if (MessageBox.Show("Do you want To Delete this history ?", "Delete History", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        var id = int.Parse(logHistoryDataGridView.CurrentRow.Cells[0].Value.ToString());

                        var logItem = dbModel.Log_History_Table.Where(i => i.log_id == id).SingleOrDefault();

                        dbModel.Entry(logItem).State = System.Data.Entity.EntityState.Deleted;
                        dbModel.SaveChanges();

                        await historyGridObj.PopulateGridView(historyGridObj.fullList = dbModel.Log_History_Table.Where(i =>i.employee_id == this.accountUser.hris_account_id).ToList());

                    }
                }
            }
        }

        private async void filterButtton_Click(object sender, EventArgs e)
        {
            await historyGridObj.PopulateGridView(historyGridObj.fullList
                  .Where(i => DateTime.Parse(i.login_date.ToString()).ToLongDateString().Contains(yearDatePicker.Value.ToString("yyyy"))
                  && DateTime.Parse(i.login_date.ToString()).ToLongDateString().Contains(monthDatePicker.Value.ToString("MMMM")) && i.employee_id == this.accountUser.hris_account_id).ToList());
        }

        private async void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove all history ?", "Delete History", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await RemoveAllLogHistory();
            }
        }


        private  Task RemoveAllLogHistory()
        {
            return Task.Run(() => {

                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {

                    var logItems = dbModel.Log_History_Table.Where(i => i.employee_id == this.accountUser.hris_account_id).ToList();
                    dbModel.Log_History_Table.RemoveRange(logItems);
                    dbModel.SaveChanges();

                    historyGridObj.PopulateGridView(historyGridObj.fullList = dbModel.Log_History_Table.Where(i => i.employee_id == this.accountUser.hris_account_id).ToList());
                    
                }

            });
        }

        private async void logHistoryDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await historyGridObj.SortGridView(logHistoryDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
    
}
