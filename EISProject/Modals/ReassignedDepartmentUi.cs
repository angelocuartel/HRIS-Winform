using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EISProject.Modals
{
    public partial class ReassignedDepartmentUi : Form
    {
        public static bool HasReassigned { get; set; }
        Employee_Information_Table employee;
        public static string AssignedDepartment;
        public ReassignedDepartmentUi(Employee_Information_Table employee)
        {
            InitializeComponent();

            employeeNameLabel.Text = $"{employee.given_name} {employee.last_name}";
            currentDepartmentLabel.Text = employee.department_name;
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                departmentComboBox.DataSource = dbModel.Department_Table.Where(i => i.department_name != employee.department_name).Select(i => i.department_name).ToList();
            }

            this.employee = employee;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {

                    DataBaseFunctions.Department.ReassignEmployee(this.employee.employee_id, departmentComboBox.Text.Trim());
                    new NotificationUi("Successfully Re-assign Employee", NotificationUi.NotificationType.restore).Show();
                    HasReassigned = true;
                    this.Close();
                    AssignedDepartment = departmentComboBox.Text.Trim();
          
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
