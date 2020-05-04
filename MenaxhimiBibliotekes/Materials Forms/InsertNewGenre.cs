using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BLL.Validate;
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


    public partial class InsertNewGenre : Form
    {
        Genre ge;
        GenreValidation gv;
        GenreBLL genBLL;
        public InsertNewGenre()
        {
            InitializeComponent();
            genBLL = new GenreBLL();
            ge = new Genre();
            gv = new GenreValidation();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv.ValidateGenre(txtInsert.Text.Trim()))
                {
                    ge._Genre = txtInsert.Text.Trim();
                    ge.InsBy = FormLoggedUser.Id;

                    if (genBLL.Add(ge))
                    {
                        this.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Genre is not valid");
            }
            catch (Exception)
            {
                MessageBox.Show("Genre not inserted please contact your administrator");
            }
        }
    }
}
