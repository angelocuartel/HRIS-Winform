using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EISProject.DataBaseFunctions
{
   public class ComboBoxControl
    {
        private Guna2ComboBox comboBox;

        public ComboBoxControl(Guna2ComboBox comboBox)
        {
            this.comboBox = comboBox;
        }

        public void SetDataSource(List<string> datasource)
        {
            this.comboBox.DataSource = datasource;
        }
    }
}
