using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EISProject.DataBaseFunctions
{
   public static class AccessLevel
    {



       public static void SetAccessControls(params Control[] controls)
        {
          if(SystemUser.UserAccount.access_level == "HR")
            {
                LoopControls(false, controls);
            }
          else if (SystemUser.UserAccount.access_level == "Administrator")
            {
                controls.Where(i => i.Name == "settingBtn").SingleOrDefault().Visible = false;
            }
          else
            {
                LoopControls(true, controls);
            }
        }

        private static void LoopControls(bool isShow, params Control[] controls)
        {

            foreach (var control in controls)
            {
                control.Visible = isShow;
            }
        }
    }
}
