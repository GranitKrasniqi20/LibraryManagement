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
    public partial class UpdateMemberForm : Form
    {
        public UpdateMemberForm()
        {
            InitializeComponent();

            //subscriber = new Subscriber();
            //subcriberBLL = new SubscriberBLL();
            //subscriberList = new List<Subscriber>();
        }

        Subscriber subscriber = new Subscriber();
        SubscriberBLL subscriberBLL = new SubscriberBLL();
        List<Subscriber> subscriberList = new List<Subscriber>();

        AddMemberForm addMemberForm = new AddMemberForm();

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                subscriber = subscriberBLL.Get(int.Parse(txtMemberID.Text));

                txtFirstName.Text = subscriber.Name;
                txtLastName.Text = subscriber.LastName;
                txtFullAddress.Text = subscriber.Address;
                dtPickerBirthdate.Value = subscriber.Birthday;

                if (subscriber.Gender == 'M')
                {
                    radioMale.Checked = true;
                }

                else if (subscriber.Gender == 'F')
                {
                    radioFemale.Checked = true;
                }

                txtPersonalNumber.Text = subscriber.PersonalNo;
                txtEmail.Text = subscriber.Email;
                txtPhoneNumber.Text = subscriber.PhoneNo;
                txtTillDate.Text = subscriber.ExpirationDate.ToShortDateString();

                txtFromDate.Text = DateTime.Now.ToShortDateString();//Review

                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            try
            {
                subscriber = subscriberBLL.Get(int.Parse(txtMemberID.Text));

                subscriber.Name = txtFirstName.Text;
                subscriber.LastName = txtLastName.Text;
                subscriber.Address = txtFullAddress.Text;

                subscriber.Birthday = dtPickerBirthdate.Value;

                subscriber.PersonalNo = txtPersonalNumber.Text;
                subscriber.Email = txtEmail.Text;
                subscriber.PhoneNo = txtPhoneNumber.Text;

                //subscriber.IsActive = true;

                subscriber.UpdBy = FormLoggedUser.Id;

                if (radioMale.Checked) subscriber.Gender = 'M';
                else subscriber.Gender = 'F';

                SubscriberValidation subscriberValidator = new SubscriberValidation();

                subscriberValidator.subscriber = subscriber;

                subscriberValidator.ValidateSubscriber();

                ValidationResult results = subscriberValidator.Validate(subscriber);

                if (results.IsValid == false)
                {
                    foreach (ValidationFailure failure in results.Errors)
                    {
                        MessageBox.Show($"{failure.ErrorMessage}", "Error Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    subscriberBLL.Update(subscriber);
                    MessageBox.Show("The information of subscriber is updated successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnUpdateMemberSubscription_Click(object sender, EventArgs e)
        {
            try
            {
                subscriber = subscriberBLL.Get(int.Parse(txtMemberID.Text));
                //addMemberForm.nRegistrationDate = DateTime.Parse(txtFromDate.Text);
                subscriber.ExpirationDate = DateTime.Parse(txtTillDate.Text);

                subscriber.IsActive = true;

                subscriber.UpdBy = FormLoggedUser.Id;

                subscriberBLL.Update(subscriber);
                MessageBox.Show("The subscription was successfully updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboSubscriptionPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboSubscriptionPlan.SelectedItem == "Monthly")
                {
                    txtFromDate.Text = DateTime.Now.ToShortDateString();

                    txtTillDate.Text = DateTime.Now.AddMonths(1).ToShortDateString();

                    //subscriberRegistrationDate = DateTime.Parse(txtFromDate.Text);
                    //subscriber.ExpirationDate = DateTime.Parse(txtTillDate.Text);
                }
                if (comboSubscriptionPlan.SelectedItem == "Yearly")
                {
                    txtFromDate.Text = DateTime.Now.ToShortDateString();

                    txtTillDate.Text = DateTime.Now.AddYears(1).ToShortDateString();

                    //subscriberRegistrationDate = DateTime.Parse(txtFromDate.Text);
                   // subscriber.ExpirationDate = DateTime.Parse(txtTillDate.Text);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
