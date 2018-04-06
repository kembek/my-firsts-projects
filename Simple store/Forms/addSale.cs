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
using ARK.MyInterface;

namespace ARK.Forms
{
    public partial class addSale : Form
    {
        ArrayList _arr = new ArrayList();
        SQL_Sale _sqlSale = new SQL_Sale();
        SQL_Units _units = new SQL_Units();
        SQL_Buyer _buyer = new SQL_Buyer();
        SQL_Product _product = new SQL_Product();
        Variable v = new Variable();
        MyButtonClick _button = new MyButtonClick();

        public addSale()
        {
            InitializeComponent();

            _arr = _product.GetProduct();
            cmbx_productName.DataSource= _arr;

            _arr = _sqlSale.GetBuyer();
            cmbx_buyer.DataSource = _arr;

            _arr = _units.GetUnits();
            cmbx_units.DataSource = _arr;

        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            v.SecondID = Int32.Parse(cmbx_productName.SelectedValue.ToString());
            v.Price = Int32.Parse(txbx_price.Text.ToString());
            v.Quantity = Int32.Parse(txbx_quantity.Text.ToString());
            v.UnitsID = Int32.Parse(cmbx_units.SelectedValue.ToString());
            v.Third = Int32.Parse(cmbx_buyer.SelectedValue.ToString());
            v.Data = dtp.Text.ToString();

            if(_sqlSale.InsertSale(v))          
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
