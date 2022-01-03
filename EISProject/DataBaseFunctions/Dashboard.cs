using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EISProject.DataBaseFunctions
{
  public class Dashboard
    {
        private Label[] dashboardCountLabel;
        private Chart employeeChart;
        private List<Employee_Information_Table> employeeList;

        public Dashboard(Chart employeeChart, params Label[] dashboardCountLabel)
        {
            this.dashboardCountLabel = dashboardCountLabel;
            this.employeeChart = employeeChart;

            this.employeeList = GetEmployeeList();
        }

   

        private List<Employee_Information_Table> GetEmployeeList()
        {
           
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    return dbModel.Employee_Information_Table.ToList();
                }
         
        }

        public void LoadDashboardPanel()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var attendanceList = dbModel.Employee_Attendance_Table.Select(i => new {Attendance = i.attendance_status , Date = i.date }).ToList();

                this.dashboardCountLabel[0].Text = employeeList.Count(i => i.employee_status == "ACTIVE").ToString();
                this.dashboardCountLabel[1].Text = employeeList.Count(i => i.employee_status == "ARCHIVED").ToString();
                this.dashboardCountLabel[2].Text = dbModel.Employees_Documents_Table.Count().ToString();
                this.dashboardCountLabel[3].Text = dbModel.Department_Table.Count().ToString();
                this.dashboardCountLabel[4].Text = attendanceList.Count(i =>i.Date == DateTime.Today).ToString();
                this.dashboardCountLabel[5].Text = attendanceList.Count(i => i.Attendance == "On-Time" && i.Date == DateTime.Today).ToString();
                this.dashboardCountLabel[6].Text = attendanceList.Count(i => i.Attendance == "Late" && i.Date == DateTime.Today).ToString();
                this.dashboardCountLabel[7].Text = dbModel.HRIS_Account_Table.Where(i =>i.account_status == "ACTIVE").Count().ToString();

            }
        }
        
        
        public void LoadDashboardEmployeeChart()
        {
            this.employeeChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.employeeChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            this.employeeChart.ChartAreas[0].AxisX.Interval = 1;
            this.employeeChart.ChartAreas[0].AxisX.Title = "Months";

            this.employeeChart.Series["Employees"].Points.AddXY("January", this.employeeList.Count(i =>i.date_added.Value.ToLongDateString().Contains("January")));
            this.employeeChart.Series["Employees"].Points.AddXY("February", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("February")));
            this.employeeChart.Series["Employees"].Points.AddXY("March", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("March")));
            this.employeeChart.Series["Employees"].Points.AddXY("April", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("April")));
            this.employeeChart.Series["Employees"].Points.AddXY("May", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("May")));
            this.employeeChart.Series["Employees"].Points.AddXY("June", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("June")));
            this.employeeChart.Series["Employees"].Points.AddXY("July", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("July")));
            this.employeeChart.Series["Employees"].Points.AddXY("Aug", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("Aug")));
            this.employeeChart.Series["Employees"].Points.AddXY("Sept", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("Sept")));
            this.employeeChart.Series["Employees"].Points.AddXY("Oct", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("Oct")));
            this.employeeChart.Series["Employees"].Points.AddXY("Nov", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("Nov")));
            this.employeeChart.Series["Employees"].Points.AddXY("Dec", this.employeeList.Count(i => i.date_added.Value.ToLongDateString().Contains("Dec")));
        }    
    }
}
