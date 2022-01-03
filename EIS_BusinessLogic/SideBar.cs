using Guna.UI.WinForms;

namespace EIS_BusinessLogic
{
    public static class SideBar
    {

        public static  void SideBarOpen(params GunaAdvenceButton[] buttonCollections)
        {
            if (buttonCollections[0].Visible)
            {
                LoopItems(buttonCollections, false);
            }

            else
            {
                LoopItems(buttonCollections, true);
            }
           
        }


        private static void LoopItems(GunaAdvenceButton[] buttonCollections,bool visibility)
        {
            foreach(var item in buttonCollections)
            {
                item.Visible = visibility;
            }
        }
       



     
    }
}
