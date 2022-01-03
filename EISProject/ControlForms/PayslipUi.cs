using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EISProject.DataBaseFunctions;
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace EISProject.ControlForms
{
    public partial class PayslipUi : UserControl
    {
        public static DataBaseFunctions.ComboBoxControl comboBoxObj;
        private DataGridAction<Payroll_Table> payrollGridObj;
        private decimal ratePerHour;

        public PayslipUi()
        {
            InitializeComponent();

            comboBoxObj = new ComboBoxControl(departmentComboBox);

        }

        private  void addEmployeeButton_Click(object sender, EventArgs e)
        {
            if (startDatePicker.Value >= endDatePicker.Value)
            {
                MessageBox.Show("Invalid Date Range. Start Date should not be greater or equal to End Date", "Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if((endDatePicker.Value - startDatePicker.Value).TotalDays < 5)
            {
                MessageBox.Show("Invalid Date Range. should atleast consist of 7 days or more", "Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(new EmployeeInformationSystemDataBaseEntities().Employee_Information_Table.Where(i =>i.employee_id.ToString() == empIdLabel.Text && i.employee_status == "ARCHIVED").SingleOrDefault() != null)
            {
                MessageBox.Show("Cannot Proceed, employee is archived \n please refresh they application to see employee updates", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Payroll.GeneratePayslip(startDatePicker.Value.Date, endDatePicker.Value.Date, int.Parse(empIdLabel.Text), nameLabel.Text,this.ratePerHour, governmentDeductionToggleSwitch.Checked, OtherDeductionToggleSwitch.Checked, overTimeToggleSwitch.Checked);

                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                     payrollGridObj.PopulateGridView(payrollGridObj.fullList = dbModel.Payroll_Table.ToList());

                    if (EISMainForm.CashADvance_HasClick)
                        CashAdvanceUi.CashGridObj.PopulateGridView(CashAdvanceUi.CashGridObj.fullList = dbModel.Cash_Advance_Table.ToList());
                     
                }
                using (var payslip = new Reports.PaySlipReportUi(departmentLabel.Text, posititionLabel.Text, int.Parse(empIdLabel.Text), payrollGridObj.fullList.OrderByDescending(i => i.payslip_id).FirstOrDefault()))
                {
                    payslip.ShowDialog();
                }
            }
        }

        private async void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

                employeeComboBox.DataSource = await GetEmployeeDataSet(departmentComboBox.Text);

                

        }


        private Task<List<string>> GetEmployeeDataSet(string department)
        {
            return Task.Run(() => {

                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    var employeeDataList = new List<string>();
                    foreach (var item in dbModel.Employee_Information_Table.Where(i => i.department_name == department && i.employee_status == "ACTIVE").OrderBy(i => i.employee_id).ToList())

                    {
                        employeeDataList.Add($"{item.employee_id} - {item.given_name} {item.last_name}");
                    }

                    return employeeDataList;
                }
             
            });
          
        }

        

        private async void PayslipUi_Load(object sender, EventArgs e)
        {
          

            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                departmentComboBox.DataSource = dbModel.Department_Table.Select(i => i.department_name).OrderBy(i =>i).ToList();
                payrollGridObj = new DataGridAction<Payroll_Table>(payrollEmptyLabel, totalRecordsLabel, payrollDataGridView,dbModel.Payroll_Table.ToList());

                await payrollGridObj.PopulateGridView(payrollGridObj.fullList);
            }

            endDatePicker.MaxDate = startDatePicker.MaxDate = DateTime.Today;
        }

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var id = employeeComboBox.Text.Substring(0, employeeComboBox.Text.IndexOf(' '));
                var employee = dbModel.Employee_Information_Table.Where(i => i.employee_id.ToString() == id).SingleOrDefault();

                this.ratePerHour = (decimal) employee.rate_per_hour;

                nameLabel.Text = $"{employee.given_name} {employee.last_name}";
                departmentLabel.Text = departmentComboBox.Text;
                posititionLabel.Text = employee.job_title;
                empIdLabel.Text = employee.employee_id.ToString();
                statusLabel.Text = employee.contract;
                employeePictureBox.Image = new Bitmap(employee.profile_picture);
            }
        }

        private async void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            await payrollGridObj.SearchGridView(bunifuTextBox1.Text, "employee_id", "employee_name");
        }

        private async void payrollDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await payrollGridObj.SortGridView(payrollDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        private async void payrollDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(payrollDataGridView.Columns[e.ColumnIndex].Name == "Print" && payrollDataGridView.Rows.Count > 0)
            {

                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    int empID = int.Parse(payrollDataGridView.CurrentRow.Cells[1].Value.ToString());
                    int paySlipID = int.Parse(payrollDataGridView.CurrentRow.Cells[0].Value.ToString());
                    var empDetails = dbModel.Employee_Information_Table.Where(i => i.employee_id == empID).SingleOrDefault();

                    using (var payslipForm = new Reports.PaySlipReportUi(empDetails.department_name,empDetails.job_title,empDetails.employee_id,empDetails.Payroll_Table.Where(i =>i.payslip_id == paySlipID).SingleOrDefault()))
                    {
                        payslipForm.ShowDialog();
                    }

                }
            }
            else if(payrollDataGridView.Columns[e.ColumnIndex].Name == "Delete" && payrollDataGridView.Rows.Count > 0)
            {
                if(MessageBox.Show($"Delete payslip ID {payrollDataGridView.CurrentRow.Cells[0].Value}","Delete Payslip",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        int paySlipID = int.Parse(payrollDataGridView.CurrentRow.Cells[0].Value.ToString());
                        var payslip = dbModel.Payroll_Table.Where(i => i.payslip_id == paySlipID).SingleOrDefault();

                        dbModel.Entry(payslip).State = System.Data.Entity.EntityState.Deleted;
                       await dbModel.SaveChangesAsync();

                      await payrollGridObj.PopulateGridView(payrollGridObj.fullList = dbModel.Payroll_Table.ToList());
                    }

                    new Modals.NotificationUi("Successfully Deleted Payslip", Modals.NotificationUi.NotificationType.restore);
                }
            }
        }
    }
}
