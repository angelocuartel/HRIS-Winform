using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EISProject.ControlForms
{
    public partial class DepartmentEmployeePictureGridUi : UserControl
    {

        private int counter = 0;
        private Employee_Information_Table employee = EIS_BusinessLogic.PictureGrid<Employee_Information_Table>.ItemObject;
        public DepartmentEmployeePictureGridUi()
        {
            InitializeComponent();

            


        }

        private void LoadEmployeeInfo()
        {
            nameLabel.Text = $"{this.employee.given_name} {this.employee.last_name}";
            positionLabel.Text = this.employee.job_title;
            emailLabel.Text = this.employee.email_address;
            ratePerHourLabel.Text = this.employee.rate_per_hour.ToString();
            empPictureBox.Image = new Bitmap(this.employee.profile_picture);

        }

   

     

        private void gunaLinePanel1_MouseClick(object sender, MouseEventArgs e)
        {
            gunaLinePanel1.LineColor = Color.DodgerBlue;
            Modals.ViewDepartmentEmployees.employee = this.employee;
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if(counter == 1)
            {
                gunaLinePanel1.LineColor = Color.Silver;
                counter = 0;
                timer1.Stop();
            }
        }

        private void DepartmentEmployeePictureGridUi_Load(object sender, EventArgs e)
        {
            LoadEmployeeInfo();
        }
    }
}
