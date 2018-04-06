using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ARK.SQL;
using System.Collections;

namespace ARK.Forms
{
    public partial class addProduct : Form
    {
        ArrayList _arr = new ArrayList();

        SQLCategory _category = new SQLCategory();
        SQL_Producer _producer = new SQL_Producer();
        SQL_Product _product = new SQL_Product();
        SQL_Status _status = new SQL_Status();
        SQL_Units _units = new SQL_Units();
        Variable v = new Variable();

        public addProduct()
        {
            InitializeComponent();

            _arr = _category.GetCategory();
            cmbx_category.DataSource = _arr;

            _arr = _producer.GetProducer();
            cmbx_producer.DataSource = _arr;

            _arr = _status.GetStatus();
            cmbx_status.DataSource = _arr;

            _arr = _units.GetUnits();
            cmbx_units.DataSource = _arr;
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            try
            {
                v.Id = Int32.Parse(txbx_artikul.Text.ToString());
                v.Name = txbx_name.Text.Trim();
                v.SecondID = Int32.Parse(cmbx_category.SelectedValue.ToString());
                v.Third = Int32.Parse(cmbx_producer.SelectedValue.ToString());
                v.Price = Int32.Parse(txbx_price.Text.Trim());
                v.Quantity = Int32.Parse(txbx_quantity.Text.Trim());
                v.UnitsID = Int32.Parse(cmbx_units.SelectedValue.ToString());
                v.StatusID = Int32.Parse(cmbx_status.SelectedValue.ToString());
                v.Data = dtp.Text.Trim();
                v.Comment = txbx_comment.Text.Trim();

                if (_product.InsertProduct(v))
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
                txbx_artikul.Text = "";
                txbx_name.Text = "";
                txbx_price.Text = "";
                txbx_quantity.Text = "";
                txbx_comment.Text = "";
            }
        }
    }
}
