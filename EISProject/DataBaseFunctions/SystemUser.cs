using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EISProject.DataBaseFunctions
{
    public static class SystemUser
    {
        public static HRIS_Account_Table UserAccount { get; set; }

        public static bool HasValidPassword { get; set; }

        public static DateTime LogInDate { get; set; }

        public static string LoginTime { get; set; }



 


        public static void RecordLogHistory()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var logHistory = new Log_History_Table()
                {
                    employee_id = UserAccount.hris_account_id,
                    login_date = LogInDate,
                    login_time = LoginTime,
                    logout_date = DateTime.Today,
                    logout_time = DateTime.Now.ToLongTimeString()
                };

                dbModel.Log_History_Table.Add(logHistory);
                dbModel.SaveChanges();
            }
        }

        





        
    }
}
