using System;
using SharpValidation;
using System.Data;

using System.Linq;

using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EISProject.Modals
{
    public partial class AddEditPosition : Form
    {
       private  string position;
        Validator inputValidtor;

        public AddEditPosition()
        {
            InitializeComponent();
            InitializeValidator();
        }

      private void  InitializeValidator()
        {
            inputValidtor = new Validator(new Dictionary<Control, Label>(){ { positionTitleTextBox, positionErrorLabel }, {descriptionTextBox,descriptionErrorLabel }, { ratePerHourTextBox,ratePerHourErrorLabel} });
        }

        public AddEditPosition(string position)
        {
            InitializeComponent();
            InitializeValidator();
            this.position = position;
            Employee_Positions_Table editablePosition;
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                editablePosition = dbModel.Employee_Positions_Table.Where(i => i.position == position).SingleOrDefault();
            }


            positionTitleTextBox.Text = editablePosition.position;
            descriptionTextBox.Text = editablePosition.Description;
            ratePerHourTextBox.Text = editablePosition.rate_per_hour.ToString();
            positionButton.Text = "Edit";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void addDepartmentButton_Click(object sender, EventArgs e)
        {
            if (!inputValidtor.AreAllNotValid())
            {
               
                if (positionButton.Text == "Add" && descriptionTextBox.Text != string.Empty)
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        if (dbModel.Employee_Positions_Table.Where(i => i.position.Equals(positionTitleTextBox.Text, StringComparison.CurrentCultureIgnoreCase)).SingleOrDefault() == null)
                        {
                            var newPosition = new Employee_Positions_Table()
                            {
                                Description = descriptionTextBox.Text.Trim(),
                                position = positionTitleTextBox.Text.Trim(),
                                rate_per_hour = decimal.Parse(ratePerHourTextBox.Text),
                                date_added = DateTime.Today,
                                log_by = DataBaseFunctions.SystemUser.UserAccount.username
                            };

                            dbModel.Employee_Positions_Table.Add(newPosition);
                            await dbModel.SaveChangesAsync();
                            await ControlForms.PositionUi.JobObjGrid.PopulateGridView(ControlForms.PositionUi.JobObjGrid.fullList = dbModel.Employee_Positions_Table.ToList());


                            new NotificationUi("Successfully add new Position", NotificationUi.NotificationType.restore);
                            this.Close();
                        }
                        else
                        {
                            bunifuSnackbar1.Show(this, "Cannot Add, Position already exist", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        }
                    }
                }


                else
                {
                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        if (dbModel.Employee_Positions_Table.Where(i => i.position.Equals(positionTitleTextBox.Text, StringComparison.CurrentCultureIgnoreCase)).SingleOrDefault() == null) {
                            var editedPosition = dbModel.Employee_Positions_Table.Where(i => i.position == this.position).SingleOrDefault();

                            editedPosition.Description = descriptionTextBox.Text.Trim();
                            editedPosition.position = positionTitleTextBox.Text.Trim();
                            editedPosition.rate_per_hour = decimal.Parse(ratePerHourTextBox.Text);
                            editedPosition.date_added = DateTime.Today;
                            editedPosition.log_by = DataBaseFunctions.SystemUser.UserAccount.username;

                            dbModel.Entry(editedPosition).State = System.Data.Entity.EntityState.Modified;
                            await dbModel.SaveChangesAsync();

                            await ControlForms.PositionUi.JobObjGrid.PopulateGridView(ControlForms.PositionUi.JobObjGrid.fullList = dbModel.Employee_Positions_Table.ToList());



                            await UpdatePositionRatings();
                            new NotificationUi("Successfully Edited Position", NotificationUi.NotificationType.restore);
                            this.Close();
                        }

                        else
                        {
                            bunifuSnackbar1.Show(this, "Cannot Edit, Position already exist", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                        }

                    }
                }
            }
        }

        private void ratePerHourTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidtor.ValidateCustomInput(ratePerHourTextBox,true,false,true,2,10);
        }

        private Task UpdatePositionRatings()
        {
           return Task.Run(() =>
            {
                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    var empList = dbModel.Employee_Information_Table.Where(i => i.job_title == positionTitleTextBox.Text).ToList();

                    foreach (var item  in empList)
                    {
                        item.rate_per_hour = decimal.Parse(ratePerHourTextBox.Text);
                        dbModel.Entry(item).State = System.Data.Entity.EntityState.Modified;
                         dbModel.SaveChanges();
                    }
                    
                }

            });
         
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidtor.ValidateCustomInput(descriptionTextBox, false, true, true, 3, 100);
        }

        private void positionTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            inputValidtor.ValidateStringInput(positionTitleTextBox);
        }

        private void ratePerHourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && ratePerHourTextBox.Text.Contains("."))
            {
                e.Handled = true;
            }

            else if(e.KeyChar == '.' && ratePerHourTextBox.Text == string.Empty)
            {
                e.Handled = true;
            }

            else if(e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

          else if(e.KeyChar != '.'  && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        
      

           
         
        }

        private void AddEditPosition_Load(object sender, EventArgs e)
        {
            descriptionTextBox.BorderColor = positionTitleTextBox.BorderColor = ratePerHourTextBox.BorderColor = System.Drawing.Color.Gray;
            descriptionErrorLabel.Visible = positionErrorLabel.Visible = ratePerHourErrorLabel.Visible = false;
        }
    }
}
