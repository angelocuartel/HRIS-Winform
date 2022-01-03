using System;
using System.Collections.Generic;
using EIS_BusinessLogic;
using System.Windows.Forms;
using EISProject.ControlForms;
using System.Drawing;
using System.Threading;

namespace EISProject
{
    public partial class EISMainForm : Form
    {
        ActionMenu menuObj;
        List<UserControl> menus;

        public static DataBaseFunctions.Settings SettingObj { get { return settingObj; } }
        private static DataBaseFunctions.Settings settingObj;
        private  Modals.LoadingForm loadingForm = new Modals.LoadingForm();

        static public bool Active_Emp_HasClick { get; set; }

        static public bool CashADvance_HasClick { get; set; }
        static public bool Archived_EMp_HasClick { get; set; }
        static public bool PaySlip_HasClick { get; set; }
        static public bool Emp_File_HasClick { get; set; }


        public static bool Dashboard_HasClick { get; set; }


        public EISMainForm()
        {



            new Thread(new ThreadStart(() => { Application.Run(new Modals.LoadingForm()); })).Start();
            InitializeComponent();

            settingObj = new DataBaseFunctions.Settings(companyLogoPictureBox, companyNameLabel);

            settingObj.InitializeSystemSettings();

            LoadSystem();

            Dashboard_HasClick = true;

           LoadScreen.CloseLoadScreen((Modals.LoadingForm)Application.OpenForms["LoadingForm"]);
          

            
           
            

        }


 
     
  
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();

            checkConnection :
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                timer1.Stop();

                accessLevelLabel.ForeColor = Color.Red;
                onlineIndicator.FillColor = Color.Red;
                onlineIndicator.BorderColor = Color.Red;
                
                if (MessageBox.Show("You do not have an internet connection at the moment\n please check your connection thank you", "No Internet", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    DataBaseFunctions.SystemUser.RecordLogHistory();
                    var loginForm = new LoginUi();
                    loginForm.Show();
                    loginForm.BringToFront();

                    this.Dispose();
                }
                else
                {
                    timer1.Start();

                    accessLevelLabel.ForeColor = Color.SeaGreen;
                    onlineIndicator.FillColor = Color.SeaGreen;
                    onlineIndicator.BorderColor = Color.SeaGreen;
                    goto checkConnection;
                }

                
            }


        }


      

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
             if(MessageBox.Show("Do you really want to Logout ? ","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new LoginUi().Show();
            }
        }

    

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Logout ?","LogOut",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataBaseFunctions.SystemUser.RecordLogHistory();
                this.Hide();
                this.Dispose();
                new LoginUi().Show();
            }
        }

    
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(this.Size.Height == 737 && this.Size.Width == 1356)
            {
                this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.CenterToScreen();
            }
            else
            {
               
                this.Size = new Size(1356,737);
                this.CenterToScreen();
            }

            
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataBaseFunctions.SystemUser.RecordLogHistory();
                var loginForm = new LoginUi();
                loginForm.Show();
                loginForm.BringToFront();

                this.Dispose();

            }
        }

       

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        


        
           
            
        }

        private void LoadSystem()
        { 
            this.BringToFront();
            guna2ShadowForm1.SetShadowForm(this);
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            menus = new List<UserControl>() {
                new DashBoardUi(), new ActiveEmployeeUi(), new ArchivedEmployeeUi(),
                new EmployeeFilesUi(), new DepartmentsUi(),new DeductionsUi(), new AttendanceListUi(),
                new SettingsUI(),new PositionUi(),new HolidaysUi(),new CashAdvanceUi(),
                new PayslipUi(),new AllowanceUi(),new SystemUserAccountUi()

            };

            menuObj = new ActionMenu(menus, mainPanel);
            DataBaseFunctions.AccessLevel.SetAccessControls(settingBtn,systemUserBtn);

            this.Location = new Point(0, 0);
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);


            var dashboard = new DashBoardUi()
            {
                Size = new Size(this.mainPanel.Width, this.mainPanel.Height)
            };


            mainPanel.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;




            systemuserPictureBox.Image = new Bitmap(DataBaseFunctions.SystemUser.UserAccount.profile_picture);
            userNameLabel.Text = DataBaseFunctions.SystemUser.UserAccount.username;
            accessLevelLabel.Text = DataBaseFunctions.SystemUser.UserAccount.access_level;
        }

        private void mainEmpBtn_Click(object sender, EventArgs e)
        {
            SideBar.SideBarOpen(empFilesBtn,archiveEmpBtn, activeEmpBtn);
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            SideBar.SideBarOpen(deductionBtn, cashAdvanceBtn,genPayslipBtn);
        }

        private void LeaveBtn_Click(object sender, EventArgs e)
        {
            SideBar.SideBarOpen(leaveTypeBtn,pendingLeaveBtn);
        }

        private void dtrBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[6]);
        }

        private void activeEmpBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[1]);
            Active_Emp_HasClick = true;
        }

        private void archiveEmpBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[2]);
            Archived_EMp_HasClick = true;
        }

        private void empFilesBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[3]);
            Emp_File_HasClick = true;
        }

        private void genPayslipBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[11]);
            PaySlip_HasClick = true;
        }

        private void cashAdvanceBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[10]);
            CashADvance_HasClick = true;
        }

        private void deductionBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[5]);
        }

        private void positionBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[8]);
        }

        private void departmentBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[4]);
        }


        private void settingBtn_Click(object sender, EventArgs e)
        {
         //  menuObj.Open(menus[7]);
            OpenUserControl(new SettingsUI() {Height = this.mainPanel.Height,Width = this.mainPanel.Width });
        }

        private void systemDashboardBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[0]);
            Dashboard_HasClick = true;
        }

    
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[13]);
        }

        private void OpenUserControl(UserControl userControl)
        {


            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(userControl);
            

        
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            systemuserPictureBox.Image.Dispose();
            using (var formUser = new Modals.ViewEditUser(DataBaseFunctions.SystemUser.UserAccount, systemuserPictureBox))
            {
                formUser.ShowDialog();
            }

            userNameLabel.Text = DataBaseFunctions.SystemUser.UserAccount.username;

            systemuserPictureBox.Image = new Bitmap(DataBaseFunctions.SystemUser.UserAccount.profile_picture);

        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            menuObj.Open(menus[9]);
        }

        private void allowanceBtn_Click(object sender, EventArgs e)
        {
            menuObj.Open(menus[12]);
        }
    }
    
}
