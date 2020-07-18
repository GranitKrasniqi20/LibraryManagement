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
    public partial class ReturningsForm : Form
    {
        Borrow borrBO;
        BorrowBLL borrBLL;
        BorrowReturn brBO;
        BorrowReturnBLL brBLL;
        bool PayBill = false;
        Bill bill;
        BillBLL billBLL;
        decimal delayfee;
        public ReturningsForm()
        {
            InitializeComponent();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {

                        int b;
            bool isBorrowId = int.TryParse(txtBorrowedID.Text, out b);

            if (isBorrowId)
            {
                borrBLL = new BorrowBLL();
                borrBO = new Borrow();
                borrBO= borrBLL.Get(b);
                if (borrBO != null)
                {

               

                    txtMemberID.Text = borrBO._subscriber.SubscriberId.ToString() ;
                    txtMemberFullName.Text = $"{borrBO._subscriber.Name} {borrBO._subscriber.LastName}";
                    txtMaterialName.Text = borrBO._material.Title;
                    txtMaterialType.Text = borrBO._material._MaterialType._MaterialType;
                    txtLocated.Text = borrBO._shelf.Location;
                    txtBorrowedDate.Text = borrBO.BorrowDate.ToString();
                    txtReturnDate.Text = borrBO.DeadLine.ToString();

                    if (calculateDelays(borrBO.DeadLine) >= 0)
                    {
                        txtReturnedInTime.Text = "No";
                    }
                    else
                    {
                        txtReturnedInTime.Text = "Yes";
                    }

                  
                }
            }
        }


        decimal calculateDelays(DateTime Deadline)
        {
            return (decimal)(DateTime.Now -  Deadline).TotalDays;
        }

        private void BtnCalculateMaterialDamage_Click(object sender, EventArgs e)
        {
            if (calculateDelays(borrBO.DeadLine) >= 0)
            {
                delayfee = calculateDelays(borrBO.DeadLine) * borrBO._material._MaterialType.MaterialTypeDelayFee;
                txtDelayFee.Text = $"{String.Format("{0:F2}", delayfee)} $";
                
                PayBill = true;
            }
            delayfee = 0;

        }

        private void BtnRegisterReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (borrBO != null)
                {
                    brBO = new BorrowReturn();
                    brBLL = new BorrowReturnBLL();
                    bill = new Bill();
                    billBLL = new BillBLL();



                    brBO.BorrowId = borrBO.BorrowId;
                    brBO.ReturnDate = DateTime.Now;
                    brBO.Comment = "ska tash";
                    brBO.InsBy = FormLoggedUser.Id;



                    if (PayBill)
                    {
                        bill.BillingDate = DateTime.Now;
                        bill.BillTypeId = 2;
                        bill.MaterialId = borrBO.materialId;
                        bill.SubscriberId = borrBO.SubscriberId;
                        bill.Price = delayfee;
                        bill.InsBy = FormLoggedUser.Id;

                        brBO.BillId = billBLL.Add(bill);

                        if (brBO.BillId < 1)
                        {
                            throw new Exception();
                        }
                    }
                    
                    brBLL.Add(brBO);
                }
                else
                {
                    MessageBox.Show("Material wasn't provided");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Material is not returned, contact your administrator");
            }


        }

        private void ReturningsForm_Load(object sender, EventArgs e)
        {
            BLL.ChooseLanguage<ReturningsForm>.ChangeLanguage("sq", this);
        }
    }
}
