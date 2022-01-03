using System;
using System.Linq;
using System.Windows.Forms;

namespace EISProject.DataBaseFunctions
{
   public  class Attendance
    {

        private Control buttonTimeInOut;
        public int employeeId;
        private string timeIn;
        private string timeOut;
        private int graceTimePeriod;
        static private int holidayPercent;


        public bool IsEmployeeTimeIn { get { return IsTimeIn(); } }
        public Attendance(Control buttonTimeInOut , int employeeId)
        {
            this.buttonTimeInOut = buttonTimeInOut;
            this.employeeId = employeeId;

            LoadTimeType();
            SetTimeSchedules();

        }



        public void TimeIn()
        {
            SetTimeSchedules();

        
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var timeIn = new Employee_Attendance_Table()
                {
                    employee_id = this.employeeId,
                    date = DateTime.Today,
                    time_in = DateTime.Now.ToLongTimeString(),
                    attendance_status = SetAttendanceStatus(),
                    day_type = GetDayType()
                };


                dbModel.Employee_Attendance_Table.Add(timeIn);
                dbModel.SaveChanges();


            }

            this.buttonTimeInOut.Text = "Time Out";
        }


        public void TimeOut()
        {
            using (var DbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var employeeName = DbModel.Employee_Information_Table.Where(i => i.employee_id == this.employeeId).Select(i => new { LastName = i.last_name, GivenName = i.given_name,RatePerHour = i.rate_per_hour }).SingleOrDefault();
          
                var logTime = DbModel.Employee_Attendance_Table.Where(i => i.date == DateTime.Today && i.employee_id == this.employeeId && i.time_out == null).SingleOrDefault();

                int workHours = (int)GetWorkingHours(logTime.time_in, DateTime.Now.ToLongTimeString());
                logTime.time_out = DateTime.Now.ToLongTimeString();
                logTime.working_hours = workHours;
                logTime.overtime_hours = GetOverTimeHours();
                logTime.rate_earned = CalculateTotalEarned((decimal)employeeName.RatePerHour, workHours,GetDayType());
                logTime.employee_name = $"{employeeName.GivenName} {employeeName.LastName}";


                DbModel.Entry(logTime).State = System.Data.Entity.EntityState.Modified;
                DbModel.SaveChanges();
            }

            this.buttonTimeInOut.Text = "Time In";
        }


        private bool IsTimeIn()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                return dbModel.Employee_Attendance_Table.Where(i => i.date == DateTime.Today && i.time_in != null && i.time_out != null && i.employee_id == this.employeeId).SingleOrDefault() != null;
            }
        }


        private string GetDayType()
        {


            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var dateNow = DateTime.Today.ToLongDateString();
             
                return dbModel.Holidays_Table.Where(i => i.date_occurrence == dateNow).SingleOrDefault() != null ? "REGULAR HOLIDAY" : "REGULAR DAY";
            }
        }
        private void LoadTimeType()
        {

            using (var model = new EmployeeInformationSystemDataBaseEntities())

            {
                var logTime = model.Employee_Attendance_Table.Where(i => i.date == DateTime.Today && i.employee_id == this.employeeId && i.time_out == null).SingleOrDefault();

                if (logTime == null)
                {
                    this.buttonTimeInOut.Text = "Time In";
                }
                else
                {
                    this.buttonTimeInOut.Text = "Time Out";
                }
            }

        }


     



        private int GetWorkingHours(string timeIn, string timeOut)
        {
            var timeInHours = DateTime.Parse(timeIn);
            var timeOutHours = DateTime.Parse(timeOut);


            return timeOutHours.Subtract(timeInHours).Hours;
        }

        public static decimal CalculateTotalEarned(decimal ratePerHour, int timeOfWork, string dayType)
        {

            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                holidayPercent = (int)dbModel.Adjustment_Global_Settings_Table.Where(i => i.adjustment_type == "holiday").Select(i => i.amount_percent).SingleOrDefault();

            }

            return dayType == "REGULAR HOLIDAY" ? (timeOfWork * ratePerHour) * (holidayPercent / 100) : timeOfWork * ratePerHour;
        }


        private string SetAttendanceStatus()
        {
            return DateTime.Now.TimeOfDay > ConvertStringToTimeSPan(this.timeIn).Add(new TimeSpan(0, this.graceTimePeriod, 0)) ? "Late" : "On-Time";
        }

        private void SetTimeSchedules()
        {
            using (var dbModel= new EmployeeInformationSystemDataBaseEntities())
            {
                var schedSettings = dbModel.Attendance_Global_Settings_Table.FirstOrDefault();
                this.timeIn = schedSettings.global_time_in_mandatory;
                this.timeOut = schedSettings.global_time_out_mandatory;
                this.graceTimePeriod = (int)schedSettings.late_grace_time_period;
            }
        }


        private TimeSpan ConvertStringToTimeSPan(string time)
        {
            return TimeSpan.Parse(time.Replace("PM", "").Replace("AM", "").Trim());
        }



        private int GetOverTimeHours()
        {

            var outTime = ConvertStringToTimeSPan(this.timeOut);

            if (ConvertStringToTimeSPan(DateTime.Now.ToLongTimeString()) > outTime)
            {
                return (int)Math.Round(ConvertStringToTimeSPan(DateTime.Now.ToLongTimeString()).Subtract(outTime).TotalHours, 1);
            }
            else
            {
                return 0;
            }
        }




    }
}
