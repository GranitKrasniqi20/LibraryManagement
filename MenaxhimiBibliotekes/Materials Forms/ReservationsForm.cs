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

namespace MenaxhimiBibliotekes.Materials_Forms
{
    public partial class ReservationsForm : Form
    {
        public ReservationsForm()
        {
            InitializeComponent();
        }

        Subscriber subscriber = new Subscriber();
        SubscriberBLL subscriberBLL = new SubscriberBLL();

        Material material = new Material();
        MaterialBLL materialBLL = new MaterialBLL();

        Reservation reservation = new Reservation();
        ReservationBLL reservationBLL = new ReservationBLL();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Subscriber Data
                subscriber = subscriberBLL.Get(int.Parse(txtSubscriberID.Text));

                txtName.Text = subscriber.Name;
                txtAddress.Text = subscriber.Address;
                txtEmail.Text = subscriber.Email;
                txtPhoneNumber.Text = subscriber.PersonalNo;
                txtPersonalNumber.Text = subscriber.PersonalNo;


                //Material Data
                //material = materialBLL.Get(int.Parse(txtMaterialID.Text));

                txtMaterialName.Text = "wer";// material.Title;
                txtMaterialType.Text = 1.ToString();// material.MaterialTypeId.ToString();
                txtOverallQuantity.Text = 23.ToString();// material.Quantity.ToString();
                txtStockQuantity.Text = 19.ToString();//(material.Quantity - material.AvailableCoppies).ToString();
                txtAvailability.Text = 4.ToString();// material.AvailableCoppies.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReserveNow_Click(object sender, EventArgs e)
        {
            try
            {
                if(material.AvailableCoppies>=1)
                {
                    reservation.SubscriberId = subscriber.SubscriberId;
                    reservation.MaterialId = material.MaterialId;

                    reservation.ReservationDate = dateTill.Value;

                    reservationBLL.Add(reservation);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
