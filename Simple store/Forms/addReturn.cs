using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ARK.SQL;

namespace ARK.Forms
{
    public partial class addReturn : Form
    {
        ArrayList _arr = new ArrayList();

        Variable v = new Variable();
        SQL_Units _units = new SQL_Units();
        SQL_Product _product = new SQL_Product();

        SQL_Return _retutn = new SQL_Return();

        public addReturn()
        {
            InitializeComponent();

            _arr = _product.GetProduct();
            cmbx_productName.DataSource = (_arr);

            _arr = _units.GetUnits();
            cmbx_unitsSale.DataSource = _arr;
        }

        private void btt_renameSale_Click(object sender, EventArgs e)
        {
            v.SecondID = Int32.Parse(cmbx_productName.SelectedValue.ToString());
            v.Price = Int32.Parse(txbx_priceSale.Text.ToString());
            v.Quantity = Int32.Parse(txbx_quantitySale.Text.ToString());
            v.UnitsID = Int32.Parse(cmbx_unitsSale.SelectedValue.ToString());
            v.Data = dtp_Sale.Text.ToString();

            if (_retutn.InsertReturn(v))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
