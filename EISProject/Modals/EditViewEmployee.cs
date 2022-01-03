using EISProject.DataBaseFunctions;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;

using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EISProject.Modals
{
    public partial class EditViewEmployee : Form
    {
        Employee_Information_Table employee;
        string newImagePath = string.Empty;
        DataGridAction<Log_History_Table> logGridObj;
        DataGridAction<Employee_Attendance_Table> attendanceGridObj;
        DataGridAction<Payroll_Table> payslipGridObj;
        List<Control> inputControls;
        private bool InfoHasChanged;
        Employee_Portal_Accounts_Table account;
        bool isUsernameChanged;
        public EditViewEmployee(Employee_Information_Table employee)
        {

            new Thread(new ThreadStart(() => { Application.Run(new Modals.AddedSuccess()); })).Start();
            InitializeComponent();

            guna2ShadowForm1.SetShadowForm(this);


            

            this.employee = employee;

            this.account = GetUserAccount();


            LoadEmployeeChart();
            //load employee file
            LoadFileLayoutPanel();


            //load employee info
            LoadEmployeeInfo();
            employeeWorkIDLabel.Text = this.employee.employee_work_id;

            inputControls = new List<Control>
            {

            textbox_given_name,
            textbox_last_name,
            textbox_middle_name,
            textboox_age,
            textbox_nationality,
            textbox_religion,
            combo_box_gender,
            birthDatePicker,
            textbox_current_address,
            textbox_city,
            textbox_state,
            textbox_zip_code,
            brgyTextBox,
            textbox_house_lot_block_number,
            textbox_phone_number,
            textbox_telephone,
            positionComboBox,
            dateHiredPicker,
            textbox_work_location,
            textbox_SSS_number,
            textbox_TIN_number,
            textbox_philhealth_number,
            textbox_contract,
            combo_box_civil_status


        };


            EIS_BusinessLogic.LoadScreen.CloseLoadScreen((Modals.AddedSuccess)Application.OpenForms["AddedSuccess"]);

        }






        private Employee_Portal_Accounts_Table GetUserAccount()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                return dbModel.Employee_Portal_Accounts_Table.Where(i => i.employee_id == this.employee.employee_id).SingleOrDefault();
            }
        }

        private void LoadFileLayoutPanel()
        {

            

            flowLayoutFile.Controls.Clear();

            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var empFiles = dbModel.Employees_Documents_Table.Where(i => i.employee_id == employee.employee_id).ToList();

  

                if (empFiles.Count > 0 )
                {
                    noFilesLabel.Visible = false;

                    foreach (var file in empFiles)
                    {
                        AddFileITemToLayoutPanel(new ControlForms.fileItemUi(file));
                    }

                    if(empFiles.Count < 6)
                    {
                        addFileButton.Visible = true;
                    }
                    else
                    {

                        addFileButton.Visible = false;
                    }

                }

                else
                {
                    noFilesLabel.Visible = true;

                }

              


            }
        }



        private void AddFileITemToLayoutPanel(UserControl file)
        {
            flowLayoutFile.SuspendLayout();
            flowLayoutFile.Controls.Add(file);
            flowLayoutFile.ResumeLayout();
        }



        private async void LoadEmployeeInfo()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                logGridObj = new DataGridAction<Log_History_Table>(historyLabel, totalRecordsLabel, logHistoryDataGridView, dbModel.Log_History_Table.Where(i => i.employee_id == this.employee.employee_id).ToList());
                attendanceGridObj = new DataGridAction<Employee_Attendance_Table>(AttendanceEmptyLabel, attendanceTotalRecordLabel, attendanceDataGridView, dbModel.Employee_Attendance_Table.Where(i => i.employee_id == this.employee.employee_id && i.time_out != null).ToList());
                payslipGridObj = new DataGridAction<Payroll_Table>(payrollEmptyLabel, paylipTotalLabel, payrollDataGridView, dbModel.Payroll_Table.Where(i => i.employee_id == this.employee.employee_id).ToList());
                await payslipGridObj.PopulateGridView(payslipGridObj.fullList);
                await attendanceGridObj.PopulateGridView(attendanceGridObj.fullList);
                await logGridObj.PopulateGridView(logGridObj.fullList);

                positionComboBox.DataSource = dbModel.Employee_Positions_Table.Select(i => i.position).ToList();
            }

            employeePictureBox.Image = new Bitmap(employee.profile_picture);

        

            textbox_given_name.Text = employee.given_name;
            textbox_last_name.Text = employee.last_name;
            textbox_middle_name.Text = employee.middle_name;
            textboox_age.Text = employee.age.ToString();
            textbox_nationality.Text = employee.nationality;
            textbox_religion.Text = employee.Religion;
            combo_box_gender.Text = employee.gender;
            birthDatePicker.Text = employee.birth_date.GetValueOrDefault().ToLongDateString();
            textbox_current_address.Text = employee.current_address;
            textbox_city.Text = employee.city;
            textbox_state.Text = employee.state;
            textbox_zip_code.Text = employee.zip_code;
            brgyTextBox.Text = employee.brgy;
            textbox_house_lot_block_number.Text = employee.house_lot_block_number;
            textbox_phone_number.Text = employee.phone_number;
            textbox_telephone.Text = employee.telephone;
            textbox_email_address.Text = employee.email_address;
            positionComboBox.Text = employee.job_title;
            textbox_rate_per_hour.Text = decimal.Parse(employee.rate_per_hour.ToString()).ToString("C2",new System.Globalization.CultureInfo("en-PH"));
            textbox_department_name.Text = employee.department_name;
            dateHiredPicker.Value = employee.date_hired;
            bunifuButton4.Visible = employee.department_name == "UNASSIGNED" ? true : false;
            textbox_work_location.Text = employee.work_location;
            textbox_SSS_number.Text = employee.SSS_number;
            textbox_TIN_number.Text = employee.TIN_number;
            textbox_philhealth_number.Text = employee.philhealth_number;
            textbox_contract.Text = employee.contract;
            combo_box_civil_status.Text = employee.civil_status;
            accountIdLabel.Text = this.account.portal_account_id.ToString();
            accountStatusLabel.Text = this.account.account_status;
            passwordTextBox.Text = this.account.password;
            userTextbox.Text = this.account.username;

            deactivateBtn.Text = this.account.account_status == "DEACTIVATED" ? "Activate Account" : "Deactivate Account";


            //employee display header

            fullNameLabel.Text = $"{employee.given_name} {employee.last_name}";
            positionLabel.Text = employee.job_title;
            addressLabel.Text = $"{employee.house_lot_block_number} {employee.current_address} {employee.city} {employee.state}";




            

            isUsernameChanged = false;




            // load employee log history
           

            InfoHasChanged = false;
            
        }


        private void EnableInputControls()
        {


            foreach (var control in inputControls)
            {
                if (control is Guna2TextBox)
                {
                    ((Guna2TextBox)control).ReadOnly = false;
                }
                else
                {
                    control.Enabled = true;
                }

                changeProfileBtn.Visible = true;
            }
        }


        private void textbox_postal_code_TextChanged(object sender, EventArgs e)
        {
            if (!InfoHasChanged)
                InfoHasChanged = true;

            MessageBox.Show("change detected");
        }



       

        private string UpdateProfile()
        {


            var updatedImagePath = $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 6)}\employeeImages\{employee.employee_id}.png";

        

            this.employeePictureBox.Image.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.IO.File.Delete(employee.profile_picture);
            System.IO.File.Copy(newImagePath, updatedImagePath);

            return updatedImagePath;
        }


        private void employeePictureBox_Paint(object sender, PaintEventArgs e)
        {
            InfoHasChanged = true;
        }

  







     

        private void textbox_given_name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textboox_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void employeePictureBox_ParentChanged(object sender, EventArgs e)
        {
            InfoHasChanged = true;
        }

     

        private void changeProfileBtn_Click(object sender, EventArgs e)
        {
            using (var changeProfile = new OpenFileDialog())
            {
                changeProfile.Filter = "Png Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg";

                if (changeProfile.ShowDialog() == DialogResult.OK)
                {
                    employeePictureBox.Image.Dispose();

                    
                    newImagePath = changeProfile.FileName;
                    employeePictureBox.Image = new Bitmap(newImagePath);

                }
            }
        }



        private void addFileButton_Click_1(object sender, EventArgs e)
        {
            using (var fileForm = new Modals.UploadEmployeeFileUi(this.employee.employee_id, $"{this.employee.given_name} {this.employee.middle_name} {this.employee.last_name}"))
            {
                fileForm.ShowDialog();
            }

            LoadFileLayoutPanel();

        }

        private async void filterButtton_Click_1(object sender, EventArgs e)
        {
            await logGridObj.PopulateGridView(logGridObj.fullList
                  .Where(i => DateTime.Parse(i.login_date.ToString()).ToLongDateString().Contains(historyYearPicker.Value.ToString("yyyy"))
                  && DateTime.Parse(i.login_date.ToString()).ToLongDateString().Contains(historyMonthPicker.Value.ToString("MMMM")) && i.employee_id == this.employee.employee_id).ToList());
        }

        private void textbox_email_address_TextChanged(object sender, EventArgs e)
        {
            if (!InfoHasChanged)
            {
                InfoHasChanged = true;
            }
        }


        private void employeePictureBox_Paint_1(object sender, PaintEventArgs e)
        {
            InfoHasChanged = true;
        }

        private async void logHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (logHistoryDataGridView.Columns[e.ColumnIndex].Name == "Delete" && logHistoryDataGridView.Rows.Count >0)
            {
                if (MessageBox.Show("Do you want To Delete this history ?", "Delete History", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        var id = int.Parse(logHistoryDataGridView.CurrentRow.Cells[0].Value.ToString());

                        var logItem = dbModel.Log_History_Table.Where(i => i.log_id == id).SingleOrDefault();

                        dbModel.Entry(logItem).State = System.Data.Entity.EntityState.Deleted;
                        dbModel.SaveChanges();

                        await logGridObj.PopulateGridView(logGridObj.fullList = dbModel.Log_History_Table.Where(i =>i.employee_id == this.employee.employee_id).ToList());

                    }
                }
            }
        }

        private async void bunifuButton2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Remove all history ?","Delete History",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {

                    var logItems = dbModel.Log_History_Table.Where(i => i.employee_id == this.employee.employee_id).ToList();
                    dbModel.Log_History_Table.RemoveRange(logItems);
                    dbModel.SaveChanges();

                    await logGridObj.PopulateGridView(logGridObj.fullList = dbModel.Log_History_Table.ToList());

                }
            }
        }




        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            if (this.employee.email_received == 1)
            {
                bunifuSnackbar1.Show(this, "System Info has already been sent to the gmail of the employee, duplicate is invalid", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
            }
            else

            {
                var account = this.employee.Employee_Portal_Accounts_Table.FirstOrDefault();
                try
                {
                    EIS_BusinessLogic.ActionEmail.SendMail(employee.email_address, $"We have successfully added you as a new employee to our Employee Information System this is your default Account that You can Use To Login.\n Account ID: { account.username}\nDefaultPassword : {account.password}\n Please Do not share this information\nTHANK YOU!" );


                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        var updatedEmp = dbModel.Employee_Information_Table.Where(i => i.employee_id == this.employee.employee_id).SingleOrDefault();
                        updatedEmp.email_received = 1;
                        dbModel.Entry(updatedEmp).State = System.Data.Entity.EntityState.Modified;
                        dbModel.SaveChanges();
                    }

                    this.employee.email_received = 1;
                    bunifuSnackbar1.Show(this, "Successfully sent an email", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }

                catch (SmtpException)
                {
                    bunifuSnackbar1.Show(this, "Cannot send email please check your internet connection thank you", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove all Attendance record/s ?", "Delete Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {

                    var attItems = dbModel.Employee_Attendance_Table.Where(i => i.employee_id == this.employee.employee_id).ToList();
                    dbModel.Employee_Attendance_Table.RemoveRange(attItems);
                    dbModel.SaveChanges();

                    await attendanceGridObj.PopulateGridView(attendanceGridObj.fullList = dbModel.Employee_Attendance_Table.Where(i =>i.time_out != null).ToList());

                }
            }
        }

        private async void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            await attendanceGridObj.FilterGridView(guna2ComboBox2.Text, "None", false);
        }

        private async void bunifuButton3_Click(object sender, EventArgs e)
        {
            await attendanceGridObj.PopulateGridView(attendanceGridObj.fullList.Where(i => i.date.Value > fromPicker.Value && i.date.Value < toPicker.Value).ToList());
        }

        private async void saveEditButton_Click(object sender, EventArgs e)
        {
            if (InfoHasChanged)
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    var updatedEmployee = dbModel.Employee_Information_Table.
                        Where(i => i.employee_id == employee.employee_id).FirstOrDefault();


                    // employee information
                    updatedEmployee.given_name = textbox_given_name.Text.Trim();
                    updatedEmployee.last_name = textbox_last_name.Text.Trim();
                    updatedEmployee.middle_name = textbox_middle_name.Text.Trim();
                    updatedEmployee.age = int.Parse(textboox_age.Text);
                    updatedEmployee.birth_date = birthDatePicker.Value;
                    updatedEmployee.nationality = textbox_nationality.Text.Trim();
                    updatedEmployee.Religion = textbox_religion.Text.Trim();
                    updatedEmployee.civil_status = combo_box_civil_status.Text;
                    updatedEmployee.gender = combo_box_gender.Text;


                    // update Profile pic in dashboard if employee is current user


                    // profileImage
                    if (newImagePath != string.Empty)
                    {
                        updatedEmployee.profile_picture = UpdateProfile();
                        employeePictureBox.Image.Dispose();
                        employeePictureBox.Image = new Bitmap(updatedEmployee.profile_picture);



                    }




                    // employee address
                    updatedEmployee.current_address = textbox_current_address.Text.Trim();
                    updatedEmployee.house_lot_block_number = textbox_house_lot_block_number.Text.Trim();
                    updatedEmployee.city = textbox_city.Text.Trim();
                    updatedEmployee.state = textbox_state.Text.Trim();
                    updatedEmployee.zip_code = textbox_zip_code.Text;
                    updatedEmployee.brgy = brgyTextBox.Text.Trim();

                    //employee contact
                    updatedEmployee.phone_number = textbox_phone_number.Text;
                    updatedEmployee.email_address = textbox_email_address.Text.Trim();
                    updatedEmployee.telephone = textbox_telephone.Text;

                    //employee job information
                    updatedEmployee.job_title = positionComboBox.Text;
                    updatedEmployee.department_name = textbox_department_name.Text;
                    updatedEmployee.date_hired = dateHiredPicker.Value;
                    updatedEmployee.work_location = textbox_work_location.Text.Trim();
                    updatedEmployee.philhealth_number = textbox_philhealth_number.Text;
                    updatedEmployee.SSS_number = textbox_SSS_number.Text;
                    updatedEmployee.TIN_number = textbox_TIN_number.Text.Trim();
                    updatedEmployee.contract = textbox_contract.Text;





                    dbModel.Entry(updatedEmployee).State = System.Data.Entity.EntityState.Modified;
                    try
                    {
                        // add new employee info
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

                    
                        await ControlForms.ActiveEmployeeUi.GridObj.PopulateGridView(ControlForms.ActiveEmployeeUi.GridObj.fullList = dbModel.Employee_Information_Table
                            .Where(i => i.employee_status == "ACTIVE" )
                            .ToList());

                    

                }


                bunifuSnackbar1.Show(this, "Successfully Edited Employee", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

            }
            else
            {
                bunifuSnackbar1.Show(this, "No Changes where detected", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }

            InfoHasChanged = false;
        }

        private void enableEditEmpButton_Click(object sender, EventArgs e)
        {
            EnableInputControls();
            enableEditEmpButton.Enabled = false;
            saveEditButton.Visible = true;
            bunifuSnackbar1.Show(this, "Successfully enable Edit", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
            InfoHasChanged = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            userTextbox.ReadOnly = false;
            saveAccountButton.Visible = adminPassLabel.Visible = adminPasswordTextBox.Visible = emailnotifLabel.Visible = emailSenderCheckBox.Visible = true;
            userTextbox.Focus();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passwordTextBox.ReadOnly = false;
            saveAccountButton.Visible = adminPassLabel.Visible = retypePassLabel.Visible = retypePasswordTextBox.Visible = adminPasswordTextBox.Visible = emailnotifLabel.Visible = emailSenderCheckBox.Visible = true;
            passwordTextBox.Focus();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            saveAccountButton.Visible = adminPassLabel.Visible = adminPasswordTextBox.Visible = emailnotifLabel.Visible = emailSenderCheckBox.Visible = true;
        }



        private bool IsEmpty(string text)
        {
            return text == string.Empty;
        }


        private bool IsMinimum(string text)
        {
            return text.Length < 8;
        }


        private async void saveAccountButton_Click(object sender, EventArgs e)
        {
            if(isUsernameChanged && new EmployeeInformationSystemDataBaseEntities().Employee_Portal_Accounts_Table.Where(i =>i.username == userTextbox.Text).SingleOrDefault() != null)
            {
                bunifuSnackbar1.Show(this, "UserName is already taken", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            else if (!passwordTextBox.ReadOnly && passwordTextBox.Text != retypePasswordTextBox.Text)
            {
                bunifuSnackbar1.Show(this, "Password Do not Match", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }

            else if (adminPasswordTextBox.Text != DataBaseFunctions.SystemUser.UserAccount.password)
            {
                bunifuSnackbar1.Show(this, "Invalid Administrator Password", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                adminPasswordTextBox.Text = string.Empty;
            }

            else if (IsEmpty(userTextbox.Text) || IsEmpty(passwordTextBox.Text))
            {
                bunifuSnackbar1.Show(this, "Input should not be empty", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            else if ((!passwordTextBox.ReadOnly && !userTextbox.ReadOnly) && (IsMinimum(userTextbox.Text) || IsMinimum(passwordTextBox.Text)))
            {
                bunifuSnackbar1.Show(this, "Input should atleast 8 characters long for UserName and Password", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }

            else
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {

                    var account = dbModel.Employee_Portal_Accounts_Table.Where(i => i.employee_id == this.employee.employee_id).SingleOrDefault();
                   account.username = userTextbox.Text;

                    
                   account.password = passwordTextBox.Text;




                    try
                    {
                        dbModel.Entry(account).State = System.Data.Entity.EntityState.Modified;
                        await dbModel.SaveChangesAsync();

                        bunifuSnackbar1.Show(this, "Account is successfully updated", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        adminPasswordTextBox.Text = retypePasswordTextBox.Text = string.Empty;

                       passwordTextBox.ReadOnly = userTextbox.ReadOnly = true;

                        saveAccountButton.Visible = adminPassLabel.Visible = retypePassLabel.Visible = retypePasswordTextBox.Visible = adminPasswordTextBox.Visible = emailnotifLabel.Visible = emailSenderCheckBox.Visible  = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($@"Cannot update account an error has occured during the process\nERROR:\n{ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (emailSenderCheckBox.Checked)
                    {
                        EIS_BusinessLogic.ActionEmail.SendMail(account.Employee_Information_Table.email_address, $"Good Day Employee One of our administrator changed your system account for HRIS,your new Account Info\n UserName:{userTextbox.Text}\n Password:{passwordTextBox.Text}\n Please do not share this Information \n THANK YOU!");

                    }
                }

                isUsernameChanged = false;
            }
        }




        private async void UpdateAccountStatus(string value)
        {

            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {

                account.account_status = value;
                dbModel.Entry(account).State = System.Data.Entity.EntityState.Modified;
               await dbModel.SaveChangesAsync();

                accountStatusLabel.Text = value;
            }
        }
        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

                var button = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;


                if (MessageBox.Show($"Do you want to {button.Text.Substring(0, button.Text.IndexOf(' '))} this account ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (button.Text == "Deactivate Account")
                    {
                        UpdateAccountStatus("DEACTIVATED");
                        button.Text = "Activate Account";
                    }
                    else
                    {
                        UpdateAccountStatus("ACTIVE");
                        button.Text = "Deactivate Account";
                    }

                bunifuSnackbar1.Show(this, "Successfully Change account STATUS", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }

            
        }

        private void metroTabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void userTextbox_TextChanged(object sender, EventArgs e)
        {
            if(!isUsernameChanged)
            isUsernameChanged = true;
        }

        private async void bunifuButton4_Click_1(object sender, EventArgs e)
        {
            using (var assignDepForm = new ReassignedDepartmentUi(this.employee))
            {
                assignDepForm.ShowDialog();
                textbox_department_name.Text = ReassignedDepartmentUi.AssignedDepartment;

                if (ReassignedDepartmentUi.HasReassigned)
                {
                    bunifuButton4.Visible = false;
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        await ControlForms.ActiveEmployeeUi.GridObj.PopulateGridView(ControlForms.ActiveEmployeeUi.GridObj.fullList = dbModel.Employee_Information_Table.ToList());
                    }
                    
                }
            }
        }

        private void positionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!InfoHasChanged)
                InfoHasChanged = true;
        }

        private async void EditViewEmployee_Load(object sender, EventArgs e)
        {
            var list = await LoadEmployeeSummary();

            totalDaysLabel.Text = list[0] + " Days";
            onTimeLabel.Text = list[1] + " Days";
            latesLabel.Text = list[2] + " Days";
            earnedAmountLabel.Text =((decimal)list[3]).ToString("C2", new System.Globalization.CultureInfo("en-PH"));
            cashAdvanceLabel.Text = ((decimal)list[4]).ToString("C2", new System.Globalization.CultureInfo("en-PH"));
        }

        private async void payrollDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (payrollDataGridView.Columns[e.ColumnIndex].Name == "Print" && payrollDataGridView.Rows.Count > 0)
            {

                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    int paySlipID = int.Parse(payrollDataGridView.CurrentRow.Cells[0].Value.ToString());


                    using (var payslipForm = new Reports.PaySlipReportUi(employee.department_name, employee.job_title, employee.employee_id, payslipGridObj.fullList.Where(i => i.payslip_id == paySlipID).SingleOrDefault()))
                    {
                        payslipForm.ShowDialog();
                    }

                }
            }
            else if (payrollDataGridView.Columns[e.ColumnIndex].Name == "DeletePayslip" && payrollDataGridView.Rows.Count > 0)
            {
                if (MessageBox.Show($"Delete payslip ID {payrollDataGridView.CurrentRow.Cells[0].Value}", "Delete Payslip", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        int paySlipID = int.Parse(payrollDataGridView.CurrentRow.Cells[0].Value.ToString());
                        var payslip = dbModel.Payroll_Table.Where(i => i.payslip_id == paySlipID).SingleOrDefault();

                        dbModel.Entry(payslip).State = System.Data.Entity.EntityState.Deleted;
                        await dbModel.SaveChangesAsync();

                        await payslipGridObj.PopulateGridView(payslipGridObj.fullList = dbModel.Payroll_Table.Where(i =>i.employee_id == this.employee.employee_id).ToList());
                    }

                    new Modals.NotificationUi("Successfully Deleted Payslip", Modals.NotificationUi.NotificationType.restore);
                }
            }
        }

        private async void payrollDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await payslipGridObj.SortGridView(payrollDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        private async void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            await payslipGridObj.SearchGridView(bunifuTextBox1.Text,"payslip_id","date_issued");
        }

        private async void payrollYearPicker_ValueChanged(object sender, EventArgs e)
        {
            await payslipGridObj.SearchGridView(payrollYearPicker.Value.ToString("yyyy"), "date_issued");
        }


        public Task<List<decimal?>> LoadEmployeeSummary()
        {
            return Task.Run(() =>
            {

              
                  return new List<decimal?>()
                    {
                        this.employee.Employee_Attendance_Table.ToList().Count,
                        this.employee.Employee_Attendance_Table.Where(i =>i.attendance_status == "On-Time").Count(),
                        this.employee.Employee_Attendance_Table.Where(i =>i.attendance_status=="Late").Count(),
                        this.employee.Payroll_Table.Select(i =>i.net_pay).Sum(),
                        this.employee.Cash_Advance_Table.Where(i =>i.status == "UNPAID").Select(i =>i.remaining_balance).Sum()
                        
                    };


                

            });
        }


        private void LoadEmployeeChart()
        {
            this.chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = this.chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = this.chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            this.chart2.ChartAreas[0].AxisX.Interval = this.chart1.ChartAreas[0].AxisX.Interval = 1;
            this.chart2.ChartAreas[0].AxisX.Title = this.chart1.ChartAreas[0].AxisX.Title = "Months";

            this.chart1.Series["Monthly Salary"].Points.AddXY("Jan",this.employee.Payroll_Table.Where(i =>i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("January")).Select(i =>i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("Feb", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("February")).Select(i => i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("Mar", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("March")).Select(i => i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("Apr", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("April")).Select(i => i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("May", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("May")).Select(i => i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("June", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("June")).Select(i => i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("July", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("July")).Select(i => i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("Aug", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("August")).Select(i => i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("Sept", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("September")).Select(i => i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("Oct", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("October")).Select(i => i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("Nov", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("November")).Select(i => i.net_pay).Sum());
            this.chart1.Series["Monthly Salary"].Points.AddXY("Dec", this.employee.Payroll_Table.Where(i => i.date_issued.Value.Year == DateTime.Today.Year && i.date_issued.Value.ToString("MMMM").Contains("December")).Select(i => i.net_pay).Sum());

            this.chart2.Series["Days Worked"].Points.AddXY("Jan", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("January")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("Feb", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("February")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("Mar", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("March")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("Apr", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("April")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("May", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("May")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("June", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("June")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("July", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("July")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("Aug", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("August")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("Sept", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("September")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("Oct", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("October")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("Nov", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("November")).Count());
            this.chart2.Series["Days Worked"].Points.AddXY("Dec", this.employee.Employee_Attendance_Table.Where(i => i.date.Value.Year == DateTime.Today.Year && i.date.Value.ToString("MMMM").Contains("December")).Count());
        }

       
    }
    }
