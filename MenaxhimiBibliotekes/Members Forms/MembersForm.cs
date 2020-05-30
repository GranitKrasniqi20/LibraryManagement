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
    public partial class MembersForm : Form
    {
        SubscriberBLL subcriberBLL = new SubscriberBLL();

        public MembersForm()
        {
            InitializeComponent();
            gridView.OptionsBehavior.AutoPopulateColumns = false;
            gridMembers.DataSource = subcriberBLL.GetAll();
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
            // TODO: This line of code loads data into the 'libraryManagementDataSet1.Subscribers' table. You can move, or remove it, as needed.
            //this.subscribersTableAdapter1.Fill(this.libraryManagementDataSet1.Subscribers);
            // TODO: This line of code loads data into the 'libraryManagementDataSet.Subscribers' table. You can move, or remove it, as needed.
            //this.subscribersTableAdapter.Fill(this.libraryManagementDataSet.Subscribers);

        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            gridMembers.DataSource = null;

            if (txtSearchMember.Text == string.Empty)
            {
                gridMembers.DataSource = subcriberBLL.GetAll();
            }
            else
            {
                string[] FullNameArray = txtSearchMember.Text.Split(' ');
                gridMembers.DataSource = subcriberBLL.GetAll().Where(x => x.Name.Contains(FullNameArray[0])
                                         && x.LastName.Contains(FullNameArray[1]));
            }
        }
    }
}
