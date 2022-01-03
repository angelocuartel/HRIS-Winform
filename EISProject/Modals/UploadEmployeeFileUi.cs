using System;
using System.Collections.Generic;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Linq;

namespace EISProject.Modals
{
    public partial class UploadEmployeeFileUi : Form
    {
        private int employeeId;
        private string filePath;
        public UploadEmployeeFileUi(int employeeId,string employeeName)
        {


            InitializeComponent();

            this.employeeId = employeeId;
            employeeNameLabel.Text = employeeName;


            SetMissingFiles();


        }

        private void SetMissingFiles()
        {
            List<string> fileTypes = new List<string>() { "TOR", "Diploma", "Police Clearance", "NBI Clearance", "HEALTH Clearance", "Curriculum Vatae" };
            List<string> empFiles;

            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                 empFiles = dbModel.Employees_Documents_Table.Where(i => i.employee_id == this.employeeId).Select(i => i.filetype).ToList();
            }



            fileTypesComboBox.DataSource = fileTypes.Where(i => !empFiles.Contains(i)).ToList();
        
        }

    

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            using (var openfile = new OpenFileDialog())
            {
                openfile.Filter = "Pdf Files (*.pdf)|*.pdf";

                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    uploadCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
                    filePath = openfile.FileName;
                }
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
         
            if (filePath != string.Empty)
            {
                DataBaseFunctions.EmployeeFile.UploadSingleFile(this.employeeId, fileTypesComboBox.Text,filePath);
                DataBaseFunctions.EmployeeFile.CheckEmployeeDocs(this.employeeId);
                filePath = string.Empty;
                bunifuSnackbar1.Show(this, "Successfully add a File", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

                SetMissingFiles();
                uploadCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;

                if (EISMainForm.Dashboard_HasClick)
                    ControlForms.DashBoardUi.DashboardObj.LoadDashboardPanel();
            }

            else 
            {
                bunifuSnackbar1.Show(this, "Please choose a file from your device", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
