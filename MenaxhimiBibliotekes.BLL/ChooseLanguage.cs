using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.BLL
{
    public class ChooseLanguage<T> : Form
    {
        public static void ChangeLanguage(string langCode, Form form)
        {
            CultureInfo c1 = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentCulture = c1;
            Thread.CurrentThread.CurrentUICulture = c1;

            foreach (Control control in form.Controls)
            {
                ComponentResourceManager resource = new ComponentResourceManager(typeof(T));
                resource.ApplyResources(control, control.Name, c1);
                if (control.GetType() == typeof(TabControl))
                {
                    foreach (Control co in ((TabControl)control).Controls)
                    {

                        string text = resource.GetString(co.Name + ".Text", c1);
                        if (text != null)
                        {
                            co.Text = text;
                        }
                    }
                }

               else if (control.GetType() == typeof(Panel))
                {
                    foreach (Control co in ((Panel)control).Controls)
                    {

                        string text = resource.GetString(co.Name + ".Text", c1);
                        if (text != null)
                        {
                            co.Text = text;
                        }

                        if (co.GetType() == typeof(Panel))
                        {
                            foreach (Control control1 in ((Panel)co).Controls)
                            {

                                text = resource.GetString(control1.Name + ".Text", c1);
                                if (text != null)
                                {
                                    control1.Text = text;
                                }

                            }
                        }
                    }

                }



                else if (control.GetType() == typeof(MenuStrip))
                {
                    foreach (ToolStripMenuItem item in ((MenuStrip)control).Items)
                    {
                        string text = resource.GetString(item.Name + ".Text", c1);
                        if (text != null)
                        {
                            item.Text = text;
                        }

                        foreach (ToolStripMenuItem child in item.DropDownItems)
                        {
                             text = resource.GetString(child.Name + ".Text", c1);
                            if (text != null)
                            {
                                child.Text = text;
                            }
                        }


                    }
                }

                else if (control.GetType() == typeof(TableLayoutPanel))
                {
                    foreach (Control item in ((TableLayoutPanel)control).Controls)
                    {
                        string text;
                        if (item.GetType() == typeof(Panel))
                        {
                            foreach (Control control1 in ((Panel)item).Controls)
                            {

                                text = resource.GetString(control1.Name + ".Text", c1);
                                if (text != null)
                                {
                                    control1.Text = text;
                                }

                            }
                        }

                        else
                        {
                             text = resource.GetString(item.Name + ".Text", c1);
                            if (text != null)
                            {
                                item.Text = text;
                            }
                        }
                    }
                }


            }
        }

    }










}




    

