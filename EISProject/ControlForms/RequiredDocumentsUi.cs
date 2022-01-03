using System;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Collections.Generic;

namespace EISProject.ControlForms
{
    public partial class RequiredDocumentsUi : UserControl
    {
       private OpenFileDialog uploader = new OpenFileDialog();

       public static Dictionary<string, GunaTextBox> docs_Controls { get; set; }

        public static bool HasEmpty { get; set; }

        public int NumsEmptyBox { get; set; }
        public RequiredDocumentsUi()
        {
            InitializeComponent();
            docs_Controls = new Dictionary<string, GunaTextBox>()
            {
                {"torUploadBtn", torTxtBox },{ "cvUploadBtn", cvTxtBox },
                {"pcUploadBtn", policeTxtBox },{ "diplomaUploadBtn", diplomaTxtBox },
                {"nbiUploadBtn", nbiTxtBox },{ "brgyUploadBtn", brgyTxtBox },


            };

            HasEmpty = true;
        }



        private void SetFileName(Control fileNameHolder)
        {
          
                if (uploader.ShowDialog() == DialogResult.OK)
                {
                    fileNameHolder.Text = uploader.FileName.Trim();
                }

            NumsEmptyBox++;
        }

        private void torUploadBtn_Click(object sender, EventArgs e)
        {
            using (uploader)
            {
                uploader.Filter = "Pdf Files (*.pdf)|*.pdf";
                var button = (GunaCircleButton)sender;
                var btnName = button.Name;

                foreach (var btn in docs_Controls.Keys)
                {
                    if(btn == btnName)
                    {
                        SetFileName(docs_Controls[btnName]);

                    }
                }

                CheckEmpty();

            }
        }


        // clear all stringPath in textboxes
        private void next1Btn_Click(object sender, EventArgs e)
        {
            foreach(var txtBox in docs_Controls.Values)
            {
                txtBox.Clear();
            }
        }


       private  void CheckEmpty()
        {

            foreach (var txtbox in docs_Controls.Values)
            {
                if(txtbox.Text == string.Empty)
                {
                    HasEmpty = true;
                    break;
                }
                else
                {
                    HasEmpty = false;
                }
            }

        }

        
    }
}
