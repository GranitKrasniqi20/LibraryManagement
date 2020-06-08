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
                //Subscriber 
                subscriber = subscriberBLL.Get(int.Parse(txtSubscriberID.Text));

                txtName.Text = subscriber.Name;
                txtAddress.Text = subscriber.Address;
                txtEmail.Text = subscriber.Email;
                txtPhoneNumber.Text = subscriber.PersonalNo;
                txtPersonalNumber.Text = subscriber.PersonalNo;


                //Material 
                material = materialBLL.Get(int.Parse(txtMaterialID.Text));

                txtMaterialName.Text = material.Title;
                txtMaterialType.Text = material._MaterialType._MaterialType;
                txtOverallQuantity.Text = material.Quantity.ToString();
                txtStockQuantity.Text = material.AvailableCoppies.ToString();

                if (material.AvailableCoppies>0)
                {
                    txtAvailability.Text = "Available";
                }

                else
                {
                    txtAvailability.Text = "Unavailable";
                }

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

                    reservation.ReservationDate = dateTill.Value;
                    reservation.InsBy = FormLoggedUser.Id;

                    reservationBLL.Add(reservation);

                    reservation._subscriber = subscriber;
                    reservation._material = material;

                    MessageBox.Show("The Reservation is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    reservationBLL.EmailReservation(reservation);
                }

                else
                {
                    MessageBox.Show("Fail!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
