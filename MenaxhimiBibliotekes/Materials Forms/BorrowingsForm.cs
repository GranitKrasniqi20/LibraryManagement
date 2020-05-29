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

namespace MenaxhimiBibliotekes.Materials_Forms
{
    public partial class BorrowingsForm : Form
    {
        SubscriberBLL sbll;
        Subscriber sbo;
        Material mbo;
        MaterialBLL mbll;
        Borrow Bbo;
        BorrowBLL Bbll;
        public BorrowingsForm()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            int n;
            bool isNumeric = int.TryParse(txtSubscriberID.Text, out n);

            int m;
            bool isMaterialId = int.TryParse(txtMaterialID.Text, out m);

            if (isNumeric && isMaterialId)
            {
               sbll = new SubscriberBLL();

                mbll = new MaterialBLL();
              mbo=  mbll.Get(m);
                sbo= sbll.Get(n);


                if (sbo != null && mbo.MaterialId > 0)
                {
                    txtName.Text = $"{sbo.Name} {sbo.LastName}";
                    txtAddress.Text = sbo.Address;
                    txtEmail.Text = sbo.Email;
                    txtPhoneNumber.Text = sbo.PhoneNo;
                    txtPersonalNumber.Text = sbo.PersonalNo;

                    txtMaterialName.Text = mbo.Title;
                    txtMaterialType.Text = mbo._MaterialType._MaterialType;
                    txtOverallQuantity.Text = mbo.Quantity.ToString();
                    txtStockQuantity.Text = mbo.AvailableCoppies.ToString();

                    if (mbo.AvailableCoppies > 0)
                    {
                        txtAvailability.Text = "Yes";
                    }
                    else
                    {
                        txtAvailability.Text = "No";
                    }

                    
                }
                else
                {
                    if (sbo == null && mbo.MaterialId < 1)
                    {
                        MessageBox.Show($"Material and Subscriber are not found", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (sbo == null)
                    {
                        MessageBox.Show($"Subscriber is not found", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (mbo.MaterialId < 1)
                    {
                        MessageBox.Show($"Material is not found", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else if (txtMaterialID.Text == string.Empty && txtSubscriberID.Text == string.Empty)
            {
                MessageBox.Show($"Material and Subscriber are empty", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMaterialID.Text == string.Empty)
            {
                MessageBox.Show($"Material ID field is empty", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtSubscriberID.Text == string.Empty)
            {
                MessageBox.Show($"Subscriber ID field is empty", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Material or Subscriber is not valid", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBorrowNow_Click(object sender, EventArgs e)
        {
            if (sbo != null && mbo != null)
            {
                Bbll = new BorrowBLL();
                Bbo = new Borrow();

                Bbo.SubscriberId = sbo.SubscriberId;
                Bbo.materialId = mbo.MaterialId;
                Bbo.DeadLine = DateTime.Parse(dateTill.Text);
                Bbo.BorrowDate = DateTime.Parse(dateFrom.Text);
                Bbo.shelfId = mbo.ShelfId;
                Bbo.InsBy = FormLoggedUser.Id;


                int ee = Bbll.Add(Bbo);

                if (ee > 0)
                {
                    MessageBox.Show($"{mbo.Title} borrowed by {sbo.Name} {sbo.LastName}", $"{mbo.Title.ToUpper()} BORROWED", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Material is not borrowed please check your information or Call your administrator", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Bbll = new BorrowBLL();
                Bbo = new Borrow();
            }
            else
            {
                if (sbo == null && mbo.MaterialId < 1)
                {
                    MessageBox.Show($"Material and Subscriber are not found", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(sbo == null)
                {
                    MessageBox.Show($"Subscriber is not found", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (mbo.MaterialId < 1)
                {
                    MessageBox.Show($"Material is not found", $"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
