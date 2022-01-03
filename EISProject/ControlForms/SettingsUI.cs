using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

namespace EISProject.ControlForms
{
    public partial class SettingsUI : UserControl
    {
        private bool hasChanged;
        private bool dateTimeHasChanged;
        private string _logoPath = string.Empty;

        public SettingsUI()
        {
            InitializeComponent();

         
        }
        private TimeSpan ConvertStringToTimeSPan(string time)
        {
            return TimeSpan.Parse(time.Replace("PM", "").Replace("AM", "").Trim());
        }
        private void gunaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private async void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (hasChanged || dateTimeHasChanged)
            {
                await SaveSettings(inPicker.Value.ToLongTimeString(),outPicker.Value.ToLongTimeString(),int.Parse(graceTimePeriodTextBox.Text),int.Parse(otPercentTextBox.Text),int.Parse(holidayPercentTextBox.Text),decimal.Parse(absentPenaltyTextBox.Text),decimal.Parse(latePenaltyTextBox.Text),UpdateLogo(),titleTextBox.Text);
                new Modals.NotificationUi("Successfully saved settings", Modals.NotificationUi.NotificationType.restore);
                EISMainForm.SettingObj.InitializeSystemSettings();
            }
        }


        private Task SaveSettings(string timeInPicker,string timeOutPicker,int GraceTimePeriod,int adjustmentOT, int adjustmentHoliday, decimal absentPenaltyPercent, decimal latePenaltyPercent,string logoPath,string title)
        {
            return Task.Run(() =>
            {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var schedSettings = dbModel.Attendance_Global_Settings_Table.FirstOrDefault();
                    schedSettings.global_time_in_mandatory = timeInPicker;
                schedSettings.global_time_out_mandatory = timeOutPicker;
                    schedSettings.late_grace_time_period = GraceTimePeriod;

                    dbModel.Entry(schedSettings).State = System.Data.Entity.EntityState.Modified;

                var adjustmentOt = dbModel.Adjustment_Global_Settings_Table.Where(i => i.adjustment_type == "overtime").FirstOrDefault();
                var adjustmentsHoliday = dbModel.Adjustment_Global_Settings_Table.Where(i => i.adjustment_type == "holiday").FirstOrDefault();

                    adjustmentOt.amount_percent = adjustmentOT;
                    adjustmentsHoliday.amount_percent = adjustmentHoliday;

                    dbModel.Entry(adjustmentOt).State = System.Data.Entity.EntityState.Modified;
                    dbModel.Entry(adjustmentsHoliday).State = System.Data.Entity.EntityState.Modified;


                    var absentPenalty = dbModel.Penalty_Global_Settings_Table.Where(i => i.penalty_type == "absent").FirstOrDefault();
                    var latePenalty = dbModel.Penalty_Global_Settings_Table.Where(i => i.penalty_type == "late").FirstOrDefault();

                    absentPenalty.penalty_amount = absentPenaltyPercent;
                    latePenalty.penalty_amount = latePenaltyPercent;

                    dbModel.Entry(absentPenalty).State = System.Data.Entity.EntityState.Modified;
                    dbModel.Entry(latePenalty).State = System.Data.Entity.EntityState.Modified;

                    var systemSettings = dbModel.HRIS_System_Global_Settings__Table.FirstOrDefault();
                    systemSettings.system_logo = logoPath == string.Empty ? systemSettings.system_logo : logoPath;
                    systemSettings.system_name = title;

                   
                        dbModel.SaveChanges();
                        
                  
                   
                }
             
                
                
            });
        }

       

        private void inPicker_ValueChanged(object sender, EventArgs e)
        {
            dateTimeHasChanged = true;
        }

        private void graceTimePeriodTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Back && ((Guna.UI.WinForms.GunaTextBox)sender).Text.Length == 2)
            {
                e.Handled = true;
            }
            else if((Keys)e.KeyChar == Keys.Back && ((Guna.UI.WinForms.GunaTextBox)sender).Text.Length > 2)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void resetBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Reset Default settings for the system ? \n this may remove all current save settings for the system ", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await SaveSettings("7:30:00 AM", "5:30:00 PM", 10, 130, 200, 0, 30, $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 6)}\hris-default-logo.png", "Human Resource Information System for Quezon City University");

                new Modals.NotificationUi("Successfully Restore settings to default", Modals.NotificationUi.NotificationType.restore);

                EISMainForm.SettingObj.InitializeSystemSettings();

                graceTimePeriodTextBox.Text = "10";
                inPicker.Text = "7:30:00 AM";
                outPicker.Text = "5:30:00 PM";
                otPercentTextBox.Text = "130";
                holidayPercentTextBox.Text = "200";
                absentPenaltyTextBox.Text = "0";
                logoPictureBox.Image.Dispose();
                logoPictureBox.Image = new Bitmap($@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 6)}\hris-default-logo.png");
                titleTextBox.Text = "Human Resource Information System for Quezon City University";
            }


        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            using (var openfile = new OpenFileDialog())
            {
                openfile.Filter = "PNG IMAGE (*.png)|*.png|JPEG IMAGE (*.jpg)|*.jpg";

                if(openfile.ShowDialog() == DialogResult.OK)
                {
                    _logoPath = openfile.FileName;
                 

                    hasChanged = true;


                }
            }

            if (hasChanged)
            {
                logoPictureBox.Image = new Bitmap(_logoPath);
            }
        }


        private string  UpdateLogo()
        {
            if (this._logoPath != string.Empty)
            {
                var path = $@"{Environment.CurrentDirectory.Substring(0, Environment.CurrentDirectory.Length - 6)}\SystemSettings\logo.png";

                EISMainForm.SettingObj.LogoPicture.Image.Dispose();

                System.IO.File.Delete(path);
                System.IO.File.Copy(this._logoPath, path);

                return path;
            }

            else
            {
                return this._logoPath;
            }
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void SettingsUI_Load(object sender, EventArgs e)
        {
            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var attendance = dbModel.Attendance_Global_Settings_Table.SingleOrDefault();
                var adjustment = dbModel.Adjustment_Global_Settings_Table.ToList();
                var penalties = dbModel.Penalty_Global_Settings_Table.ToList();
                var systemSettings = dbModel.HRIS_System_Global_Settings__Table.SingleOrDefault();

                graceTimePeriodTextBox.Text = attendance.late_grace_time_period.ToString();
                inPicker.Text = attendance.global_time_in_mandatory;
                outPicker.Text = attendance.global_time_out_mandatory;

                otPercentTextBox.Text = adjustment[0].amount_percent.ToString();
                holidayPercentTextBox.Text = adjustment[1].amount_percent.ToString();

                absentPenaltyTextBox.Text = penalties[0].penalty_amount.ToString();
                latePenaltyTextBox.Text = penalties[1].penalty_amount.ToString();

                titleTextBox.Text = systemSettings.system_name;
                logoPictureBox.Image = new Bitmap(systemSettings.system_logo);

            }

            hasChanged = dateTimeHasChanged = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cannot perform an action because the database is live", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
