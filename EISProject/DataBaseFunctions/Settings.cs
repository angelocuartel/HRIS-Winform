using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EISProject.DataBaseFunctions
{
  public  class Settings
    {
        public PictureBox LogoPicture { get { return _logoPictureBox; } }
        private PictureBox _logoPictureBox;
        private Label _companyName;
        public Settings(PictureBox logoPictureBox, Label companyName)
        {
            this._logoPictureBox = logoPictureBox;
            this._companyName = companyName;
        }

        public void InitializeSystemSettings()
        {
            this._logoPictureBox.Image.Dispose();
            var imagePath = string.Empty;

            using (var dbModel = new EmployeeInformationSystemDataBaseEntities())
            {
                var settings = dbModel.HRIS_System_Global_Settings__Table.SingleOrDefault();

                imagePath = settings.system_logo;
              
                this._companyName.Text = settings.system_name;
            }

            this._logoPictureBox.Image = new Bitmap(imagePath);
        }
    }
}
