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
    public partial class CashAdvanceUi : UserControl
    {
        public static DataGridAction<Cash_Advance_Table> CashGridObj { get { return cashGridObj; } }
        static DataGridAction<Cash_Advance_Table> cashGridObj;
        public CashAdvanceUi()
        {
            InitializeComponent();
           
        }

        private async void CashAdvanceUi_Load(object sender, EventArgs e)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                cashGridObj = new DataGridAction<Cash_Advance_Table>(cashEmptyLabel, totalRecordsLabel, cashAdvanceDataGridView, dbModel.Cash_Advance_Table.ToList());
                await cashGridObj.PopulateGridView(cashGridObj.fullList);
                
            }

            LoadTotalAmount();


        }

        private void LoadTotalAmount()
        {
            amountsLabel.Text = cashGridObj.fullList.Select(i => i.amount).Sum().ToString();
        }

        private async void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            await cashGridObj.SearchGridView(bunifuTextBox1.Text, "employee_name");
        }

        private async void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            await cashGridObj.FilterGridView(guna2ComboBox3.Text, "None", false);
        }

        private async void cashAdvanceDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await cashGridObj.SortGridView(cashAdvanceDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            using (var cashAdvanceForm = new Modals.AddCashAdvanceUi())
            {
                cashAdvanceForm.ShowDialog();
            }

            LoadTotalAmount();
        }

        private async void cashAdvanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cashAdvanceDataGridView.Rows.Count > 0 && cashAdvanceDataGridView.Columns[e.ColumnIndex].HeaderText == "Action")
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?\n remaining balance that needs to paid will be void if continue", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        int id = int.Parse(cashAdvanceDataGridView.CurrentRow.Cells[0].Value.ToString());

                        var cashAdvance = dbModel.Cash_Advance_Table.Where(i => i.employee_id == id).SingleOrDefault();

                        dbModel.Entry(cashAdvance).State = System.Data.Entity.EntityState.Deleted;
                        dbModel.SaveChanges();

                        await cashGridObj.PopulateGridView(cashGridObj.fullList = dbModel.Cash_Advance_Table.ToList());
                        new Modals.NotificationUi("Successfully Deleted Cash Advance Record", Modals.NotificationUi.NotificationType.archived);
                    }
                }
            }
        }
    }
}
