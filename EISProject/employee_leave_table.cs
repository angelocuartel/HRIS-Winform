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
    
    public partial class employee_leave_table
    {
        public int leave_id { get; set; }
        public string employee_name { get; set; }
        public int employee_id { get; set; }
        public string leave_type { get; set; }
    
        public virtual Employee_Information_Table Employee_Information_Table { get; set; }
    }
}
