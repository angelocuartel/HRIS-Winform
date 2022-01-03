using System;
using System.Linq;
using System.Windows.Forms;
using EISProject.DataBaseFunctions;
namespace EISProject.ControlForms
{
    public partial class EmployeeFilesUi : UserControl
    {
        private static DataGridAction<Employees_Documents_Table> docGrid;
        public static DataGridAction<Employees_Documents_Table> DocGrid { get { return docGrid; } }
        EmployeeInformationSystemDataBaseEntities model = new EmployeeInformationSystemDataBaseEntities();

        public EmployeeFilesUi()
        {
            InitializeComponent();
       
        }

    

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Modals.ViewEmployeeFileUi(docGrid.fullList.Where(i =>i.file_id == int.Parse(employeeFilesDataGridView.CurrentRow.Cells[0].Value.ToString())).Select(i => i.filename).FirstOrDefault()).ShowDialog();
        }



        private async void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           await docGrid.FilterGridView(filterFileComboBox.Text, "None",true);

        }



      



        private async void employeeFilesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(employeeFilesDataGridView.Columns[e.ColumnIndex].HeaderText == "Action")
            {
                if (MessageBox.Show("Do you want to delete this file ?", "Deleting File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        int fileId = int.Parse(employeeFilesDataGridView.CurrentRow.Cells[0].Value.ToString());
                        var file = docGrid.fullList.Where(i => i.file_id == fileId).SingleOrDefault();

                        System.IO.File.Delete(file.filename);

                        dbModel.Entry(file).State = System.Data.Entity.EntityState.Deleted;
                        dbModel.SaveChanges();

                       await docGrid.PopulateGridView(docGrid.fullList = dbModel.Employees_Documents_Table.ToList());
                    }
                }

                
            }
        }

        private async void employeeFilesDataGridView_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           await docGrid.SortGridView(employeeFilesDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

     
        

      
        private async void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            await docGrid.SearchGridView(searchTextBox.Text, "filetype", "employee_name");
        }

        private void dropAllEmpbutton_Click(object sender, EventArgs e)
        {
            if (employeeFilesDataGridView.Rows.Count > 0)
            {
                if (MessageBox.Show($"Do you really want to delete all Employee Files ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                
                    DataBaseFunctions.EmployeeFile.DeleteAllFiles();
                    new Modals.NotificationUi("Successfully Delete All Employee Files ", Modals.NotificationUi.NotificationType.restore).Show();
                }


            }
        }

        private void viewFileButton_Click(object sender, EventArgs e)
        {
            if (employeeFilesDataGridView.RowCount > 0)
            {
                using (var viewFileForm = new Modals.ViewEmployeeFileUi(docGrid.fullList.Where(i => i.file_id.ToString() == employeeFilesDataGridView.CurrentRow.Cells[0].Value.ToString()).Select(i => i.filename).FirstOrDefault()))
                {
                    viewFileForm.ShowDialog();
                }
            }
        }

        private void employeeFilesDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (employeeFilesDataGridView.Columns[e.ColumnIndex].HeaderText == "Action" && employeeFilesDataGridView.Rows.Count > 0)
            {
                int fileID = int.Parse(employeeFilesDataGridView.CurrentRow.Cells[0].Value.ToString());

                if (MessageBox.Show($"Do you really want to delete {fileID} ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    DataBaseFunctions.EmployeeFile.DeleteSingleFile(fileID);

                    new Modals.NotificationUi("Successfully Deleted an Employee File", Modals.NotificationUi.NotificationType.restore).Show();
                }


            }
        }

        private async void EmployeeFilesUi_Load(object sender, EventArgs e)
        {
            docGrid = new DataGridAction<Employees_Documents_Table>(fileLabel, totalRecordsLabel, employeeFilesDataGridView, model.Employees_Documents_Table.ToList());
            await docGrid.PopulateGridView(docGrid.fullList);
        }
    }
}
