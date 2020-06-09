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
        }

        private void DisplayAll()
        {
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

        private void DisplaySubscribers()
        {
            flowpanelMain.Controls.Clear();

            foreach (var message in notificationsList)
            {
                if (message.Category == "Subscriber Notification")
                {
                    flowpanelMain.Controls.Add(message);
                }
            }
        }

        private void DisplayMaterials()
        {
            flowpanelMain.Controls.Clear();

            foreach (var message in notificationsList)
            {
                if (message.Category == "Material Notification")
                {
                    flowpanelMain.Controls.Add(message);
                }
                
            }
        }

        private void NotificationsForm_Activated(object sender, EventArgs e)
        {
            flowpanelMain.Controls.Clear();

            if (comboNotificationType.SelectedIndex == 0)
            {
                PopulateNotifications();
                DisplayAll();
            }
            else if (comboNotificationType.SelectedIndex == 1)
            {
                PopulateNotifications();
                DisplaySubscribers();
            }
            else if (comboNotificationType.SelectedIndex == 2)
            {
                PopulateNotifications();
                DisplayMaterials();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            flowpanelMain.Controls.Clear();

            if (comboNotificationType.SelectedIndex == 0)
            {
                PopulateNotifications();
                DisplayAll();
            }
            else if (comboNotificationType.SelectedIndex == 1)
            {
                PopulateNotifications();
                DisplaySubscribers();
            }
            else if (comboNotificationType.SelectedIndex == 2)
            {
                PopulateNotifications();
                DisplayMaterials();
            }
        }
    }
}
