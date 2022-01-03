using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIS_BusinessLogic
{
    public class ActionMenu
    {
        List<UserControl> menus;
        Panel mainPanel;
        public List<UserControl> Menus { set { menus = value; } }

        public ActionMenu(List<UserControl>menus,Panel mainPanel)
        {
            this.menus = menus;
            this.mainPanel = mainPanel;
            mainPanel.Controls.Clear();


        }



        public void Open(UserControl pageMenu)
        {

            if (!this.mainPanel.Contains(pageMenu))
            {
                

                foreach (var menu in menus)
                {
                    if (menu.Equals(pageMenu))
                    {
                      
                        mainPanel.SuspendLayout();

                        var tempMenu = pageMenu;

                        tempMenu.Width = mainPanel.Width;
                        tempMenu.Height = mainPanel.Height;
                        mainPanel.Controls.Add(tempMenu);
                        tempMenu.Dock = DockStyle.Fill;
                        mainPanel.Controls.RemoveAt(0);

                        mainPanel.ResumeLayout();
                    }


                }

              
            }

          


        }

        

    
    }

}
