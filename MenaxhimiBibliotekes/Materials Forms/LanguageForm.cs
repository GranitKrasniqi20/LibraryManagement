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
    public partial class LanguageForm : Form
    {

        Language language;
        LanguageBLL languageBLL;
        List<Language> storedLanguages;
        bool booleanVariable;

        LanguageValidation languageValidation;

        public LanguageForm()
        {
            InitializeComponent();
            language = new Language();
            languageBLL = new LanguageBLL();
            storedLanguages = new List<Language>();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (languageValidation.validateLanguage(txtLanguageCreate.Text.Trim()))
                {
                    language._Language = txtLanguageCreate.Text;
                    language.InsBy = FormLoggedUser.Id;

                    int error = languageBLL.Add(language);
                    if (error == 0)
                    {
                        MessageBox.Show("This Language is created succesfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Language could not be inserted!");
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchLanguageUpdate.Text != string.Empty)
                {
                    storedLanguages = languageBLL.GetAll();

                    foreach (var lang in storedLanguages)
                    {
                        if (lang._Language == txtSearchLanguageUpdate.Text)
                        {
                            language = lang;
                        }
                    }

                    txtLanguageIDUpdate.Text = language.LanguageId.ToString();
                    txtLanguageUpdate.Text = language._Language;
                }
                else
                {
                    txtLanguageIDUpdate.Text = "---";
                    txtLanguageUpdate.Text = string.Empty;
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
                if (languageValidation.validateLanguage(txtSearchLanguageUpdate.Text.Trim()))
                {
                    language._Language = txtLanguageUpdate.Text;
                    language.UpdBy = FormLoggedUser.Id;
                    language.isActive = booleanVariable;

                    int error = languageBLL.Update(language);
                    if (error == 0)
                    {
                        MessageBox.Show("This Language is updated succesfully!");
                        this.Close();
                    }
                    else if (error == 1)
                    {
                        MessageBox.Show("Language could not be Updated!");
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchLanguageDelete.Text != string.Empty)
                {
                    storedLanguages = languageBLL.GetAll();

                    foreach (var lang in storedLanguages)
                    {
                        if (lang._Language == txtSearchLanguageDelete.Text)
                        {
                            language = lang;
                        }
                    }

                    txtLanguageIDDelete.Text = language.LanguageId.ToString();
                    txtLanguageDelete.Text = language._Language;
                }
                else
                {
                    txtLanguageIDDelete.Text = "---";
                    txtLanguageDelete.Text = "---";
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
                if (languageBLL.Delete(language.LanguageId) == 0)
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

        private void BtnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
