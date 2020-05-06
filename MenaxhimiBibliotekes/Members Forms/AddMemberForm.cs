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

        public DateTime subscriberRegistrationDate;//me rujt vleren e RegistrationDate

        public static List<Subscriber> ManSubscriber = new List<Subscriber>();
        public static List<Subscriber> WomanSubscriber = new List<Subscriber>();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                subscriber = new Subscriber();
                subscriberBLL = new SubscriberBLL();

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
                    subscriberBLL.Add(subscriber);
                    MessageBox.Show("The subscriber is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


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
                //Abonimi Mujor
                if (comboSubscriptionPlan.SelectedItem == "Monthly")
                {
                    txtFromDate.Text = DateTime.Now.ToShortDateString();

                    txtTillDate.Text = DateTime.Now.AddMonths(1).ToShortDateString();

                    subscriberRegistrationDate = DateTime.Parse(txtFromDate.Text);
                    subscriber.ExpirationDate = DateTime.Parse(txtTillDate.Text);
                }

                //Abonimi Vjetor
                if (comboSubscriptionPlan.SelectedItem == "Yearly")
                {
                    txtFromDate.Text = DateTime.Now.ToShortDateString();

                    txtTillDate.Text = DateTime.Now.AddYears(1).ToShortDateString();

                    subscriberRegistrationDate = DateTime.Parse(txtFromDate.Text);
                    subscriber.ExpirationDate = DateTime.Parse(txtTillDate.Text);
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

            if (radioMashkull.Checked)
            {
                subscriber.Gender = 'M';

                ManSubscriber.Add(subscriber);
            }

            if(radioFemer.Checked)
            {
                subscriber.Gender = 'F';

                WomanSubscriber.Add(subscriber);
            }
        }

       
    }
}
