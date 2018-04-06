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
using PrintDataGrid;

namespace ARK.Forms
{
    public partial class ProducerForm : Form
    {
        ArrayList _arr = new ArrayList();

        SQL_Producer _producer = new SQL_Producer();
        SQL_CountryTown _ct = new SQL_CountryTown();
        Variable v = new Variable();
        addProducer _addProducer = new addProducer();
        MyButtonClick _button = new MyButtonClick();

        object _id;

        public ProducerForm()
        {
            InitializeComponent();

            _arr = _producer.GetProducer();
            dgv.DataSource = _arr;

            cmbx_country = _ct.GetCountry(cmbx_country);
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            if (_button.AddButton(sender, e, _addProducer.ShowDialog() == DialogResult.OK))
            {
                dgv.DataSource = _producer.GetProducer();
            }
        }
       
        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.DataSource != null)
            {
                _id = (dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                txbx_name.Text = dgv.Rows[e.RowIndex].Cells["Название"].Value.ToString();
                txbx_surname.Text = dgv.Rows[e.RowIndex].Cells["ПолНаз"].Value.ToString();
                cmbx_country.Text = dgv.Rows[e.RowIndex].Cells["Страна"].Value.ToString();
                cmbx_town.Text = dgv.Rows[e.RowIndex].Cells["Город"].Value.ToString();
                txbx_number.Text = dgv.Rows[e.RowIndex].Cells["Телефон"].Value.ToString();
                txbx_address.Text = dgv.Rows[e.RowIndex].Cells["Адрес"].Value.ToString();
                txbx_email.Text = dgv.Rows[e.RowIndex].Cells["ЭлПочта"].Value.ToString();
            }
        }

        private void btt_rename_Click(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
            {
                v.MainID = Int32.Parse(_id.ToString());
                v.Name = txbx_name.Text.Trim();
                v.Comment = txbx_surname.Text.Trim();
                v.Id = Int32.Parse(cmbx_country.SelectedValue.ToString());
                v.SecondID = Int32.Parse(cmbx_town.SelectedValue.ToString());
                v.Number = txbx_number.Text.Trim();
                v.Address = txbx_address.Text.Trim();
                v.Email = txbx_email.Text.Trim();
                

                if (_button.EditButton(sender, e, _producer.UpdateProducer(v)))
                {
                    dgv.DataSource = _producer.GetProducer();
                }
            }
        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
            if (dgv.DataSource != null)
            {
                v.Id = Int32.Parse(_id.ToString());

                if (_button.DeleteButton(sender, e, _producer.DeleteProducer(v)))
                {
                    dgv.DataSource = _producer.GetProducer();
                }
            }
        }

        private void cmbx_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            v.Id = Int32.Parse(cmbx_country.SelectedValue.ToString());
            cmbx_town = _ct.GetTown(cmbx_town, v);
        }

        private void печататьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dgv);
        }

        List<DataGridViewRow> searchedRows;
        int curRow;
        private void btt_search_Click(object sender, EventArgs e)
        {
            searchedRows = new List<DataGridViewRow>();
            v.Name = txbx_searchName.Text.Trim();
            v.Comment = txbx_searchSurname.Text.Trim();
            v.Passport = txbx_searchNumber.Text.Trim();



            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (
                    row.Cells["Название"].FormattedValue.ToString().Contains(v.Name) &&
                    row.Cells["ПолНаз"].FormattedValue.ToString().Contains(v.Comment) &&
                    row.Cells["Телефон"].FormattedValue.ToString().Contains(v.Passport)
                    )
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

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BuyerForm().Ex(dgv);
        }

        
    }
}
