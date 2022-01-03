using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EISProject.DataBaseFunctions;

namespace EISProject.ControlForms
{
    public partial class DeductionsUi : UserControl
    {

        public static DataGridAction<Deductions_Table> DeductionObjGrid { get { return deductionObjGrid; } }
        private static DataGridAction<Deductions_Table> deductionObjGrid;
        private EmployeeInformationSystemDataBaseEntities model = new EmployeeInformationSystemDataBaseEntities();
        public DeductionsUi()
        {
            InitializeComponent();

            
           
            
        }
       
        private async void accountDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await deductionObjGrid.SortGridView(deductionDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        private async void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            await deductionObjGrid.SearchGridView(searchTextBox.Text, "id");
        }

  


  

        //private void deactivateButton_Click(object sender, EventArgs e)
        //{

        //    if (deductionDataGridView.Rows.Count > 0)
        //    {
        //        var button = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
              

        //        if(MessageBox.Show($"Do you want to {button.Text.Substring(0,button.Text.IndexOf(' '))} this account ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            if (button.Text == "Deactivate Account")
        //            {
        //                UpdateAccountStatus("DEACTIVATED");
        //            }
        //            else
        //            {
        //                UpdateAccountStatus("ACTIVE");
        //            }
        //        }
               
        //    }
        //}


        //private async void UpdateAccountStatus(string value)
        //{
        //    var accountID = int.Parse(deductionDataGridView.CurrentRow.Cells[0].Value.ToString());
        //    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
        //    {
        //        var account = dbModel.Accounts_Table.Where(i => i.account_id == accountID).SingleOrDefault();
        //        account.account_status = value;
        //        dbModel.Entry(account).State = System.Data.Entity.EntityState.Modified;
        //        dbModel.SaveChanges();
        //        await deductionObjGrid.PopulateGridView(deductionObjGrid.fullList = dbModel.Deductions_Table.ToList());
               
        //    }
        //}





        private async void AccountsUi_Load(object sender, EventArgs e)
        {
            using (model)
            {
                deductionObjGrid = new DataGridAction<Deductions_Table>(deductiontEmptyLabel, totalRecordsLabel, deductionDataGridView, model.Deductions_Table.ToList());
            }
            await deductionObjGrid.PopulateGridView(deductionObjGrid.fullList);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            using (var deductionForm = new Modals.AddEditDeductionUi())
            {
                deductionForm.ShowDialog();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            using (var deductionForm = new Modals.AddEditDeductionUi(deductionObjGrid.fullList.Where(i =>i.id == int.Parse(deductionDataGridView.CurrentRow.Cells[0].Value.ToString())).SingleOrDefault()))
            {
  
                deductionForm.ShowDialog();
            }
        }

        private async void deductionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deductionDataGridView.Columns[e.ColumnIndex].Name == "Delete" && deductionDataGridView.Rows.Count > 0)
            {
                if (MessageBox.Show($"Do you want to delete deduction Type {deductionDataGridView.CurrentRow.Cells[1].Value.ToString()} ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        var deducDelete = deductionObjGrid.fullList.Where(i => i.id == int.Parse(deductionDataGridView.CurrentRow.Cells[0].Value.ToString())).SingleOrDefault();

                        dbModel.Entry(deducDelete).State = System.Data.Entity.EntityState.Deleted;
                        await dbModel.SaveChangesAsync();
                        new Modals.NotificationUi("Successfully Delete Deduction Type", Modals.NotificationUi.NotificationType.archived);
                        await deductionObjGrid.PopulateGridView(deductionObjGrid.fullList = dbModel.Deductions_Table.ToList());
                    }
                }
            }
            
        }
    }
}
