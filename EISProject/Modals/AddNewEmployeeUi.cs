using System;
using System.Collections.Generic;
using Bunifu.UI.WinForms;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using EISProject.ControlForms;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using EIS_BusinessLogic;


using System.Data.Entity.Validation;
using System.Threading;

namespace EISProject.Modals
{
    public partial class AddNewEmployeeUi : Form
    {

        EmployeeInformationSystemDataBaseEntities dbModel = new EmployeeInformationSystemDataBaseEntities();
        Employee_Information_Table employee = new Employee_Information_Table();
        List<UserControl> menus = new List<UserControl>() { new PersonalDetailsUI(), new JobDetailsUI(), new RequiredDocumentsUi(), new AddedSuccessUi() };
        Menu menu;
        int accumulator = 0;
        OpenFileDialog imageDialog = new OpenFileDialog();
        JobDetailsUI jobDetails;
        RequiredDocumentsUi docsDetails;
        bool isSkip = true;

        public AddNewEmployeeUi()
        {

            new Thread(new ThreadStart(() => { Application.Run(new Modals.AddedSuccess()); })).Start();                
            InitializeComponent();

           

            // initialize menu change
           menu = new Menu(menus,panel1,new Dictionary<Label,BunifuCheckBox>() { {label5,bunifuCheckBox1 }, { label6, bunifuCheckBox2 }, { label7,bunifuCheckBox3 } });

            jobDetails = (JobDetailsUI)menus[1];
            docsDetails = (RequiredDocumentsUi)menus[2];




            // Remove Hscroll in panel
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;

            new Guna.UI2.WinForms.Guna2ShadowForm().SetShadowForm(this);
            panel1.Controls.Add(menus[0]);

            LoadScreen.CloseLoadScreen((AddedSuccess)Application.OpenForms["AddedSuccess"]);


        }

        private  void AddEmployeeToDB()
        {
            int emailSentt = 1 ;
            new Thread(new ThreadStart(() => { Application.Run(new Modals.AddedSuccess()); })).Start();

            using (dbModel)
                {


                    var account = new Employee_Portal_Accounts_Table();
                    try
                    {
                        // add new employee info
                        dbModel.Employee_Information_Table.Add(employee);
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


                     account.date_added = DateTime.Today;
                    account.username = new Random().Next(10000, 90000).ToString();
                    account.password = (new Random().Next(10000, 90000) + new Random().Next(10000, 90000)).ToString();
                    account.employee_id = dbModel.Employee_Information_Table
                        .Where(c => c.email_address == employee.email_address)
                        .Select(c => c.employee_id)
                        .FirstOrDefault();

                    // add new employee account
                    dbModel.Employee_Portal_Accounts_Table.Add(account);
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

                    // adding files to employee
                    DataBaseFunctions.EmployeeFile.AddFilesToEmployee(RequiredDocumentsUi.docs_Controls, account.employee_id);

                    // check if employee docs are completed
                    DataBaseFunctions.EmployeeFile.CheckEmployeeDocs(account.employee_id);

                if (EISMainForm.Dashboard_HasClick)
                {
                    DashBoardUi.DashboardObj.LoadDashboardPanel();
                    DashBoardUi.DashboardObj.LoadDashboardEmployeeChart();
                }
                   

                    try
                    {

                        ActionEmail.SendMail(employee.email_address, $"We have successfully added you as a new employee to our Employee Information System this is your default Account that You can Use To Login.\n Account ID: { account.username}\nDefaultPassword : {account.password}\n Please Do not share this information\nTHANK YOU!");
                        gunaCirclePictureBox1.Image = null;

                    }
                    catch (SmtpException)
                    {
                    emailSentt = 0;
                        bunifuSnackbar1.Show(this, "Unable To send an Email Right Now, please Contact your Administrator Thank you!", BunifuSnackbar.MessageTypes.Error);
                    }

                    bunifuCheckBox4.Checked = true;
                    label1.ForeColor = Color.Green;
                }




                // 
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    var lastEmp = dbModel.Employee_Information_Table.OrderByDescending(i => i.employee_id).FirstOrDefault();


                    string imagePath = $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 6)}\employeeImages\{lastEmp.employee_id}.png";

                    if (imageDialog.FileName == string.Empty)
                    {
                        imageDialog.FileName = $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 6)}\default-image.png";
                }

                    System.IO.File.Copy(imageDialog.FileName, imagePath);
                    lastEmp.profile_picture = imagePath;
                lastEmp.email_received = emailSentt;

                    dbModel.Entry(lastEmp).State = System.Data.Entity.EntityState.Modified;
                    dbModel.SaveChanges();

                }

            LoadScreen.CloseLoadScreen((AddedSuccess)Application.OpenForms["AddedSuccess"]);
        }








        private void AnimatePanel()
        {
            guna2Transition1.HideSync(panel1, false, Animation.Transparent);
            menu.NextMenu(menus[accumulator], accumulator);
        }
  
        private  void gunaButton2_Click(object sender, EventArgs e)
        {

            
            var jobDetails = (JobDetailsUI)menus[1];
            var docsDetails = (RequiredDocumentsUi)menus[2];

            if (accumulator == 2)
            {
                if (RequiredDocumentsUi.HasEmpty)
                {
                    if (MessageBox.Show("Documents for the employee are Empty but you can skip it for now Do you want still to continue ?", "Important Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        isSkip = true;
                        AddEmployeeToDB();
                    }
                    else
                    {
                        isSkip = false;
                    }
                }
                else
                {
                     AddEmployeeToDB();
                }
              

            }
            else if(nextBtn.Text == "Finish")
            {
                this.Close();
            }

            if (jobDetails.IsInputAllValid)
            {
                bunifuSnackbar1.Show(this, "Please Check all your input", BunifuSnackbar.MessageTypes.Error);
            }
            else
            {
                accumulator++;
                if (accumulator == menus.Count - 1 && isSkip)
                {
                    previousBtn.Enabled = false;
                    nextBtn.Text = "Finish";
                    AnimatePanel();
                }

                else if (accumulator == 1)
                {
                    nextBtn.Text = "Next";
                    AnimatePanel();

                }

                else if (accumulator == 2)
                {
                    employee.job_title = jobDetails.Position;
                    employee.contract = jobDetails.Contract;
                    employee.philhealth_number = jobDetails.PhilHealth.Trim();
                    employee.SSS_number = jobDetails.SSS.Trim();
                    employee.TIN_number = jobDetails.TIN.Trim();
                    employee.work_location = jobDetails.WorkLocation.Trim();
                    employee.date_hired = jobDetails.DateHired;
                    employee.department_name = jobDetails.Department;
                    employee.rate_per_hour = jobDetails.Rate_Per_Hour;
                    employee.campus_assigned = jobDetails.Campus;
                    employee.employee_work_id = DataBaseFunctions.EmployeeEntity.GenerateEmployeeWorkID();
                    AnimatePanel();
                }
                else if (!isSkip)
                {
                    accumulator--;
                }

                
                
            }

          
            }

        

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           
             if(accumulator > 0)
            {
                guna2Transition1.HideSync(panel1, false, Animation.Transparent);
                accumulator--;
                menu.PreviousMenu(menus[accumulator], accumulator + 1);

                if (accumulator == 0)
                {
                    nextBtn.Visible = false;
                    next1Btn.Visible = true;
                    previousBtn.Visible = false;
                }

            }
        }

   

   

        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
            guna2Transition1.Show(panel1, false, Animation.Transparent);
        }

        private void next1Btn_Click(object sender, EventArgs e)
        {
           var personalObj = (PersonalDetailsUI)menus[0];

            if (personalObj.inputValidator.AreAllNotValid())
            {
                bunifuSnackbar1.Show(this, "Please Check all your input", BunifuSnackbar.MessageTypes.Error);
            }
            else
            {

               // add employee information

                employee.given_name = personalObj.GivenName.Trim();
                employee.last_name = personalObj.LastName.Trim();
                employee.gender = personalObj.Gender;
                employee.middle_name = personalObj.MiddleName.Trim();
                employee.phone_number = personalObj.PhoneNumber.Trim();
                employee.email_address = personalObj.Email.Trim();
                employee.current_address = personalObj.Address.Trim();
                employee.age = personalObj.Age;
                employee.Religion = personalObj.Religion;
                employee.nationality = personalObj.Nationality;
                employee.birth_date = DateTime.Parse(personalObj.BirthDate);
                employee.civil_status = personalObj.CivilStatus;
                employee.house_lot_block_number = personalObj.HouseNumber;
                employee.city = personalObj.City;
                employee.state = personalObj.State;
                employee.zip_code = personalObj.ZipCode;
                employee.brgy = personalObj.Brgy;
                employee.telephone = $"{personalObj.Telephone:000-000-0000}";
                employee.date_added = DateTime.Today;


                if (dbModel.Employee_Information_Table.Where(em => em.email_address == employee.email_address).FirstOrDefault() != null)
                {
                    bunifuSnackbar1.Show(this, "Email already Exist, cannot use duplicate Emails", BunifuSnackbar.MessageTypes.Error);
                }
                else if (dbModel.Employee_Information_Table.Where(emp => emp.last_name == employee.last_name && emp.given_name == employee.given_name && emp.middle_name == employee.middle_name).FirstOrDefault() != null)
                {
                    bunifuSnackbar1.Show(this, "Employee Already Exist, cannot use duplicate Information of an Employee", BunifuSnackbar.MessageTypes.Error);
                }

                else
                {


                    previousBtn.Visible = true;
                    next1Btn.Visible = false;
                    nextBtn.Visible = true;
                    accumulator++;
                    AnimatePanel();



                }
            }
            
        }

   

        private void uploadPhotoBtn1_Click(object sender, EventArgs e)
        {
            imageDialog.Filter = "Image Files(*.Png;*.JPEG;*.JPG)|*.Png;*.JPEG;*.JPG|All Files(*.*)|*.*";

            using (imageDialog)
            {
                if (imageDialog.ShowDialog() == DialogResult.OK)
                {
                    gunaCirclePictureBox1.Image = new Bitmap(imageDialog.FileName);
                }
            }
        }

    }

}
  