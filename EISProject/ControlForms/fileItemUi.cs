using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EISProject.ControlForms
{
    public partial class fileItemUi : UserControl
    {

        string filePath;
        Employees_Documents_Table file;
        public fileItemUi(Employees_Documents_Table file)
        {
            InitializeComponent();
            this.file = file;

            filePath = file.filename;

            fileUploadedLabel.Text = file.date_uploaded.ToString();
            fileTypeLabel.Text = file.filetype;
            fileSizeLabel.Text = file.file_size;

        }

        private void viewFileBtn_Click(object sender, EventArgs e)
        {
            new Modals.ViewEmployeeFileUi(filePath).ShowDialog();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete this file ?", "Deleting File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.IO.File.Delete(file.filename);

                using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
                {
                    dbModel.Entry(file).State = System.Data.Entity.EntityState.Deleted;
                    dbModel.SaveChanges();
                }

                this.Dispose();
            }
        }
    }
}
