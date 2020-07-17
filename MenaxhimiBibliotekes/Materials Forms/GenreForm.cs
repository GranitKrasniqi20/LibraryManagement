using FluentValidation.Results;
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
        List<Genre> storedGenre;
        bool booleanVariable;

        public GenreForm()
        {
            InitializeComponent();
            genBLL = new GenreBLL();
            ge = new Genre();
            gv = new GenreValidation();
            storedGenre = new List<Genre>();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv.ValidateGenre(txtGenreCreate.Text.Trim()))
                {
                    ge = new Genre();
                    ge._Genre = txtGenreCreate.Text.Trim();
                    ge.InsBy = FormLoggedUser.Id;

                    int error = genBLL.Add(ge);
                    if (error == 0)
                    {
                        this.Close();
                    }
                    else
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

        private void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchGenreUpdate.Text != string.Empty)
                {
                    storedGenre = genBLL.GetAll();

                    foreach (var specifiedGenre in storedGenre)
                    {
                        if (specifiedGenre._Genre == txtSearchGenreUpdate.Text)
                        {
                            ge = specifiedGenre;
                        }
                    }

                    txtGenreIDUpdate.Text = ge.GenreId.ToString();
                    txtGenreUpdate.Text = ge._Genre;
                }
                else
                {
                    txtGenreIDUpdate.Text = "---";
                    txtGenreUpdate.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv.ValidateGenre(txtGenreUpdate.Text.Trim()))
                {
                    ge = new Genre();


                    ge.GenreId = int.Parse(txtGenreIDUpdate.Text);
                    ge._Genre = txtGenreUpdate.Text.Trim();
                    ge.UpdBy = FormLoggedUser.Id;
                    ge.isActive = booleanVariable;

                    int error = genBLL.Update(ge);
                    if (error == 0)
                    {
                        MessageBox.Show("Genre Updated Succesfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cannot update the specified Genre!");
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
                MessageBox.Show("Genre is not updated please contact your administrator");
            }
        }

        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchGenreDelete.Text != string.Empty)
                {
                    storedGenre = genBLL.GetAll();

                    foreach (var specifiedGenre in storedGenre)
                    {
                        if (specifiedGenre._Genre == txtSearchGenreDelete.Text)
                        {
                            ge = specifiedGenre;
                        }
                    }

                    txtGenreIDDelete.Text = ge.GenreId.ToString();
                    txtGenreDelete.Text = ge._Genre;
                }
                else
                {
                    txtGenreIDUpdate.Text = "---";
                    txtGenreUpdate.Text = "---";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (genBLL.Delete(ge.GenreId) == 0)
                {
                    MessageBox.Show("Deleted Succesfully!");
                }
                else
                {
                    MessageBox.Show("Error Occured in deletion!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboIsActiveUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboIsActiveUpdate.SelectedItem == "Active")
            {
                booleanVariable = true;
            }
            else
            {
                booleanVariable = false;
            }
        }

        private void LblGenreIDUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
