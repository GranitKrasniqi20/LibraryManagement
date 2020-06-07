using DevExpress.Charts.Native;
using DevExpress.XtraCharts;
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

namespace MenaxhimiBibliotekes.Dashboard_Forms
{
    public partial class DashboardForm : Form
    {
        List<Material> materialList = new List<Material>();
        MaterialBLL materialBLL = new MaterialBLL();
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet2.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.libraryManagementDataSet2.Materials);

            //materialList = materialBLL.GetAll();

            //Series materialStock = new Series();
            //materialStock = chartMaterials.Series["Available Materials"];

            //foreach (var material in materialList)
            //{
            //    if (material.AvailableCoppies > 0)
            //    {

            //        materialStock.Points.AddPoint(material.Title, (double)material.AvailableCoppies);
            //    }
            //}

            chartMaterials.Series["Available Materials"].Points.AddRange( new SeriesPoint("hello", 3));
            chartMaterials.Series["Available Materials"].Points.AddPoint("hello2", 5);
            chartMaterials.Series["Available Materials"].Points.AddPoint("hello3", 8);
            chartMaterials.Series["Available Materials"].Points.AddPoint("hello4", 2);
        }
    }
}
