using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpValidation;
namespace EISProject.Modals
{
    public partial class AddCashAdvanceUi : Form
    {

        private decimal paymentPerMonth = 0;
       
        public AddCashAdvanceUi()
        {
            InitializeComponent();
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

        private async void addAttendanceButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text != "")
            {
                if (decimal.Parse(amountTextBox.Text) <= 10000)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        int employeeID = int.Parse(employeeComboBox.Text.Substring(0, employeeComboBox.Text.IndexOf('-')));

                        if (dbModel.Cash_Advance_Table.Where(i => i.employee_id == employeeID && i.status == "UNPAID").SingleOrDefault() == null)
                        {





                            var newCashAdvance = new Cash_Advance_Table()
                            {
                                log_by = DataBaseFunctions.SystemUser.UserAccount.username,
                                amount = decimal.Parse(amountTextBox.Text),
                                employee_id = int.Parse(employeeComboBox.Text.Substring(0, employeeComboBox.Text.IndexOf('-'))),
                                employee_name = employeeComboBox.Text.Substring(employeeComboBox.Text.IndexOf('-') + 1),
                                date_added = DateTime.Today,
                                status = "UNPAID",
                                remaining_balance = decimal.Parse(amountTextBox.Text),
                                total_payment = (decimal)0.00,
                                amount_payment_per_month = this.paymentPerMonth,
                                month_length = int.Parse(guna2ComboBox1.Text)

                            };

                            dbModel.Cash_Advance_Table.Add(newCashAdvance);
                            await dbModel.SaveChangesAsync();



                            new NotificationUi("Successfully Add Cash Advance", NotificationUi.NotificationType.restore);
                            await ControlForms.CashAdvanceUi.CashGridObj.PopulateGridView(ControlForms.CashAdvanceUi.CashGridObj.fullList = dbModel.Cash_Advance_Table.ToList());





                            this.Close();
                        }
                        else
                        {
                            bunifuSnackbar1.Show(this, "Cannot Add, emmployee has a remaining balance that needs to be paid", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        }

                    }
                }

                else
                {
                    bunifuSnackbar1.Show(this, "Maximum Amount is 10000.00", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            else
            {
                bunifuSnackbar1.Show(this, "Please provide an amount",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }

          
            
       }
        

        private async void AddCashAdvanceUi_Load(object sender, EventArgs e)
        {
            employeeComboBox.DataSource = await DataBaseFunctions.EmployeeEntity.GetEmployeeNamesIDs();
        }

        private void ratePerHourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (amountTextBox.Text != string.Empty)
            {
                amountPerMonthLabel.Text = decimal.Parse(amountTextBox.Text).ToString("C2", new System.Globalization.CultureInfo("en-PH"));
                guna2ComboBox1.Text = "1";
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.paymentPerMonth = decimal.Parse(amountTextBox.Text) / int.Parse(guna2ComboBox1.Text);
            amountPerMonthLabel.Text = this.paymentPerMonth.ToString("C2", new System.Globalization.CultureInfo("en-PH"));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
