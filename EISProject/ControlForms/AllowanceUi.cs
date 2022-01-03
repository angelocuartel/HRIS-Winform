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
    public partial class AllowanceUi : UserControl
    {
     public static DataGridAction<Employee_Allowance_Table> AllowanceGridObj { get { return allowanceGridObj; } }
      private static DataGridAction<Employee_Allowance_Table> allowanceGridObj;
        public AllowanceUi()
        {
            InitializeComponent();
        }

        private async void AllowanceUi_Load(object sender, EventArgs e)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                allowanceGridObj = new DataGridAction<Employee_Allowance_Table>(allowanceEmptyLabel, totalRecordsLabel, allowanceDataGridView, dbModel.Employee_Allowance_Table.ToList());
                await allowanceGridObj.PopulateGridView(allowanceGridObj.fullList);
            }
            
        }

        private async void allowanceDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await allowanceGridObj.SortGridView(allowanceDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        private async void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            await allowanceGridObj.SearchGridView (searchTextBox.Text,"allowance_name","amount","log_by");
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            using (var addAllowanceForm = new Modals.AddAllowanceUi())
            {
                addAllowanceForm.ShowDialog();
            }
        }

        private async void allowanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(allowanceDataGridView.Columns[e.ColumnIndex].HeaderText == "Action" && allowanceDataGridView.Rows.Count > 0)
            {
                if(MessageBox.Show($"Do you want to Delete {allowanceDataGridView.CurrentRow.Cells[1].Value.ToString()} ","Delete Allowance",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        int allowanceID = int.Parse(allowanceDataGridView.CurrentRow.Cells[0].Value.ToString());
                        var deleteAllowance = dbModel.Employee_Allowance_Table.Where(i => i.allowance_id == allowanceID).SingleOrDefault();

                        dbModel.Entry(deleteAllowance).State = System.Data.Entity.EntityState.Deleted;
                        await dbModel.SaveChangesAsync();
                       await allowanceGridObj.PopulateGridView(allowanceGridObj.fullList = dbModel.Employee_Allowance_Table.ToList());
                    }
                }
            }
        }
    }
}
