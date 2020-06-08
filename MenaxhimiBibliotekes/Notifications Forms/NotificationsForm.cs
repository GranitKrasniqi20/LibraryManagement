using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BO;
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
        Notification notification = new Notification();
        NotificationBLL notificationBLL = new NotificationBLL();

        List<ucNotificationMessages> notificationsList = new List<ucNotificationMessages>();

        public NotificationsForm()
        {
            InitializeComponent();
        }

        private void NotificationsForm_Load(object sender, EventArgs e)
        {
            comboNotificationType.SelectedIndex = 0;
        }

        private void PopulateNotifications()
        {
            notificationsList.Clear();

            foreach (var notification in notificationBLL.GetAll())
            {
                if (notification.Category == "Subscriber Notification")
                {
                    notificationsList.Add(new ucNotificationMessages()
                    {
                        Category = notification.Category,
                        Message = notification.Message,
                        Date = notification.Date.ToShortDateString(),
                        Icon = Resources.notificationsSubscribers
                    });
                }
                else if (notification.Category == "Material Notification")
                {
                    notificationsList.Add(new ucNotificationMessages()
                    {
                        Category = notification.Category,
                        Message = notification.Message,
                        Date = notification.Date.ToShortDateString(),
                        Icon = Resources.notificationsMaterials
                    });
                }
            }
            

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

        private void PopulateSubscribersNotifications()
        {
            notificationsList.Clear();
            flowpanelMain.Controls.Clear();

            foreach (var notification in notificationBLL.GetAll())
            {
                if (notification.Category == "Subscriber Notification")
                {
                    notificationsList.Add(new ucNotificationMessages()
                    {
                        Category = notification.Category,
                        Message = notification.Message,
                        Date = notification.Date.ToShortDateString(),
                        Icon = Resources.notificationsSubscribers
                    });
                }
            }

            foreach (var message in notificationsList)
            {
                flowpanelMain.Controls.Add(message);
            }
        }

        private void PopulateMaterialsNotifications()
        {
            notificationsList.Clear();
            flowpanelMain.Controls.Clear();

            foreach (var notification in notificationBLL.GetAll())
            {
                if (notification.Category == "Material Notification")
                {
                    notificationsList.Add(new ucNotificationMessages()
                    {
                        Category = notification.Category,
                        Message = notification.Message,
                        Date = notification.Date.ToShortDateString(),
                        Icon = Resources.notificationsMaterials
                    });
                }
            }

            foreach (var message in notificationsList)
            {
                flowpanelMain.Controls.Add(message);
            }
        }

        private void NotificationsForm_Activated(object sender, EventArgs e)
        {
            if (comboNotificationType.SelectedIndex == 0)
            {
                PopulateNotifications();
            }
            else if (comboNotificationType.SelectedIndex == 1)
            {
                PopulateSubscribersNotifications();
            }
            else if (comboNotificationType.SelectedIndex == 2)
            {
                PopulateMaterialsNotifications();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (comboNotificationType.SelectedIndex == 0)
            {
                PopulateNotifications();
            }
            else if (comboNotificationType.SelectedIndex == 1)
            {
                PopulateSubscribersNotifications();
            }
            else if (comboNotificationType.SelectedIndex == 2)
            {
                PopulateMaterialsNotifications();
            }
        }
    }
}
