using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace EISProject.Modals
{
    public partial class LoadingForm : Form
    {

        public LoadingForm()
        {
            InitializeComponent();
            new DataBaseFunctions.Settings(logoPictureBox, titleTextBox).InitializeSystemSettings();
            metroProgressSpinner1.Update();
            
        }

     
    }
}
