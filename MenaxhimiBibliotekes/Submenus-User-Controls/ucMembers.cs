using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.Submenus_User_Controls
{
    public partial class ucMembers : UserControl
    {
        public ucMembers()
        {
            InitializeComponent();
        }

        // Custom made methods -- for MouseHover (if implemented)
        private void HoverChangeColor(Control c)
        {
            c.BackColor = Color.Gray;
            c.ForeColor = Color.White;
        }

        private void HoverReverseColor(Control c)
        {
            c.BackColor = Color.Transparent;
            c.ForeColor = Color.DimGray;
        }
    }
}
