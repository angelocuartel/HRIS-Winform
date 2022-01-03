using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
namespace EISProject.Modals
{
    public partial class AddAllowanceUi : Form
    {
        private readonly BunifuSnackbar _snackBar;
        public AddAllowanceUi()
        {
            InitializeComponent();
            _snackBar = new BunifuSnackbar();
        }

        private void ratePerHourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && amountTextBox.Text.Contains("."))
            {
                e.Handled = true;
            }

            else if (e.KeyChar == '.' && amountTextBox.Text == string.Empty)
            {
                e.Handled = true;
            }

            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            else if (e.KeyChar != '.' && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void addAttendanceButton_Click(object sender, EventArgs e)
        {
            
            if (amountTextBox.Text != "" && allowanceTextBox.Text != "")
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    var allowance = new Employee_Allowance_Table()
                    {
                        allowance_name = allowanceTextBox.Text.Trim(),
                        amount_per_month = decimal.Parse(amountTextBox.Text),
                        log_by = DataBaseFunctions.SystemUser.UserAccount.username.ToString(),
                        date_added = DateTime.Today
                    };

                    dbModel.Employee_Allowance_Table.Add(allowance);
                    await dbModel.SaveChangesAsync();
                    await ControlForms.AllowanceUi.AllowanceGridObj.PopulateGridView(ControlForms.AllowanceUi.AllowanceGridObj.fullList = dbModel.Employee_Allowance_Table.ToList());

                }
                new NotificationUi("Sucessfully Add new Allowance Per Month", NotificationUi.NotificationType.restore);
                this.Close();
            }
            else
            {
                _snackBar.Show(this, "Please enter an amount and allowance name", BunifuSnackbar.MessageTypes.Error);
            }
        }

   
    }
}
