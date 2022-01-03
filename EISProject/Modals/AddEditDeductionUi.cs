using System;
using SharpValidation;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace EISProject.Modals
{
    public partial class AddEditDeductionUi : Form
    {
       private Deductions_Table deductRecord;
       private Validator inputValidator;

        public AddEditDeductionUi(Deductions_Table deductRecord)
        {
            InitializeComponent();
            InitializeInputValidator();

            this.deductRecord = deductRecord;

            amountTextBox.Text = this.deductRecord.deduction_amount.ToString();
            descriptionTextBox.Text = this.deductRecord.description;
            deductionTypeTextBox.Text = this.deductRecord.deduction_type;

            amountTextBox.BorderColor = descriptionTextBox.BorderColor = deductionTypeTextBox.BorderColor = Color.Gray;
            amountErrorLabel.Visible = deductionTypeErrorLabel.Visible = false;

            addDepartmentButton.Text = "Edit";

           
        }

        public AddEditDeductionUi()
        {
            InitializeComponent();
            InitializeInputValidator();
        }

        private void InitializeInputValidator()
        {
            inputValidator = new Validator(new System.Collections.Generic.Dictionary<Control, Label>() { { amountTextBox, amountErrorLabel }, { deductionTypeTextBox, deductionTypeErrorLabel } });
        }

        private async void addDepartmentButton_Click(object sender, EventArgs e)
        {
            if (!inputValidator.AreAllNotValid())
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    if (addDepartmentButton.Text == "Add")
                    {
                        var newDeduc = new Deductions_Table();

                        newDeduc.log_by = DataBaseFunctions.SystemUser.UserAccount.username;
                        newDeduc.date_added = DateTime.Today;
                        newDeduc.deduction_amount = decimal.Parse(amountTextBox.Text);
                        newDeduc.deduction_type = deductionTypeTextBox.Text.Trim();
                        newDeduc.description = descriptionTextBox.Text.Trim();

                        dbModel.Deductions_Table.Add(newDeduc);
                        await dbModel.SaveChangesAsync();

                        new Modals.NotificationUi("Successfully Add Deduction", NotificationUi.NotificationType.restore);

                    }

                    else
                    {
                        this.deductRecord.deduction_amount = decimal.Parse(amountTextBox.Text);
                        this.deductRecord.deduction_type = deductionTypeTextBox.Text.Trim();
                        this.deductRecord.description = descriptionTextBox.Text.Trim();

                        dbModel.Entry(this.deductRecord).State = System.Data.Entity.EntityState.Modified;
                        await dbModel.SaveChangesAsync();

                        new Modals.NotificationUi("Successfully Edit Deduction", NotificationUi.NotificationType.restore);
                    }

                    await ControlForms.DeductionsUi.DeductionObjGrid.PopulateGridView(ControlForms.DeductionsUi.DeductionObjGrid.fullList = dbModel.Deductions_Table.ToList());


                }

                this.Close();
            }
            else
            {
                bunifuSnackbar1.Show(this, "Please check your input", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void deductionTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(deductionTypeTextBox,true,true,false,3,30);
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(amountTextBox, true, false, true, 1, 10);
        }

 

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
