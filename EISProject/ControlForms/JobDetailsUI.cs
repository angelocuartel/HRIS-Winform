using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SharpValidation;
using System.Linq;

namespace EISProject.ControlForms
{
    public partial class JobDetailsUI : UserControl
    {
        Validator inputValidator = new Validator();

        
        public string Position { get { return positionCombox.Text; } }
        public string Department { get { return departmentComboBox.Text; } }
        public string SSS { get { return sssTxt.Text; } }
        public string PhilHealth { get { return philhealthTxt.Text; } }
        public string TIN { get { return tinTxt.Text; } }
        public string Contract { get { return contractComboBox.Text; } }
        public string WorkLocation { get { return workingAddressTxt.Text; } }
        public DateTime DateHired { get { return DateTime.Parse(dateHireDatePicker.Text); } }

        public decimal Rate_Per_Hour { get { return Math.Round((decimal) new EmployeeInformationSystemDataBaseEntities().Employee_Positions_Table.Where(i =>i.position == positionCombox.Text).Select(i => i.rate_per_hour).SingleOrDefault()); } }

        public string Campus { get { return campusComboBox.Text; } }
        public bool IsInputAllValid { get { return inputValidator.AreAllNotValid(); } }

        public JobDetailsUI()
        {
            InitializeComponent();
            inputValidator = new Validator(new Dictionary<Control, Label>() { { sssTxt, sssErrorLabel }, { workingAddressTxt, workLocationErrorLbl }, { tinTxt, tinErrorLabel }, { philhealthTxt, philhealthErrorLabel } });
            using (var model = new EmployeeInformationSystemDataBaseEntities())
            {
                departmentComboBox.DataSource = model.Department_Table.Select(i => i.department_name).ToList();
                positionCombox.DataSource = model.Employee_Positions_Table.Select(i => i.position).ToList();
            }

        }



        private void philhealthTxt_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(philhealthTxt, false, false, true, 12, 12);
        }




        private void workingAddressTxt_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(workingAddressTxt, false, true, true, 0, 50);
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sssTxt_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(sssTxt, false, false, true, 11, 11);
        }

        private void tinTxt_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(tinTxt, false, true, true, 8, 20);
        }
    }
}
