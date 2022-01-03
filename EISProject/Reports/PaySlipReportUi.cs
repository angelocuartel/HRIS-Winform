using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EISProject.Reports
{
    public partial class PaySlipReportUi : Form
    {
        private int employeeID;
        private string department;
        private string position;
        private Payroll_Table payslip;
        private List<Employee_Attendance_Table> attendanceList;


        public PaySlipReportUi(string department, string position, int employeeID, Payroll_Table payslip)
        {
            InitializeComponent();

            this.department = department;
            this.position = position;
            this.employeeID = employeeID;
            this.payslip = payslip;


            this.attendanceList = GetAttendanceList();

            LoadCrystalReportTextObjects();
         
        }


       

        private string ConvertDecimalToPeso(decimal? amount)
        {
            return ((decimal)amount).ToString("C2", new System.Globalization.CultureInfo("en-PH"));
        }

        private int CountWorkingDays(DateTime start, DateTime end)
        {

            int workingDays = 0;



            int dayCount = (int)start.DayOfWeek;


            for(int dt = 1; dt <= (end - start ).TotalDays + 1; dt++)
            {
              
                
                if (dayCount != 0)
                {
                    workingDays++;
                }



                if (dayCount == 6)
                    dayCount = -1;

                dayCount++;


            }

            return workingDays;
        }

        private List<Employee_Attendance_Table> GetAttendanceList()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                return dbModel.Employee_Attendance_Table.Where(i => i.date.Value >= payslip.cutoff_start && i.date.Value <= payslip.cutoff_end && i.employee_id == this.employeeID).ToList();
            }

        }


        private void LoadCrystalReportTextObjects()
        {
            int onTimeCount = this.attendanceList.Where(i => i.attendance_status == "On-Time").Count();
            int lateCount = this.attendanceList.Where(i => i.attendance_status == "Late").Count();
            int workingDays = CountWorkingDays(payslip.cutoff_start.Value, payslip.cutoff_end.Value);
            int absentCount = (onTimeCount + lateCount) == workingDays ? 0 : workingDays - (onTimeCount + lateCount);



            var listDictionary = new Dictionary<string, string>()
            {
                {"Section1,fullnameTextObject",payslip.employee_name },
                {"Section1,positionTextObject",position },
                {"Section1,departmentTextObject",department },
                {"Section1,dateTodayTextObject",DateTime.Now.ToLongDateString() },
                {"Section1,netpayTextObject",ConvertDecimalToPeso(payslip.net_pay) },
                {"Section1,cuttoffDateTextObject",$"{payslip.cutoff_start.Value.ToLongDateString()} to {payslip.cutoff_end.Value.ToLongDateString()}" },
                {"Section2,ontimeTextObject",$"{onTimeCount} Day(s)" },
                {"Section2,absentTextObject",$"{absentCount} Day(s)" },
                {"Section2,lateTextObject",$"{lateCount} Day(s)" },
                {"Section2,totaldaysWorkTextObject",$"{payslip.total_days_work} Day(s)" },
                {"Section2,hoursRenderedTextObject",$"{payslip.total_hours_rendered} Hour(s)" },
                {"Section2,totalOvertimeTextObject",$"{payslip.total_overtime_hours} Hour(s)"},
                {"Section2,basicPayTextObject",ConvertDecimalToPeso(payslip.basic_pay)},
                {"Section2,otPayTextObject",ConvertDecimalToPeso(payslip.overtime_pay) },
                {"Section2,grossPayTextObject",ConvertDecimalToPeso(payslip.gross_pay) },
                {"Section3,lateDeductionTextObject",ConvertDecimalToPeso(payslip.late_deductions) },
                {"Section3,taxDeductionTextObject",ConvertDecimalToPeso(payslip.withholding_tax)},
                {"Section3,pagibigTextObject",ConvertDecimalToPeso(payslip.pag_ibig_contribution) },
                {"Section3,philhealthTextObject",ConvertDecimalToPeso(payslip.philhealth_contribution) },
                {"Section3,othersTextObject",ConvertDecimalToPeso(payslip.other_deductions) },
                {"Section3,totalDeductionsTextObject",ConvertDecimalToPeso(payslip.late_deductions + payslip.gsis_sss_contribution + payslip.withholding_tax + payslip.pag_ibig_contribution + payslip.philhealth_contribution + payslip.other_deductions+payslip.absent_deduction) },
                {"Section3,remainingBalanceTextObject",ConvertDecimalToPeso(payslip.cash_advance_remaining_balance) },
                {"Section3,absentDeductionTextObject",ConvertDecimalToPeso(payslip.absent_deduction) },
                {"Section3,allowanceTextObject",ConvertDecimalToPeso(payslip.allowance) },
                {"Section3,sssTextObject",ConvertDecimalToPeso(payslip.gsis_sss_contribution) },
                {"Section3,paymentPerMonthTextObject",ConvertDecimalToPeso(payslip.cash_advance_payment)}



            };

            foreach (var item in listDictionary.Keys)
            {
                var objText = (TextObject)PaySlip1.ReportDefinition.Sections[item.Substring(0, item.IndexOf(','))].ReportObjects[item.Substring(item.IndexOf(',') + 1)];
                objText.Text = listDictionary[item];
            }
        }

    }
}

