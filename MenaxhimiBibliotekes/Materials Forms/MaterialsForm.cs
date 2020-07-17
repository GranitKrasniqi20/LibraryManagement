using DevExpress.XtraWaitForm;
using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.Materials_Forms
{
    public partial class MaterialsForm : Form
    {

        ReservationsForm reservationForm = new ReservationsForm();
        BorrowingsForm borrowingsForm = new BorrowingsForm();
        ReturningsForm returningsForm = new ReturningsForm();
        BorrowBLL bbll = new BorrowBLL();
        ReservationBLL res;
        Reservation reservationBO;
        MaterialBLL materialBLL = new MaterialBLL();

        public MaterialsForm()
        {


            InitializeComponent();
            gridView.OptionsBehavior.AutoPopulateColumns = false;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            AddNewMaterial add = new AddNewMaterial();
            add.ShowDialog();
        }

        private void btnUpdateMaterial_Click(object sender, EventArgs e)
        {
            UpdateMaterialForm update = new UpdateMaterialForm();
            update.ShowDialog();
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            DeleteMaterialForm delete = new DeleteMaterialForm();
            delete.ShowDialog();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            if (reservationForm.IsDisposed)
            {
                reservationForm = new ReservationsForm();
            }

            reservationForm.ShowDialog();

        
        }
        

        private void btnBorrowings_Click(object sender, EventArgs e)
        {
            if (borrowingsForm.IsDisposed)
            {
                borrowingsForm = new BorrowingsForm();
            }

            borrowingsForm.ShowDialog();
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            if (returningsForm.IsDisposed)
            {
                returningsForm = new ReturningsForm();
            }

            returningsForm.ShowDialog();
        }

        private void btnSearchMaterial_Click(object sender, EventArgs e)
        {
            gridMaterials.DataSource = null;

            if (txtSearchMaterial.Text == string.Empty)
            {
                gridMaterials.DataSource = materialBLL.GetAll();
            }
            else
            {
                gridMaterials.DataSource = materialBLL.GetAll().Where(x => x.Title.Contains(txtSearchMaterial.Text)  );
            }    
        }

        private void TableLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridSplitContainer1Grid_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            //x => x._subscriber.SubscriberId == 2 ||
            int m;
            bool isNumeric = int.TryParse(txtBorrowings.Text, out m);

            if (comboChoseGrid.SelectedItem.ToString() == "Borrowings")
            {
                gridBorrowings.MainView = gridView3;
                BorrowingsLanguageChange();

                if (txtBorrowings.Text == string.Empty)
                {
                    gridBorrowings.DataSource = bbll.GetAll();
                }

                else if (isNumeric)
                {
                    gridBorrowings.DataSource = bbll.GetAll().Where(x => x.SubscriberId == m ||
                    x.materialId == m || x.BorrowId == m);
                }
                else
                {
                    if (txtBorrowings.Text == string.Empty)
                    {
                        gridBorrowings.DataSource = bbll.GetAll();
                    }
                    else
                    {

                        gridBorrowings.DataSource = bbll.GetAll().Where(x => $"{x._subscriber.Name} {x._subscriber.LastName}" == txtBorrowings.Text || $"{ x._subscriber.LastName}" == txtBorrowings.Text ||
                    $"{ x._subscriber.Name}" == txtBorrowings.Text ||
                      x._material.Title == txtBorrowings.Text || x._material._Author.AuthorName == txtBorrowings.Text || x._shelf.Location == txtBorrowings.Text);
                    }
                }


            }

            else
            {

                reservationBO = new Reservation();
                res = new ReservationBLL();
                gridBorrowings.MainView = gridView1;

                ReservationLanguageChange();
                if (txtBorrowings.Text == string.Empty)
                {

                    gridBorrowings.DataSource = res.GetAll();
                }

               else if (isNumeric)
                {
                    gridBorrowings.DataSource = res.GetAll().Where(x => x.SubscriberId == m ||
                    x.MaterialId == m || x.MaterialId == m);
                }
                else
                {
                    if (txtBorrowings.Text == string.Empty)
                    {
                        gridBorrowings.DataSource = res.GetAll();
                    }
                    else
                    {
                        gridBorrowings.DataSource = res.GetAll().Where(x => $"{x._subscriber.Name} {x._subscriber.LastName}" == txtBorrowings.Text||
                        x._material.Title == txtBorrowings.Text || x._material._Author.AuthorName == txtBorrowings.Text ) ;
                    }
                }

            }


        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridMaterials_Click(object sender, EventArgs e)
        {

        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name== "sq")
            {
                btnAddMaterial.Text = "Shto Material";
                btnUpdateMaterial.Text = "Perditso Material";
                btnDeleteMaterial.Text = "Fshij Material";
                btnSearchMaterial.Text = "Kerko";
                colTitle.Caption = "Titulli";
                btnReservations.Text = "Rezervimet";
                btnBorrowings.Text = "Huazimet";
                btnReturns.Text = "Kthimet";
                button4.Text = "Kerko";
                colMaterialType.Caption = "Lloji materialit";
                colGenre.Caption = "Zhanri";
                colLanguage.Caption = "Gjuha";
                colPublishHouse.Caption = "Shtepia Botuese";
                colPublishYear.Caption = "Viti i publikimit";
                colAvailableCoppies.Caption = "Kopje te lira";
                colNumberOfPages.Caption = "Nr. Faqeve";
                BorrowingsLanguageChange();
                ReservationLanguageChange();


            }
            else
            {
                btnAddMaterial.Text = "Add Material";
            }

        }
        void BorrowingsLanguageChange()
        {
            gridColumn13.Caption = "Id huazmit";
            gridColumn14.Caption = "Id abonuesit";
            gridColumn15.Caption = "Emri abonuesit";
            gridColumn16.Caption = "Mbiemri abonuesit";
            gridColumn17.Caption = "Titulli";
            gridColumn18.Caption = "Autori";
            gridColumn19.Caption = "Lloji materialit";
            gridColumn20.Caption = "Data huazimit";
            gridColumn21.Caption = "Perfundimi afatit";
            gridColumn22.Caption = "Lokacionit";
            gridColumn23.Caption = "Data e kthimit";
            gridColumn24.Caption = "Id fatures";
            gridColumn25.Caption = "Id rezervimit";
        }

        void ReservationLanguageChange()
        {
            gridColumn33.Caption = "Id rezervimit";
            gridColumn2.Caption = "Emri abonuesit";
            gridColumn3.Caption = "Emri abonuesit";
            gridColumn4.Caption = "Mbiemri abonuesit";
            gridColumn26.Caption = "Numri telefonit";
            gridColumn7.Caption = "Lloji materialit";
            gridColumn5.Caption = "Titulli";
            gridColumn6.Caption = "Autori";
            gridColumn30.Caption = "Lokacioni";
            gridColumn9.Caption = "Perfundimi afatit";
            gridColumn31.Caption = "Data Rezervimit";
        }

        private void TableDataGridView_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
