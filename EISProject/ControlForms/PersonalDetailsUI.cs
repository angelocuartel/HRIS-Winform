using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpValidation;
namespace EISProject.ControlForms
{
    public partial class PersonalDetailsUI : UserControl
    {
        public Validator inputValidator;
        public Dictionary<Control,Label> InputControls { get; }
        public  string GivenName { get { return givenNameTxt.Text; } }
        public string LastName { get { return lastNameTxt.Text; } }
        public string MiddleName { get { return middleNameTxt.Text; } }
        public string Email { get { return emailTxt.Text; } }
        public int Age { get { return int.Parse(ageTxt.Text); } }
        public  string Gender { get { return genderCombo.Text; } }
        public string Address { get { return currentAddressTxt.Text; } }
        public string PhoneNumber { get { return phoneNumberTxt.Text; } }

        public string Nationality { get { return nationalityTextBox.Text; } }
        public string Religion { get { return religionTextBox.Text; } }

        public string CivilStatus { get { return civilStatusComboBox.Text; } }

        public string BirthDate { get { return birthDateDatePicker.Text; } }

        public string HouseNumber { get { return houseNoTextBox.Text; } }
        public string City { get { return cityTextBox.Text; } }
        public string ZipCode { get { return zipCodeTextBox.Text; } }
        public string Brgy { get { return brgyTextBox.Text; } }
        public string State { get { return stateTextBox.Text; } }
        public string Telephone { get { return telephonTextBox.Text; } }


        public PersonalDetailsUI()
        {
            InitializeComponent();

            InputControls = new Dictionary<Control, Label>()
            {
                {givenNameTxt,givenNameErrorLabel },
                {lastNameTxt,lastNameErrorLabel },
                {middleNameTxt,middleNameErrorLabel },
                {phoneNumberTxt,phoneNumberErrorLabel},
                {ageTxt,ageErrorLbl },
                {emailTxt,emailErrorLabel },
                {currentAddressTxt,addressErrorLbl },
                {nationalityTextBox,nationalityErrorLabel },
                {religionTextBox,religionErrorLabel },
                {houseNoTextBox,houseNoErrorLabel },
                {cityTextBox,cityErrorLabel },
                {zipCodeTextBox,zipCodeErrorLabel },
                {brgyTextBox,brgyErrorLabel },
                {stateTextBox,stateErrorLabel },
                {telephonTextBox,telephoneErrorLabel }

            };

            inputValidator = new Validator(InputControls)
            {
                ValidTextBoxCustomColor = Color.FromArgb(64, 64, 64)
            };
           
        }


        private void ageTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void emailTxt_Leave(object sender, EventArgs e)
        {
            inputValidator.ValidateEmail(emailTxt);
        }

        private void givenNameTxt_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateStringInput(givenNameTxt);
        }

        private void lastNameTxt_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateStringInput(lastNameTxt);
        }

        private void middleNameTxt_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateStringInput(middleNameTxt);
        }

        private void ageTxt_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(ageTxt, false, false, true, 1, 100);
        }

        private void phoneNumberTxt_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(phoneNumberTxt, false, false, true, 11, 11);
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            if (emailTxt.Text != string.Empty)
            {
                try
                {
                    inputValidator.ValidateEmail(emailTxt);
                }
                catch (Exception)
                {

                    MessageBox.Show("Invalid EMail address format", "Email", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }

        private void currentAddressTxt_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(currentAddressTxt, false, true, true, 0, 100);
        }

        private void religionTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateStringInput(religionTextBox);
        }

        private void nationalityTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateStringInput(nationalityTextBox);
        }

        private void houseNoTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateIntegerInput(houseNoTextBox);
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateStringInput(cityTextBox);
        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateStringInput(stateTextBox);
        }

        private void zipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(zipCodeTextBox, false, false, true, 4, 10);
        }

        private void brgyTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateStringInput(brgyTextBox);
        }

        private void telephonTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidator.ValidateCustomInput(telephonTextBox, false, false, true, 10, 10);
        }

      
    }
}
