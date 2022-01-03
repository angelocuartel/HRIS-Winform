using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EISProject.ControlForms
{
    public partial class SystemUserAccountUi : UserControl
    {
        public static DataBaseFunctions.DataGridAction<HRIS_Account_Table> SystemAccountGridObj { get { return systemAccountGridObj; } }
        private static DataBaseFunctions.DataGridAction<HRIS_Account_Table> systemAccountGridObj;
        public SystemUserAccountUi()
        {
            InitializeComponent();
        }

        private async void SystemUserAccountUi_Load(object sender, EventArgs e)
        {
            

            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                systemAccountGridObj = new DataBaseFunctions.DataGridAction<HRIS_Account_Table>(emptyHolidayLabel, totalRecordsLabel, systemAccountDataGridView, dbModel.HRIS_Account_Table.Where(i =>i.hris_account_id != DataBaseFunctions.SystemUser.UserAccount.hris_account_id && (DataBaseFunctions.SystemUser.UserAccount.access_level == "Primary Administrator" ? i.access_level != "Primary Administrator" : i.access_level == "HR")).ToList());
                await systemAccountGridObj.PopulateGridView(systemAccountGridObj.fullList);
            }
      
        }

        private async void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            await systemAccountGridObj.SearchGridView(searchTextBox.Text, "username");
        }

        private async void filterMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await systemAccountGridObj.FilterGridView(filterMonthComboBox.Text, "None", true);
        }

        private async void systemAccountDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (systemAccountDataGridView.Rows.Count > 0)
            {
                if (systemAccountDataGridView.Columns[e.ColumnIndex].Name == "edit")
                {
                    var selectedUsername = systemAccountDataGridView.CurrentRow.Cells[0].Value.ToString();

                    using (var editForm = new Modals.ViewEditUser(systemAccountGridObj.fullList.Where(i => i.username == selectedUsername).SingleOrDefault(),null))
                    {
                        editForm.ShowDialog();
                    }
                }
                else if(systemAccountDataGridView.Columns[e.ColumnIndex].Name == "delete")
                {
                    if(MessageBox.Show("Do you want to delete the selected user ? ","DELETE SYSTEM USER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                    
                    var selectedUsername = systemAccountDataGridView.CurrentRow.Cells[0].Value.ToString();

                        using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                        {
                            var acc = dbModel.HRIS_Account_Table.Where(i => i.username == selectedUsername).SingleOrDefault();

                            dbModel.Entry(acc).State = System.Data.Entity.EntityState.Deleted;
                            dbModel.SaveChanges();

                            new Modals.NotificationUi("Successfully Deleted System User", Modals.NotificationUi.NotificationType.archived);
                            await SystemAccountGridObj.PopulateGridView(SystemAccountGridObj.fullList = dbModel.HRIS_Account_Table.Where(i => i.hris_account_id != DataBaseFunctions.SystemUser.UserAccount.hris_account_id && (DataBaseFunctions.SystemUser.UserAccount.access_level == "Primary Administrator" ? i.access_level != "Primary Administrator" : i.access_level == "HR")).ToList());

                        }
                    }
                }
            }
        }
        

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            using (var addSystemUserForm = new Modals.AddNewUserUi())
            {
                addSystemUserForm.ShowDialog();
            }
        }

        private async void systemAccountDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await systemAccountGridObj.SortGridView(systemAccountDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
}
