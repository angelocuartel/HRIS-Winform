using System;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using EISProject.DataBaseFunctions;
using System.Linq;

namespace EISProject.Modals
{
    public partial class ArchivingEmployeUi : Form
    {
        private int employeeId;



        public ArchivingEmployeUi(int employeeId,string employeeName )
        {
            InitializeComponent();

            this.employeeId = employeeId;
            employeeNameLabel.Text = employeeName.Trim();
        }

        private void reasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(reasonComboBox.Text == "Others")
            {
                othersTextBox.Enabled = true;
                suspensionDateTimePicker.Enabled = false;
            }
            else if (reasonComboBox.Text == "Suspended")
            {
                othersTextBox.Enabled = false;
                suspensionDateTimePicker.Enabled = true;
            }
            else
            {
                othersTextBox.Enabled = suspensionDateTimePicker.Enabled = false;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private  void guna2Button1_Click(object sender, EventArgs e)
        {
            
            
        }




        private  void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void archiveButton_Click(object sender, EventArgs e)
        {
            await EmployeeEntity.UpdateEmployeeStatus(suspensionDateTimePicker.Value.ToShortDateString(), othersTextBox.Enabled ? othersTextBox.Text : reasonComboBox.Text, employeeId, "ARCHIVED");

            var dbModel = new EmployeeInformationSystemDataBaseEntities();

            //refresh archived employee data
            if (EISMainForm.Archived_EMp_HasClick)
                await ControlForms.ArchivedEmployeeUi.GridObjArchived.PopulateGridView(ControlForms.ArchivedEmployeeUi.GridObjArchived.fullList = dbModel.Employee_Information_Table.Where(i => i.employee_status == "ARCHIVED").ToList());

            if (EISMainForm.Dashboard_HasClick)
                ControlForms.DashBoardUi.DashboardObj.LoadDashboardPanel();

            if (EISMainForm.Active_Emp_HasClick)
                await ControlForms.ActiveEmployeeUi.GridObj.PopulateGridView(ControlForms.ActiveEmployeeUi.GridObj.fullList = dbModel.Employee_Information_Table.Where(i => i.employee_status == "ACTIVE").ToList());

            new Modals.NotificationUi("Sucessfully Archived Employee", NotificationUi.NotificationType.archived).Show();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
