using MenaxhimiBibliotekes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.Members_Forms
{
    public partial class BillingAddMember : Form
    {
        public BillingAddMember()
        {
            InitializeComponent();
            
        }

        private void BillingAddMember_Load(object sender, EventArgs e)
        {
            txtMemberID.Text = CookieSubscriber.ID.ToString();
            txtFullName.Text = CookieSubscriber.FullName;
            txtPersonalNumber.Text = CookieSubscriber.PersonalNumber;
            txtSubscriptionPlan.Text = CookieSubscriber.SubscriptionPlan;
            txtBillingDate.Text = CookieSubscriber.BillingDate.ToString();
            txtExpirationDate.Text = CookieSubscriber.ExpirationDate.ToShortDateString();
            txtPrice.Text = CookieSubscriber.Price.ToString();
            txtCashier.Text = CookieSubscriber.Cashier;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int Id = Convert.ToInt32(txtMemberID.Text);
            string sID = "SL" + Id.ToString("00000");

            string s = "Membership    Bill";
            string h = "_________________________________________________";
            string v = "-----------------------------------------------------------------------";

            e.Graphics.DrawString(s, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(100, 80));
            e.Graphics.DrawString(h, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString(
                "Subscriber:\t\t" + txtFullName.Text + "\n" + v + "\n" +
                "Number ID:\t\t" + txtPersonalNumber.Text + "\n" + v + "\n" +
                "Subscriber ID:\t\t" + sID + "\n" + v + "\n" +
                "Subscription:\t\t" + txtSubscriptionPlan.Text + "\n" + v + "\n" +
                "Registration Date:\t" + txtBillingDate.Text + "\n" + v + "\n" +
                "Expiration Date:\t\t" + txtExpirationDate.Text + "\n" + v + "\n\n" +
                "Price:\t\t\t" + txtPrice.Text + " €\n" + h + "\n\n\n\n\n" +
                "Cashier:\t" + txtCashier.Text + "\n\n\n" +
                "Signature:\t" + "_________________\n\n\n\n\n\n\n" +
                "\t\t©Stackbooks Co.",
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 130));
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocument;
            printPreview.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }
    }
}
