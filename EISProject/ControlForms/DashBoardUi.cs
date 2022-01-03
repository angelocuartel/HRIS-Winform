using System;
using EISProject.DataBaseFunctions;
using System.Windows.Forms;
using System.Linq;
using LiveCharts;

namespace EISProject.ControlForms
{
    public partial class DashBoardUi : UserControl
    {
        public static Dashboard DashboardObj { get { return dashboardObj; } }
        private static Dashboard dashboardObj;
      public static  DataGridAction<Holidays_Table> HolidayGridObjDashboard { get { return holidayGridObjDashboard; } }
      private static DataGridAction<Holidays_Table> holidayGridObjDashboard; 
        public DashBoardUi()
        {
            InitializeComponent();
        }

     
       
        private void DashBoardUi_Load(object sender, EventArgs e)
        {

            dashboardObj = new Dashboard( chart1, totalActiveLabel, totalArchivedLabel, totalFilesLabel, totalDepartmentsLabel, totalPresentTodayLabel, totalOnTimeTodayLabel, totalLatesTodayLabel, totalPendingLeavesLabel);
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var month = DateTime.Today.ToString("MMMM");
                holidayGridObjDashboard = new DataGridAction<Holidays_Table>(holidayEmptyLabel, totalRecordLabel, holidayDataGridView,dbModel.Holidays_Table.Where(i =>i.date_occurrence.Contains(month)).ToList());
                holidayGridObjDashboard.PopulateGridView(holidayGridObjDashboard.fullList);
            }
            
            dashboardObj.LoadDashboardPanel();
            dashboardObj.LoadDashboardEmployeeChart();

           

        }

    }
}
