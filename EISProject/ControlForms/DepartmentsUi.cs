using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using EISProject.DataBaseFunctions;
using System.Linq.Dynamic.Core;
using SharpValidation;

namespace EISProject.ControlForms
{
    public partial class DepartmentsUi : UserControl
    {
        public static DataGridAction<Department_Table> DepartmentObjGrid { get { return departmentObjGrid; } }
        private static DataGridAction<Department_Table> departmentObjGrid;
   
        public DepartmentsUi()
        {
            InitializeComponent();

            var dBmodel = new EmployeeInformationSystemDataBaseEntities();

            departmentObjGrid = new DataGridAction<Department_Table>(activeLabel, totalRecordsLabel, departmentDataGridView, dBmodel.Department_Table.ToList());

        }






        private async  void departmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (departmentDataGridView.Columns[e.ColumnIndex].HeaderText == "Action")
            {
                var departmentName = departmentDataGridView.CurrentRow.Cells[0].Value.ToString();

                if (MessageBox.Show($"Do you really want to delete {departmentName} ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        var department = dbModel.Department_Table.SingleOrDefault(i => i.department_name == departmentName);
                        dbModel.Entry(department).State = System.Data.Entity.EntityState.Deleted;
                        await dbModel.SaveChangesAsync();

                       await departmentObjGrid.PopulateGridView(dbModel.Department_Table.ToList());

                       
                    }

                    await Department.RemoveAllEmployees(departmentName);

                    new Modals.NotificationUi("Successfully Deleted a Department", Modals.NotificationUi.NotificationType.restore).Show();
                }

               
            }

           
        }
    




        private async void departmentDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await departmentObjGrid.SortGridView(departmentDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

    

        private void viewAssignedEmpButton_Click(object sender, EventArgs e)
        {
            if (departmentDataGridView.Rows.Count > 0)
            {
                using (var viewEmpDep = new Modals.ViewDepartmentEmployees(departmentDataGridView.CurrentRow.Cells[0].Value.ToString(), departmentDataGridView.CurrentRow.Cells[2].Value.ToString()))
                {
                    viewEmpDep.ShowDialog();
                }
            }
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            using (var addForm = new Modals.AddDepartmentUi())
            {
                addForm.ShowDialog();
            }
        }

        private async void searchTextBox_TextChanged(object sender, EventArgs e)
        {
           await departmentObjGrid.SearchGridView(searchTextBox.Text, "department_name", "department_head", "department_code");
        }

        private async void DepartmentsUi_Load(object sender, EventArgs e)
        {
            await departmentObjGrid.PopulateGridView(departmentObjGrid.fullList);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            var depName = departmentDataGridView.CurrentRow.Cells[0].Value.ToString();

            using (var editDepartment = new Modals.AddDepartmentUi(departmentObjGrid.fullList.Where(i => i.department_name == depName).SingleOrDefault()))
            {
                editDepartment.ShowDialog();
            }
        }
    }
}
