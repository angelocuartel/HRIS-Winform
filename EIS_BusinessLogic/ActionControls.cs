using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIS_BusinessLogic
{
   public static class ActionControls
    {
        static void ClearAllTexts(params Control[] controls)
        {
            foreach(var item in controls)
            {
                item.Text = string.Empty;
            }
        }
    }
}
