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
        Subscriber subscriber = new Subscriber();
        SubscriberBLL subscriberBLL = new SubscriberBLL();

        public DateTime nRegistrationDate { get; set; }//me rujt vleren e RegistrationDate

        public static List<Subscriber> ManSubscriber = new List<Subscriber>();
        public static List<Subscriber> WomanSubscriber = new List<Subscriber>();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                subscriber.Name = txtFirstName.Text;
                subscriber.LastName = txtLastName.Text;
                subscriber.Address = txtFullAddress.Text;

                subscriber.Birthday = dtPickerBirthdate.Value;

                subscriber.PersonalNo = txtPersonalNumber.Text;
                subscriber.Email = txtEmail.Text;
                subscriber.PhoneNo = txtPhoneNumber.Text;

                subscriber.IsActive = true;

                subscriber.InsBy = FormLoggedUser.Id;

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
                    subscriberBLL.Add(subscriber);
                    MessageBox.Show("The subscriber is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void cmbSubscriptionPlan(object sender, EventArgs e)
        {
            try
            {
                if (comboSubscriptionPlan.SelectedItem == "Monthly")
                {
                    txtFromDate.Text = DateTime.Now.ToShortDateString();

                    txtTillDate.Text = DateTime.Now.AddMonths(1).ToShortDateString();

                    nRegistrationDate = DateTime.Parse(txtFromDate.Text);
                    subscriber.ExpirationDate = DateTime.Parse(txtTillDate.Text);
                }

                if (comboSubscriptionPlan.SelectedItem == "Yearly")
                {
                    txtFromDate.Text = DateTime.Now.ToShortDateString();

                    txtTillDate.Text = DateTime.Now.AddYears(1).ToShortDateString();

                    nRegistrationDate = DateTime.Parse(txtFromDate.Text);
                    subscriber.ExpirationDate = DateTime.Parse(txtTillDate.Text);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

