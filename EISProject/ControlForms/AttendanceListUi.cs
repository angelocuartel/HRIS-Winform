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
    public partial class AttendanceListUi : UserControl
    {
        public static DataGridAction<Employee_Attendance_Table> AttendanceGridObj { get { return attendanceGridObj; } }
        private static DataGridAction<Employee_Attendance_Table> attendanceGridObj;
        public AttendanceListUi()
        {
            InitializeComponent();

            
        }

        private async void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            await attendanceGridObj.SearchGridView(searchTextBox.Text, "employee_name");
        }

        private async void AttendanceListUi_Load(object sender, EventArgs e)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                attendanceGridObj = new DataGridAction<Employee_Attendance_Table>(attendanceEmptyLabel, totalRecordsLabel, attendanceDataGridView, dbModel.Employee_Attendance_Table.ToList());
                await attendanceGridObj.PopulateGridView(attendanceGridObj.fullList);
            }
          
        }

      

        private async void attendanceDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await attendanceGridObj.SortGridView(attendanceDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            using (var addAttendanceForm = new Modals.AddAttendanceUi())
            {
                addAttendanceForm.ShowDialog();
            }
        }

        private async void attendanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(attendanceDataGridView.Columns[e.ColumnIndex].HeaderText == "Action" && attendanceDataGridView.Rows.Count > 0)
            {
                if(MessageBox.Show("Do you want to Delete this Attendance ?","Delete Attendance",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        int id = int.Parse( attendanceDataGridView.CurrentRow.Cells[0].Value.ToString());
                        var attendanceItem = dbModel.Employee_Attendance_Table.Where(i => i.attendance_id ==id).SingleOrDefault();

                        dbModel.Entry(attendanceItem).State = System.Data.Entity.EntityState.Deleted;
                        await dbModel.SaveChangesAsync();
                       await attendanceGridObj.PopulateGridView(dbModel.Employee_Attendance_Table.ToList());
                    }

                    new Modals.NotificationUi("Successfully Delete Attendance", Modals.NotificationUi.NotificationType.restore);
                }
            }
        }

        private async void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await attendanceGridObj.FilterGridView(filterComboBox.Text, "None", true);
        }

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {

            var report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            report.Load(@"C:\Users\Boss\Documents\Visual Studio 2015\Projects\EISProject\EISProject\Reports\ReportDocuments\Attendance.rpt");
            report.SetDataSource(attendanceGridObj.PrintList.OrderBy(i => i.employee_name).Select(i => new { i.employee_name,i.date,i.time_in,i.time_out,i.attendance_status,i.day_type }));



            new Reports.ReportViewer(report).Show();
        }
    }
}
