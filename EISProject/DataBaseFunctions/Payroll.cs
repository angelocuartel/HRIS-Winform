using System;
using System.Collections.Generic;
using System.Linq;


namespace EISProject.DataBaseFunctions
{
    public static class Payroll
    {
        static DateTime _endTime;
        static DateTime _startTime;
        static int _employeeID;
        static decimal _ratePerHour;
        static bool _hasGovernmentDeduction;
        static bool _hasOtherDeduction;
        static bool _hasOverTimePay;
        static List<Employee_Attendance_Table> _attendanceList;
        static int _otPercent;
        static decimal _latePenalty;
        static decimal _absentPenalty;



        private static List<Employee_Attendance_Table> GetAttendance(int employeeID)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
              
                return dbModel.Employee_Attendance_Table.Where(i => i.date.Value >= _startTime && i.date.Value <= _endTime && i.employee_id == employeeID).ToList();
            }
        }


        private static decimal PayCashAdvance()
        {



            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                

                Cash_Advance_Table cashAdvance = dbModel.Cash_Advance_Table.Where(i => i.employee_id == _employeeID && i.status == "UNPAID").SingleOrDefault();


                    if (cashAdvance != null)
                    {

                    if (cashAdvance.month_length > 0)
                    {
                        cashAdvance.month_length--;
                        cashAdvance.remaining_balance -= cashAdvance.amount_payment_per_month;

                        cashAdvance.total_payment += cashAdvance.amount_payment_per_month;
                        cashAdvance.status = cashAdvance.month_length == 0 ? "PAID" : "UNPAID";

                        dbModel.Entry(cashAdvance).State = System.Data.Entity.EntityState.Modified;
                        dbModel.SaveChanges();

                        return (decimal)cashAdvance.amount_payment_per_month;
                    }
                    else
                        return 0;
                    }

                    else
                        return 0;
                
                



            }


        }


        private static int GetTotalHoursRendered()
        {
            return int.Parse(_attendanceList.Sum(i => i.working_hours).ToString());
        }



        private static decimal GetBasicPay()
        {
            return decimal.Parse(_attendanceList.Sum(i => i.rate_earned).ToString());
        }

        private static int GetTotalOverTimeHours()
        {
            return int.Parse(_attendanceList.Sum(i => i.overtime_hours).ToString());
        }

        private static decimal GetOverTimePay()
        {
            if (_hasOverTimePay)
                return decimal.Parse(((_ratePerHour *(_otPercent/100)) * GetTotalOverTimeHours() ).ToString());
            else
                return 0;
        }

        private static decimal GetGrossPay()
        {
            return (decimal) (GetBasicPay() + GetOverTimePay() + GetTotalAllowances());
        }

        private static decimal GetCashAdvanceBalance()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var cashAdvanceList = dbModel.Cash_Advance_Table.Where(i => i.employee_id == _employeeID).ToList();

                return decimal.Parse(cashAdvanceList.Sum(i => i.remaining_balance).ToString());
            }
        }

        private static void SetPayAdjustments()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var adjustment = dbModel.Adjustment_Global_Settings_Table.ToList();
                _otPercent = (int)adjustment.Where(i => i.adjustment_type == "overtime").Select(i => i.amount_percent).SingleOrDefault();
            }
        }

        private static void SetPenalty()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var adjustment = dbModel.Penalty_Global_Settings_Table.ToList();
                _absentPenalty = (decimal)adjustment.Where(i => i.penalty_type == "absent").Select(i => i.penalty_amount).SingleOrDefault();
                _latePenalty = (decimal)adjustment.Where(i => i.penalty_type == "late").Select(i => i.penalty_amount).SingleOrDefault();
            }
        }


        private static decimal GetTotalLateDeductions()
        {
            return decimal.Parse((_attendanceList.Where(i => i.attendance_status.Equals("LATE", StringComparison.CurrentCultureIgnoreCase)).Count() * 50.00).ToString());
        }


        private static decimal GetGovernmentDeduction(string deductionType)
        {
            if (_hasGovernmentDeduction)
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    var amount = dbModel.Deductions_Table.Where(i => i.deduction_name.Contains(deductionType)).Select(i => i.deduction_amount).SingleOrDefault();

                    return amount == null ? 0 : decimal.Parse(amount.ToString());
                }
            }
            else
                return 0;
        }

        private static decimal GetOtherDeductions()
        {
            if (_hasOtherDeduction)
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    return decimal.Parse(dbModel.Deductions_Table.Where(i => i.deduction_type != "Government").Sum(i => i.deduction_amount).ToString());
                }
            }
            else
                return 0;
        }

        private static decimal GetTotalGovernmentDeduction()
        {
            if (_hasGovernmentDeduction)
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    var totalGovernmentDeductionList = dbModel.Deductions_Table.Where(i => i.deduction_type == "Government").ToList();

                    return totalGovernmentDeductionList.Count > 0 ? decimal.Parse(totalGovernmentDeductionList.Sum(i => i.deduction_amount).ToString()) : 0;
                }
            }
            else
                return 0;
        }


     

        private static decimal GetAbsentDeduction()
        {
            int onTimeCount = _attendanceList.Where(i => i.attendance_status == "On-Time").Count();
            int lateCount = _attendanceList.Where(i => i.attendance_status == "Late").Count();

        


            int workingDays = 0;

            int dayCount = (int)_startTime.DayOfWeek;

            for (int dt = 1; dt <= (_endTime - _startTime).TotalDays + 1; dt++)
            {


                if (dayCount != 0)
                {
                    workingDays++;
                }



                if (dayCount == 6)
                    dayCount = -1;

                dayCount++;


            }

           
            return _absentPenalty * ((onTimeCount + lateCount) == workingDays ? 0 : workingDays - (onTimeCount + lateCount));
        }
        private static decimal GetTotalAllowances()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                return (decimal) dbModel.Employee_Allowance_Table.Select(i => i.amount_per_month).ToList().Sum();
            }
        }

        public static async void GeneratePayslip(DateTime startTime, DateTime endTime, int employeeID, string employeeName, decimal ratePerHour, bool hasGovernmentDeduction, bool hasOtherDeduction, bool hasOverTimePay)
        {
            _endTime = endTime;
            _startTime = startTime;
            _employeeID = employeeID;
            _ratePerHour = ratePerHour;
            _hasOverTimePay = hasOverTimePay;
            _hasGovernmentDeduction = hasGovernmentDeduction;
            _hasOtherDeduction = hasOtherDeduction;

            SetPenalty();
            SetPayAdjustments();

            _attendanceList = GetAttendance(employeeID);



            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                decimal grossPay = GetGrossPay();
                decimal cashAdvancePayment = PayCashAdvance();
                decimal overallDeduction = GetOtherDeductions() + GetTotalGovernmentDeduction() + GetAbsentDeduction() + GetTotalLateDeductions() + cashAdvancePayment;
                decimal netPay = grossPay - overallDeduction;
                

                var employeePaySlip = new Payroll_Table()
                {
                    employee_id = employeeID,
                    date_issued = DateTime.Today,
                    cutoff_start = _startTime,
                    cutoff_end = _endTime,
                    employee_name = employeeName,
                    total_hours_rendered = GetTotalHoursRendered(),
                    total_days_work = _attendanceList.Count,
                    basic_pay = GetBasicPay(),
                    gross_pay = grossPay,
                    total_overtime_hours = GetTotalOverTimeHours(),
                    overtime_pay = GetOverTimePay(),
                    cash_advance_remaining_balance = GetCashAdvanceBalance(),
                    cash_advance_payment = cashAdvancePayment,
                    late_deductions = GetTotalLateDeductions(),
                    other_deductions = GetOtherDeductions(),
                    withholding_tax = GetGovernmentDeduction("BIR Witholding TAX"),
                    gsis_sss_contribution = GetGovernmentDeduction("SSS"),
                    pag_ibig_contribution = GetGovernmentDeduction("PAG-IBIG"),
                    philhealth_contribution = GetGovernmentDeduction("Phil-Health"),
                    generate_by = "Angelo",
                    net_pay = netPay < 0 ? 0 : netPay,
                    allowance = GetTotalAllowances(),
                    absent_deduction = GetAbsentDeduction()
                };

                dbModel.Payroll_Table.Add(employeePaySlip);
                await dbModel.SaveChangesAsync();
            }
        }












    }

}
