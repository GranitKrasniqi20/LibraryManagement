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
    public partial class DeleteMemberForm : Form
    {
        public DeleteMemberForm()
        {
            InitializeComponent();
        }

        //Global Variables and Instances
        Subscriber subscriber;
        SubscriberBLL subscriberBLL;

        AddMemberForm addMemberForm = new AddMemberForm();

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            subscriberBLL.Get(int.Parse(txtMemberID.Text));
                
            txtFirstName.Text = subscriber.Name;
            txtLastName.Text = subscriber.LastName;
            txtFullAddress.Text = subscriber.Address;
            txtBirthdate.Text = subscriber.Birthday.ToShortDateString();
            txtGender.Text = subscriber.Gender.ToString();
            txtPersonalNumber.Text = subscriber.PersonalNo;
            txtEmail.Text = subscriber.Email;
            txtPhoneNumber.Text = subscriber.PhoneNo;
            txtTillDate.Text = subscriber.ExpirationDate.ToShortDateString();

            //txtSubscriptionPlan.Text = txtSubscriptionPlan.Text;

            txtFromDate.Text = addMemberForm.subscriberRegistrationDate.ToShortDateString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            subscriberBLL.Delete(int.Parse(txtMemberID.Text));

        }
    }
}
