using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EISProject.DataBaseFunctions
{
    class EmployeeEntity
    {

        public static Task UpdateEmployeeStatus(string suspensionLiftDate, string archivedReason, int employeeId, string toEmployeeStatus)
        {


            return Task.Run(() =>
            {



                using (var model = new EmployeeInformationSystemDataBaseEntities())
                {
                    // update the employee status column
                    var employee = model.Employee_Information_Table.First(c => c.employee_id == employeeId);
                    employee.employee_status = toEmployeeStatus;
                    employee.description_for_archiving = archivedReason == null ? "--" : archivedReason;
                    employee.suspension_lift_date = suspensionLiftDate == null ? "--" : suspensionLiftDate;

                    model.Entry(employee).State = System.Data.Entity.EntityState.Modified;

                    //udpate the account status column
                    var account = model.Employee_Portal_Accounts_Table.First(e => e.employee_id == employeeId);
                    account.account_status = toEmployeeStatus == "ARCHIVED" ? "DEACTIVATED" : "ACTIVE";
                    model.Entry(account).State = EntityState.Modified;

                    model.SaveChanges();


                };


            });






        }


        public static string GenerateEmployeeWorkID()
        {

            var rand = new Random();
            var builder = new StringBuilder();

            for (int i = 1; i <= 13; i++)
            {
                if (i <= 5)
                    builder.Append((char)rand.Next(65, 90));
                else if (i == 6)
                {
                    builder.Append(DateTime.Today.Year.ToString().Substring(2));
                    i++;
                }
                else
                    builder.Append(rand.Next(0, 9));
            }



            return builder.ToString();
        }

        public static Task<List<string>> GetEmployeeNamesIDs()
        {
            return Task.Run(() =>
            {

                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    var empGivenName = dbModel.Employee_Information_Table.Where(i => i.employee_status == "ACTIVE").Select(i => i.given_name).ToList();
                    var empLastName = dbModel.Employee_Information_Table.Where(i => i.employee_status == "ACTIVE").Select(i => i.last_name).ToList();
                    var empIds = dbModel.Employee_Information_Table.Where(i => i.employee_status == "ACTIVE").Select(i => i.employee_id).ToList();
                    var empName = new List<string>();

                    for (int i = 0; i < empGivenName.Count; i++)
                    {
                        empName.Add($"{empIds[i]} - {empGivenName[i]} {empLastName[i]}");
                    }

                    return empName;
                }
            });
        }

        public static Task  CheckSuspendedEmployee()
        {
            return Task.Run(() =>
            {

                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    var suspendedEmployees = dbModel.Employee_Information_Table.Where(i => i.description_for_archiving == "Suspended").ToList();

                   
                    suspendedEmployees.Where(i => DateTime.Parse(i.suspension_lift_date) <= DateTime.Today).ToList().ForEach(i => { i.suspension_lift_date = "--"; i.description_for_archiving = "--"; i.employee_status = "ACTIVE"; });

                    foreach (var employee in suspendedEmployees)
                    {

                        dbModel.Entry(employee).State = EntityState.Modified;
                    }

                     dbModel.SaveChanges();

                }
            });
       
        }
    }

}


    

