using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIS_BusinessLogic
{
   public class PictureGrid<T>
    {

        private FlowLayoutPanel panel;
        private Label noRecordFoundLabel;
        private Label recordCountLabel;
        public static T ItemObject { get; set; }
        public PictureGrid(FlowLayoutPanel panel,Label noRecordFoundLabel,Label recordCountLabel)
        {
            this.panel = panel;
            this.noRecordFoundLabel = noRecordFoundLabel;
            this.recordCountLabel = recordCountLabel;
        }


        public void LoadItems<c>(UserControl pictureGridControl, List<T> items) where c : UserControl, new()
        {
            this.panel.SuspendLayout();
            this.panel.Controls.Clear();

            

            if (items.Count > 0)
            {
               
                noRecordFoundLabel.Visible = false;

                foreach (var item in items)
                {
                    ItemObject = item;
                    this.panel.Controls.Add(new c());
                }
            }
            else
            {
                this.panel.SendToBack();
                this.noRecordFoundLabel.BringToFront();
                this.noRecordFoundLabel.Visible = true;
            }

            this.recordCountLabel.Text = items.Count.ToString();
            this.panel.ResumeLayout();
        }
    }
}
