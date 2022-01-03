using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIS_BusinessLogic
{
   public static class LoadScreen
    {

        public static void CloseLoadScreen(Form form)
        {
            form.Invoke(new ThreadStart(delegate { form.Dispose(); }));
        }
    }
}
