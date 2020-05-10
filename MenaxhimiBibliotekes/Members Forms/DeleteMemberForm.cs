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
        SubscriberBLL subscriberBLL = new SubscriberBLL();

        AddMemberForm addMemberForm = new AddMemberForm();

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMemberID.Text);
                subscriber = subscriberBLL.Get(id);//errori

                txtFirstName.Text = subscriber.Name;
                txtLastName.Text = subscriber.LastName;
                txtFullAddress.Text = subscriber.Address;
                txtBirthdate.Text = subscriber.Birthday.ToShortDateString();
                txtGender.Text = subscriber.Gender.ToString();
                txtPersonalNumber.Text = subscriber.PersonalNo;
                txtEmail.Text = subscriber.Email;
                txtPhoneNumber.Text = subscriber.PhoneNo;
                txtTillDate.Text = subscriber.ExpirationDate.ToShortDateString();
                txtFromDate.Text = DateTime.Now.ToShortDateString();// addMemberForm.subscriberRegistrationDate.ToShortDateString();

                //txtSubscriptionPlan.Text = "Yearly";

                if(subscriber.ExpirationDate.Month== DateTime.Now.AddMonths(1).Month)
                {
                    txtSubscriptionPlan.Text = "Monthly";
                }
                else if (subscriber.ExpirationDate.Year == DateTime.Now.AddYears(1).Year)
                {
                    txtSubscriptionPlan.Text = "Yearly";
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show("errorrrrrrrrr !", "fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            subscriberBLL.Delete(int.Parse(txtMemberID.Text));
            MessageBox.Show("The subscriber is deleted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
