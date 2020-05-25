using MenaxhimiBibliotekes.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.Notifications_Forms
{
    public partial class NotificationsForm : Form
    {

        List<ucNotificationMessages> notificationsList = new List<ucNotificationMessages>();

        public NotificationsForm()
        {
            InitializeComponent();
        }

        private void NotificationsForm_Load(object sender, EventArgs e)
        {
            PopulateNotifications();
        }

        public void PopulateNotifications()
        {
            //this is temporary
            notificationsList.Add(new ucNotificationMessages()
            {
                Category = "Subscribers Notification",
                Message = "Jon Ahmeti is registered in the system from 2020 till 2021!",
                Date = "03/02/2020",
                Icon = Resources.notificationsSubscribers
            });
            notificationsList.Add(new ucNotificationMessages()
            {
                Category = "Subscribers Notification",
                Message = "Elmedin Sahiti is registered in the system from 2020 till 2021!",
                Date = "03/02/2020",
                Icon = Resources.notificationsSubscribers
            });
            notificationsList.Add(new ucNotificationMessages()
            {
                Category = "Subscribers Notification",
                Message = "Granit Kransniqi i eshte derguar email paralajmerimi per skadimin e afatitit (04/04/2020)!",
                Date = "01/04/2020",
                Icon = Resources.notificationsSubscribers
            });

            if (flowpanelMain.Controls.Count < 0)
            {
                flowpanelMain.Controls.Clear();
            }
            else
            {
                foreach (var message in notificationsList)
                {
                    flowpanelMain.Controls.Add(message);
                }
            }
        }

        
    }
}
