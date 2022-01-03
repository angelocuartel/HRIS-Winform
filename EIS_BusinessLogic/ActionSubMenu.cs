using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using System.Drawing;
using Guna.UI2.WinForms;
using Guna.UI2.AnimatorNS;
   public sealed class Menu
    {
    private Panel displayPanel;
    private  Dictionary< Label,BunifuCheckBox> progress;
    private  List<UserControl> menus;
    private UserControl menuPage;
    private int indexProgress;
   
    public Menu(List<UserControl>menus,Panel displayPanel,Dictionary<Label,BunifuCheckBox>progress)
        {
            this.displayPanel = displayPanel;
            this.menus = menus;
            this.progress = progress;
        }


        public void NextMenu(UserControl menuPage, int indexProgress)
        {
            this.indexProgress = indexProgress--;
            this.menuPage = menuPage;
            progress.ElementAt(indexProgress).Key.ForeColor = System.Drawing.Color.Green;
            progress.ElementAt(indexProgress).Value.Checked = true;

            RemoveUserControl();    
        }

       


        private void RemoveUserControl()
        {
            this.displayPanel.Controls.Clear();
            menuPage.Width = this.displayPanel.Width;
            menuPage.Height = this.displayPanel.Height;
            displayPanel.Controls.Add(menuPage);
            menuPage.Dock = DockStyle.Fill;
        }

        public void PreviousMenu(UserControl menuPage, int indexProgress)
        {
            this.indexProgress = indexProgress--;
            this.menuPage = menuPage;
              progress.ElementAt(indexProgress).Key.ForeColor = System.Drawing.Color.White;
            progress.ElementAt(indexProgress).Value.Checked = false;

            RemoveUserControl();
        }

  






}

