using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BO;
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
    public partial class BillForm : Form
    {
        Bill bill = new Bill();
        BillBLL billBll = new BillBLL();

        public BillForm()
        {
            InitializeComponent();
        }

        //private void comboBillType(object sender, EventArgs e)
        //{
        //    if (cmbBillType.SelectedItem == "Subscription")
        //    {
        //        //txtMaterialId.ReadOnly = false;

        //        bill.BillingDate = dtpBillingDate.Value;

        //        //if (bill._Subscriber.ExpirationDate.Month == bill._Subscriber.RegistrationDate.AddMonths(1).Month)
        //        //{
        //        //    txtPrice.Text = Convert.ToString(10.0);//10euro per Muaj
        //        //}

        //        //if (bill._Subscriber.ExpirationDate.Year == bill._Subscriber.RegistrationDate.AddYears(1).Year)
        //        //{
        //        //    txtPrice.Text = Convert.ToString(100.0);//100euro per Vit
        //        //}
        //        bill.Description = txtDescription.Text;
        //        //bill.RegistrationDate = bill._Subscriber.RegistrationDate;
        //        //bill.ExpirationDate = bill._Subscriber.ExpirationDate;

        //        if (cmbBillType.SelectedItem == "Penalty")
        //        {
        //            //txtMaterialId.ReadOnly = true;

        //            bill.BillingDate = dtpBillingDate.Value;
        //            bill.Price = decimal.Parse(txtPrice.Text);
        //            bill.Description = txtDescription.Text;
        //        }
        //    }

        //}
    }
}