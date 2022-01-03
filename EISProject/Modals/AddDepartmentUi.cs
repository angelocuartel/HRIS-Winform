using System;
using SharpValidation;
using System.Windows.Forms;
using System.Linq;

namespace EISProject.Modals
{
    public partial class AddDepartmentUi : Form
    {
        private Department_Table _department;
        Validator inputValidator;
        public AddDepartmentUi()
        {
            InitializeComponent();
            InitializeInputValidator();



            //set draggable form
            new Guna.UI2.WinForms.Guna2DragControl().TargetControl = gunaLinePanel1;

        }

        public AddDepartmentUi(Department_Table department)
        {
            InitializeComponent();
            InitializeInputValidator();


            this._department = department;

            departmentCodeTextBox.Text = department.department_code;
            departmentCodeTextBox.ReadOnly = true;

            departmentTextBox.Text = department.department_name;
            depHeadTextBox.Text = department.department_head;

            departmentNameErrorLabel.Visible = depHeadErrorLabel.Visible = depCodeErrorLabel.Visible = false;

            addDepartmentButton.Text = "Save";

            label5.Text = "Edit Department";

        }
       

        private void InitializeInputValidator()
        {

            inputValidator = new Validator(new System.Collections.Generic.Dictionary<Control, Label>()
           {
               {departmentCodeTextBox,depCodeErrorLabel },
                {departmentTextBox,departmentNameErrorLabel },
                {depHeadTextBox,depHeadErrorLabel },

           })

            {
                ValidTextBoxCustomColor = System.Drawing.Color.Gray
            };
        }
       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            if (inputValidator.AreAllNotValid())
            {
                bunifuSnackbar1.Show(this, "Please Check all your input",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

            }
            else
            {
               
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    if (addDepartmentButton.Text == "Add")
                    {
                        var department = new Department_Table()
                        {
                            department_head = depHeadTextBox.Text.Trim(),
                            department_code = departmentCodeTextBox.Text.Trim(),
                            department_name = departmentTextBox.Text.Trim().ToUpper(),
                            department_date_added = DateTime.Now.ToLongDateString(),
                            added_by = DataBaseFunctions.SystemUser.UserAccount.username

                        };

                        dbModel.Department_Table.Add(department);
                        dbModel.SaveChanges();

                        new NotificationUi("Successfully Add Department", NotificationUi.NotificationType.restore).Show();
                        this.Close();

                    }

                    else
                    {
                        this._department.department_head = depHeadTextBox.Text;
                        this._department.department_name = departmentTextBox.Text;

                        dbModel.Entry(this._department).State = System.Data.Entity.EntityState.Modified;
                        dbModel.SaveChanges();

                        new NotificationUi("Successfully Update Department", NotificationUi.NotificationType.restore).Show();
                        this.Close();
                    }
                    // refresh department list after adding new department
                    ControlForms.DepartmentsUi.DepartmentObjGrid.PopulateGridView(dbModel.Department_Table.ToList());

                    if (EISMainForm.PaySlip_HasClick)
                        ControlForms.PayslipUi.comboBoxObj.SetDataSource(dbModel.Department_Table.Select(i =>i.department_name).ToList());

                    if (EISMainForm.Dashboard_HasClick)
                        ControlForms.DashBoardUi.DashboardObj.LoadDashboardPanel();


                }

                // refresh inputs

               
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void departmentTextBox_TextChanged_1(object sender, EventArgs e)
        {
            inputValidator.ValidateStringInput(departmentTextBox);
        }

        private void depHeadTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateStringInput(depHeadTextBox);
        }


        private void departmentCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateIntegerInput(departmentCodeTextBox);
        }
    }

 
}
