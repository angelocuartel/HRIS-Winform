using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EISProject.DataBaseFunctions
{
    public static class Department
    {







        public static void ReassignEmployee(int employeeId, string newAssignedDepartment)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var emp = dbModel.Employee_Information_Table.Where(i =>i.employee_id == employeeId).SingleOrDefault();
                emp.department_name = newAssignedDepartment;
                dbModel.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                dbModel.SaveChanges();
            }
        }

        public static  Task RemoveAllEmployees(string department)
        {
            return Task.Run(() =>
             {
                 using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                 {
                     var empList = dbModel.Employee_Information_Table.Where(i => i.department_name == department).ToList();

                     foreach (var employee in empList)
                     {
                        
                             employee.department_name = "UNASSIGNED";
                             dbModel.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                             dbModel.SaveChanges();
                         if (EISMainForm.Active_Emp_HasClick)
                              ControlForms.ActiveEmployeeUi.GridObj.PopulateGridView(ControlForms.ActiveEmployeeUi.GridObj.fullList = dbModel.Employee_Information_Table.ToList());
                     }
                 }
                
            }
            
            );

        }
    }
}

