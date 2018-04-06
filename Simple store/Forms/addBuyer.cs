using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ARK.MyInterface;
using ARK.SQL;

namespace ARK.Forms
{
    public partial class addBuyer : Form
    {
        ArrayList _arr = new ArrayList();

        Variable v = new Variable();
        MyButtonClick _buttonClick = new MyButtonClick();
        SQL_Buyer _buyer = new SQL_Buyer();
        SQL_CountryTown _ct = new SQL_CountryTown();

        public addBuyer()
        {
            InitializeComponent();

            cmbx_country = _ct.GetCountry(cmbx_country);
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            try
            {
                v.Name = txbx_name.Text.Trim();
                v.Comment = txbx_surname.Text.Trim();
                v.Id = Int32.Parse(cmbx_country.SelectedValue.ToString());
                v.SecondID = Int32.Parse(cmbx_town.SelectedValue.ToString());
                v.Number = txbx_number.Text.Trim();
                v.Passport = txbx_passport.Text.Trim();
                v.Address = txbx_address.Text.Trim();
                v.Email = txbx_email.Text.Trim();

                if (_buyer.InsertBuyer(v))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch
            {
                MessageBox.Show("Error", "LastCast", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txbx_name.Text = "";
                txbx_surname.Text = "";
                txbx_number.Text = "";
                txbx_address.Text = "";
                txbx_passport.Text = "";
                txbx_email.Text = "";
            }
        }

        private void addProducer_Load(object sender, EventArgs e)
        {
            cmbx_country.SelectedValueChanged += new EventHandler(cmbx_country_SelectedValueChanged);
        }

        private void cmbx_country_SelectedValueChanged(object sender, EventArgs e)
        {
            v.Id = Int32.Parse(cmbx_country.SelectedValue.ToString());
            cmbx_town = _ct.GetTown(cmbx_town, v);
        }
    }
}
