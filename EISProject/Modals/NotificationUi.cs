using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EISProject.Modals
{
    public partial class NotificationUi : Form
    {
        private NotificationType notiftype;
        private string message;
        public NotificationUi(string message,NotificationType notiftype)
        {
            this.notiftype = notiftype;
            this.message = message;
            InitializeComponent();

            guna2ShadowForm1.SetShadowForm(this);
            guna2Transition1.ShowSync(this,false,Guna.UI2.AnimatorNS.Animation.Transparent);
            this.TopMost = true;
        }

        private void SetNotificationType()
        {

            //Get screen resolution
            Rectangle res = Screen.PrimaryScreen.Bounds;

            // Calculate location (etc. 1366 Width - form size...)
            //   this.Location = new Point((res.Width - Size.Width)-10,10);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width-5, Screen.PrimaryScreen.WorkingArea.Height - this.Height - 2);
            timer1.Start();

            this.label1.Text = message;

            dateLabel.Text = DateTime.Now.ToLongTimeString();
            switch (this.notiftype)
            {
                case NotificationType.archived:
                  panelHeadColor.BackColor = Color.FromArgb(236, 43, 62);
                    this.pictureBox1.Image = new Bitmap(@"C:\Users\Boss\Desktop\Menu\c#\icons\icons8_archive_16.png");
                    

                    break;

                case NotificationType.restore:
                    panelHeadColor.BackColor = Color.SeaGreen;
                    this.pictureBox1.Image = new Bitmap(@"C:\Users\Boss\Desktop\Menu\c#\icons\icons8_data_backup_16.png");
                    break;

            }

            
        }


        public enum NotificationType
        {
            archived,
            restore
        }
        private void NotificationUi_Load(object sender, EventArgs e)
        {

            SetNotificationType();

            
        }

     

        int seconds = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds == 4)
            {
                timer1.Stop();
                seconds = 0;


                this.Dispose();

            }


        }
    }
}
