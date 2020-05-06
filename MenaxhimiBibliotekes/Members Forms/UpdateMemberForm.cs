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
        Subscriber subscriber;
        SubscriberBLL subcriberBLL;
        List<Subscriber> subscriberList;

        public UpdateMemberForm()
        {
            InitializeComponent();

            subscriber = new Subscriber();
            subcriberBLL = new SubscriberBLL();
            subscriberList = new List<Subscriber>();


        }

        AddMemberForm addMemberForm =new AddMemberForm();

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            subscriber = subcriberBLL.Get(int.Parse(txtMemberID.Text));

            txtFirstName.Text = subscriber.Name;
            txtLastName.Text = subscriber.LastName;
            txtFullAddress.Text = subscriber.Address;
            dtPickerBirthdate.Value = subscriber.Birthday;

            if (subscriber.Gender == 'M')
            {
                panel4.Enabled = radioMashkull.Checked;
            }

            else if (subscriber.Gender == 'F')
            {
                panel4.Enabled = radioFemer.Checked;
            }

            txtPersonalNumber.Text = subscriber.PersonalNo;
            txtEmail.Text = subscriber.Email;
            txtPhoneNumber.Text = subscriber.PhoneNo;
            txtTillDate.Text = subscriber.ExpirationDate.ToShortDateString();

            txtFromDate.Text = addMemberForm.subscriberRegistrationDate.ToShortDateString();

            //skemi mundsi me shfaq subscriptionplan
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Vlen veq per te dhena, nuk duhet ta lejoje qe ta ndryshoje subscription plan
            subscriber = subcriberBLL.Get(int.Parse(txtMemberID.Text));

            subscriber.Name = txtFirstName.Text;
            subscriber.LastName = txtLastName.Text;
            subscriber.Address = txtFullAddress.Text;

            subscriber.Birthday = dtPickerBirthdate.Value;

            subscriber.PersonalNo = txtPersonalNumber.Text;
            subscriber.Email = txtEmail.Text;
            subscriber.PhoneNo = txtPhoneNumber.Text;

            subscriber.IsActive = true;

            subscriber.InsBy = FormLoggedUser.Id;

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
                //if (subscriberBLL.Update(subscriber) == 0)
                //{
                //    MessageBox.Show("The subscriber is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}
            }

        }

        private void btnUpdateMemberSubscription_Click(object sender, EventArgs e)
        {

            //Veq per subscriptionPlan, nuk duhet te lejoje qe te i ndryshoje te dhenat tjera
            addMemberForm.subscriberRegistrationDate = DateTime.Parse(txtFromDate.Text);
            subscriber.ExpirationDate = DateTime.Parse(txtTillDate.Text);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (radioMashkull.Checked)
            {
                subscriber.Gender = 'M';
            }

            if (radioFemer.Checked)
            {
                subscriber.Gender = 'F';
            }
        }

        private void comboSubscriptionPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Abonimi Mujor
                if (comboSubscriptionPlan.SelectedItem == "Monthly")
                {
                    txtFromDate.Text = DateTime.Now.ToShortDateString();

                    txtTillDate.Text = DateTime.Now.AddMonths(1).ToShortDateString();

                    //subscriberRegistrationDate = DateTime.Parse(txtFromDate.Text);
                    //subscriber.ExpirationDate = DateTime.Parse(txtTillDate.Text);
                }

                //Abonimi Vjetor
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
