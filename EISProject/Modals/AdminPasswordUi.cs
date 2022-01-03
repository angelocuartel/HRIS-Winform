using EISProject.DataBaseFunctions;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EISProject.Modals
{
    public partial class AdminPasswordUi : Form
    {
        private int employeeId;
        public AdminPasswordUi(int employeeId,string employeeName,string modalTitle)
        {
            InitializeComponent();

            this.employeeId = employeeId;

            new Guna.UI2.WinForms.Guna2DragControl().TargetControl = gunaLinePanel1;

            employeeNameLabel.Text = employeeName;

            ModalTitleLabel.Text = modalTitle;
        }

     

     

        private async void addDepartmentButton_Click(object sender, EventArgs e)
        {
            if (ModalTitleLabel.Text == "Restoring Employee")
            {
                if (passwordTextbox.Text != DataBaseFunctions.SystemUser.UserAccount.password)
                {
                    bunifuSnackbar1.Show(this, "Invalid Password, Please try again", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else
                {
                    await EmployeeEntity.UpdateEmployeeStatus(null, null, employeeId, "ACTIVE");

                    new Modals.NotificationUi("Successfully Restored Employee", NotificationUi.NotificationType.restore).Show();
                    //refresh archived employee data

                    var dbModel = new EmployeeInformationSystemDataBaseEntities();
                    if (EISMainForm.Archived_EMp_HasClick)
                       await ControlForms.ArchivedEmployeeUi.GridObjArchived.PopulateGridView(ControlForms.ArchivedEmployeeUi.GridObjArchived.fullList = dbModel.Employee_Information_Table.Where(i => i.employee_status == "ARCHIVED").ToList());

                    if (EISMainForm.Active_Emp_HasClick)
                        await ControlForms.ActiveEmployeeUi.GridObj.PopulateGridView(ControlForms.ArchivedEmployeeUi.GridObjArchived.fullList = dbModel.Employee_Information_Table.Where(i => i.employee_status == "ACTIVE").ToList());

                    if (EISMainForm.Dashboard_HasClick)
                        ControlForms.DashBoardUi.DashboardObj.LoadDashboardPanel();

                    DataBaseFunctions.SystemUser.HasValidPassword = true;
                    this.Close();
                }
            }
            else
            {
                if (passwordTextbox.Text.Trim() == DataBaseFunctions.SystemUser.UserAccount.password)
                {
                    DataBaseFunctions.SystemUser.HasValidPassword = true;
                    this.Close();

                }
                else
                    bunifuSnackbar1.Show(this, "Invalid Password, Please try again", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
