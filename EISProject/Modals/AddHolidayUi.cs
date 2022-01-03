using System;
using System.Linq;
using System.Windows.Forms;

namespace EISProject.Modals
{
    public partial class AddHolidayUi : Form
    {
        private int holidayId;
        public AddHolidayUi()
        {
            InitializeComponent();
        }

        public AddHolidayUi(Holidays_Table holiday)
        {
            InitializeComponent();

            addButton.Text = "Save";

            monthCalendar1.SelectionStart = DateTime.Parse(holiday.date_occurrence.ToString());
            holidayTitleTextBox.Text = holiday.holiday_title;
            descriptionTextBox.Text = holiday.description;
            holidayId = holiday.id;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthLabel.Text = monthCalendar1.SelectionRange.Start.ToString("MMMM");
            dayLabel.Text = monthCalendar1.SelectionRange.Start.ToString("dd");
            yearLabel.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy");
        }

        private async void positionButton_Click(object sender, EventArgs e)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {


                if (addButton.Text == "Save")
                {

                    var UpdatedHoliday = dbModel.Holidays_Table.Where(i => i.id == this.holidayId).SingleOrDefault();
                    UpdatedHoliday.description = descriptionTextBox.Text;
                    UpdatedHoliday.holiday_title = holidayTitleTextBox.Text;
                    UpdatedHoliday.date_occurrence = monthCalendar1.SelectionStart.ToLongDateString();

                    dbModel.Entry(UpdatedHoliday).State = System.Data.Entity.EntityState.Modified;
                    await dbModel.SaveChangesAsync();

                    new NotificationUi("Successfully Edit Holiday", NotificationUi.NotificationType.restore);
                }
                else
                {



                    var newHoliday = new Holidays_Table()
                    {
                        date_added = DateTime.Today,
                        date_occurrence = monthCalendar1.SelectionStart.ToLongDateString(),
                        description = descriptionTextBox.Text,
                        holiday_title = holidayTitleTextBox.Text,
                        log_by = DataBaseFunctions.SystemUser.UserAccount.username,

                    };

                    dbModel.Holidays_Table.Add(newHoliday);
                    await dbModel.SaveChangesAsync();

                 
                    new NotificationUi("Successfully Add Holiday", NotificationUi.NotificationType.restore);



                }

                await ControlForms.HolidaysUi.HolidayGridObj.PopulateGridView(ControlForms.HolidaysUi.HolidayGridObj.fullList = dbModel.Holidays_Table.ToList());
                if (EISMainForm.Dashboard_HasClick)
                {
                    var month = DateTime.Today.ToString("MMMM");
                    await ControlForms.DashBoardUi.HolidayGridObjDashboard.PopulateGridView(ControlForms.DashBoardUi.HolidayGridObjDashboard.fullList = dbModel.Holidays_Table.Where(i => i.date_occurrence.Contains(month)).ToList());
                }
                this.Close();
            }
        }
    }
}
