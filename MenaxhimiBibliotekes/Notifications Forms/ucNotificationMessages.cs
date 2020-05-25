using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.Notifications_Forms
{
    public partial class ucNotificationMessages : UserControl
    {
        public ucNotificationMessages()
        {
            InitializeComponent();
        }


        #region Custom Properties
        private string _message;
        private string _date;
        private string _category;
        private Image _icon;

        [Category("Custom Properties")]
        public string Message
        {
            get { return _message; }
            set { _message = value; txtNotificationMessage.Text = value; }
        }

        [Category("Custom Properties")]
        public string Date
        {
            get { return _date; }
            set { _date = value; txtNotificationDate.Text = value; }
        }

        [Category("Custom Properties")]
        public string Category
        {
            get { return _category; }
            set { _category = value; txtNotificationCategory.Text = value; }
        }

        [Category("Custom Properties")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureCategory.Image = value; }
        }
        #endregion
    }
}
