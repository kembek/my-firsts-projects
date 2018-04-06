using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ARK.MyInterface;
using System.Collections;
using ARK.SQL;
using PrintDataGrid;

namespace ARK.Forms
{
    public partial class ProductForm : Form
    {
        ArrayList _arr = new ArrayList();

        MyButtonClick _button = new MyButtonClick();
        addProduct _addProduct = new addProduct();
        SQL_Product _sqlProduct = new SQL_Product();
        Variable v = new Variable();

        SQLCategory _category = new SQLCategory();
        SQL_Product _product = new SQL_Product();
        SQL_Producer _producer = new SQL_Producer();
        SQL_Status _status = new SQL_Status();
        SQL_Units _units = new SQL_Units();
        object _id;

        public ProductForm()
        {
            InitializeComponent();

            _arr = _producer.GetProducer();
            cmbx_searchProducer.DataSource = _arr;

            _arr = _status.GetStatus();
            cmbx_searchStatus.DataSource = _arr;

            _arr = _category.GetCategory();
            cmbx_searchCategory.DataSource = _arr;

            _arr = _sqlProduct.GetProduct();
            dgv.DataSource = _arr;


            _arr = _category.GetCategory();
            cmbx_category.DataSource = _arr;

            _arr = _producer.GetProducer();
            cmbx_producer.DataSource = _arr;

            _arr = _status.GetStatus();
            cmbx_status.DataSource = _arr;

            _arr = _units.GetUnits();
            cmbx_units.DataSource = _arr;
        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
            {
                v.Id = Int32.Parse(_id.ToString());

                if (_button.DeleteButton(sender, e, _sqlProduct.DeleteProduct(v)))
                {
                    dgv.DataSource = _sqlProduct.GetProduct();
                }
            }
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            if (_button.AddButton(sender, e, _addProduct.ShowDialog() == DialogResult.OK))
            {
                dgv.DataSource = _sqlProduct.GetProduct();
            }
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.DataSource != null)
            {

                _id = txbx_artikul.Text = dgv.Rows[e.RowIndex].Cells["Артикул"].Value.ToString();
                txbx_name.Text = dgv.Rows[e.RowIndex].Cells["Название"].Value.ToString();
                txbx_comment.Text = dgv.Rows[e.RowIndex].Cells["Описание"].Value.ToString();
                txbx_price.Text = dgv.Rows[e.RowIndex].Cells["Цена"].Value.ToString();
                txbx_quantity.Text = dgv.Rows[e.RowIndex].Cells["Количество"].Value.ToString();

                cmbx_category.Text = dgv.Rows[e.RowIndex].Cells["Категория"].Value.ToString();
                cmbx_producer.Text = dgv.Rows[e.RowIndex].Cells["Поставщик"].Value.ToString();
                cmbx_status.Text = dgv.Rows[e.RowIndex].Cells["Статус"].Value.ToString();
                cmbx_units.Text = dgv.Rows[e.RowIndex].Cells["ЕдИзмер"].Value.ToString();

                dtp.Text = dgv.Rows[e.RowIndex].Cells["Дата"].Value.ToString();
            }
        }

        private void btt_rename_Click_1(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
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
                v.MainID = Int32.Parse(_id.ToString());

                if(_button.EditButton(sender, e, _product.UpdateProduct(v)))
                {
                    dgv.DataSource = _product.GetProduct();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dgv);
        }

        List<DataGridViewRow> searchedRows;
        int curRow;
        private void btt_search_Click(object sender, EventArgs e)
        {
            searchedRows = new List<DataGridViewRow>();
            v.Name = txbx_searchName.Text.Trim();
            v.Comment = txbx_searchArtikul.Text.Trim();
            v.Passport = cmbx_searchCategory.Text.Trim();




            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["Артикул"].FormattedValue.ToString().Contains(v.Comment) &&
                    row.Cells["Название"].FormattedValue.ToString().Contains(v.Name) &&
                    row.Cells["Категория"].FormattedValue.ToString().Contains(v.Passport) &&

                    row.Cells["Поставщик"].FormattedValue.ToString().Contains(cmbx_searchProducer.Text.ToString()) &&
                    row.Cells["Статус"].FormattedValue.ToString().Contains(cmbx_searchStatus.Text.ToString()))
                {
                    searchedRows.Add(row);
                }
            }
            if (searchedRows.Count == 0)
            {
                MessageBox.Show("Поданному запросу не найдено записей", "Склад");
                btt_Next.Enabled = false;
                return;
            }
            MessageBox.Show("Поданному запросу найдено " + searchedRows.Count + " записей", "Склад");
            btt_Next.Enabled = true;
            curRow = -1;
            btt_Next_Click(null, null);
        }

        private void btt_Next_Click(object sender, EventArgs e)
        {
            if (curRow == searchedRows.Count - 1)
                curRow = 0;
            else
                curRow++;

            dgv.CurrentCell = searchedRows[curRow].Cells[1];

        }

        private void tsmi_print_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dgv);
        }

        private void tsmi_export_Click(object sender, EventArgs e)
        {
            new BuyerForm().Ex(dgv);
        }



    }
}
