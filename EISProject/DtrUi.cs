using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EISProject
{
    public partial class DtrUi : Form
    {
        DataBaseFunctions.Attendance attendanceEmployee;
        private string _employeeName;
        public DtrUi()
        {
            InitializeComponent();
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
           
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
          
                if(clockInOutButton.Text == "Time In")
                {
                    attendanceEmployee.TimeIn();
                    bunifuSnackbar1.Show(this, $"{this._employeeName} You have successfully Time In", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    attendanceEmployee.TimeOut();
                    bunifuSnackbar1.Show(this, $"{this._employeeName} You have successfully Time Out", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
               

            clockInOutButton.Visible = false;
            bunifuTextBox1.Clear();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginUi().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private async void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(bunifuTextBox1.Text.Length == 13)
            {
                Employee_Information_Table employee = await GetEmployeeRecord(bunifuTextBox1.Text);

                

                if (employee != null)
                {

                    attendanceEmployee = new DataBaseFunctions.Attendance(clockInOutButton, employee.employee_id);

                    if (attendanceEmployee.IsEmployeeTimeIn)
                    {
                        bunifuSnackbar1.Show(this, $"{employee.given_name} {employee.last_name} You have already Timed In and Timed Out Today", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        bunifuTextBox1.Clear();

                    }
                    else
                    {
                        this._employeeName = employee.given_name +" "+ employee.last_name;
                        clockInOutButton.Visible = true;
                    }
                       
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Employee ID does not exist in the current system", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            else
            {
                if (clockInOutButton.Visible)
                {
                    clockInOutButton.Visible = false;
                }
            }
        }

        private Task<Employee_Information_Table> GetEmployeeRecord(string employeeWorkID)
        {
            return Task.Run(() =>
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    return dbModel.Employee_Information_Table.Where(i => i.employee_work_id == employeeWorkID).SingleOrDefault();
                }
            });
        }

        private void clockInOutButton_VisibleChanged(object sender, EventArgs e)
        {
            clockInOutButton.IdleBorderColor = clockInOutButton.Text == "Time In" ? Color.SeaGreen : Color.Red;

            if(clockInOutButton.Text == "Time In")
            {
                clockInOutButton.IdleBorderColor = Color.SeaGreen;
                clockInOutButton.OnIdleState.FillColor = Color.SeaGreen;
                clockInOutButton.OnIdleState.BorderColor = Color.SeaGreen;
                clockInOutButton.onHoverState.BorderColor = Color.SeaGreen;
                clockInOutButton.onHoverState.FillColor = Color.SeaGreen;
                clockInOutButton.OnPressedState.BorderColor = Color.SeaGreen;
                clockInOutButton.OnPressedState.BorderColor = Color.SeaGreen;
                clockInOutButton.IdleFillColor = Color.SeaGreen;
            }
            else
            {
                clockInOutButton.IdleBorderColor = Color.Red;
                clockInOutButton.OnIdleState.FillColor = Color.Red;
                clockInOutButton.OnIdleState.BorderColor = Color.Red;
                clockInOutButton.onHoverState.BorderColor = Color.Red;
                clockInOutButton.onHoverState.FillColor = Color.Red;
                clockInOutButton.OnPressedState.BorderColor = Color.Red;
                clockInOutButton.OnPressedState.BorderColor = Color.Red;
                clockInOutButton.IdleFillColor = Color.Red;

            }
        }
    }
}
