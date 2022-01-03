using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace EISProject.Modals
{
    public partial class ViewDepartmentEmployees : Form
    {
        public static Employee_Information_Table employee;
        private EIS_BusinessLogic.PictureGrid<Employee_Information_Table> employeeGridLoader;
        public ViewDepartmentEmployees(string departmentName,string departHead)
        {
            InitializeComponent();


            departmentHeadLabel.Text = departHead;
            departmentNameLabel.Text = departmentName;


            employeeGridLoader = new EIS_BusinessLogic.PictureGrid<Employee_Information_Table>(flowLayoutPanel1, empDepartmentLabel, totalRecordsLabel);

            employeeGridLoader.LoadItems<ControlForms.DepartmentEmployeePictureGridUi>(new ControlForms.DepartmentEmployeePictureGridUi(), GetAllEmployees());

 
        }


        private List<Employee_Information_Table> GetAllEmployees()
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                return dbModel.Employee_Information_Table.Where(i => i.department_name == departmentNameLabel.Text && i.employee_status == "ACTIVE").ToList();
            }
        }

     

 

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if (employee == null || flowLayoutPanel1.Controls.Count == 0)
            {
                bunifuSnackbar1.Show(this, "Please choose an employee", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            else
            {
                using (var reassignForm = new Modals.ReassignedDepartmentUi(employee))
                {
                    reassignForm.ShowDialog();
                }

                if (Modals.ReassignedDepartmentUi.HasReassigned)
                {
                    employeeGridLoader.LoadItems<ControlForms.DepartmentEmployeePictureGridUi>(new ControlForms.DepartmentEmployeePictureGridUi(), GetAllEmployees());
                    ReassignedDepartmentUi.HasReassigned = false;
                }
            }
        }
    }
}