﻿using DevExpress.DataProcessing;
using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.Materials_Forms;
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
    public partial class MembersForm : Form
    {
        SubscriberBLL subcriberBLL = new SubscriberBLL();
        BillBLL billBLL = new BillBLL();

        public MembersForm()
        {
            InitializeComponent();
            gridView.OptionsBehavior.AutoPopulateColumns = false;
            gridMembers.DataSource = subcriberBLL.GetAll();
            gridViewBills.OptionsBehavior.AutoPopulateColumns = false;
            gridBills.DataSource = billBLL.GetAll();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm add = new AddMemberForm();
            add.ShowDialog();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            UpdateMemberForm update = new UpdateMemberForm();
            update.ShowDialog();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            DeleteMemberForm delete = new DeleteMemberForm();
            delete.ShowDialog();
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'libraryManagementDataSet1.Subscribers' table. You can move, or remove it, as needed.
            //this.subscribersTableAdapter1.Fill(this.libraryManagementDataSet1.Subscribers);
            //// TODO: This line of code loads data into the 'libraryManagementDataSet.Subscribers' table. You can move, or remove it, as needed.
            //this.subscribersTableAdapter.Fill(this.libraryManagementDataSet.Subscribers);

        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            //if (comboSortMember.SelectedItem.ToString() == "Active Members")
            if (comboSortMember.SelectedIndex == 0)
            {
                BindDataGrid(true);
            }
            else if (comboSortMember.SelectedIndex == 1)
            {
                BindDataGrid(false);
            }
            else
            {
                gridMembers.DataSource = null;
                gridMembers.DataSource = subcriberBLL.GetAll().Where(x => (x.Name.Contains(txtSearchMember.Text.Trim())
                                     || x.LastName.Contains(txtSearchMember.Text.Trim()) ||
                                     $"{x.Name} {x.LastName}".Contains(txtSearchMember.Text.Trim())));

                //gridMembers.DataSource = subcriberBLL.GetAll().Where(x => (x.Name.StartsWith(txtSearchMember.Text)
                //|| x.LastName.StartsWith(txtSearchMember.Text) || $"{x.Name} {x.LastName}".StartsWith(txtSearchMember.Text)));
            }
        }

        void BindDataGrid(bool i)
        {
            // string[] FullNameArray = txtSearchMember.Text.Split(' ');
            gridMembers.DataSource = null;

            if (txtSearchMember.Text == string.Empty)
            {
                gridMembers.DataSource = subcriberBLL.GetAll().Where(x => x.IsActive == i);
            }
            else
            {
                gridMembers.DataSource = subcriberBLL.GetAll().Where(x => (x.Name.Contains(txtSearchMember.Text.Trim())
                                     || x.LastName.Contains(txtSearchMember.Text.Trim()) ||
                                     $"{x.Name} {x.LastName}".Contains(txtSearchMember.Text.Trim())) && x.IsActive == i);

                //gridMembers.DataSource = subcriberBLL.GetAll().Where(x => (x.Name.StartsWith(txtSearchMember.Text)
                //|| x.LastName.StartsWith(txtSearchMember.Text) || $"{x.Name} {x.LastName}".StartsWith(txtSearchMember.Text)));
            }
        }

        private void btnSearchBills_Click(object sender, EventArgs e)
        {
            BindBillsGrid(true);
        }

        private void BindBillsGrid(bool i)
        {

            if (txtSearchBills.Text == string.Empty)
            {
                gridBills.DataSource = billBLL.GetAll();
            }
            else
            {
                gridBills.DataSource = billBLL.GetAll().Where(x => x.BillId == int.Parse(txtSearchBills.Text));
            }
        }

        private void tableHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMemberHelp_Click(object sender, EventArgs e)
        {
            MaterialsForm.GetHelpProvider(this, "Members.htm");
        }

       
    }
}
