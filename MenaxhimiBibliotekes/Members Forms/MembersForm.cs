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
        public MembersForm()
        {
            InitializeComponent();
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
    }
}
