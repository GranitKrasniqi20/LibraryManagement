using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BLL.Validate;
using MenaxhimiBibliotekes.BO;


namespace MenaxhimiBibliotekes.Members_Forms
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }

        //Global Variables and Instances
        Subscriber subscriber;
        SubscriberBLL subscriberBLL;

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                subscriber = new Subscriber();
                subscriberBLL = new SubscriberBLL();

                //if(subscriber.Birthday != null)
                //{
                //    DateTime d = DateTime.Now;
                //    DateTime min = new DateTime(1, 1, 1);

                //    if(subscriber.Birthday < min && subscriber.Birthday > d)
                //    {
                //        MessageBox.Show("No valid date");
                //    }

                //    else
                //    {
                //        subscriber.Birthday = DateTime.Parse(txtBirthdate.Text);
                //    }
                //}
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
