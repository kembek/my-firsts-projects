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
using ARK.MyInterface;
using PrintDataGrid;

namespace ARK.Forms
{
    public partial class SRForm : Form
    {
        ArrayList _arr = new ArrayList();

        SQL_Sale _sale = new SQL_Sale();
        MyButtonClick _button = new MyButtonClick();
        Variable v =new Variable();
        SQL_Units _units = new SQL_Units();
        SQL_Product _product = new SQL_Product();

        SQL_Return _return = new SQL_Return();
        object _id;
        object _id2;

        public SRForm()
        {
            InitializeComponent();

            _arr = _return.GetReturn();
            dgv_Return.DataSource = _arr;

            _arr = _product.GetProduct();
            cmbx_returnName.DataSource = (_arr);

            _arr = _units.GetUnits();
            cmbx_returnUnits.DataSource = _arr;

            _arr = _sale.GetSale();
            dgv_Sale.DataSource = _arr;

            _arr = _product.GetProduct();
            cmbx_productName.DataSource = (_arr);

            _arr = _sale.GetBuyer();
            cmbx_buyerSale.DataSource = _arr;

            _arr = _units.GetUnits();
            cmbx_unitsSale.DataSource = _arr;

            _arr = _sale.GetBuyer();
            cmbx_searchBuyer.DataSource = _arr;
        }

        private void btt_addSale_Click(object sender, EventArgs e)
        {
            if (_button.AddButton(sender, e, new addSale().ShowDialog() == DialogResult.OK))
            {
                dgv_Sale.DataSource = _sale.GetSale();
            }
        }

        private void dgv_Sale_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Sale.DataSource != null)
            {
                _id = dgv_Sale.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                cmbx_productName.Text = dgv_Sale.Rows[e.RowIndex].Cells["Товар"].Value.ToString();
                txbx_priceSale.Text = dgv_Sale.Rows[e.RowIndex].Cells["Цена"].Value.ToString();
                txbx_quantitySale.Text = dgv_Sale.Rows[e.RowIndex].Cells["Количество"].Value.ToString();
                cmbx_unitsSale.Text = dgv_Sale.Rows[e.RowIndex].Cells["Единица"].Value.ToString();
                dtp_Sale.Text = dgv_Sale.Rows[e.RowIndex].Cells["Дата"].Value.ToString();
                cmbx_buyerSale.Text = dgv_Sale.Rows[e.RowIndex].Cells["Покупатель"].Value.ToString();
            }
        }

        private void btt_deleteSale_Click(object sender, EventArgs e)
        {
            if (dgv_Sale.DataSource != null)
            {
                v.Id = Int32.Parse(_id.ToString());

                if (_button.DeleteButton(sender, e, _sale.DeleteSale(v)))
                {
                    dgv_Sale.DataSource = _sale.GetSale();
                }
            }

        }

        private void btt_printSale_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dgv_Sale);
        }

       

        List<DataGridViewRow> searchedRows;
        int curRow;
        private void btt_searchSale_Click(object sender, EventArgs e)
        {
            searchedRows = new List<DataGridViewRow>();
            v.Name = txbx_searchArtikul.Text.Trim();
            v.Comment = txbx_searchQuantitu.Text.Trim();
            v.Passport = cmbx_searchBuyer.Text.Trim();



            foreach (DataGridViewRow row in dgv_Sale.Rows)
            {
                if (
                    row.Cells["Товар"].FormattedValue.ToString().Contains(v.Name) &&
                    row.Cells["Количество"].FormattedValue.ToString().Contains(v.Comment) &&
                    row.Cells["Покупатель"].FormattedValue.ToString().Contains(v.Passport)
                    )
                {
                    searchedRows.Add(row);
                }
            }
            if (searchedRows.Count == 0)
            {
                MessageBox.Show("Поданному запросу не найдено записей", "Склад");
                btt_NextSale.Enabled = false;
                return;
            }
            MessageBox.Show("Поданному запросу найдено " + searchedRows.Count + " записей", "Склад");
            btt_NextSale.Enabled = true;
            curRow = -1;
            btt_NextSale_Click(null, null);
        }

        private void btt_NextSale_Click(object sender, EventArgs e)
        {
            if (curRow == searchedRows.Count - 1)
                curRow = 0;
            else
                curRow++;

            dgv_Sale.CurrentCell = searchedRows[curRow].Cells[1];
        }




        private void btt_renameSale_Click(object sender, EventArgs e)
        {
            if (dgv_Sale.DataSource != null)
            {
                v.MainID = Int32.Parse(_id.ToString());
                v.SecondID = Int32.Parse(cmbx_productName.SelectedValue.ToString());
                v.Price = Int32.Parse(txbx_priceSale.Text.ToString());
                v.Quantity = Int32.Parse(txbx_quantitySale.Text.ToString());
                v.UnitsID = Int32.Parse(cmbx_unitsSale.SelectedValue.ToString());
                v.Third = Int32.Parse(cmbx_buyerSale.SelectedValue.ToString());
                v.Data = dtp_Sale.Text.ToString();


                if (_button.EditButton(sender, e, _sale.UpdateSale(v)))
                {
                    _arr = _sale.GetSale();
                    dgv_Sale.DataSource = _arr;

                }
            }
        }

        private void продажаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuyerForm().Ex(dgv_Sale);
        }

        private void возвратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuyerForm().Ex(dgv_Return);
        }
        

        private void btt_addReturn_Click(object sender, EventArgs e)
        {
            if (_button.AddButton(sender, e, new addReturn().ShowDialog() == DialogResult.OK))
            {
                dgv_Return.DataSource = _return.GetReturn();
            }
        }

        private void btt_deleteReturn_Click(object sender, EventArgs e)
        {
            if (dgv_Return.DataSource != null)
            {
                v.Id = Int32.Parse(_id.ToString());

                if (_button.DeleteButton(sender, e, _return.DeleteReturn(v)))
                {
                    dgv_Return.DataSource = _return.GetReturn();
                }
            }
        }

        private void btt_printReturn_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dgv_Return);
        }

        private void dgv_Return_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Return.DataSource != null)
            {
                _id2 = dgv_Return.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                cmbx_returnName.Text = dgv_Return.Rows[e.RowIndex].Cells["Товар"].Value.ToString();
                txbx_returnPrice.Text = dgv_Return.Rows[e.RowIndex].Cells["Цена"].Value.ToString();
                txbx_returnQuantity.Text = dgv_Return.Rows[e.RowIndex].Cells["Количество"].Value.ToString();
                cmbx_returnUnits.Text = dgv_Return.Rows[e.RowIndex].Cells["Единица"].Value.ToString();
                dtp_return.Text = dgv_Return.Rows[e.RowIndex].Cells["Дата"].Value.ToString();
            }
        }

        private void btt_renameReturn_Click(object sender, EventArgs e)
        {
            if (dgv_Return.DataSource != null)
            {
                v.Id = Int32.Parse(_id2.ToString());
                v.SecondID = Int32.Parse(cmbx_returnName.SelectedValue.ToString());
                v.Price = Int32.Parse(txbx_returnPrice.Text.ToString());
                v.Quantity = Int32.Parse(txbx_returnQuantity.Text.ToString());
                v.UnitsID = Int32.Parse(cmbx_returnUnits.SelectedValue.ToString());
                v.Data = dtp_return.Text;

                if (_button.EditButton(sender, e, _return.UpdateReturn(v)))
                {
                    dgv_Return.DataSource = _return.GetReturn();
                }
            }
        }

       
       
        List<DataGridViewRow> searchedRows2;
        int curRow2;
         private void btt_returnSearch_Click(object sender, EventArgs e)
        {

            searchedRows2 = new List<DataGridViewRow>();
            v.Name = txbx_returnSearchName.Text.Trim();
            v.Comment = txbx_returnSearchQuantity.Text.Trim();
            v.Passport = txbx_returnSearchPrice.Text.Trim();



            foreach (DataGridViewRow row in dgv_Return.Rows)
            {
                if (
                    row.Cells["Товар"].FormattedValue.ToString().Contains(v.Name) &&
                    row.Cells["Количество"].FormattedValue.ToString().Contains(v.Comment) &&
                    row.Cells["Цена"].FormattedValue.ToString().Contains(v.Passport)
                    )
                {
                    searchedRows2.Add(row);
                }
            }
            if (searchedRows2.Count == 0)
            {
                MessageBox.Show("Поданному запросу не найдено записей", "Склад");
                btt_returnNext.Enabled = false;
                return;
            }
            MessageBox.Show("Поданному запросу найдено " + searchedRows2.Count + " записей", "Склад");
            btt_returnNext.Enabled = true;
            curRow2 = -1;
            btt_returnNext_Click(null, null);
        }

         private void btt_returnNext_Click(object sender, EventArgs e)
        {
            if (curRow2 == searchedRows2.Count - 1)
                curRow2 = 0;
            else
                curRow2++;

            dgv_Return.CurrentCell = searchedRows2[curRow2].Cells[1];
        }


    }
}
