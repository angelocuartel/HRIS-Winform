using System;
using EISProject.DataBaseFunctions;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;
using CrystalDecisions.CrystalReports.Engine;

namespace EISProject.ControlForms
{
    public partial class ActiveEmployeeUi : UserControl
    {
        public static DataGridAction<Employee_Information_Table> GridObj { get { return gridObj; } }
        private static DataGridAction<Employee_Information_Table> gridObj;

        
        EmployeeInformationSystemDataBaseEntities model = new EmployeeInformationSystemDataBaseEntities();
        public  ActiveEmployeeUi()
        {
            InitializeComponent();
            
          
        }

        private async  void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
          
           await gridObj.SearchGridView(bunifuTextBox1.Text, "given_name","last_name");
        }

        private async void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           await gridObj.FilterGridView(guna2ComboBox3.Text,"None",true);

        }


        private async void activeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (activeDataGridView.Columns[e.ColumnIndex].Name == "archived" && activeDataGridView.Rows.Count > 0)
            {


                var employeeName = $"{activeDataGridView.CurrentRow.Cells[1].Value} {activeDataGridView.CurrentRow.Cells[2].Value}";

                int employeeId = int.Parse(activeDataGridView.CurrentRow.Cells[0].Value.ToString());

                

                if (!SystemUser.HasValidPassword)
                {
                    using (var adminUI = new Modals.AdminPasswordUi(employeeId, employeeName, "Admin Password Required"))
                    {
                        adminUI.ShowDialog();
                    }
                }

                if (SystemUser.HasValidPassword)
                {
                    using (var archivedEmoloyee = new Modals.ArchivingEmployeUi(employeeId, employeeName))
                    {
                        archivedEmoloyee.ShowDialog();

                    }

                    // refresh active employee datagridview
                     await gridObj.PopulateGridView(gridObj.fullList = model.Employee_Information_Table.Where(i => i.employee_status == "ACTIVE" ).ToList());
                }


              
                    


                
               


                

                //refresh dashboard data
               // DashBoardUi.DashboardObj.RefreshDashboard();
              
            }

          
        }

  

   



        private async void activeDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           await gridObj.SortGridView(activeDataGridView.Columns[e.ColumnIndex].DataPropertyName);

        }

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {
            if (activeDataGridView.Rows.Count > 0)
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    var id = activeDataGridView.CurrentRow.Cells[0].Value.ToString();
                    var employee = dbModel.Employee_Information_Table.Where(i => i.employee_id.ToString() == id).FirstOrDefault();

                    using (var form = new Modals.EditViewEmployee(employee))
                    {
                        form.ShowDialog();
                    }

                }
            }
        }

      

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            new Modals.AddNewEmployeeUi().ShowDialog();
        }

        private async void ActiveEmployeeUi_Load(object sender, EventArgs e)
        {
            gridObj = new DataGridAction<Employee_Information_Table>(activeLabel, totalRecordsLabel, activeDataGridView, model.Employee_Information_Table.Where(i => i.employee_status == "ACTIVE").ToList());
            await gridObj.PopulateGridView(gridObj.fullList);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

           

                var report = new ReportDocument();
                report.Load(@"C:\Users\Boss\Documents\Visual Studio 2015\Projects\EISProject\EISProject\Reports\ReportDocuments\employee.rpt");
                report.SetDataSource( gridObj.PrintList.OrderBy(i => i.last_name).Select(i => new { i.last_name, i.given_name, i.middle_name, i.gender, i.phone_number, i.email_address }));

            

                new Reports.ReportViewer(report).Show();

            
        }
    }
}
