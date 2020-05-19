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
    public partial class GenreForm : Form
    {

        Genre ge;
        GenreValidation gv;
        GenreBLL genBLL;

        public GenreForm()
        {
            InitializeComponent();
            genBLL = new GenreBLL();
            ge = new Genre();
            gv = new GenreValidation();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv.ValidateGenre(txtGenreCreate.Text.Trim()))
                {
                    ge._Genre = txtGenreCreate.Text.Trim();
                    ge.InsBy = 80; //FormLoggedUser.Id;

                    int error = genBLL.Add(ge);
                    if (error == 0)
                    {
                        this.Close();
                    }

                    else if (error == 1)
                    {
                        MessageBox.Show("Genre name  should be uniqe, please if this material type is deactivated update it");
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
                MessageBox.Show("Genre is not inserted please contact your administrator");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
