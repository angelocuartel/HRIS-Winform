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
    public partial class PositionUi : UserControl
    {
        public static DataGridAction<Employee_Positions_Table> JobObjGrid { get { return jobObjGrid; } }
        private static  DataGridAction<Employee_Positions_Table> jobObjGrid;
        public PositionUi()
        {
            InitializeComponent();

            jobObjGrid = new DataGridAction<Employee_Positions_Table>(EmptyLabel,totalRecordsLabel,positionDataGridView,new EmployeeInformationSystemDataBaseEntities().Employee_Positions_Table.ToList());
        }

        private async void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            await jobObjGrid.SearchGridView(bunifuTextBox1.Text, "position");
        }

        private async void PositionUi_Load(object sender, EventArgs e)
        {
            await jobObjGrid.PopulateGridView(jobObjGrid.fullList);
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            using (var addPositionForm = new Modals.AddEditPosition())
            {
                addPositionForm.ShowDialog();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (positionDataGridView.Rows.Count > 0)
            {
                using (var addPositionForm = new Modals.AddEditPosition(positionDataGridView.CurrentRow.Cells[0].Value.ToString()))
                {
                    addPositionForm.ShowDialog();
                }
            }
        }

        private async void positionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(positionDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                
                var position = positionDataGridView.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show($"Do you want to Delete Position {position} ?", "Delete Position", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {

                        var positionDelete = dbModel.Employee_Positions_Table.Where(i => i.position == position).SingleOrDefault();

                        dbModel.Entry(positionDelete).State = System.Data.Entity.EntityState.Deleted;
                        await dbModel.SaveChangesAsync();
                        await jobObjGrid.PopulateGridView(jobObjGrid.fullList = dbModel.Employee_Positions_Table.ToList());
                    }

                    new Modals.NotificationUi("Sucessfully Deleted a position", Modals.NotificationUi.NotificationType.archived);
                }
            }
        }

        private async void positionDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await jobObjGrid.SortGridView(positionDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
}
