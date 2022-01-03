using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EISProject.Modals
{
    public partial class AddAttendanceUi : Form
    {


        public AddAttendanceUi()
        {
            InitializeComponent();

            
        }

        private async void addDepartmentButton_Click(object sender, EventArgs e)
        {


            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {

                var timeOut = timeOutPicker.Value.TimeOfDay;
                var workingHours = timeOutPicker.Value.Subtract(timeInPicker.Value).Hours;
                int employeeId = int.Parse(employeeComboBox.Text.Substring(0, employeeComboBox.Text.IndexOf(' ')));
                var date = monthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd");

                if (dbModel.Employee_Information_Table.Where(i => i.employee_id == employeeId && i.employee_status == "ARCHIVED").SingleOrDefault() != null)
                {
                    bunifuSnackbar1.Show(this, "Cannot Proceed, employee is archived \n please refresh they application to see employee updates", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }


               
                else if (dbModel.Employee_Attendance_Table.Where(i => i.date.Value.ToString() == date && i.employee_id == employeeId).SingleOrDefault() != null)
                {
                    bunifuSnackbar1.Show(this, "Cannot Add, duplicate attendance is invalid", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                else {

                    var month = monthCalendar1.SelectionStart.ToLongDateString();

                    var attendance = new Employee_Attendance_Table()
                    {
                        time_in = timeInPicker.Value.ToLongTimeString(),
                        time_out = timeOutPicker.Value.ToLongTimeString(),
                        employee_id = employeeId,
                        employee_name = employeeComboBox.Text.Substring(employeeComboBox.Text.IndexOf('-') + 1),
                        overtime_hours = timeOut > new TimeSpan(17, 30, 00) ? (int)Math.Round(timeOut.Subtract(new TimeSpan(17, 30, 00)).TotalHours, 1) : 0,
                        working_hours = workingHours,
                        date = monthCalendar1.SelectionStart.Date,
                      
                        attendance_status = timeInPicker.Value.TimeOfDay > new TimeSpan(8, 0, 0) ? "Late" : "On-Time",

                        day_type = dbModel.Holidays_Table.Where(i => i.date_occurrence == month).SingleOrDefault() != null ? "REGULAR HOLIDAY" : "REGULAR DAY",
                       
                    };

                    attendance.rate_earned = DataBaseFunctions.Attendance.CalculateTotalEarned((decimal)dbModel.Employee_Information_Table.Where(i => i.employee_id == employeeId).Select(i => i.rate_per_hour).SingleOrDefault(), workingHours, attendance.day_type);

                    dbModel.Employee_Attendance_Table.Add(attendance);
                    await dbModel.SaveChangesAsync();
                    await ControlForms.AttendanceListUi.AttendanceGridObj.PopulateGridView(ControlForms.AttendanceListUi.AttendanceGridObj.fullList = dbModel.Employee_Attendance_Table.Where(i => i.time_out != null).ToList());


                    new NotificationUi("Successfully Add new Attendance", NotificationUi.NotificationType.restore);
                    this.Close();
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AddAttendanceUi_Load(object sender, EventArgs e)
        {
            employeeComboBox.DataSource = await DataBaseFunctions.EmployeeEntity.GetEmployeeNamesIDs();
        }
    }
}
