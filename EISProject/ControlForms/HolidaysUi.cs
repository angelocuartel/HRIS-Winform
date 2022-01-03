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

namespace EISProject.ControlForms
{
    public partial class HolidaysUi : UserControl
    {
        public static DataGridAction<Holidays_Table> HolidayGridObj { get { return holidayGridObj; } }
        private static  DataGridAction<Holidays_Table> holidayGridObj;
        public HolidaysUi()
        {
            InitializeComponent();
        }

        private async void HolidaysUi_Load(object sender, EventArgs e)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                holidayGridObj = new DataGridAction<Holidays_Table>(emptyHolidayLabel, totalRecordsLabel, holidayDataGridView,dbModel.Holidays_Table.ToList());
               await holidayGridObj.PopulateGridView(holidayGridObj.fullList);
            }
            
        }

        private async void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            await holidayGridObj.SearchGridView(searchTextBox.Text, "holiday_title", "date_occurrence", "log_by");
        }

        private async void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           await holidayGridObj.FilterGridView(filterMonthComboBox.Text,"Show All",true);
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            using (var addHolidayForm = new Modals.AddHolidayUi())
            {
                addHolidayForm.ShowDialog();
            }
        }

        private async void holidayDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            await holidayGridObj.SortGridView(holidayDataGridView.Columns[e.ColumnIndex].DataPropertyName);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            using (var addHolidayForm = new Modals.AddHolidayUi(holidayGridObj.fullList.Where(i => i.id.ToString() == holidayDataGridView.CurrentRow.Cells[0].Value.ToString()).SingleOrDefault()))
            {
                addHolidayForm.ShowDialog();
            }
        }

        private async void holidayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (holidayDataGridView.Columns[e.ColumnIndex].HeaderText == "Action" && holidayDataGridView.Rows.Count > 0)
            {
                int holidayID = int.Parse(holidayDataGridView.CurrentRow.Cells[0].Value.ToString());

                if (MessageBox.Show($"Do you really want to delete Holiday {holidayDataGridView.CurrentRow.Cells[1].Value.ToString()} ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                    {
                        var deletedHoliday = dbModel.Holidays_Table.Where(i => i.id == holidayID).SingleOrDefault();
                        dbModel.Entry(deletedHoliday).State = System.Data.Entity.EntityState.Deleted;
                       await dbModel.SaveChangesAsync();

                       await  holidayGridObj.PopulateGridView(dbModel.Holidays_Table.ToList());
                    }

                    new Modals.NotificationUi("Successfully Deleted a Holiday", Modals.NotificationUi.NotificationType.restore).Show();
                }


            }
        }
    }
    
}
