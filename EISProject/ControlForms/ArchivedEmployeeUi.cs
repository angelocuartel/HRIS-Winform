using System;
using System.Data;
using System.Linq;
using EISProject.DataBaseFunctions;
using System.Windows.Forms;

namespace EISProject.ControlForms
{
    public partial class ArchivedEmployeeUi : UserControl
    {
        public static DataGridAction<Employee_Information_Table> GridObjArchived { get { return gridObjArchived; } }
        private static DataGridAction<Employee_Information_Table> gridObjArchived;
        private EmployeeInformationSystemDataBaseEntities model = new EmployeeInformationSystemDataBaseEntities();
        public ArchivedEmployeeUi()
        {
            InitializeComponent();
           
        }



        private  void activeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (archivedDataGridView.Columns[e.ColumnIndex].Name == "unarchived" && archivedDataGridView.Rows.Count > 0)
            {
                using(var passwordGui = new Modals.AdminPasswordUi(int.Parse(archivedDataGridView.CurrentRow.Cells[0].Value.ToString()), $"{archivedDataGridView.CurrentRow.Cells[1].Value} {archivedDataGridView.CurrentRow.Cells[2].Value}", "Restoring Employee"))
                {
                    passwordGui.ShowDialog();
                }
     
            
            

             

            }
        }

  

        private async void guna2ComboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            await gridObjArchived.FilterGridView(filterComboBox.Text, "None",true);
        }

        private async void activeDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           await gridObjArchived.SortGridView(archivedDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

       

        private async void dropEmpButton_Click(object sender, EventArgs e)
        {
            if (GridObjArchived.fullList.Count > 0)
            {
                int empId = int.Parse(archivedDataGridView.CurrentRow.Cells[0].Value.ToString());

                if (MessageBox.Show($"Do you want to drop Employee {empId} By doing this you will not be able to retrieve the employee and its associated records", "Drop Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {

                        var employee = dbModel.Employee_Information_Table.Where(i => i.employee_id == empId).SingleOrDefault();


                        // delete employee files
                        System.IO.File.Delete(employee.profile_picture);
                        EmployeeFile.DeleteEmployeeFiles(empId);

                        //delete portal account


                        // delete portal account log history


                        // delete cashadvance

                        
                        // delete employee attendance


                        // delete employee payslip



                     
                       

                        dbModel.Entry(employee).State = System.Data.Entity.EntityState.Deleted;
                        dbModel.SaveChanges();


                        //refresh archived list
                       await gridObjArchived.PopulateGridView(gridObjArchived.fullList = dbModel.Employee_Information_Table.Where(i => i.employee_status == "ARCHIVED").ToList());


                        //refresh cashadvance list

                        // refresh payslip list

                        // refresh employee files list

                        // refresh dashboard
                        if (EISMainForm.Dashboard_HasClick)
                            DashBoardUi.DashboardObj.LoadDashboardPanel();

                    }
                }
            }
        }

        private  async void dropAllEmpbutton_Click(object sender, EventArgs e)
        {
            if (archivedDataGridView.Rows.Count > 0)
            {
                if (MessageBox.Show($"Do you really want to Drop all Archived Employees ? by doing so you will not be able to recover", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        var empList = dbModel.Employee_Information_Table.Where(i => i.employee_status == "ARCHIVED").ToList();

                        // delete files and profiles
                        foreach (var item in empList)
                        {
                            EmployeeFile.DeleteEmployeeFiles(item.employee_id);
                            System.IO.File.Delete(item.profile_picture);
                        }




                        dbModel.Employee_Information_Table.RemoveRange(dbModel.Employee_Information_Table.RemoveRange(empList));
                        dbModel.SaveChanges();



                      await  gridObjArchived.PopulateGridView(gridObjArchived.fullList = dbModel.Employee_Information_Table.Where(i => i.employee_status == "ARCHIVED").ToList());
                    }
                    if (EISMainForm.Dashboard_HasClick)
                            DashBoardUi.DashboardObj.LoadDashboardPanel();
                    new Modals.NotificationUi(" Deleted All Archived Employee ", Modals.NotificationUi.NotificationType.archived).Show();
                }


            }
        }

        private async void searchTextBox_TextChanged(object sender, EventArgs e)
        {
           await gridObjArchived.SearchGridView(searchTextBox.Text, "employee_id", "given_name", "last_name");
        }

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void ArchivedEmployeeUi_Load(object sender, EventArgs e)
        {
            gridObjArchived = new DataGridAction<Employee_Information_Table>(archivedLabel, totalRecordsLabel, archivedDataGridView, model.Employee_Information_Table.Where(i => i.employee_status == "ARCHIVED").ToList());
            await GridObjArchived.PopulateGridView(gridObjArchived.fullList);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            var report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            report.Load(@"C:\Users\Boss\Documents\Visual Studio 2015\Projects\EISProject\EISProject\Reports\ReportDocuments\ArchivedEmployee.rpt");
            report.SetDataSource(gridObjArchived.PrintList.OrderBy(i => i.last_name).Select(i => new { i.last_name, i.given_name, i.middle_name, i.gender, i.phone_number, i.email_address }));



            new Reports.ReportViewer(report).Show();
        }
    }
}
