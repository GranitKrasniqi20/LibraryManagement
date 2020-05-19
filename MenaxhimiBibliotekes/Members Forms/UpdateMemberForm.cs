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
        }

        Subscriber subscriber = new Subscriber();
        SubscriberBLL subscriberBLL = new SubscriberBLL();
        List<Subscriber> subscriberList = new List<Subscriber>();


        Bill bill = new Bill();
        BillBLL billBLL = new BillBLL();

        public DateTime r;
        
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                subscriber = subscriberBLL.Get(int.Parse(txtMemberID.Text));

                txtFirstName.Text = subscriber.Name;
                txtLastName.Text = subscriber.LastName;
                txtFullAddress.Text = subscriber.Address;
                dtPickerBirthdate.Value = subscriber.Birthday;

                if (subscriber.Gender == 'M') { radioMale.Checked = true; }
                else if(subscriber.Gender == 'F') { radioFemale.Checked = true; }

                txtPersonalNumber.Text = subscriber.PersonalNo;
                txtEmail.Text = subscriber.Email;
                txtPhoneNumber.Text = subscriber.PhoneNo;

                bill = billBLL.Get(int.Parse(txtMemberID.Text));

                if (subscriber.UpdNo == 0) { txtFromDate.Text = subscriber.InsDate.ToShortDateString(); }
                else { txtFromDate.Text = subscriber.UpdDate.ToShortDateString(); }

                txtTillDate.Text = subscriber.ExpirationDate.ToShortDateString();
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

                subscriber.IsActive = true;
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

                subscriber.UpdDate = DateTime.Parse(txtFromDate.Text);
                subscriber.ExpirationDate = DateTime.Parse(txtTillDate.Text);
                subscriber.IsActive = true;
                subscriber.UpdBy = FormLoggedUser.Id;

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

                    #region BILL///////////////////////////////////////////
                    bill.BillingDate = DateTime.Now;
                    bill.RegistrationDate = DateTime.Parse(txtFromDate.Text);
                    bill.ExpirationDate = DateTime.Parse(txtTillDate.Text);

                    if (bill.ExpirationDate.Month == bill.RegistrationDate.AddMonths(1).Month)
                    {
                        bill.Price = 10;//10euro per Muaj
                    }

                    if (bill.ExpirationDate.Year == bill.RegistrationDate.AddYears(1).Year)
                    {
                        bill.Price = 100;//100euro per Vit
                    }

                    bill.BillTypeId = 1;
                    bill.IsActive = true;
                    bill.InsBy = FormLoggedUser.Id;

                    BillValidation billValidator = new BillValidation();
                    billValidator.bill = bill;
                    billValidator.ValidateBill();
                    ValidationResult resultsBill = billValidator.Validate(bill);

                    if (resultsBill.IsValid == false)
                    {
                        foreach (ValidationFailure failure in resultsBill.Errors)
                        {
                            MessageBox.Show($"{failure.ErrorMessage}", "Error Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        bill.SubscriberId = int.Parse(txtMemberID.Text);
                        billBLL.Add(bill);
                        MessageBox.Show("The subscription was successfully updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    #endregion
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
                if (comboSubscriptionPlan.SelectedItem == "Monthly")
                {
                    txtFromDate.Text = DateTime.Now.ToShortDateString();

                    txtTillDate.Text = DateTime.Now.AddMonths(1).ToShortDateString();
                }
                if (comboSubscriptionPlan.SelectedItem == "Yearly")
                {
                    txtFromDate.Text = DateTime.Now.ToShortDateString();

                    txtTillDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Dizajnimi i Fatures
        private void printDocBill_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string p;
            if (bill.Price == 10)
            {
                p = "Monthly";
            }
            else p = "Yearly";

            int Id = subscriberBLL.MaxSubscriberId();
            string sID = "SL" + Id.ToString("00000");

            string s = "Subscription    Bill";
            string h = "_______________________________";
            string v = "-------------------------------------------------";

            e.Graphics.DrawString(s, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(100, 80));
            e.Graphics.DrawString(h, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString(
                "Subscriber:\t" + subscriber.Name + "  " + subscriber.LastName + "\n" + v + "\n" +
                "Number ID:\t" + subscriber.PersonalNo + "\n" + v + "\n" +
                "Subscriber ID:\t" + sID + "\n" + v + "\n" +
                "Subscription:\t" + p + "\n" + v + "\n" +
                "Expires:\t" + bill.ExpirationDate.ToShortDateString() + "\n" + v + "\n\n" +
                "Price:\t\t" + bill.Price + " €\n" + h + "\n\n\n\n\n" +
                "Date:\t\t" + bill.BillingDate + "\n\n" +
                "Cashier:\t" + FormLoggedUser.Name + "\t" + FormLoggedUser.LastName + "\n\n\n" +
                "Signature:\t" + "_________________\n\n\n\n\n\n\n" +
                "\t\tV.V",
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 130));
        }

        // "Inicializimi" i Print Preview
        private void btnPreview_Click_1(object sender, EventArgs e)
        {
            printPreview.Document = printDocBill;
            printPreview.ShowDialog();
        }

        //Dizajnimi i Fatures
        private void btnBill_Click_1(object sender, EventArgs e)
        {
            printDocBill.Print();
        }
    }
}


