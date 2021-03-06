//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EISProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payroll_Table
    {
        public int payslip_id { get; set; }
        public Nullable<int> employee_id { get; set; }
        public string employee_name { get; set; }
        public Nullable<int> total_hours_rendered { get; set; }
        public Nullable<int> total_days_work { get; set; }
        public Nullable<decimal> basic_pay { get; set; }
        public Nullable<decimal> allowance { get; set; }
        public Nullable<decimal> gross_pay { get; set; }
        public Nullable<System.DateTime> date_issued { get; set; }
        public Nullable<int> total_overtime_hours { get; set; }
        public Nullable<decimal> overtime_pay { get; set; }
        public Nullable<decimal> cash_advance_remaining_balance { get; set; }
        public Nullable<decimal> cash_advance_payment { get; set; }
        public Nullable<System.DateTime> cutoff_start { get; set; }
        public Nullable<System.DateTime> cutoff_end { get; set; }
        public Nullable<decimal> late_deductions { get; set; }
        public Nullable<decimal> other_deductions { get; set; }
        public Nullable<decimal> withholding_tax { get; set; }
        public Nullable<decimal> gsis_sss_contribution { get; set; }
        public Nullable<decimal> pag_ibig_contribution { get; set; }
        public Nullable<decimal> philhealth_contribution { get; set; }
        public string generate_by { get; set; }
        public Nullable<decimal> net_pay { get; set; }
        public Nullable<decimal> absent_deduction { get; set; }
    
        public virtual Employee_Information_Table Employee_Information_Table { get; set; }
    }
}
